using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using berclean.DataAccessLayer;
using berclean.Entities;
using System.Windows.Forms;
using System.Data;

namespace berclean.BussinessLayer
{
    class ClienteService
    {
        private ClienteDao oClienteDao;
        private ClienteE oCliente = new ClienteE();
        public ClienteService()
        {
            oClienteDao = new ClienteDao();
        }
        public IList<ClienteE> recuperarCliente()
        {
            return oClienteDao.GetAll();
        }
    }
}
