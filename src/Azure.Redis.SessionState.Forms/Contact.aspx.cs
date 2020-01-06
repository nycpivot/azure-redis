using System;
using System.Web.UI;

namespace Azure.Redis.SessionState.Forms
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var firstName = Session["FirstName"] != null
                ? Session["FirstName"].ToString() : String.Empty;
            var lastName = Session["LastName"] != null
                ? Session["LastName"].ToString() : String.Empty;

            this.firstName.Text = firstName;
            this.lastName.Text = lastName;
        }
    }
}