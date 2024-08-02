using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoColecciones
{
    public class ListadoCliente
    {
        private List<Cliente> LisCliente;

        public ListadoCliente()
        {
            this.LisCliente1 = new List<Cliente>();
        }

        public List<Cliente> LisCliente1 { get => LisCliente; set => LisCliente = value; }

        public void agregaCliente(Cliente cliente)
        {
            this.LisCliente1.Add(cliente);
        }

        public void imprimeCliente()
        {
            IEnumerator iter = this.LisCliente1.GetEnumerator();

            while (iter.MoveNext())
            {
                Cliente auxCliente = new Cliente();
                auxCliente = (Cliente)iter.Current;
                Console.WriteLine(auxCliente.Rut + " " + auxCliente.Nombre);
            }
        }

        
    }
}
