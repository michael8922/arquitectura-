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
    /// Descripción breve de WebServiceMantenedorMerma
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorMerma : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarMermaService(Merma merma)
        {
            NegocioMerma auxNegocioMerma = new NegocioMerma();
            auxNegocioMerma.insertarMerma(merma);
        }
        [WebMethod]
        public DataSet retornarMermaService()
        {
            NegocioMerma auxNegocioMerma = new NegocioMerma();
            return auxNegocioMerma.retornarMerma();
        }
        [WebMethod]
        public Merma retornaPosicionMermaService(int pos)
        {
            NegocioMerma auxNegocioMerma = new NegocioMerma();
            return auxNegocioMerma.retornaPosicionMerma(pos);
        }
        [WebMethod]
        public Merma buscarMermaService(String id_merma)
        {
            NegocioMerma auxNegocioMerma = new NegocioMerma();
            return auxNegocioMerma.buscarMerma(id_merma);
        }
        [WebMethod]
        public void eliminarMermaService(String id_merma)
        {
            NegocioMerma auxNegocioMerma = new NegocioMerma();
            auxNegocioMerma.eliminarMerma(id_merma);
        }

        [WebMethod]
        public void actualizarMermaService(Merma merma)
        {
            NegocioMerma auxNegocioMerma = new NegocioMerma();
            auxNegocioMerma.actualizarMerma(merma);
        }

        [WebMethod]

        public DataSet retornarMermaDetalleService()
        {
            NegocioMerma auxNegocioMerma = new NegocioMerma();
            return auxNegocioMerma.retornarMermaDetalle();
        }

        [WebMethod]

        public DataSet retornarMermaPorIdMermaService(string id_merma)
        {
            NegocioMerma auxNegocioMerma = new NegocioMerma();
            return auxNegocioMerma.retornarMermaPorIdMerma(id_merma);
        }
    }
}
