using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap
{
    public partial class ListNews : System.Web.UI.Page
    {
        readonly ModelDataContext _db=new ModelDataContext();
        private const int PageSize = 4;

        protected void Page_Load(object sender, EventArgs e)
        {
            var data = _db.NewsLetters.Where(n => n.NewsID.ToString() != null);
            DataList.DataSource = data;
            DataList.DataBind();
            int page = 1;
            if (Request.QueryString["page"] != null)
                page = int.Parse(Request.QueryString["page"]);
            DataList.DataSource = data.Skip((page - 1)*PageSize).Take(PageSize);
            DataList.DataBind();
            int records = data.Count();
            int totalPge = records / PageSize;
            int modRecord = records%PageSize;
            if (modRecord != 0)
                totalPge += 1;
            paging.Text = "";
            for (int i = 1; i <= totalPge; i++)
            {
                if (page != i)
                    paging.Text +=
                        "<a stype='color:blue'; text-decoration:underline; padding:3px; href='ListNews.aspx?page=" + i +
                        "'>" + i + "</a>";
                else
                {
                    paging.Text +=
                        "<a stype='font-weight:bold'; color:Red; text-decoration:none; padding:3px; href='ListNews.aspx?page=" + i +
                        "'>" + i + "</a>";
                }
            }
        }

        protected void btGo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListNews.aspx?page=" + txtPage.Text + "");
        }
    }
}