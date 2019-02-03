using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace SistemaProg4.CAD
{
    public class CAD_ITBIS
    {
        protected Conexion conexion = new Conexion();

        SqlDataReader leerfilas;
        DataTable tabla;
        SqlCommand comando;

        public DataTable MostrarDatos()
        {
            comando = new SqlCommand();
            comando.Connection = conexion.OpenConectar();
            comando.CommandText = "SP_Buscar_Todos_Registro";
            leerfilas = comando.ExecuteReader();

            tabla = new DataTable();
            tabla.Load(leerfilas);
            conexion.CloseConectar();

            comando.Parameters.Clear();
            return tabla;
        }

        public void Insertar(string descripcion, float tarifa)
        {
            comando.Connection = conexion.OpenConectar();
            comando.CommandText = "SP_Insertar_Regristro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 400));
            comando.Parameters.Add(new SqlParameter("@Tarifa", SqlDbType.Float));
            comando.Parameters["@Descripcion"].Value = descripcion;
            comando.Parameters["@Tarifa"].Value = tarifa;

            comando.ExecuteNonQuery();
            conexion.CloseConectar();
            comando.Parameters.Clear();
        }
        public void Editar(int id, string descripcion, float tarifa)
        {
            comando.Connection = conexion.OpenConectar();
            comando.CommandText = "SP_ACtualizar_Registro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@Id_ITBIS", SqlDbType.Int));
            comando.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 400));
            comando.Parameters.Add(new SqlParameter("@Tarifa", SqlDbType.Float));

            comando.Parameters["@Id_ITBIS"].Value = id;
            comando.Parameters["@Descripcion"].Value = descripcion;
            comando.Parameters["@Tarifa"].Value = tarifa;
            
            comando.ExecuteNonQuery();
            conexion.CloseConectar();
            comando.Parameters.Clear();
        }
    }
}
