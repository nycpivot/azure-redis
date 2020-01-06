using System;
using System.Web.UI;

namespace Azure.Redis.SessionState.Forms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["FirstName"] = "John";
            Session["LastName"] = "Doe";
            Session["Color"] = "Blue";
        }
    }
}