using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.AdminCP
{
    public partial class Admin1 : System.Web.UI.Page
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadMenuChild();
            LoadMenu();
            string menudo = Request.QueryString["do"];
            System.Web.UI.Control ctrl = null;
            switch (menudo)
            {
                case "group":
                    ctrl = Page.LoadControl("Controls/GroupAccount.ascx");
                    break;
                case "editaccount":
                    ctrl = Page.LoadControl("Controls/AccountEdit.ascx");
                    break;
                case "listnew":
                    ctrl = Page.LoadControl("Controls/AccountList.ascx");
                    break;
                case "addnews":
                    ctrl = Page.LoadControl("Controls/AddNews.ascx");
                    break;
                case "listnews":
                    ctrl = Page.LoadControl("Controls/ListNews.ascx");
                    break;
                case "editnews":
                    ctrl = Page.LoadControl("Controls/EditNews.ascx");
                    break;
                default:
                    break;
            }
         if(ctrl!=null)
            phContent.Controls.Add(ctrl);
        }

        public void LoadMenu()
        {
            rptParent.DataSource = _db.MenuManagers.Where(m => m.MenuParentID.ToString() == null);
            rptParent.DataBind();
        }

        public void LoadMenuChild()
        {
            string newsId = Request.QueryString["id"];
            rptChild.DataSource = _db.MenuManagers.Where(m => m.MenuParentID.ToString() == newsId);
            rptChild.DataBind();
        }
    }
}