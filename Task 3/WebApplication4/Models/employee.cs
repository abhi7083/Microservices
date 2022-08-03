using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class employee
    {
        [Key]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public int Salary { get; set; }
    }
}
