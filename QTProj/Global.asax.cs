using QTProj.TimerTasks;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace QTProj
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске приложения
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ExcelPageScheduler.Start();
        }
    }
}