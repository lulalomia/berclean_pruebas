using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using berclean.Entities;

namespace berclean.DataAccessLayer
{
    class UsuarioDao
    {
        private UsuarioE MappingUsuario(DataRow row)
        {
            UsuarioE oUsuario = new UsuarioE
            {
                Id = Convert.ToInt32(row["id"].ToString()),
                Nombre = row["nombre"].ToString(),
                Contraseña = row["contraseña"].ToString(),
                Id_permiso = Convert.ToInt32(row["id_permiso"].ToString()),
            };

            return oUsuario;
        }

        public UsuarioE recuperarUsuario(string pUsuario)
        {
            String consultaSql = string.Concat("SELECT id, nombre, contraseña, idPermiso ",
                                               "FROM usuario ",
                                               "WHERE borrado = 0 AND nombre= '", pUsuario, "'");
            var TablaResultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if (TablaResultado.Rows.Count > 0)
            {
                return MappingUsuario(TablaResultado.Rows[0]);
            }

            return null;
        }

        internal void baja(int id_usuario)
        {
            string sentencia = string.Concat("UPDATE usuario SET borrado = 1 WHERE id =", id_usuario);
            DBHelper.GetDBHelper().ConsultaSQL(sentencia);
        }

        internal UsuarioE GetUsuario(int id_usuario)
        {
            //Construimos la consulta sql para buscar al Usuario
            String consultaSql = string.Concat("SELECT id, nombre, contraseña, id_permiso",
                                               " FROM usuario",
                                               " WHERE id = " + id_usuario);
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                return MappingUsuario(resultado.Rows[0]);
            }

            return null;
        }

        internal void actualizacion(int id, string nom, string contra, int permiso, bool esAlta)
        {
            string sentencia;
            if (esAlta)
            {
                sentencia = string.Concat("INSERT INTO usuario (nombre, contraseña, id_permiso, borrado) ",
                                          "VALUES ('", nom, "', '", contra, "' , '", permiso, "', 0)");
            }
            else
            {
                sentencia = string.Concat("UPDATE usuario SET nombre = '", nom,
                                                             "', contraseña = '", contra,
                                                             "', id_permiso = '", permiso,
                                                            "' WHERE id = ", id);
            }
            DBHelper.GetDBHelper().abm(sentencia);
        }

        internal IList<UsuarioE> GetAll()
        {
            List<UsuarioE> listadoUsuario = new List<UsuarioE>();

            var strSQL = "SELECT id, nombre, contraseña, id_permiso FROM usuario WHERE  borrado = 0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSQL);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuario.Add(MappingUsuario(row));
            }
            return listadoUsuario;
        }

    }
}
