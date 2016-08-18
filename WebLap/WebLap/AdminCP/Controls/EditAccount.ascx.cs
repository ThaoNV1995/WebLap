using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.AdminCP.Controls
{
    public partial class EditAccount : System.Web.UI.UserControl
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            var qry = from a in _db.Accounts
                where a.Username == Session["User"].ToString()
                select a;
            foreach (var q in qry)
            {
                txtUser.Text = q.Username;
                txtPass.Text = q.Password;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var qry = from a in _db.Accounts
                      where a.AccountID.ToString()==Session["id"].ToString()
                      select a;
            foreach (var q in qry)
            {
                q.Username=txtUser.Text;
                q.Password=txtPass.Text;
            }
            _db.SubmitChanges();
        }
    }
}