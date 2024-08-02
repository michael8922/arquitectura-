using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoColecciones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            /* Cliente auxCliente = new Cliente();
             auxCliente.Rut = "1-9";
             auxCliente.Nombre = " juan";

             Cliente auxCliente2 = new Cliente();
             auxCliente2.Rut = "1-8";
             auxCliente2.Nombre = " pedro";

             ListadoCliente auxListado = new ListadoCliente();
             auxListado.agregaCliente(auxCliente);
             auxListado.agregaCliente(auxCliente2);

             auxListado.imprimeCliente();

             Console.ReadKey();*/


            PantallaMenu pMenu = new PantallaMenu();
            pMenu.ShowDialog();

        }

        
    }
}
