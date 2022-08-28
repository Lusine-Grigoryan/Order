using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Order.DAL.Models
{
    public partial class State:IDEntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
