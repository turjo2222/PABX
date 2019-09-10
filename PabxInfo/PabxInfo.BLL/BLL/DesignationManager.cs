using PabxInfo.Models.Models;
using PabxInfo.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabxInfo.BLL.BLL
{
    public class DesignationManager
    {
        DesignationRepository _designationRepository = new DesignationRepository();
        public bool Add(Designation designation)
        {
            return _designationRepository.Add(designation);
        }
        public List<Designation> GetAll()
        {
            return _designationRepository.GetAll();
        }
    }
}
