using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Result
    {
        [Key]
        public int ID { get; set; }

        public User User { get; set; }

        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        public double FIRST_NUMBER { get; set; }
        public string OPERATION { get; set; }
        public double SECOND_NUMBER { get; set; }
        public double RESULT { get; set; }
    }
}