using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berclean.Entities
{
    class UsuarioE
    {
        private int id;
        private string nombre;
        private string contraseña;
        private int id_permiso;
        private bool borrado;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Id_permiso { get => id_permiso; set => id_permiso = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
    }
}
