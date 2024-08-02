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
    public class NegocioCliente
    {
        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "cliente";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarCliente(Cliente cliente)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (rut,nombre,apellido,telefono) VALUES ('"
                + cliente.Rut + "','" + cliente.Nombre + "','" + cliente.Apellido + "'," + cliente.Telefono + ");";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarCliente()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Cliente retornaPosicionCliente(int pos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla;

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Cliente auxCliente = new Cliente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxCliente.Rut = (String)dt.Rows[pos]["rut"];
                auxCliente.Nombre = (String)dt.Rows[pos]["nombre"];
                auxCliente.Apellido = (String)dt.Rows[pos]["apellido"];
                auxCliente.Telefono = (int)dt.Rows[pos]["telefono"];

            }
            catch (Exception ex)
            {
                auxCliente.Rut = "";
                auxCliente.Nombre = "";
                auxCliente.Apellido = "";
                auxCliente.Telefono = 0;

            }

            return auxCliente;
        }



        public Cliente buscarCliente(String rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE rut = '" + rut + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Cliente auxCliente = new Cliente();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxCliente.Rut = (String)dt.Rows[0]["rut"];
                auxCliente.Nombre = (String)dt.Rows[0]["nombre"];
                auxCliente.Apellido = (String)dt.Rows[0]["apellido"];
                auxCliente.Telefono = (int)dt.Rows[0]["telefono"];

            }
            catch (Exception ex)
            {
                auxCliente.Rut = "";
                auxCliente.Nombre = "";
                auxCliente.Apellido = "";
                auxCliente.Telefono = 0;



            }
            return auxCliente;
        }

        public void eliminarCliente(String rut)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE rut = '" + rut + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarCliente(Cliente cliente)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "nombre = '" + cliente.Nombre + "',apellido = '" + cliente.Apellido + "',telefono = " + cliente.Telefono
                + " WHERE rut = '" + cliente.Rut + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

    }
}
