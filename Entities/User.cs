using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Agency { get; set; }
        public string Password { get; set; }
    }
}
