using PabxInfo.DatabaseContext.DatabaseContext;
using PabxInfo.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabxInfo.Repository.Repository
{
    public class ClientRepository
    {
        PabxInfoDBContext db = new PabxInfoDBContext();
        public bool Add(Client client)
        {
            int isExecuted = 0;

            db.Clients.Add(client);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
    }


}
