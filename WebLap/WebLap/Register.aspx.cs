using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap
{
    public partial class Login : System.Web.UI.Page
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Account acc=new Account();
            acc.Username = txtUserName.Text;
            acc.Password = txtPass.Text;
            if (txtRePass.Text == txtPass.Text && txtUserName.Text!=null && txtPass.Text!=null && txtRePass.Text!=null)
            {
                _db.Accounts.InsertOnSubmit(acc);
                _db.SubmitChanges();
                ShowMessage("Đăng ký thành công!");
                Session["User"] = acc.Username;
                Response.Redirect("Default.aspx");
            }
            else
            {
                ShowMessage("Đăng ký không thành công!");
            }
        }

        public void ShowMessage(string mess)
        {
            string strBulder = "<script language='javascript'>alert('" + mess + "')</script>";
            Response.Write(strBulder);
        }
    }
}