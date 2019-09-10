using PabxInfo.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PabxInfo.Models
{
    public class ClientAddViewModel
    {
        public int Id { get; set; }
        public string ClientName { get; set; }

        [DisplayName("Designation")]
        public int DesignationID { get; set; }
        public IEnumerable<SelectListItem> DesignationSelectListItem { get; set; }
        


      

    }
}