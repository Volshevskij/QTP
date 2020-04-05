using System.Collections.Generic;

namespace QTProj.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FistName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public List<Call> Calls { get; set; }

        public Customer()
        {
            Calls = new List<Call>();
        }
    }
}