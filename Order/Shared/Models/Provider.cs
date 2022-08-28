using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Order.DAL.Models
{
    public partial class Provider:IDEntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address1 { get; set; }
        [Required]
        public string Address2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zip { get; set; }
        public State State { get; set; }
        [Required]
        public int StateId { get; set; }
    }
}
