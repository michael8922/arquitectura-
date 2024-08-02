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
    public class Negocio_Det_Salida
    {

        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "det_salida";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarDetalleSalidaProducto(Det_Salida detalle_salida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_detalle_salida,cantidad,valor_total,salida_p_id_salida,producto_codigo) VALUES ('"
                + detalle_salida.Id_detalle_salida + "','" + detalle_salida.Cantidad + "','" + detalle_salida.Valor_total + "','" + detalle_salida.Salida_p_id_salida + "','" + detalle_salida.Producto_codigo + "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarDetalleSalidaProducto(string id_salida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE salida_p_id_salida = '" + id_salida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Det_Salida retornaPosicionDetalleSalidaProducto(int pos,string id_salida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE salida_p_id_salida = '" + id_salida + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Det_Salida auxDetalle = new Det_Salida();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalle.Id_detalle_salida = (String)dt.Rows[pos]["id_detalle_salida"];
                auxDetalle.Cantidad = (int)dt.Rows[pos]["cantidad"];
                auxDetalle.Valor_total = (int)dt.Rows[pos]["valor_total"];
                auxDetalle.Salida_p_id_salida = (String)dt.Rows[pos]["salida_p_id_salida"];
                auxDetalle.Producto_codigo = (String)dt.Rows[pos]["producto_codigo"];


            }
            catch (Exception ex)
            {
                auxDetalle.Id_detalle_salida = "";
                auxDetalle.Cantidad = 0;
                auxDetalle.Valor_total = 0;
                auxDetalle.Salida_p_id_salida = "";
                auxDetalle.Producto_codigo = "";


            }

            return auxDetalle;
        }



        public Det_Salida buscarDetalleSalidaProducto(String id_detalle_salida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_detalle_salida = '" + id_detalle_salida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Det_Salida auxDetalle = new Det_Salida();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalle.Id_detalle_salida = (String)dt.Rows[0]["id_detalle_salida"];
                auxDetalle.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalle.Valor_total = (int)dt.Rows[0]["valor_total"];
                auxDetalle.Salida_p_id_salida = (String)dt.Rows[0]["salida_p_id_salida"];
                auxDetalle.Producto_codigo = (String)dt.Rows[0]["producto_codigo"];


            }
            catch (Exception ex)
            {
                auxDetalle.Id_detalle_salida = "";
                auxDetalle.Cantidad = 0;
                auxDetalle.Valor_total = 0;
                auxDetalle.Salida_p_id_salida = "";
                auxDetalle.Producto_codigo = "";
            }
            return auxDetalle;
        }

        public Det_Salida buscarDetallePorIdSalida(String id_salida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE salida_p_id_salida = '" + id_salida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Det_Salida auxDetalle = new Det_Salida();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxDetalle.Id_detalle_salida = (String)dt.Rows[0]["id_detalle_salida"];
                auxDetalle.Cantidad = (int)dt.Rows[0]["cantidad"];
                auxDetalle.Valor_total = (int)dt.Rows[0]["valor_total"];
                auxDetalle.Salida_p_id_salida = (String)dt.Rows[0]["salida_p_id_salida"];
                auxDetalle.Producto_codigo = (String)dt.Rows[0]["producto_codigo"];


            }
            catch (Exception ex)
            {
                auxDetalle.Id_detalle_salida = "";
                auxDetalle.Cantidad = 0;
                auxDetalle.Valor_total = 0;
                auxDetalle.Salida_p_id_salida = "";
                auxDetalle.Producto_codigo = "";
            }
            return auxDetalle;
        }

        public void eliminarDetalleSalidaProducto(String id_detalle_salida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_detalle_salida = '" + id_detalle_salida + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarDetalleSalidaProducto(Det_Salida detalle_salida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "cantidad = " + detalle_salida.Cantidad + ",valor_total = " + detalle_salida.Valor_total + ",salida_p_id_salida = '" + detalle_salida.Salida_p_id_salida + "',producto_codigo = '" + detalle_salida.Producto_codigo
                + "' WHERE id_detalle_salida = '" + detalle_salida.Id_detalle_salida + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

    }
}
