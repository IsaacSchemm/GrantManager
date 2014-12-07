using System.Configuration;
using System.Text;
namespace GrantApp {
	public partial class grant
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("{");
            sb.Append(this.grant_name + ", ");
            sb.Append(this.grant_description + ", ");
            sb.Append(this.grantor.organization_name + ", ");
            sb.Append(this.submit_date + ", ");
            sb.Append(this.due_date + ", ");
            sb.Append(this.turnaround_time + ", ");
            sb.Append(this.start_date + ", ");
            sb.Append(this.payment_date + ", ");
            sb.Append(this.grant_requested_amount + ", ");
            sb.Append(this.grant_actual_amount + ", ");
            sb.Append(this.status_type.description + ", ");
            sb.Append(this.grantor_website + ", ");
            sb.Append(this.grantor_username + ", ");
            sb.Append(this.grantor_password + ", ");
            sb.Append(this.grant_writer + ", ");
            sb.Append("{");
            foreach (var p in this.grant_projects)
            {
                sb.Append(p.project.project_name + ", ");
            }
            sb.Append("}, ");
            sb.Append("{");
            foreach (var p in this.grant_programs)
            {
                sb.Append(p.program.program_name + ", ");
            }
            sb.Append("}, ");
            sb.Append(this.program_emphasis + ", ");
            sb.Append("{");
            foreach (var d in this.documentation_requirements)
            {
                sb.Append(d.documentation_type.name + ", ");
            }
            sb.Append("}, ");
            sb.Append(this.notes);
            sb.Append("}");
            return sb.ToString();
        }
    }

    public partial class grantor
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("{");
            sb.Append(this.organization_name + ", ");
            sb.Append(this.address + ", ");
            sb.Append(this.city + ", ");
            sb.Append(this.state_id + ", ");
            sb.Append(this.zipcode + ", ");
            sb.Append(this.email + ", ");
            sb.Append(this.phone + ", ");
            sb.Append(this.fax + ", ");
            sb.Append(this.contact_name + ", ");
            sb.Append(this.contact_title + ", ");
            sb.Append(this.types_of_support + ", ");
            sb.Append(this.average_gift + ", ");
            sb.Append(this.giving_history + ", ");
            sb.Append(this.buzzwords + ", ");
            sb.Append(this.notes + "}");
            return sb.ToString();
        }
    }

    public partial class project
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("{");
            sb.Append(this.project_name + ", ");
            sb.Append(this.project_overview + ", ");
			sb.Append(this.project_objectives + ", ");
			sb.Append(this.project_outcomes + ", ");
            sb.Append(this.project_timeline + ", ");
            sb.Append(this.project_letters_support + ", ");
            sb.Append(this.notes + "}");
            return sb.ToString();
        }
    }

    public partial class contact_history
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("{");
            sb.Append(this.approach != null
                ? this.approach.approach_type
                : "NULL");
            sb.Append(", ");
            sb.Append(this.contact_name + ", ");
            sb.Append(this.call_date + ", ");
            sb.Append(this.outcome + ", ");
            sb.Append(this.user != null
                ? this.user.display_name
                : "NULL");
            sb.Append(", ");
            sb.Append(this.notes + "}");
            return sb.ToString();
        }
    }
}
