using CustomerManagmentAPI.Models;

namespace CustomerManagmentAPI
{
    public class CustomerRepository
    {
        static List<Customer> Customers = new List<Customer>
        {
         new Customer() { LastName= "Aaaa", FirstName= "Aaaa", Age= 20, Id= 3 },
         new Customer() { LastName= "Aaaa", FirstName= "Bbbb", Age= 56, Id= 2 },
         new Customer() { LastName= "Cccc", FirstName= "Aaaa", Age= 32, Id= 5 },
         new Customer() { LastName= "Cccc", FirstName= "Bbbb", Age= 50, Id= 1 },
         new Customer() { LastName= "Dddd", FirstName= "Aaaa", Age= 70, Id= 4 },
        };
    }
}
