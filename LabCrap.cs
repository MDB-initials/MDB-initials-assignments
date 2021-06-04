using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AssignLab.Models
{
    public class LabCrap
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }
        public bool Check { get; set; }
    }
    public class LabTestsDue
    {
        public int ID { get; set; }
        [ForeignKey("lc")]
        public int labTestId { get; set; }
        public LabCrap lc { get; set; }
        public string patientName { get; set; }
        public DateTime dateTimeStamp { get; set; }
    }

    public class LabContext : ApplicationDbContext
    {
        public DbSet<LabCrap> lab { get; set; }//labTest

        public DbSet<LabTestsDue> Tests { get; set; }//LabTestsDue
    }
}