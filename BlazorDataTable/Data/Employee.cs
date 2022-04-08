using System.ComponentModel.DataAnnotations;

namespace BlazorDataTable.Data
{
    public class Employee
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public DateTime? HireDate { get; set; }

        public int JobId { get; set; }
        public decimal Salary { get; set; }

        public int ManagerId { get; set; }
        public int DeptId { get; set; }

    }
}
