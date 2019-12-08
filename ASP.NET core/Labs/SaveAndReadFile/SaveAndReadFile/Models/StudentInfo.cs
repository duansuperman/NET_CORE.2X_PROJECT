using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaveAndReadFile.Models
{
    public class StudentInfo
    {
       
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public double Marks { get; set; }
    }
}
