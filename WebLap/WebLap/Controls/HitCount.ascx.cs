using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLap.Controls
{
    public partial class HitCount : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblHitCount.Text = "Số lượng người truy cập:" + Application["HitCount"];
            lbOnline.Text = "Số người đang online" + Application["Online"];
        }
    }
}