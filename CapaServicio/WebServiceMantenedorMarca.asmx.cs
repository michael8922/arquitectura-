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
    /// Descripción breve de WebServiceMantenedorMarca
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorMarca : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarMarcaService(Marca marca)
        {
            NegocioMarca auxNegocioMarca = new NegocioMarca();
            auxNegocioMarca.insertarMarca(marca);
        }

        [WebMethod]
        public DataSet retornarMarcaService()
        {
            NegocioMarca auxNegocioMarca = new NegocioMarca();
            return auxNegocioMarca.retornarMarca();
        }

        [WebMethod]
        public Marca retornaPosicionMarcaService(int pos)
        {
            NegocioMarca auxNegocioMarca = new NegocioMarca();
            return auxNegocioMarca.retornaPosicionMarca(pos);
        }

        [WebMethod]
        public Marca buscarMarcaService(String id_marca)
        {
            NegocioMarca auxNegocioMarca = new NegocioMarca();
            return auxNegocioMarca.buscarMarca(id_marca);
        }

        [WebMethod]
        public void eliminarMarcaService(String id_marca)
        {
            NegocioMarca auxNegocioMarca = new NegocioMarca();
            auxNegocioMarca.eliminarMarca(id_marca);
        }

        [WebMethod]
        public void actualizarMarcaService(Marca marca)
        {
            NegocioMarca auxNegocioMarca = new NegocioMarca();
            auxNegocioMarca.actualizarMarca(marca);
        }
    }
}
