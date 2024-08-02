using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Cliente
    {
        private String rut;
        private String nombre;
        private String apellido;
        private int telefono;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
