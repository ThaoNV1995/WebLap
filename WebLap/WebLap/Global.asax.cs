using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Routing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebLap
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
            // Lần đầu tiên đưa Web lên
            // Mở tệp tin counter để đọc dữ liệu và ghi nhớ trong tệp tin.
            StreamReader sr=new StreamReader(Server.MapPath("Counter.txt"));
            Application["HitCount"] = int.Parse(sr.ReadLine());
            Application["Online"] = 0;
            sr.Close();
        }

        void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
               "DefaultRoute",
               "Default",
               "~/Default.aspx"
               );
            routes.MapPageRoute(
                "ProductRoute",
                "Product",
                "~/Product.aspx"
                );
            routes.MapPageRoute(
                "CategoryRoute",
                "Category",
                "~/Category.aspx"
                );
            routes.MapPageRoute(
                "CateNewRoute",
                "CateNews",
                "~/CateNews.aspx"
                );
        }

       protected void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "ProductsByCategoryRoute",
                "Category/{categoryName}",
                "~/ProductList.aspx"
            );
            routes.MapPageRoute(
                "ProductByNameRoute",
                "Product/{productName}",
                "~/ProductDetails.aspx"
            );
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["HitCount"] = (int) Application["HitCount"] + 1;
            Application["Online"] = (int) Application["Online"] + 1;

            StreamWriter sw = new StreamWriter(Server.MapPath("Counter.txt"));
            sw.Write(Application["HitCount"]);
            sw.Close();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["HitCount"] = (int) Application["HitCount"] - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}