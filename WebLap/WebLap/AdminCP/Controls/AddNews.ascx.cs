using System;
using System.Linq;

namespace WebLap.AdminCP.Control
{
    public partial class AddNews : System.Web.UI.UserControl
    {
        ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCate.DataSource = _db.Categories.Where(c => c.CateParentID !=null);
            ddlCate.DataValueField = "CateID";
            ddlCate.DataTextField = "CateName";
            ddlCate.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NewsLetter n = new NewsLetter();
                n.CateID = int.Parse(ddlCate.SelectedValue);
                n.Title = txtTitle.Text;
                n.SubTilte = txtSubTile.Text;
                n.Detail = txtContent.Text;
                n.Time = DateTime.Now;
                n.HiCount = 0;
                if (fileImge.HasFile)
                {
                    string path = "/Upload/images/news/" + fileImge.FileName;
                    n.Image = path;
                    fileImge.SaveAs(Server.MapPath(path));
                }
                _db.NewsLetters.InsertOnSubmit(n);
                _db.SubmitChanges();
            }
            Response.Redirect("Default.aspx?do=listnews");
        }

    }
}