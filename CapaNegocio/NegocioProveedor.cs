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
    public class NegocioProveedor
    {

        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "proveedor";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarProveedor(Proveedor proveedor)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (rol,nombre_proveedor,direccion,telefono) VALUES ('"
                + proveedor.Rol + "','" + proveedor.Nombre_proveedor + "','" + proveedor.Direccion + "'," + proveedor.Telefono  + ");";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarProveedor()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Proveedor retornaPosicionProveedor(int pos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla;

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Proveedor auxProveedor = new Proveedor();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxProveedor.Rol = (String)dt.Rows[pos]["rol"];
                auxProveedor.Nombre_proveedor = (String)dt.Rows[pos]["nombre_proveedor"];
                auxProveedor.Direccion = (String)dt.Rows[pos]["direccion"];
                auxProveedor.Telefono = (int)dt.Rows[pos]["telefono"];
                
            }
            catch (Exception ex)
            {
                auxProveedor.Rol = "";
                auxProveedor.Nombre_proveedor = "";
                auxProveedor.Direccion = "";
                auxProveedor.Telefono = 0;
            
            }

            return auxProveedor;
        }



        public Proveedor buscarProveedor(String rol)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE rol = '" + rol + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Proveedor auxProveedor = new Proveedor();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxProveedor.Rol = (String)dt.Rows[0]["rol"];
                auxProveedor.Nombre_proveedor = (String)dt.Rows[0]["nombre_proveedor"];
                auxProveedor.Direccion = (String)dt.Rows[0]["direccion"];
                auxProveedor.Telefono = (int)dt.Rows[0]["telefono"];
                
            }
            catch (Exception ex)
            {
                auxProveedor.Rol = "";
                auxProveedor.Nombre_proveedor = "";
                auxProveedor.Direccion = "";
                auxProveedor.Telefono = 0;
             


            }
            return auxProveedor;
        }

        public void eliminarProveedor(String rol)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE rol = '" + rol + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarProveedor(Proveedor proveedor)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "nombre_proveedor = '" + proveedor.Nombre_proveedor + "',direccion = '" + proveedor.Direccion + "',telefono = " + proveedor.Telefono
                + " WHERE rol = '" + proveedor.Rol + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public DataSet buscarRolProveedor(String rol)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE rol = '" + rol + "';"; ;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }


    }



}
