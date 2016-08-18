using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.Controls
{
    public partial class CateNews : System.Web.UI.UserControl
    {
        readonly ModelDataContext _dataContext = new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string cateId = Request.QueryString["nid"];

            rptContent.DataSource =
                _dataContext.Categories.Where(n => n.CateParentID == 3);

            rptContent.DataBind();
            LoadCateName();
            
        }

        public void LoadCateName()
        {
            //rptContent.DataSource = _dataContext.NewsLetters
            //rptContent.DataBind();
        }

        protected void rptContent_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField hdCateId = (HiddenField)e.Item.FindControl("HiddenField1");
            Repeater rptChild = (Repeater)e.Item.FindControl("rptCon");
            Label lb = (Label)e.Item.FindControl("lblTitle");
            HyperLink hyper = (HyperLink) e.Item.FindControl("HyperLink1");
            Label lds = (Label)e.Item.FindControl("lblSubTitle");
            Image img = (Image) e.Item.FindControl("Image");
            var data = _dataContext.NewsLetters.Where(c => c.CateID.ToString() == hdCateId.Value);
            NewsLetter news = data.First();
            hyper.Text = news.Title;
            hyper.NavigateUrl = "/NewsDetail.aspx?nid="+news.NewsID+"";
            lds.Text = news.SubTilte;
            img.ImageUrl = news.Image;
            rptChild.DataSource = data.Skip(1).Take(3);
            rptChild.DataBind();
        }
    }
}