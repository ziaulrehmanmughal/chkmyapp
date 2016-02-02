using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace chk12345.DBFolder
{
    public class user
    {
        [Required]
        public string name { get; set; }

        [Key]
        public int id { get; set; }

        public string address { get; set; }
    }
}