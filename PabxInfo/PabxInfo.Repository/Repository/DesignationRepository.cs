using PabxInfo.DatabaseContext.DatabaseContext;
using PabxInfo.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        ////
        public bool Delete(Designation designation)
        {
            int isExecuted = 0;
            Designation adesignation = db.Designations.FirstOrDefault(c => c.ID == designation.ID);
            if (adesignation != null)
            {
                db.Designations.Remove(adesignation);
                isExecuted = db.SaveChanges();
            }
            if (isExecuted > 0)
                return true;
            return false;
        }
        public Designation GetById(int Id)
        {
            Designation adesignation = db.Designations.FirstOrDefault(c => c.ID == Id);
            return adesignation;
        }

        public bool Update(Designation designation)
        {
            int isExecuted = 0;
            //Method 1
            //Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            //if (aStudent != null)
            //{
            //    aStudent.Name = student.Name;
            //    isExecuted = db.SaveChanges();
            //}

            //Method 2
            db.Entry(designation).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }


    }
}
