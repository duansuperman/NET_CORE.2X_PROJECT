using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveAndReadFile.Models
{
    public class FileInputModel
    {
        public IFormFile UploadToFile { get; set; }
    }
}
