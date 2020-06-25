using System;
//using System;
using System.ComponentModel.DataAnnotations;

namespace CBA.Training.Talmate.Api.Models
{
    public class UserRolesDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string RoleName { get; set; }
    }
}
