using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Det_Salida
    {
        private String id_detalle_salida;
        private int cantidad;
        private int valor_total;
        private String salida_p_id_salida;
        private String producto_codigo;

        public string Id_detalle_salida { get => id_detalle_salida; set => id_detalle_salida = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Valor_total { get => valor_total; set => valor_total = value; }
        public string Salida_p_id_salida { get => salida_p_id_salida; set => salida_p_id_salida = value; }
        public string Producto_codigo { get => producto_codigo; set => producto_codigo = value; }
    }
}
