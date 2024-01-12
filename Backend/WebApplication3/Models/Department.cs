using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Department
    {
        [Key]

    public int Department_ID { get; set; }
    public string Department_Code { get; set;}

    public string Department_Name { get; set;}
    }
}
