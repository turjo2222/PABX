using PabxInfo.Models.Models;
using PabxInfo.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PabxInfo.BLL.BLL
{
   public class ClientManager
    {
        ClientRepository _clientRepository = new ClientRepository();
        public bool Add(Client client)
        {
            return _clientRepository.Add(client);
        }
    }
}
