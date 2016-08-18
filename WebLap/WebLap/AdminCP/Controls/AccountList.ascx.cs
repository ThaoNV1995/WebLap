using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.AdminCP.Controls
{
    public partial class AccountList : System.Web.UI.UserControl
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Account.DataSource = _db.Accounts.Where(a => a.Username.ToString() == Session["User"].ToString());
            Account.DataBind();
        }

        protected void Account_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}