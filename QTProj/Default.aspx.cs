using QTProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QTProj
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			using (var db = new CustomersContext())
			{
                var customers = db.Customers.Join(db.Calls, 
                cust => cust.CustomerId, 
                cal => cal.CallId,
                (cust, cal) => new 
                {
                    CustomerId = cust.CustomerId,
                    FirstName = cust.FistName,
                    Surname = cust.Surname,
                    Number = cal.Number
                });

                Grid.DataSource = customers.ToList();
                Grid.DataBind();
            }		
		}
    }
}