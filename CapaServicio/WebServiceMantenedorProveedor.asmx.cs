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
    /// Descripción breve de WebServiceMantenedorProveedor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorProveedor : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarProveedorService(Proveedor proveedor)
        {
            NegocioProveedor auxNegocioProveedor = new NegocioProveedor();
            auxNegocioProveedor.insertarProveedor(proveedor);
        }

        [WebMethod]
        public DataSet retornarProveedorService()
        {
            NegocioProveedor auxNegocioProveedor = new NegocioProveedor();
            return auxNegocioProveedor.retornarProveedor();
        }

        [WebMethod]
        public Proveedor retornaPosicionProveedorService(int pos)
        {
            NegocioProveedor auxNegocioProveedor = new NegocioProveedor();
            return auxNegocioProveedor.retornaPosicionProveedor(pos);
        }

        [WebMethod]
        public Proveedor buscarProveedorService(String rol)
        {
            NegocioProveedor auxNegocioProveedor = new NegocioProveedor();
            return auxNegocioProveedor.buscarProveedor(rol);
        }

        [WebMethod]
        public void eliminarProveedorService(String rol)
        {
            NegocioProveedor auxNegocioProveedor = new NegocioProveedor();
            auxNegocioProveedor.eliminarProveedor(rol);
        }

        [WebMethod]
        public void actualizarProveedorService(Proveedor proveedor)
        {
            NegocioProveedor auxNegocioProveedor = new NegocioProveedor();
            auxNegocioProveedor.actualizarProveedor(proveedor);
        }

        [WebMethod]
        public DataSet buscarRolProveedorService(String rol)
        {
            NegocioProveedor auxNegocioProveedor = new NegocioProveedor();
            return auxNegocioProveedor.buscarRolProveedor(rol);
        }
    }
}
