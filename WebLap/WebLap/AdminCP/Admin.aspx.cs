using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.AdminCP
{
    public partial class Admin2 : System.Web.UI.Page
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptMenu.DataSource = _db.MenuManagers.Where(n => n.MenuParentID.ToString() == null);
            rptMenu.DataBind();
        }

        protected void rptMenu_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField hfMenuId = (HiddenField)e.Item.FindControl("hfMenuID");
            DataList dlList = (DataList)e.Item.FindControl("prtdtList");
            var data = _db.MenuManagers.Where(m => m.MenuParentID.ToString() ==hfMenuId.Value);
            dlList.DataSource = data;
            dlList.DataBind();
        }
    }
}