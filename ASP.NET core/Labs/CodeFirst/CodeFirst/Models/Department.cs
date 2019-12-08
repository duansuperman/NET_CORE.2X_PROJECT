using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Department
    {
        [Key]
        public string ID { get; set; }
        [StringLength(8,MinimumLength =3)]
        public string Name { get; set; }
    }
}
