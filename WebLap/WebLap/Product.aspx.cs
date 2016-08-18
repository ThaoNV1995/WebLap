using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap
{
    public partial class Product : System.Web.UI.Page
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect(GetRouteUrl("ProductRoute",null));
            rptProcduct.DataSource = _db.Categories.Where(n => n.CateParentID == 4);
            rptProcduct.DataBind();

        }

        protected void rptProcduct_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField hdCateId = (HiddenField)e.Item.FindControl("Hidden");
            Repeater rptContent = (Repeater) e.Item.FindControl("rptContent");
            Label lblTitle = (Label)e.Item.FindControl("lbtitle");
            var data = _db.NewsLetters.Where(p => p.CateID.ToString() == hdCateId.Value);
            rptContent.DataSource = data;
            rptContent.DataBind();
        }
    }
}