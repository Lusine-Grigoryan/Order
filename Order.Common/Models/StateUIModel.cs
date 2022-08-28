using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Common.Models
{
    public class StateUIModel
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
