using QTProj.Models;
using System;
using System.Linq;
using System.Web.UI;

namespace QTProj
{
    public partial class Customers : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new CustomersContext())
            {              
                Grid.DataSource = db.Customers.ToList();
                Grid.DataBind();
            }
        }
    }
}