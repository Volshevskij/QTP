using QTProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QTProj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			using (var db = new CustomersContext())
			{
				var mq = from c in db.Customers
						 orderby c.CustomerId
						 select c;
				string myOut = "";

				foreach (var item in mq)
				{
					myOut += item.FistName;
				}
				lblOut.Text = myOut;
			}
		}
    }
}