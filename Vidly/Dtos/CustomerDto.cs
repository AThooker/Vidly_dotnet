using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        //Data Annotations - overriding code-first conventions
        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        //Navigational property - lets you navigate from one type to another
        //foreign key property
        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
        //[Min18YearsIfMember]
        public DateTime? Birthday { get; set; }
    }
}