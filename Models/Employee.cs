using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDotNetCoreCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email Pattern error")]
        [StringLength(100,ErrorMessage = "Email length")]
        public string Email { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Employee Name")]
        public string EmployeeName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Employee Code")]
        public string EmployeeCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string position { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
