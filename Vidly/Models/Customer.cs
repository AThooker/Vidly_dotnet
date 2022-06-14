using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //Data Annotations - overriding code-first conventions
        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        //Navigational property - lets you navigate from one type to another
        public MembershipType MembershipType { get; set; }
        //foreign key property
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date of Birth")]
        [Min18YearsIfMember]
        public DateTime? Birthday { get; set; }
    }
}