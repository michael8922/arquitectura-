using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Salida_P
    {
        private String id_salida;
        private DateTime fecha;
        private String cliente_rut;
        private String usuario_rut;
        

        public string Id_salida { get => id_salida; set => id_salida = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Cliente_rut { get => cliente_rut; set => cliente_rut = value; }
        public string Usuario_rut { get => usuario_rut; set => usuario_rut = value; }
        
    }
}
