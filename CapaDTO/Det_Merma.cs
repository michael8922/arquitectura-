using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Det_Merma
    {
        private String id_det_merma;
        private int cantidad;
        private String producto_codigo;
        private int valor_total;
        private String merma_id_merma;

        public string Id_det_merma { get => id_det_merma; set => id_det_merma = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Producto_codigo { get => producto_codigo; set => producto_codigo = value; }
        public int Valor_total { get => valor_total; set => valor_total = value; }
        public string Merma_id_merma { get => merma_id_merma; set => merma_id_merma = value; }
    }
}
