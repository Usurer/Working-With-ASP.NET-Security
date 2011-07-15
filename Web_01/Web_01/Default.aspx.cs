using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_01
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MembershipProvider CurrentProvider = Membership.Provider;
                lblName.Text = "Current Membership Provider is " + CurrentProvider.Name;
                MembershipUser CurrentUser = Membership.CreateUser("abc", "abcabc_");
                lblName.Text += " and currently created user name is " + CurrentUser.UserName;
                Membership.DeleteUser("abc");
            }
        }
    }
}