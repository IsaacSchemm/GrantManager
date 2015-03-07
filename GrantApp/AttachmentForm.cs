using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrantApp
{
    /// <summary>
    /// Allows managing attachments that are attached to grants.
    /// Only one attachment is allowed per grant, but this attachment may be a zip file with multiple files.
    /// </summary>
    public partial class AttachmentForm : Form
    {
        private attachment attachment;
        private int grant_id;
        private DataClasses1DataContext db;

        /// <summary>
        /// Opens window.
        /// </summary>
        /// <param name="grant_id">Id of grant that holds focus.</param>
        /// <param name="attachment_id">Id of attachment to edit (if any.)</param>
        public AttachmentForm(int grant_id, int? attachment_id = null)
        {
            InitializeComponent();
            this.db = new DataClasses1DataContext();
            this.FormClosed += AttachmentForm_FormClosed;
            this.grant_id = grant_id;
            this.attachment = attachment_id != null
                ? (from a in db.attachments where a.attachment_id == attachment_id select a).Single()
                : null;

            RefreshLabels();
        }
    
        /// <summary>
        /// Finds attachment name from grant and inserts it into the label.
        /// Also prints size of file.
        /// </summary>
        private void RefreshLabels()
        {
            //find name and size
            this.lblSize.Text = attachment == null ? "" : String.Format("{0} ({1} bytes)", attachment.filename, attachment.data.Length);

            //enable download button and delete button only if an attachment is present
            this.btnDownload.Enabled = this.btnDelete.Enabled = attachment != null;
        }

        /// <summary>
        /// Close database context when window closes.
        /// </summary>
        private void AttachmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        /// <summary>
        /// Adds an attachment to grant.
        /// </summary>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            //open file select dialog
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;

            //if cancelled or x-ed out
            if (open.ShowDialog() != DialogResult.OK) return;

            //confirm that user wants to overwrite attachment if an attachment already existed
            if (attachment != null)
            {
                if (MessageBox.Show(this, "Are you sure you want to overwrite the current attachment?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return;
                }
            }
            // get information before it is changed
            String oldAttachment = attachment == null ? null : attachment.filename;
            String newGrantorSummary = Path.GetFileName(open.FileName);

            //add to database
            byte[] data;
            try
            {
                data = File.ReadAllBytes(open.FileName);
            }
            catch
            {
                MessageBox.Show("File is currently in use, please save it, close the file, and try again");
                return;
            }
            if (attachment == null) {
                attachment = new attachment();
                attachment.grant_id = this.grant_id;
                db.attachments.InsertOnSubmit(attachment);
            }
            attachment.data = new Binary(data);
            attachment.filename = Path.GetFileName(open.FileName);

            if (Settings.EnableChangelog)
            {
                changelog log = new changelog()
                {
                    object_edited = attachment.filename + " on grant ID " + this.grant_id,
                    username = Login.currentUser,
                    date = DateTime.Now,
                };
                if (oldAttachment != null)
                {
                    log.details = oldAttachment + " => " + newGrantorSummary;
                }
                else
                {
                    log.details = "Added: " + newGrantorSummary;
                }
                db.changelogs.InsertOnSubmit(log);
            }
            
            db.SubmitChanges();

            //add coinfirmation text
            lblFeedback.Text = "Attachment uploaded";

            //update the label
            RefreshLabels();
        }

        /// <summary>
        /// Allows downloading the current attachment.
        /// </summary>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            //open save file dialog
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = attachment.filename;
            if (save.ShowDialog() != DialogResult.OK) return;

            byte[] data = attachment.data.ToArray();
            File.WriteAllBytes(save.FileName, data);

            //show confirmation text
            lblFeedback.Text = "File saved to: " + save.FileName;
            RefreshLabels();
        }

        /// <summary>
        /// Allows opening the attachment without downloading it.
        /// </summary>
        private void btnViewCopy_Click(object sender, EventArgs e)
        {
            if (attachment.data != null)
            {
                byte[] data = attachment.data.ToArray();
                string tempFile = Path.GetTempPath();
                File.WriteAllBytes(tempFile + attachment.filename, data);
                Process p = Process.Start(tempFile + attachment.filename);
            }
            else
            {
                // error handle
            }
        }

        /// <summary>
        /// Allows deleting an attachment.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //confirm user wants to delete it
            if (MessageBox.Show(this, "Are you sure you want to delete this attachment from the database?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                String oldAttachment = attachment.filename;
                if (Settings.EnableChangelog)
                {
                    changelog log = new changelog()
                    {
                        object_edited = attachment.filename,
                        username = Login.currentUser,
                        date = DateTime.Now,
                    };
                    log.details = oldAttachment + " has been removed";
                    db.changelogs.InsertOnSubmit(log);
                }
                db.SubmitChanges();

                //delete from database
                db.attachments.DeleteOnSubmit(attachment);
                db.SubmitChanges();

                attachment = null;

                //show confirmation text
                lblFeedback.Text = "Attachment deleted";

                //refresh label
                RefreshLabels();
            }
        }

        private void AttachmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
