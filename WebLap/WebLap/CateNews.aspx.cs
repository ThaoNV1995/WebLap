using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap
{
    public partial class CateNews : System.Web.UI.Page
    {
        readonly ModelDataContext db = new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            int pagesize = 3;//so item tron 1 trang
            int page = 1;//ktao trang bd =1
            if (Request.QueryString["page"] != null)
                page = int.Parse(Request.QueryString["page"]);

            int total = db.Products.Count();//dem tong so item
            int index = total / pagesize;//tong so trang
            if (total % pagesize > 0)
                index = index + 1;//neu le thi cong them 1 trang
            for (int i = 1; i <= index; i++)//in ra so trang
                if (i == page)
                {
                    paging.Text += "<a class='current' href='CateNews.aspx?page=" + i + "'>" + i + "</a>";
                }
                else
                {
                    paging.Text += "<a href='CateNews.aspx?page=" + i + "'>" + i + "</a>";
                }
            rptPro.DataSource = db.Products.Skip((page - 1) * pagesize).Take(pagesize);
            rptPro.DataBind();
        }

        protected void btPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("CateNews.aspx?page="+txtPage.Text+"");
        }
    }
}