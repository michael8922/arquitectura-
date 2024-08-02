using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioUsuario
    {

        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "usuario";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }



        public void insertarUsuario(Usuario usuario)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (rut,nombre,clave,cargo) VALUES ('"
                + usuario.Rut + "','" + usuario.Nombre + "','"+ usuario.Clave + "','"+ usuario.Cargo + "' );";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarUsuario()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Usuario retornaPosicionUsuario(int pos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla;

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Usuario auxUsuario = new Usuario();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxUsuario.Rut = (String)dt.Rows[pos]["rut"];
                auxUsuario.Nombre = (String)dt.Rows[pos]["nombre"];
                auxUsuario.Clave = (String)dt.Rows[pos]["clave"];
                auxUsuario.Cargo = (String)dt.Rows[pos]["cargo"];

            }
            catch (Exception ex)
            {
                auxUsuario.Rut = "";
                auxUsuario.Nombre = "";
                auxUsuario.Clave = "";
                auxUsuario.Cargo = "";

            }

            return auxUsuario;
        }



        public Usuario buscarUsuario(String rut)
        {
            
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE rut = '"+ rut +"';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Usuario auxUsuario = new Usuario();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxUsuario.Rut = (String)dt.Rows[0]["rut"];
                auxUsuario.Nombre = (String)dt.Rows[0]["nombre"];
                auxUsuario.Clave = (String)dt.Rows[0]["clave"];
                auxUsuario.Cargo = (String)dt.Rows[0]["cargo"];

            }
            catch (Exception ex)
            {
                auxUsuario.Rut = "";
                auxUsuario.Nombre = "";
                auxUsuario.Clave = "";
                auxUsuario.Cargo = "";



            }
            return auxUsuario;
        }

        public void eliminarUsuario(String rut)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE rut = '" + rut + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarUsuario(Usuario usuario)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "nombre = '" + usuario.Nombre + "',clave = '" + usuario.Clave + "',cargo = '" + usuario.Cargo
                + "' WHERE rut = '" + usuario.Rut + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public DataSet buscarRutUsuario(String rut)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE rut = '" + rut + "';"; ;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }






    }



}
