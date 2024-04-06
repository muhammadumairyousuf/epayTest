using CustomerManagmentAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerManagmentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> Get()
        {
            return Customer.Customers
            .ToArray();
        }

        [HttpPost(Name = "AddCustomers")]
        public List<Customer> AddCustomer([FromBody] List<Customer> customers)
        {
            if (ModelState.IsValid)
            {

                Customer.Customers.AddRange(customers);
                int n = Customer.Customers.Count;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (string.Compare(Customer.Customers[j].LastName,Customer.Customers[j + 1].LastName) > 0 && string.Compare(Customer.Customers[j].FirstName, Customer.Customers[j + 1].FirstName) > 1)
                        {
                            Customer temp = Customer.Customers[j];
                            Customer.Customers[j] = Customer.Customers[j + 1];
                            Customer.Customers[j + 1] = temp;
                        }
                        if (string.Compare(Customer.Customers[j].FirstName, Customer.Customers[j + 1].FirstName) > 1)
                        {
                            Customer temp = Customer.Customers[j];
                            Customer.Customers[j] = Customer.Customers[j + 1];
                            Customer.Customers[j + 1] = temp;
                        }
                    }
                }



            }
            return customers;
        }
    }
}
