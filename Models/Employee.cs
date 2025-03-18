using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Client_Invoice_System.Models
{
    public enum Designation
    {
        Developer,
        Designer,
        ProjectManager,
        QAEngineer,
        HR,
        Admin
    }

    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public Designation Designation { get; set; } // ✅ Changed from string to Enum

        [Column(TypeName = "decimal(18,2)")]
        public decimal HourlyRate { get; set; }

        // Navigation Property
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
