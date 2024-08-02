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
    public class Negocio_Det_Ingreso
    {

        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "det_ingreso";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarDetalleIngresoProducto(Det_Ingreso detalle_ingreso)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_detalle_ingreso,cantidad,valor_total,ingreso_p_id_ingreso,producto_codigo) VALUES ('"
                + detalle_ingreso.Id_detalle_ingreso + "','" + detalle_ingreso.Cantidad + "','" + detalle_ingreso.Valor_total + "','" + detalle_ingreso.Ingreso_p_id_ingreso + "','" + detalle_ingreso.Producto_codigo + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarDetalleIngresoProducto(string id_ingreso)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE ingreso_p_id_ingreso = '" + id_ingreso + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Det_Ingreso retornaPosicionDetalleIngresoProducto(int pos,string id_ingreso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE ingreso_p_id_ingreso = '" + id_ingreso + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Det_Ingreso auxDetalle = new Det_Ingreso();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalle.Id_detalle_ingreso = (String)dt.Rows[pos]["id_detalle_ingreso"];
                auxDetalle.Cantidad = (int)dt.Rows[pos]["cantidad"];
                auxDetalle.Valor_total = (int)dt.Rows[pos]["valor_total"];
                auxDetalle.Ingreso_p_id_ingreso = (String)dt.Rows[pos]["ingreso_p_id_ingreso"];
                auxDetalle.Producto_codigo = (String)dt.Rows[pos]["producto_codigo"];


            }
            catch (Exception ex)
            {
                auxDetalle.Id_detalle_ingreso = "";
                auxDetalle.Cantidad = 0;
                auxDetalle.Valor_total = 0;
                auxDetalle.Ingreso_p_id_ingreso = "";
                auxDetalle.Producto_codigo = "";


            }

            return auxDetalle;
        }



        public Det_Ingreso buscarDetalleIngresoProducto(String id_detalle_ingreso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalle_ingreso = '" + id_detalle_ingreso + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Det_Ingreso auxDetalle = new Det_Ingreso();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalle.Id_detalle_ingreso = (String)dt.Rows[0]["id_detalle_ingreso"];
                auxDetalle.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalle.Valor_total = (int)dt.Rows[0]["valor_total"];
                auxDetalle.Ingreso_p_id_ingreso = (String)dt.Rows[0]["ingreso_p_id_ingreso"];
                auxDetalle.Producto_codigo = (String)dt.Rows[0]["producto_codigo"];


            }
            catch (Exception ex)
            {
                auxDetalle.Id_detalle_ingreso = "";
                auxDetalle.Cantidad = 0 ;
                auxDetalle.Valor_total = 0;
                auxDetalle.Ingreso_p_id_ingreso = "";
                auxDetalle.Producto_codigo = "";




            }
            return auxDetalle;
        }

        public Det_Ingreso buscarDetallePorIdIngreso(String id_ingreso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE ingreso_p_id_ingreso = '" + id_ingreso + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Det_Ingreso auxDetalle = new Det_Ingreso();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalle.Id_detalle_ingreso = (String)dt.Rows[0]["id_detalle_ingreso"];
                auxDetalle.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalle.Valor_total = (int)dt.Rows[0]["valor_total"];
                auxDetalle.Ingreso_p_id_ingreso = (String)dt.Rows[0]["ingreso_p_id_ingreso"];
                auxDetalle.Producto_codigo = (String)dt.Rows[0]["producto_codigo"];


            }
            catch (Exception ex)
            {
                auxDetalle.Id_detalle_ingreso = "";
                auxDetalle.Cantidad = 0;
                auxDetalle.Valor_total = 0;
                auxDetalle.Ingreso_p_id_ingreso = "";
                auxDetalle.Producto_codigo = "";




            }
            return auxDetalle;
        }

        public void eliminarDetalleIngresoProducto(String id_detalle_ingreso)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_detalle_ingreso = '" + id_detalle_ingreso + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarDetalleIngresoProducto(Det_Ingreso detalle_ingreso)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "cantidad = " + detalle_ingreso.Cantidad + ",valor_total = " + detalle_ingreso.Valor_total + ",ingreso_p_id_ingreso = '" + detalle_ingreso.Ingreso_p_id_ingreso + "',producto_codigo = '" + detalle_ingreso.Producto_codigo
                + "' WHERE id_detalle_ingreso = '" + detalle_ingreso.Id_detalle_ingreso + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }
    }
}
