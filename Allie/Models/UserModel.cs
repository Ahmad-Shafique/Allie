using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Allie.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }
        public int CompanyId { get; set; }
    }
}