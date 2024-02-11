using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MvcApplication_Hrms.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Boolean IsAgree { get; set; }
        public string CityId { get; set; }
        public string[] Languages { get; set; }
        public UserStatus Status { get; set; }
    }
    public enum UserStatus
    {
        Active = 1,
        InActive = 0
    }
}