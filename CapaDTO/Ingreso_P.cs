using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Ingreso_P
    {
        private String id_ingreso;
        private DateTime fecha;
        private String usuario_rut;
        private String proveedor_rol;
        

        public string Id_ingreso { get => id_ingreso; set => id_ingreso = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Usuario_rut { get => usuario_rut; set => usuario_rut = value; }
        public string Proveedor_rol { get => proveedor_rol; set => proveedor_rol = value; }
       
    }
}
