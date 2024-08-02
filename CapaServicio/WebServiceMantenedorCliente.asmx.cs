using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceMantenedorCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorCliente : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarClienteService(Cliente cliente)
        {
            NegocioCliente auxNegocioCliente = new NegocioCliente();
            auxNegocioCliente.insertarCliente(cliente);
        }

        [WebMethod]
        public DataSet retornarClienteService()
        {
            NegocioCliente auxNegocioCliente = new NegocioCliente();
            
            return auxNegocioCliente.retornarCliente();
        }

        [WebMethod]
        public Cliente retornaPosicionClienteService(int pos)
        {
            NegocioCliente auxNegocioCliente = new NegocioCliente();
            return auxNegocioCliente.retornaPosicionCliente(pos);
        }

        [WebMethod]
        public Cliente buscarClienteService(String rut)
        {
            NegocioCliente auxNegocioCliente = new NegocioCliente();

             return auxNegocioCliente.buscarCliente(rut);
        }

        [WebMethod]
        public void eliminarClienteService(String rut)
        {
            NegocioCliente auxNegocioCliente = new NegocioCliente();
            auxNegocioCliente.eliminarCliente(rut);
        }

        [WebMethod]

        public void actualizarClienteService(Cliente cliente)
        {
            NegocioCliente auxNegocioCliente = new NegocioCliente();
            auxNegocioCliente.actualizarCliente(cliente);
        }




    }
}
