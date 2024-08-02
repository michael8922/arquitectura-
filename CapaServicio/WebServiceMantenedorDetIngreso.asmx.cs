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
    /// Descripción breve de WebServiceMantenedorDetIngreso
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorDetIngreso : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarDetalleIngresoProductoService(Det_Ingreso detalle_ingreso)
        {
            Negocio_Det_Ingreso auxNegocioDetalle = new Negocio_Det_Ingreso();
            auxNegocioDetalle.insertarDetalleIngresoProducto(detalle_ingreso);
            
        }

        [WebMethod]
        public DataSet retornarDetalleIngresoProductoService(string id_ingreso)
        {
            Negocio_Det_Ingreso auxNegocioDetalle = new Negocio_Det_Ingreso();
            return auxNegocioDetalle.retornarDetalleIngresoProducto(id_ingreso);
        }

        [WebMethod]
        public Det_Ingreso retornaPosicionDetalleIngresoProductoService(int pos, string id_ingreso)
        {
            Negocio_Det_Ingreso auxNegocioDetalle = new Negocio_Det_Ingreso();
            return auxNegocioDetalle.retornaPosicionDetalleIngresoProducto(pos,id_ingreso);
        }

        [WebMethod]

        public Det_Ingreso buscarDetalleIngresoProductoService(String id_detalle_ingreso)
        {
            Negocio_Det_Ingreso auxNegocioDetalle = new Negocio_Det_Ingreso();
            return auxNegocioDetalle.buscarDetalleIngresoProducto(id_detalle_ingreso);
        }

        [WebMethod]
        public Det_Ingreso buscarDetallePorIdIngresoService(String id_ingreso)
        {
            Negocio_Det_Ingreso auxNegocioDetalle = new Negocio_Det_Ingreso();
            return auxNegocioDetalle.buscarDetallePorIdIngreso(id_ingreso);
        }

        [WebMethod]

        public void eliminarDetalleIngresoProductoService(String id_detalle_ingreso)
        {
            Negocio_Det_Ingreso auxNegocioDetalle = new Negocio_Det_Ingreso();
            auxNegocioDetalle.eliminarDetalleIngresoProducto(id_detalle_ingreso);
        }

        [WebMethod]

        public void actualizarDetalleIngresoProductoService(Det_Ingreso detalle_ingreso)
        {
            Negocio_Det_Ingreso auxNegocioDetalle = new Negocio_Det_Ingreso();
            auxNegocioDetalle.actualizarDetalleIngresoProducto(detalle_ingreso);
        }

    }
}
