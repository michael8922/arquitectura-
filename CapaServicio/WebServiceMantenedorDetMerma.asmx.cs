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
    /// Descripción breve de WebServiceMantenedorDetMerma
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorDetMerma : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarDetalleMermaService(Det_Merma detalle_merma)
        {
            Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
            auxNegocioDetalle.insertarDetalleMerma(detalle_merma);
        }

        [WebMethod]
        public DataSet retornarDetalleMermaService(string id_merma)
        {
            Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
            return auxNegocioDetalle.retornarDetalleMerma(id_merma);
        }

        [WebMethod]
        public Det_Merma retornaPosicionDetalleMermaService(int pos, string id_merma)
        {
            Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
            return auxNegocioDetalle.retornaPosicionDetalleMerma(pos,id_merma);
        }

        [WebMethod]
        public Det_Merma buscarDetalleMermaService(String id_det_merma)
        {
            Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
            return auxNegocioDetalle.buscarDetalleMerma(id_det_merma);
        }

        [WebMethod]
        public void eliminarDetalleMermaService(String id_det_merma)
        {
            Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
            auxNegocioDetalle.eliminarDetalleMerma(id_det_merma);
        }

        [WebMethod]
        public void actualizarDetalleMermaService(Det_Merma detalle_merma)
        {
            Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
            auxNegocioDetalle.actualizarDetalleMerma(detalle_merma);
        }

        [WebMethod]
        public Det_Merma buscarDetallePorIdMermaService(String id_merma)
        {
            Negocio_Det_Merma auxNegocioDetalle = new Negocio_Det_Merma();
            return auxNegocioDetalle.buscarDetallePorIdMerma(id_merma);
        }
    }
}
