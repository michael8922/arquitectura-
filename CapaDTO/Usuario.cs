using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Usuario
    {
        private String rut;
        private String nombre;
        private String clave;
        private String cargo;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
