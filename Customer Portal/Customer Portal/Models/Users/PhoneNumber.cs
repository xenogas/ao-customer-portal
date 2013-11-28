using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Portal.Models.Users
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public int AreaCode { get; set; }
        public int Number { get; set; }
        public int Extension { get; set; }
        public PhoneType Type { get; set; }
    }
}