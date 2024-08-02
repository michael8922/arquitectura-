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
    /// Descripción breve de WebServiceMantenedorDetSalida
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorDetSalida : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarDetalleSalidaProductoService(Det_Salida detalle_salida)
        {
            Negocio_Det_Salida auxNegocioDetalle = new Negocio_Det_Salida();
            auxNegocioDetalle.insertarDetalleSalidaProducto(detalle_salida);
        }

        [WebMethod]
        public DataSet retornarDetalleSalidaProductoService(string id_salida)
        {
            Negocio_Det_Salida auxNegocioDetalle = new Negocio_Det_Salida();
            return auxNegocioDetalle.retornarDetalleSalidaProducto(id_salida);
        }

        [WebMethod]
        public Det_Salida buscarDetalleSalidaProductoService(String id_detalle_salida)
        {

            Negocio_Det_Salida auxNegocioDetalle = new Negocio_Det_Salida();
            return auxNegocioDetalle.buscarDetalleSalidaProducto(id_detalle_salida);
        }

        [WebMethod]

        public Det_Salida buscarDetallePorIdSalidaService(String id_salida)
        {

            Negocio_Det_Salida auxNegocioDetalle = new Negocio_Det_Salida();
            return auxNegocioDetalle.buscarDetallePorIdSalida(id_salida);
        }

        [WebMethod]

        public void eliminarDetalleSalidaProductoService(String id_detalle_salida)
        {
            Negocio_Det_Salida auxNegocioDetalle = new Negocio_Det_Salida();
            auxNegocioDetalle.eliminarDetalleSalidaProducto(id_detalle_salida);
        }

        [WebMethod]

        public void actualizarDetalleSalidaProductoService(Det_Salida detalle_salida)
        {
            Negocio_Det_Salida auxNegocioDetalle = new Negocio_Det_Salida();
            auxNegocioDetalle.actualizarDetalleSalidaProducto(detalle_salida);
        }

        [WebMethod]
        public Det_Salida retornaPosicionDetalleSalidaProductoService(int pos, string id_salida)
        {
            Negocio_Det_Salida auxNegocioDetalle = new Negocio_Det_Salida();
            return auxNegocioDetalle.retornaPosicionDetalleSalidaProducto(pos,id_salida);
        }
    }
}
