using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap
{
    public partial class Site : System.Web.UI.MasterPage
    {
        readonly ModelDataContext _dbDataContext = new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            plogout.Visible = false;
            Log();
            rptParent.DataSource = _dbDataContext.Categories.Where(c => c.CateParentID == null);
            rptParent.DataBind();
        }

        protected void rptParent_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField hdCateId = (HiddenField) e.Item.FindControl("hdCateID");
            Repeater rptChild = (Repeater) e.Item.FindControl("rptChild");
            var data = _dbDataContext.Categories.Where(c => c.CateParentID.ToString() == hdCateId.Value);
            rptChild.DataSource = data;
            rptChild.DataBind();
        }

      

        protected void lbRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void lgin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminCP/Default.aspx");
            plogin.Visible = false;
        }

        protected void lgLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
            plogin.Visible = false;
        }

        public void Log()
        {
            if (Session["User"] != null)
            {
                plogin.Visible = false;
                lbName.Text = @"Xin chào:"+Session["User"].ToString();
                plogout.Visible = true;

            }
        }

        protected void lbName_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminCP/Default.aspx");
        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Account acc = _dbDataContext.Accounts.SingleOrDefault(a => a.Username == txtUser.Text && a.Password == txtPass.Text);
            if (acc != null)
            {
                Session["User"] = acc.Username;
                Session["id"] = acc.AccountID;
                Response.Redirect("Default.aspx");

            }
            else
            {
                ShowMessage("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        public void ShowMessage(string mess)
        {
            string strBulder = "<script language='javascript'>alert('" + mess + "')</script>";
            Response.Write(strBulder);
        }
    }
}