using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public static class CurrentUser
    {
        public static string Email { get; set; }
        public static int UserID { get; set; }
    }
}