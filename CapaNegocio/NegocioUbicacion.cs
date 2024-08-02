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
    public class NegocioUbicacion
    {

        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "ubicacion";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarUbicacion(Ubicacion ubicacion)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_ubicacion,nombre_ubicacion,fecha_ingreso_ubicacion,producto_codigo,cantidad) VALUES ('"
                + ubicacion.Id_ubicacion + "','" + ubicacion.Nombre_ubicacion + "','" + ubicacion.Fecha_ingreso_ubicacion + "','" + ubicacion.Producto_codigo + "',"+ ubicacion.Cantidad +");";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarUbicacion()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Ubicacion retornaPosicionUbicacion(int pos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla;

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Ubicacion auxUbicacion = new Ubicacion();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxUbicacion.Id_ubicacion = (String)dt.Rows[pos]["id_ubicacion"];
                auxUbicacion.Nombre_ubicacion = (String)dt.Rows[pos]["nombre_ubicacion"];
                auxUbicacion.Fecha_ingreso_ubicacion = (DateTime)dt.Rows[pos]["fecha_ingreso_ubicacion"];
                auxUbicacion.Producto_codigo = (String)dt.Rows[pos]["producto_codigo"];
                auxUbicacion.Cantidad = (int)dt.Rows[pos]["cantidad"];

            }
            catch (Exception ex)
            {
                auxUbicacion.Id_ubicacion = "";
                auxUbicacion.Nombre_ubicacion = "";
                auxUbicacion.Fecha_ingreso_ubicacion = DateTime.Today;
                auxUbicacion.Producto_codigo = "";
                auxUbicacion.Cantidad = 0;
            }

            return auxUbicacion;
        }



        public Ubicacion buscarUbicacion(String id_ubicacion)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_ubicacion = '" + id_ubicacion + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Ubicacion auxUbicacion = new Ubicacion();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxUbicacion.Id_ubicacion = (String)dt.Rows[0]["id_ubicacion"];
                auxUbicacion.Nombre_ubicacion = (String)dt.Rows[0]["nombre_ubicacion"];
                auxUbicacion.Fecha_ingreso_ubicacion= (DateTime)dt.Rows[0]["fecha_ingreso_ubicacion"];
                auxUbicacion.Producto_codigo = (String)dt.Rows[0]["producto_codigo"];
                auxUbicacion.Cantidad = (int)dt.Rows[0]["cantidad"];

            }
            catch (Exception ex)
            {
                auxUbicacion.Id_ubicacion = "";
                auxUbicacion.Nombre_ubicacion = "";
                auxUbicacion.Fecha_ingreso_ubicacion = DateTime.Today;
                auxUbicacion.Producto_codigo = "";
                auxUbicacion.Cantidad = 0;
                


            }
            return auxUbicacion;
        }

        public void eliminarUbicacion(String id_ubicacion)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_ubicacion = '" + id_ubicacion + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarUbicacion(Ubicacion ubicacion)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "nombre_ubicacion = '" + ubicacion.Nombre_ubicacion + "',fecha_ingreso_ubicacion = '" + ubicacion.Fecha_ingreso_ubicacion + "',producto_codigo = '" + ubicacion.Producto_codigo
                + "' WHERE id_ubicacion = '" + ubicacion.Id_ubicacion + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public DataSet buscarUbicacionCodigoProducto(string codigo_producto)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE producto_codigo = '" + codigo_producto + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }
    }



}
