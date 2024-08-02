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
    /// Descripción breve de WebServiceMantenedorSalidaProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorSalidaProducto : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarSalidaProductoService(Salida_P salida_producto)
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            auxNegocioSalida.insertarSalidaProducto(salida_producto);
        }

        [WebMethod]
        public DataSet retornarSalidaProductoService()
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            return auxNegocioSalida.retornarSalidaProducto();
        }

        [WebMethod]
        public Salida_P retornaPosicionSalidaProductoService(int pos)
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            return auxNegocioSalida.retornaPosicionSalidaProducto(pos);
        }

        [WebMethod]
        public Salida_P buscarSalidaProductoService(String id_salida)
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            return auxNegocioSalida.buscarSalidaProducto(id_salida);
        }

        [WebMethod]
        public Salida_P buscarSalidaPorRutClienteService(String rut_cliente)
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            return auxNegocioSalida.buscarSalidaPorRutCliente(rut_cliente);
        }

        [WebMethod]
        public void eliminarSalidaProductoService(String id_salida)
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            auxNegocioSalida.eliminarSalidaProducto(id_salida);
        }

        [WebMethod]
        public void actualizarSalidaProductoService(Salida_P salida_producto)
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            auxNegocioSalida.actualizarSalidaProducto(salida_producto);
        }

        [WebMethod]
        public DataSet retornarSalidaYDetalleService()
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            return auxNegocioSalida.retornarSalidaYDetalle();
        }

        [WebMethod]
        public DataSet buscarIdSalidaService(String id_salida)
        {
            Negocio_Salida_P auxNegocioSalida = new Negocio_Salida_P();
            return auxNegocioSalida.buscarIdSalida(id_salida);
        }
    }
}
