using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabxInfo.Models.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }

        public int DesignationId { get; set; }
        public Designation Designation { get; set; }
    }
}
