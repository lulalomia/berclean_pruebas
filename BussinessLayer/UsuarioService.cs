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
    class UsuarioService
    {
        UsuarioDao oUsuarioDao;
        UsuarioE oUsuario = new UsuarioE();
        public UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }
        public IList<UsuarioE> recuperarUsuario()
        {
            return oUsuarioDao.GetAll();
        }
        public UsuarioE validarUsuario(string usuario, string contraseña)
        {
            UsuarioE usr = oUsuarioDao.recuperarUsuario(usuario);
            
            if (usr != null)
            {
                if (usr.Contraseña.Equals(contraseña))
                {
                    return usr;
                }
            }

            return null;
        }
    }
}
