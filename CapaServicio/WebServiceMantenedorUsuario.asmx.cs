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
    /// Descripción breve de WebServiceMantenedorUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorUsuario : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarUsuarioService(Usuario usuario)
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            auxNegocioUsuario.insertarUsuario(usuario);

        }

        [WebMethod]
        public DataSet retornarUsuarioService()
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            return auxNegocioUsuario.retornarUsuario();

        }

        [WebMethod]
        public Usuario retornaPosicionUsuarioService(int pos)
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            return auxNegocioUsuario.retornaPosicionUsuario(pos);
        }

        [WebMethod]
        public Usuario buscarUsuarioService(String rut)
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            return auxNegocioUsuario.buscarUsuario(rut);
        }

        [WebMethod]
        public void eliminarUsuarioService(String rut)
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            auxNegocioUsuario.eliminarUsuario(rut);
        }

        [WebMethod]
        public void actualizarUsuarioService(Usuario usuario)
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            auxNegocioUsuario.actualizarUsuario(usuario);
        }

        [WebMethod]
        public DataSet buscarRutUsuarioService(String rut)
        {
            NegocioUsuario auxNegocioUsuario = new NegocioUsuario();
            return auxNegocioUsuario.buscarRutUsuario(rut);
        }
    }
}
