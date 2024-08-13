using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class User
    {
        [Key] 
        public int ID { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }

        public List<Result> Results { get; set; }
    }
}