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
    public class Negocio_Ingreso_P
    {

        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "ingreso_p";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarIngresoProducto(Ingreso_P ingreso_producto)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_ingreso,fecha,usuario_rut,proveedor_rol) VALUES ('"
                + ingreso_producto.Id_ingreso + "','" + ingreso_producto.Fecha + "','" + ingreso_producto.Usuario_rut + "','" + ingreso_producto.Proveedor_rol +  "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet listarIngresoProducto()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DataSet retornarIngresoProducto()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " select  ing.id_ingreso 'Id Ingreso', ing.fecha , ing.usuario_rut 'Rut Trabajador', ing.proveedor_rol 'Rut Proveedor', det.cantidad, det.valor_total , det.producto_codigo 'codigo producto' from ingreso_p ing join det_ingreso det on(ing.id_ingreso=det.ingreso_p_id_ingreso); ";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DataSet buscarPorIdIngreso(string id_ingreso)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " select  ing.id_ingreso 'Id Ingreso', ing.fecha , ing.usuario_rut 'Rut Trabajador', ing.proveedor_rol 'Rut Proveedor', det.cantidad, det.valor_total , det.producto_codigo 'codigo producto' from ingreso_p ing join det_ingreso det on(ing.id_ingreso=det.ingreso_p_id_ingreso) where ing.id_ingreso = '" + id_ingreso + "'; ";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Ingreso_P retornaPosicionIngresoProducto(int pos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla;

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Ingreso_P auxIngreso = new Ingreso_P();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxIngreso.Id_ingreso = (String)dt.Rows[pos]["id_ingreso"];
                auxIngreso.Fecha = (DateTime)dt.Rows[pos]["fecha"];
                auxIngreso.Usuario_rut = (String)dt.Rows[pos]["usuario_rut"];
                auxIngreso.Proveedor_rol = (String)dt.Rows[pos]["proveedor_rol"];
                


            }
            catch (Exception ex)
            {
                auxIngreso.Id_ingreso = "";
                auxIngreso.Fecha = DateTime.Today;
                auxIngreso.Usuario_rut = "";
                auxIngreso.Proveedor_rol = "";
                


            }

            return auxIngreso;
        }



        public Ingreso_P buscarIngresoProducto(String id_ingreso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_ingreso = '" + id_ingreso + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Ingreso_P auxIngreso = new Ingreso_P();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxIngreso.Id_ingreso = (String)dt.Rows[0]["id_ingreso"];
                auxIngreso.Fecha = (DateTime)dt.Rows[0]["fecha"];
                auxIngreso.Usuario_rut = (String)dt.Rows[0]["usuario_rut"];
                auxIngreso.Proveedor_rol = (String)dt.Rows[0]["proveedor_rol"];
                


            }
            catch (Exception ex)
            {
                auxIngreso.Id_ingreso = "";
                auxIngreso.Fecha = DateTime.Today;
                auxIngreso.Usuario_rut = "";
                auxIngreso.Proveedor_rol = "";
                




            }
            return auxIngreso;
        }

        public void eliminarIngresoProducto(String id_ingreso)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_ingreso = '" + id_ingreso + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarIngresoProducto(Ingreso_P ingreso_producto)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "fecha = '" + ingreso_producto.Fecha + "',usuario_rut = '" + ingreso_producto.Usuario_rut + "',proveedor_rol = '" + ingreso_producto.Proveedor_rol 
                + "' WHERE id_ingreso = '" + ingreso_producto.Id_ingreso + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


   
    }
}

