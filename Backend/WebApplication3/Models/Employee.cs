using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Employee
    {

        [Key]

        public int Employee_ID { get; set; }
        public int Department_ID { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Email { get; set; }

        public string Date_of_Birth { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }
       
        public string Department { get; set; }
    }
}
