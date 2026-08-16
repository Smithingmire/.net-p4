using System;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEventRegistration
{
    public partial class EventRegistration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblMessage.Text = "Registration Successful!";
                lblMessage.ForeColor = Color.Green;
            }
        }

        protected void cvTerms_ServerValidate(
            object source,
            ServerValidateEventArgs args)
        {
            args.IsValid = chkTerms.Checked;
        }
    }
}