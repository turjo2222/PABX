using PabxInfo.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PabxInfo.Models
{
    public class DesignationAddViewModel
    {
        [Required(ErrorMessage = "Please enter Designation")]
        [DisplayName ("Designation")]
        public string DesignationName { get; set; }
        public List<Designation> Designations { get; set; }
        
    }
}