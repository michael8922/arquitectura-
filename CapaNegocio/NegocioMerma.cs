using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioMerma
    {

        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "merma";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarMerma(Merma merma)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_merma,fecha,motivo,tipo_solicitud,usuario_rut) VALUES ('"
                + merma.Id_merma + "','" + merma.Fecha + "','" + merma.Motivo + "','" + merma.Tipo_solicitud + "','" + merma.Usuario_rut +  "'  );";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarMerma()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Merma retornaPosicionMerma(int pos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla;

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Merma auxMerma = new Merma();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMerma.Id_merma = (String)dt.Rows[pos]["id_merma"];
                auxMerma.Fecha = (DateTime)dt.Rows[pos]["fecha"];
                auxMerma.Motivo = (String)dt.Rows[pos]["motivo"];
                auxMerma.Tipo_solicitud = (String)dt.Rows[pos]["tipo_solicitud"];
                auxMerma.Usuario_rut = (String)dt.Rows[pos]["usuario_rut"];
                



            }
            catch (Exception ex)
            {
                auxMerma.Id_merma = "";
                auxMerma.Fecha = DateTime.Today;
                auxMerma.Motivo = "";
                auxMerma.Tipo_solicitud = "";
                auxMerma.Usuario_rut = "";
                




            }

            return auxMerma;
        }



        public Merma buscarMerma(String id_merma)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_merma = '" + id_merma + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Merma auxMerma = new Merma();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMerma.Id_merma = (String)dt.Rows[0]["id_merma"];
                auxMerma.Fecha = (DateTime)dt.Rows[0]["fecha"];
                auxMerma.Motivo = (String)dt.Rows[0]["motivo"];
                auxMerma.Tipo_solicitud = (String)dt.Rows[0]["tipo_solicitud"];
                auxMerma.Usuario_rut = (String)dt.Rows[0]["usuario_rut"];
                



            }
            catch (Exception ex)
            {
                auxMerma.Id_merma = "";
                auxMerma.Fecha = DateTime.Today;
                auxMerma.Motivo = "";
                auxMerma.Tipo_solicitud = "";
                auxMerma.Usuario_rut = "";
                




            }
            return auxMerma;
        }

        public void eliminarMerma(String id_merma)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_merma = '" + id_merma + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarMerma(Merma merma)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "fecha = '" + merma.Fecha + "',motivo = '" + merma.Motivo + "',tipo_solicitud = '" + merma.Tipo_solicitud + "',usuario_rut = '" + merma.Usuario_rut 
                + "' WHERE id_merma = '" + merma.Id_merma + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public DataSet retornarMermaDetalle()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " select mer.id_merma 'Id Merma', mer.fecha, mer.motivo , mer.tipo_solicitud 'Tipo Solicitud',mer.usuario_rut 'Rut Usuario' , det.producto_codigo 'Codigo Producto' , det.cantidad , det.valor_total 'Total'  from det_merma det join merma mer on(det.merma_id_merma=mer.id_merma) ;";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DataSet retornarMermaPorIdMerma(string id_merma)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " select mer.id_merma 'Id Merma', mer.fecha, mer.motivo , mer.tipo_solicitud 'Tipo Solicitud',mer.usuario_rut 'Rut Usuario' , det.producto_codigo 'Codigo Producto' , det.cantidad , det.valor_total 'Total'  from det_merma det join merma mer on(det.merma_id_merma=mer.id_merma)  WHERE mer.id_merma = '"+ id_merma + "' ;";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }
    }
}
