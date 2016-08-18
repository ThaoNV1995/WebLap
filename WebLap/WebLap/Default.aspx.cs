using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap
{
    public partial class Default : System.Web.UI.Page
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptNewhot.DataSource = _db.NewsLetters.Where(n => n.HiCount > 1).OrderByDescending(letter => letter.HiCount).Take(4);
            rptNewhot.DataBind();
        }
    }
}