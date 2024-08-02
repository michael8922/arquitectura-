using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Det_Ingreso
    {
        private String id_detalle_ingreso;
        private int cantidad;
        private int valor_total;
        private String ingreso_p_id_ingreso;
        private String producto_codigo;

        public string Id_detalle_ingreso { get => id_detalle_ingreso; set => id_detalle_ingreso = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Valor_total { get => valor_total; set => valor_total = value; }
        public string Ingreso_p_id_ingreso { get => ingreso_p_id_ingreso; set => ingreso_p_id_ingreso = value; }
        public string Producto_codigo { get => producto_codigo; set => producto_codigo = value; }
    }
}
