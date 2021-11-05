using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using berclean.Entities;

namespace berclean.DataAccessLayer
{
    class ClienteDao
    {
        string sentencia;
        public IList<ClienteE> GetAll()
        {
            List<ClienteE> listadoClie = new List<ClienteE>();

            var strSql = "SELECT cuit, razonSocial, iva, ganancias, domicilio, idIngresos, telefono, mail, condicion, tipo " +
                         "FROM cliente WHERE borrado = 0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoClie.Add(crearObjClien(row));
            }

            return listadoClie;
        }
        private ClienteE crearObjClien(DataRow row)
        {
            ClienteE oCliente = new ClienteE();
            oCliente.Cuit = Convert.ToInt32(row[0].ToString());
            oCliente.Razon_social = row[1].ToString();
            oCliente.Iva = Convert.ToInt32(row[2].ToString());
            oCliente.Ganancias = Convert.ToInt32(row[3].ToString());
            oCliente.Domicilio = Convert.ToInt32(row[4].ToString());
            oCliente.Ingresos = Convert.ToInt32(row[5].ToString());
            oCliente.Telefono = Convert.ToInt32(row[6].ToString());
            oCliente.Mail = row[7].ToString();
            oCliente.Condicion_venta = Convert.ToInt32(row[8].ToString());
            oCliente.Tipo = Convert.ToInt32(row[9].ToString());
            return oCliente;
        }
    }
}
