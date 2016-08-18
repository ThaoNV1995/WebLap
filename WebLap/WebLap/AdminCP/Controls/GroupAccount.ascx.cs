using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.AdminCP.Controls
{
    public partial class GroupAccount : System.Web.UI.UserControl
    {
        readonly ModelDataContext _db=new ModelDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            groupAccuont.DataSource = _db.Accounts;
            groupAccuont.DataBind();
        }
    }
}