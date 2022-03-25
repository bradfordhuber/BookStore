using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_7.Models
{
    public class Payment
    {

        [Key]
        [BindNever]
        public int PaymentId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please Enter a Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter an Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter a City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter a State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please Enter a Zip")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please Enter a Country")]
        public string Country { get; set; }

        [BindNever]
        public bool PaymentRecieved { get; set; }


    }
}
