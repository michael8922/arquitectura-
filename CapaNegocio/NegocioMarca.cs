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
    public class NegocioMarca
    {

        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "marca";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }



        public void insertarMarca(Marca marca)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_marca,nombre) VALUES ('"
                + marca.Id_marca + "','" + marca.Nombre + "' );";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarMarca()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Marca retornaPosicionMarca(int pos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla;

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Marca auxMarca = new Marca();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMarca.Id_marca = (String)dt.Rows[pos]["id_marca"];
                auxMarca.Nombre = (String)dt.Rows[pos]["nombre"];
                

            }
            catch (Exception ex)
            {
                auxMarca.Id_marca = "";
                auxMarca.Nombre = "";
                

            }

            return auxMarca;
        }



        public Marca buscarMarca(String id_marca)
        {

            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_marca = '" + id_marca + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Marca auxMarca = new Marca();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxMarca.Id_marca = (String)dt.Rows[0]["id_marca"];
                auxMarca.Nombre = (String)dt.Rows[0]["nombre"];
                

            }
            catch (Exception ex)
            {
                auxMarca.Id_marca = "";
                auxMarca.Nombre = "";
                



            }
            return auxMarca;
        }

        public void eliminarMarca(String id_marca)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_marca = '" + id_marca + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarMarca(Marca marca)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "nombre = '" + marca.Nombre 
                + "' WHERE id_marca = '" + marca.Id_marca + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }
    }
}
