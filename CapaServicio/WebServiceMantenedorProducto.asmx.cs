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
    /// Descripción breve de WebServiceMantenedorProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorProducto : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarProductoService(Producto producto)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            auxNegocioProducto.insertarProducto(producto);
        }
        [WebMethod]
        public DataSet retornarProductoService(string id_marca)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            return auxNegocioProducto.retornarProducto(id_marca);
        }

        [WebMethod]
        public Producto retornaPosicionProductoService(int pos, string id_marca)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            return auxNegocioProducto.retornaPosicionProducto(pos,id_marca);
        }

        [WebMethod]
        public Producto buscarProductoService(String codigo)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            return auxNegocioProducto.buscarProducto(codigo);
        }

        [WebMethod]
        public void eliminarProductoService(String codigo)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            auxNegocioProducto.eliminarProducto(codigo);
        }

        [WebMethod]
        public void actualizarProductoService(Producto producto)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            auxNegocioProducto.actualizarProducto(producto);
        }

        [WebMethod]
        public DataSet buscarCodigoProductoService(String codigo)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            return auxNegocioProducto.buscarCodigoProducto(codigo);
        }

        [WebMethod]
        public Producto buscarIdMarcaProductoService(String id_marca)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            return auxNegocioProducto.buscarIdMarcaProducto(id_marca);
        }
        [WebMethod]
        public DataSet retornarTotalProductoService()
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            return auxNegocioProducto.retornarTotalProducto();
        }
        [WebMethod]
        public DataSet retornarStockProductoService(string codigo)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            return auxNegocioProducto.retornarStockProducto(codigo);
        }
    }
}
