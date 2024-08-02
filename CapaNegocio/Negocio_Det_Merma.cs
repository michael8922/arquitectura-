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
    public class Negocio_Det_Merma
    {
        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "det_merma";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarDetalleMerma(Det_Merma detalle_merma)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_det_merma,cantidad,producto_codigo,valor_total,merma_id_merma) VALUES ('"
                + detalle_merma.Id_det_merma + "'," + detalle_merma.Cantidad + ",'" + detalle_merma.Producto_codigo + "'," + detalle_merma.Valor_total + ",'" + detalle_merma.Merma_id_merma + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarDetalleMerma(string id_merma)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE merma_id_merma = '" + id_merma + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Det_Merma retornaPosicionDetalleMerma(int pos,string id_merma)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla +  " WHERE merma_id_merma = '" + id_merma + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Det_Merma auxDetalle = new Det_Merma();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalle.Id_det_merma = (String)dt.Rows[pos]["id_det_merma"];
                auxDetalle.Cantidad = (int)dt.Rows[pos]["cantidad"];
                auxDetalle.Producto_codigo = (String)dt.Rows[pos]["producto_codigo"];
                auxDetalle.Valor_total = (int)dt.Rows[pos]["valor_total"];                
                auxDetalle.Merma_id_merma = (String)dt.Rows[pos]["merma_id_merma"];


            }
            catch (Exception ex)
            {
                auxDetalle.Id_det_merma = "";
                auxDetalle.Cantidad = 0;
                auxDetalle.Producto_codigo = "";
                auxDetalle.Valor_total = 0;
                auxDetalle.Merma_id_merma = "";


            }

            return auxDetalle;
        }



        public Det_Merma buscarDetalleMerma(String id_det_merma)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_det_merma = '" + id_det_merma + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Det_Merma auxDetalle = new Det_Merma();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalle.Id_det_merma = (String)dt.Rows[0]["id_det_merma"];
                auxDetalle.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalle.Producto_codigo = (String)dt.Rows[0]["producto_codigo"];
                auxDetalle.Valor_total = (int)dt.Rows[0]["valor_total"];
                auxDetalle.Merma_id_merma = (String)dt.Rows[0]["merma_id_merma"];


            }
            catch (Exception ex)
            {
                auxDetalle.Id_det_merma = "";
                auxDetalle.Cantidad = 0;
                auxDetalle.Producto_codigo = "";
                auxDetalle.Valor_total = 0;
                auxDetalle.Merma_id_merma = "";




            }
            return auxDetalle;
        }

        public void eliminarDetalleMerma(String id_det_merma)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_det_merma = '" + id_det_merma + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarDetalleMerma(Det_Merma detalle_merma)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "cantidad = " + detalle_merma.Cantidad + ",producto_codigo = '" + detalle_merma.Producto_codigo + "',valor_total = " + detalle_merma.Valor_total + ",merma_id_merma = '" + detalle_merma.Merma_id_merma
                + "' WHERE id_det_merma = '" + detalle_merma.Id_det_merma + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public Det_Merma buscarDetallePorIdMerma(String id_merma)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE merma_id_merma = '" + id_merma + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Det_Merma auxDetalle = new Det_Merma();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalle.Id_det_merma = (String)dt.Rows[0]["id_det_merma"];
                auxDetalle.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalle.Producto_codigo = (String)dt.Rows[0]["producto_codigo"];
                auxDetalle.Valor_total = (int)dt.Rows[0]["valor_total"];
                auxDetalle.Merma_id_merma = (String)dt.Rows[0]["merma_id_merma"];


            }
            catch (Exception ex)
            {
                auxDetalle.Id_det_merma = "";
                auxDetalle.Cantidad = 0;
                auxDetalle.Producto_codigo = "";
                auxDetalle.Valor_total = 0;
                auxDetalle.Merma_id_merma = "";




            }
            return auxDetalle;
        }
    }
}
