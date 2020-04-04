namespace QTProj.Models
{
    public class Call
    {
        public int CallId { get; set; }
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}