using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.AdminCP.Controls
{
    public partial class ListNews : System.Web.UI.UserControl
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private const int PageSize = 2;
        public void Load_Data()
        {
            var data = _db.NewsLetters.Where(n => n.NewsID.ToString() != null);
            GridView1.DataSource = data;
            GridView1.DataBind();
            int page = 1;
            if (Request.QueryString["id"] != null)
                page = int.Parse(Request.QueryString["id"]);
            GridView1.DataSource = data.Skip((page - 1) * PageSize).Take(PageSize);
            GridView1.DataBind();
            int records = data.Count();
            int totalPge = records / PageSize;
            int modRecord = records % PageSize;
            if (modRecord != 0)
                totalPge += 1;
            paging.Text = "";
            for (int i = 1; i <= totalPge; i++)
            {
                if (page != i)
                    paging.Text +=
                        "<a stype='color:blue'; text-decoration:underline; padding:3px; href='Default.aspx?id=" + i +
                        "&do=listnews'>" + i + "</a>";
                else
                {
                    paging.Text +=
                        "<a stype='font-weight:bold'; color:Red; text-decoration:none; padding:3px; href='Default.aspx?id=" + i +
                        "&do=listnews'>" + i + "</a>";
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void GridView1_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            NewsLetter n = _db.NewsLetters.SingleOrDefault(m => m.NewsID.ToString() == e.CommandArgument.ToString());
            _db.NewsLetters.DeleteOnSubmit(n);
            _db.SubmitChanges();
        }
    }
}