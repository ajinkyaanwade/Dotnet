namespace WebApplication_Task_1.Models
{
    public class CustomerServices:ICustomer
    {
        public static List<Customer> _customerlist;
        public CustomerServices() 
        {
            _customerlist = new List<Customer>()
            {
                new Customer() {Id = 1,Name = "Ajinkya",MobileNo = "7249821775",BillAmount = 6330},
                new Customer() {Id = 2,Name = "Sushil Gavit",MobileNo = "8421556678", BillAmount = 6000},
                new Customer() {Id = 3,Name = "Shubham Gaikwad",MobileNo = "9877654312",BillAmount = 5000},
                new Customer() {Id = 4,Name = "Shubham More",MobileNo = "7788996433",BillAmount = 4333},
                new Customer() {Id = 5,Name = "Akshay Shinde",MobileNo = "9899664531",BillAmount = 6000},
                new Customer() {Id = 6,Name = "Yash Hajare",MobileNo = "7787655421",BillAmount = 6400}
            };
        }
        public List<Customer> GetAllCustomers()
        {
            return _customerlist;
        }
    }
}
