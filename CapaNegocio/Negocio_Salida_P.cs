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
    public class Negocio_Salida_P
    {
        private Conexion conec1;

        public Conexion Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.conec1 = new Conexion();
            this.conec1.NombreBaseDeDatos = "ControlExistencias";
            this.conec1.NombreTabla = "salida_p";
            this.conec1.CadenaConexion = "Data Source=DESKTOP-PEB2PMR;Initial Catalog=ControlExistencias;Integrated Security=True";
        }

        public void insertarSalidaProducto(Salida_P salida_producto)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "INSERT INTO " + this.conec1.NombreTabla + " (id_salida,fecha,cliente_rut,usuario_rut) VALUES ('"
                + salida_producto.Id_salida + "','" + salida_producto.Fecha + "','" + salida_producto.Cliente_rut + "','" + salida_producto.Usuario_rut +  "');";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        public DataSet retornarSalidaProducto()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " SELECT * FROM " + this.conec1.NombreTabla;
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public Salida_P retornaPosicionSalidaProducto(int pos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.conec1.NombreTabla;

            this.conec1.EsSelect = true;
            this.Conec1.conectar();
            Salida_P auxSalida = new Salida_P();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxSalida.Id_salida = (String)dt.Rows[pos]["id_salida"];
                auxSalida.Fecha = (DateTime)dt.Rows[pos]["fecha"];
                auxSalida.Cliente_rut = (String)dt.Rows[pos]["cliente_rut"];
                auxSalida.Usuario_rut = (String)dt.Rows[pos]["usuario_rut"];
                



            }
            catch (Exception ex)
            {
                auxSalida.Id_salida = "";
                auxSalida.Fecha = DateTime.Today;
                auxSalida.Cliente_rut = "";
                auxSalida.Usuario_rut = "";
                
                


            }

            return auxSalida;
        }



        public Salida_P buscarSalidaProducto(String id_salida)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE id_salida = '" + id_salida + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Salida_P auxSalida = new Salida_P();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxSalida.Id_salida = (String)dt.Rows[0]["id_salida"];
                auxSalida.Fecha = (DateTime)dt.Rows[0]["fecha"];
                auxSalida.Cliente_rut = (String)dt.Rows[0]["cliente_rut"];
                auxSalida.Usuario_rut = (String)dt.Rows[0]["usuario_rut"];
                



            }
            catch (Exception ex)
            {
                auxSalida.Id_salida = "";
                auxSalida.Fecha = DateTime.Today;
                auxSalida.Cliente_rut = "";
                auxSalida.Usuario_rut = "";
                

            }
            return auxSalida;
        }

        public Salida_P buscarSalidaPorRutCliente(String rut_cliente)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT * FROM " + this.Conec1.NombreTabla +
                " WHERE cliente_rut = '" + rut_cliente + "';";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            Salida_P auxSalida = new Salida_P();
            DataTable dt = new DataTable();
            dt = this.conec1.DbDataSet.Tables[this.conec1.NombreTabla];
            try
            {
                auxSalida.Id_salida = (String)dt.Rows[0]["id_salida"];
                auxSalida.Fecha = (DateTime)dt.Rows[0]["fecha"];
                auxSalida.Cliente_rut = (String)dt.Rows[0]["cliente_rut"];
                auxSalida.Usuario_rut = (String)dt.Rows[0]["usuario_rut"];
                



            }
            catch (Exception ex)
            {
                auxSalida.Id_salida = "";
                auxSalida.Fecha = DateTime.Today;
                auxSalida.Cliente_rut = "";
                auxSalida.Usuario_rut = "";
                

            }
            return auxSalida;
        }

        public void eliminarSalidaProducto(String id_salida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " DELETE FROM " + this.conec1.NombreTabla +
                " WHERE id_salida = '" + id_salida + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }

        public void actualizarSalidaProducto(Salida_P salida_producto)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = "UPDATE " + this.conec1.NombreTabla + " SET "
                + "fecha = '" + salida_producto.Fecha + "',cliente_rut = '" + salida_producto.Cliente_rut + "',usuario_rut = '" + salida_producto.Usuario_rut 
                +  "' WHERE id_salida = '" + salida_producto.Id_salida + "';";
            this.conec1.EsSelect = false;
            this.conec1.conectar();
        }


        
        public DataSet retornarSalidaYDetalle()
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " select  sa.id_salida 'id salida',sa.fecha 'Fecha', sa.cliente_rut 'Rut Cliente' , sa.usuario_rut 'Rut Trabajador' , det.producto_codigo 'Codigo', det.cantidad 'Cantidad' , det.valor_total 'Valor' from det_salida det  join salida_p sa on(sa.id_salida=det.salida_p_id_salida) ;  ";
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }

        public DataSet buscarIdSalida(String id_salida)
        {
            this.configurarConexion();
            this.conec1.CadenaSQL = " select  sa.id_salida 'id salida',sa.fecha 'Fecha', sa.cliente_rut 'Rut Cliente' , sa.usuario_rut 'Rut Trabajador' , det.producto_codigo 'Codigo', det.cantidad 'Cantidad' , det.valor_total 'Valor' from det_salida det  join salida_p sa on(sa.id_salida=det.salida_p_id_salida)  where sa.id_salida = '" + id_salida + "';"; 
            this.conec1.EsSelect = true;
            this.conec1.conectar();
            return this.conec1.DbDataSet;
        }
    }
}
