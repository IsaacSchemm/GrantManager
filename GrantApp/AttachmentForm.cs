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
        private grant grant;
        private DataClasses1DataContext db;

        /// <summary>
        /// Opens window.
        /// </summary>
        /// <param name="grant_id">Id of grant that holds focus.</param>
        public AttachmentForm(int grant_id)
        {
            InitializeComponent();
            this.db = new DataClasses1DataContext();
            this.FormClosed += AttachmentForm_FormClosed;
            this.grant = (from g in db.grants
                          where g.grant_id == grant_id
                          select g).First();

            RefreshLabels();
        }
    
        /// <summary>
        /// Finds attachment name from grant and inserts it into the label.
        /// Also prints size of file.
        /// </summary>
        private void RefreshLabels()
        {
            //find name and size
            this.lblSize.Text = grant.attachment == null ? "none" : String.Format("{0} ({1} bytes)", grant.attachment_name, grant.attachment.Length);

            //enable download button and delete button only if an attachment is present
            this.btnDownload.Enabled = this.btnDelete.Enabled = (grant.attachment != null);
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
            if (grant.attachment != null)
            {
                if (MessageBox.Show(this, "Are you sure you want to overwrite the current attachment?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return;
                }
            }
            // get information before it is changed
            String oldAttachment =  grant.attachment_name;
            if (grant.attachment == null)
            {
                oldAttachment = null;
            }
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
            grant.attachment = new Binary(data);
            grant.attachment_name = Path.GetFileName(open.FileName);

            if (Settings.EnableChangelog)
            {

                changelog log = new changelog()
                {
                    object_edited = grant.grant_name,
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
            save.FileName = grant.attachment_name;
            if (save.ShowDialog() != DialogResult.OK) return;

            byte[] data = grant.attachment.ToArray();
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
            if (grant.attachment != null)
            {
                byte[] data = grant.attachment.ToArray();
                string tempFile = Path.GetTempPath();
                File.WriteAllBytes(tempFile + grant.attachment_name, data);
                Process p = Process.Start(tempFile + grant.attachment_name);
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
                
                String oldAttachment = grant.attachment_name;
                if (Settings.EnableChangelog)
                {
                    changelog log = new changelog()
                    {
                        object_edited = grant.grant_name,
                        username = Login.currentUser,
                        date = DateTime.Now,
                    };
                    log.details = oldAttachment + " has been removed";
                    db.changelogs.InsertOnSubmit(log);
                }
                db.SubmitChanges();

                //delete from database
                grant.attachment = null;
                db.SubmitChanges();

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
