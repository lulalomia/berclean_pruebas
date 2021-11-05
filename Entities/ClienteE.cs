using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berclean.Entities
{
    class ClienteE
    {
        private int cuit;
        private string razon_social;
        private int iva;
        private int ganancias;
        private int domicilio;
        private int id_ingresos;
        private int telefono;
        private string mail;
        private int condicion_venta;
        private int tipo;
        private bool borrado;

        public int Cuit { get => cuit; set => cuit = value; }
        public string Razon_social { get => razon_social; set => razon_social = value; }
        public int Iva { get => iva; set => iva = value; }
        public int Ganancias { get => ganancias; set => ganancias = value; }
        public int Domicilio { get => domicilio; set => domicilio = value; }
        public int Ingresos { get => id_ingresos; set => id_ingresos = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Condicion_venta { get => condicion_venta; set => condicion_venta = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

    }
}
