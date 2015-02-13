using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.DataContracts.Entities
{
    /// <summary>
    /// Represent customer in system
    /// </summary>
    public class Customer : BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Customer Id")]
        public long CustomerId { get; set; }
        
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string Lastname { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "E-mail address")]
        public string Email { get; set; }
        
        [Display(Name = "Mobile phone")]
        public string MobilePhone { get; set; }

        [Display(Name = "Facebook user id")]
        [ForeignKey("FacebookToken")]
        public string FacebookUserID { get; set; }

        [Display(Name = "Is blocked")]
        public bool IsBlocked { get; set; }

        [Display(Name = "Is waiting facebook registration")]
        public bool IsWaitingFacebookRegistration { get; set; }
        public string Password { get; set; }

        [Display(Name = "Accepts terms")]
        public bool? AcceptsTerms { get; set; }

        [Display(Name = "Date activated")]
        public DateTime? DateActivated { get; set; }

        [Display(Name = "Date deactivated")]
        public DateTime? DateDeactivated { get; set; }

        [Display(Name = "Last successful login")]
        public DateTime? LastSuccesfulLogin { get; set; }

        public virtual FacebookToken FacebookToken { get; set; }
    }
}
