using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobPlacementDashboard.Models
{
    public class JPCurrentJob
    {

        [Key]
        

        public Guid JPCurrentId { get; set; }
        [DisplayName("Company Name")]
        public string JPCompanyName { get; set; }
        [DisplayName("Job Title")]
        public string JPJobTitle { get; set; }
        [DisplayName("Job Category")]
        public JPJobCategory JPJobCategory { get; set; }
        [DisplayName("Salary")]
        public decimal JPSalary { get; set; }
        [DisplayName("Work Location City")]
        public string JPCompanyCity { get; set; }
        [DisplayName("Work Location State")]
        public JPCompanyState JPCompanyState { get; set; }
        [DisplayName("Careers Page")]
        public string JPCareersPage { get; set; }
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}