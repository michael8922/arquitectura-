using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Marca
    {

        private String id_marca;
        private String nombre;

        public string Id_marca { get => id_marca; set => id_marca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
