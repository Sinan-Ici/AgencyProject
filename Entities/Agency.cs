using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Agency
    {
        [Key]
        public int AgencyID { get; set; }
        public string AgencyName { get; set; }
    }
}
