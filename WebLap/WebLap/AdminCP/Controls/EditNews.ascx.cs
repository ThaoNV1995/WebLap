using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.AdminCP.Controls
{
    public partial class EditNews : System.Web.UI.UserControl
    {
        readonly ModelDataContext _db = new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCate.DataSource = _db.Categories.Where(c => c.CateParentID == 4);
            ddlCate.DataValueField = "CateID";
            ddlCate.DataTextField = "CateName";
            ddlCate.DataBind();
            var qry = from m in _db.NewsLetters
                where m.NewsID == Convert.ToInt32(Request.QueryString["id"])
                select m;
            foreach (var p in qry)
            {
                txtTitle.Text = p.Title;
                txtSubTile.Text = p.SubTilte;
                txtContent.Text = p.Detail;
            }
        }
    
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ddlCate.DataSource = _db.Categories.Where(c => c.CateParentID !=null);
            ddlCate.DataValueField = "CateID";
            ddlCate.DataTextField = "CateName";
            ddlCate.DataBind();
            var qry = from m in _db.NewsLetters
                      where m.NewsID == Convert.ToInt32(Request.QueryString["id"])
                      select m;
            foreach (var p in qry)
            {
                p.Title = txtTitle.Text;
                p.SubTilte = txtSubTile.Text;
                p.Detail = txtContent.Text;
                if (fileImge.HasFile)
                {
                    string path = "/Upload/images/news/" + fileImge.FileName;
                    p.Image = path;
                    fileImge.SaveAs(Server.MapPath(path));
                }
            }
            _db.SubmitChanges();
            Response.Redirect("/AdminCP/Default.aspx?id=2&do=listnews");
        }
    }
}