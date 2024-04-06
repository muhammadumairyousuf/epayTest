using System.ComponentModel.DataAnnotations;

namespace CustomerManagmentAPI.Models
{
    public class Customer: IValidatableObject
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public int Age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Age < 18)
            {
                yield return new ValidationResult("Age should be greater than 18");
            }
            if(Customers.Select(x=>x.Id).Contains(Id))
            {
                yield return new ValidationResult("Id is already Exists");
            }

        }
        public static List<Customer> Customers = new List<Customer>() {

            new Customer() { LastName= "Aaaa", FirstName= "Aaaa", Age= 20, Id= 3 },
             new Customer() { LastName= "Aaaa", FirstName= "Bbbb", Age= 56, Id= 2 },
             new Customer() { LastName= "Cccc", FirstName= "Aaaa", Age= 32, Id= 5 },
             new Customer() { LastName= "Cccc", FirstName= "Bbbb", Age= 50, Id= 1 },
             new Customer() { LastName= "Dddd", FirstName= "Aaaa", Age= 70, Id= 4 },
        };

    }


}
