using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SistemaProg4.CAD
{
    public class Conexion
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-GKJB6TV\\FRANPAULINO;Initial Catalog=SistemaProg4;Integrated Security=True");

        public SqlConnection OpenConectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CloseConectar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }


}
