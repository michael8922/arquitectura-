using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Merma
    {
        private String id_merma;
        private DateTime fecha;
        private String motivo;
        private String tipo_solicitud;
        private String usuario_rut;
        

        public string Id_merma { get => id_merma; set => id_merma = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Tipo_solicitud { get => tipo_solicitud; set => tipo_solicitud = value; }
        public string Usuario_rut { get => usuario_rut; set => usuario_rut = value; }
       
    }
}
