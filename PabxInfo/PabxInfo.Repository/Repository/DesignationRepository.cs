using PabxInfo.DatabaseContext.DatabaseContext;
using PabxInfo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabxInfo.Repository.Repository
{
    public class DesignationRepository
    {

        PabxInfoDBContext db = new PabxInfoDBContext();
        public bool Add(Designation designation)
        {
            int isExecuted = 0;

            db.Designations.Add(designation);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        public List<Designation> GetAll()
        {

            return db.Designations.ToList();
        }
    }
}
