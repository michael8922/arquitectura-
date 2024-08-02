using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Ubicacion
    {
        private String id_ubicacion;
        private String nombre_ubicacion;
        private DateTime fecha_ingreso_ubicacion;
        private String producto_codigo;
        private int cantidad;

        public string Id_ubicacion { get => id_ubicacion; set => id_ubicacion = value; }
        public string Nombre_ubicacion { get => nombre_ubicacion; set => nombre_ubicacion = value; }
        public DateTime Fecha_ingreso_ubicacion { get => fecha_ingreso_ubicacion; set => fecha_ingreso_ubicacion = value; }
        public string Producto_codigo { get => producto_codigo; set => producto_codigo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
