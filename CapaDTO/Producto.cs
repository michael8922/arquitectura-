using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Producto
    {
        private String codigo;
        private String descripcion;
        private int precio_unitario;
        private int cantidad_total;
        private String marca_id_marca;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public int Cantidad_total { get => cantidad_total; set => cantidad_total = value; }
        public string Marca_id_marca { get => marca_id_marca; set => marca_id_marca = value; }
    }
}
