using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Client
{
    public class MyModel
    {
        [MaxLength(3)]
        [Required]
        public string Name { get; set; }
    }
}
