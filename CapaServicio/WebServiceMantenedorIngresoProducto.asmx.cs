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
    /// Descripción breve de WebServiceMantenedorIngresoProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorIngresoProducto : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarIngresoProductoService(Ingreso_P ingreso_producto)
        {
            Negocio_Ingreso_P auxIngresoProducto = new Negocio_Ingreso_P();
            auxIngresoProducto.insertarIngresoProducto(ingreso_producto);
        }

        [WebMethod]
        public DataSet listarIngresoProductoService()
        {
            Negocio_Ingreso_P auxIngresoProducto = new Negocio_Ingreso_P();
            return auxIngresoProducto.listarIngresoProducto();
        }

        [WebMethod]
        public DataSet retornarIngresoProductoService()
        {
            Negocio_Ingreso_P auxIngresoProducto = new Negocio_Ingreso_P();
            return auxIngresoProducto.retornarIngresoProducto();
        }

        [WebMethod]
        public DataSet buscarPorIdIngresoService(string id_ingreso)
        {
            Negocio_Ingreso_P auxIngresoProducto = new Negocio_Ingreso_P();
            return auxIngresoProducto.buscarPorIdIngreso(id_ingreso);
        }

        [WebMethod]
        public Ingreso_P retornaPosicionIngresoProductoService(int pos)
        {
            Negocio_Ingreso_P auxIngresoProducto = new Negocio_Ingreso_P();
            return auxIngresoProducto.retornaPosicionIngresoProducto(pos);
        }

        [WebMethod]
        public Ingreso_P buscarIngresoProductoService(String id_ingreso)
        {
            Negocio_Ingreso_P auxIngresoProducto = new Negocio_Ingreso_P();
            return auxIngresoProducto.buscarIngresoProducto(id_ingreso);
        }

        [WebMethod]
        public void eliminarIngresoProductoService(String id_ingreso)
        {
            Negocio_Ingreso_P auxIngresoProducto = new Negocio_Ingreso_P();
            auxIngresoProducto.eliminarIngresoProducto(id_ingreso);
        }

        [WebMethod]
        public void actualizarIngresoProductoService(Ingreso_P ingreso_producto)
        {
            Negocio_Ingreso_P auxIngresoProducto = new Negocio_Ingreso_P();
            auxIngresoProducto.actualizarIngresoProducto(ingreso_producto);
        }

    }
}
