using QTProj.Models;
using System;
using System.Linq;
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
                var customers = from call in db.Calls
                             join customer in db.Customers on call.CustomerId equals customer.CustomerId
                             select new
                             {
                                 FirstName = customer.FistName,
                                 Surname = customer.Surname,
                                 Address = customer.Address,
                                 Number = call.Number,
                                 Index = call.Index
                             };

                Grid.DataSource = customers.ToList();
                Grid.DataBind();
            }		
		}
    }
}