using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.Controls
{
    public partial class HotNews : System.Web.UI.UserControl
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptNews.DataSource = _db.NewsLetters.Where(n => n.HiCount >1).OrderByDescending(letter => letter.HiCount).Take(6);
            rptNews.DataBind();
        }

        protected void rptNews_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField hdCateId = (HiddenField)e.Item.FindControl("hdCount");
            Repeater rptChild = (Repeater)e.Item.FindControl("rptNews");
            var count = _db.NewsLetters.Single(x => x.NewsID.ToString() == hdCateId.Value);
            if (count.HiCount != null) count.HiCount = count.HiCount.Value + 1;
            _db.SubmitChanges();
        }
    }
}