using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        readonly ModelDataContext _dataContext = new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string newsId = Request.QueryString["pid"];
            rptProDe.DataSource = _dataContext.NewsLetters.Where(p => p.NewsID.ToString() == newsId);
            rptProDe.DataBind();
        }
    }
}