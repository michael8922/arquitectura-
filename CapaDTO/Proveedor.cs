using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Proveedor
    {
        private String rol;
        private String nombre_proveedor;
        private String direccion;
        private int telefono;

        public string Rol { get => rol; set => rol = value; }
        public string Nombre_proveedor { get => nombre_proveedor; set => nombre_proveedor = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
