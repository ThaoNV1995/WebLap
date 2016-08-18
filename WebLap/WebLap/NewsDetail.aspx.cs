using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap
{
    public partial class NewsDetail : System.Web.UI.Page
    {
        readonly ModelDataContext _db = new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string newsId = Request.QueryString["nid"];
            NewsLetter news = _db.NewsLetters.SingleOrDefault(n => n.NewsID.ToString() == newsId);
            if (news != null) Label1.Text = news.Detail;
            rptDetai.DataSource = _db.NewsLetters.Where(t => t.NewsID.ToString() == newsId);
            rptDetai.DataBind();
            UpdateClick();
        }


        public void UpdateClick()
        {
            string newsId = Request.QueryString["nid"];
            var count = _db.NewsLetters.SingleOrDefault(x => x.NewsID.ToString() == newsId);
            if (count != null && count.HiCount != null) count.HiCount = count.HiCount.Value + 1;
            _db.SubmitChanges();
        }
    }
}