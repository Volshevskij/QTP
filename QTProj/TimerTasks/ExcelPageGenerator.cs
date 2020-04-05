using OfficeOpenXml;
using QTProj.Models;
using Quartz;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace QTProj.TimerTasks
{
    public class ExcelPageGenerator : IJob
    {
        public async Task Execute(IJobExecutionContext context)
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

                ExcelPackage excel = new ExcelPackage();
                var workSheet = excel.Workbook.Worksheets.Add("Sheet1");
                workSheet.Cells[1, 1].LoadFromCollection(customers.ToArray(), true);
                using (var fileStream = new FileStream(@"C:\Scrumpeer\exc.xls", FileMode.OpenOrCreate))
                {
                    excel.SaveAs(fileStream);
                    fileStream.Close();
                }
            }      
        }
    }
}
    
