using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabxInfo.Models.Models
{
    public class Designation
    {
        public List<Designation> Designations;
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter Designation")]
        //[DisplayName("Designation")]
        public string DesignationName { get; set; }
    }
}
