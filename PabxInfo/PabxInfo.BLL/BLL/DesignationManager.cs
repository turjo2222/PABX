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


        public bool Delete(Designation designation)
        {
            return _designationRepository.Delete(designation);
        }
        public Designation GetById(int Id)
        {
            return _designationRepository.GetById(Id);

        }
        public bool Update(Designation designation)
        {
            return _designationRepository.Update(designation);
        }
        public List<Designation> GetAll()
        {
            return _designationRepository.GetAll();
        }
    }
}
