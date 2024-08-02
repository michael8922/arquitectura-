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
    /// Descripción breve de WebServiceUbicacion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUbicacion : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarUbicacionService(Ubicacion ubicacion)
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            auxNegocioUbicacion.insertarUbicacion(ubicacion);
        }

        [WebMethod]
        public DataSet retornarUbicacionService()
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            return auxNegocioUbicacion.retornarUbicacion();
        }

        [WebMethod]
        public Ubicacion retornaPosicionUbicacionService(int pos)
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            return auxNegocioUbicacion.retornaPosicionUbicacion(pos);
        }

        [WebMethod]
        public Ubicacion buscarUbicacionService(String id_ubicacion)
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            return auxNegocioUbicacion.buscarUbicacion(id_ubicacion);
        }

        [WebMethod]
        public void eliminarUbicacionService(String id_ubicacion)
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            auxNegocioUbicacion.eliminarUbicacion(id_ubicacion);
        }

        [WebMethod]
        public void actualizarUbicacionService(Ubicacion ubicacion)
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            auxNegocioUbicacion.actualizarUbicacion(ubicacion);
        }

        [WebMethod]
        public DataSet buscarUbicacionCodigoProductoService(string codigo_producto)
        {
            NegocioUbicacion auxNegocioUbicacion = new NegocioUbicacion();
            return auxNegocioUbicacion.buscarUbicacionCodigoProducto(codigo_producto);
        }
    }
}
