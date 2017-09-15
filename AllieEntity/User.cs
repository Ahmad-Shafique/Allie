using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AllieEntity
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "User Nmae required")]
        [StringLength(160)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password required")]
        [StringLength(20)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Address required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phone Number required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "UserType required")]
        public int UserType { get; set; }
        public int CompanyId { get; set; }
    }
}
