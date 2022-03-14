using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string AdminName { get; set; }
    }
}
