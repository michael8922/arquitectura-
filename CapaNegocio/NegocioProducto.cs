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
    public class NegocioProducto
    {

        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "producto";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarProducto(Producto producto)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (codigo,descripcion,precio_unitario,cantidad_total,marca_id_marca) VALUES ('"
                + producto.Codigo + "','" + producto.Descripcion + "'," + producto.Precio_unitario + "," + producto.Cantidad_total + ",'" + producto.Marca_id_marca +  "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarProducto(string id_marca)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE marca_id_marca = '" + id_marca + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Producto retornaPosicionProducto(int pos,string id_marca)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla + " WHERE marca_id_marca = '" + id_marca + "';";

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Producto auxProducto = new Producto();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxProducto.Codigo = (String)dt.Rows[pos]["codigo"];
                auxProducto.Descripcion = (String)dt.Rows[pos]["descripcion"];
                auxProducto.Precio_unitario = (int)dt.Rows[pos]["precio_unitario"];
                auxProducto.Cantidad_total = (int)dt.Rows[pos]["cantidad_total"];
                auxProducto.Marca_id_marca = (String)dt.Rows[pos]["marca_id_marca"];
                
                
            }
            catch (Exception ex)
            {
                auxProducto.Codigo = "";
                auxProducto.Descripcion = "";
                auxProducto.Precio_unitario = 0;
                auxProducto.Cantidad_total = 0;
                auxProducto.Marca_id_marca = "";
               
                
            }

            return auxProducto;
        }



        public Producto buscarProducto(String codigo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE codigo = '" + codigo + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Producto auxProducto = new Producto();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxProducto.Codigo = (String)dt.Rows[0]["codigo"];
                auxProducto.Descripcion = (String)dt.Rows[0]["descripcion"];
                auxProducto.Precio_unitario = (int)dt.Rows[0]["precio_unitario"];
                auxProducto.Cantidad_total = (int)dt.Rows[0]["cantidad_total"];
                auxProducto.Marca_id_marca = (String)dt.Rows[0]["marca_id_marca"];
                
                
            }
            catch (Exception ex)
            {
                auxProducto.Codigo = "";
                auxProducto.Descripcion = "";
                auxProducto.Precio_unitario = 0;
                auxProducto.Cantidad_total = 0;
                auxProducto.Marca_id_marca = "";
                
                


            }
            return auxProducto;
        }

        public void eliminarProducto(String codigo)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE codigo = '" + codigo + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarProducto(Producto producto)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "descripcion = '" + producto.Descripcion + "',precio_unitario = " + producto.Precio_unitario + ",cantidad_total = " + producto.Cantidad_total + ",marca_id_marca = '" + producto.Marca_id_marca 
                + "' WHERE codigo = '" + producto.Codigo + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet buscarCodigoProducto(String codigo)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla + " WHERE codigo = '" + codigo + "';"; ;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Producto buscarIdMarcaProducto(String id_marca)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE marca_id_marca = '" + id_marca + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Producto auxProducto = new Producto();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxProducto.Codigo = (String)dt.Rows[0]["codigo"];
                auxProducto.Descripcion = (String)dt.Rows[0]["descripcion"];
                auxProducto.Precio_unitario = (int)dt.Rows[0]["precio_unitario"];
                auxProducto.Cantidad_total = (int)dt.Rows[0]["cantidad_total"];
                auxProducto.Marca_id_marca = (String)dt.Rows[0]["marca_id_marca"];


            }
            catch (Exception ex)
            {
                auxProducto.Codigo = "";
                auxProducto.Descripcion = "";
                auxProducto.Precio_unitario = 0;
                auxProducto.Cantidad_total = 0;
                auxProducto.Marca_id_marca = "";




            }
            return auxProducto;


        }

        public DataSet retornarTotalProducto()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla ;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DataSet retornarStockProducto(string codigo)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " select ma.nombre,pro.codigo,pro.descripcion,pro.precio_unitario,pro.cantidad_total from marca ma join producto pro on(ma.id_marca=pro.marca_id_marca) where  pro.codigo = '"+ codigo + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        


    }




}
