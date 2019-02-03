using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaProg4.CAD;


namespace SistemaProg4.CNegocio
{
    class CN_ITBIS
    {
        // Propiedades
        private int id;
        private string descripcion;
        private float tarifa;

        public int pId
        {
            get { return id; }
            set { id = value; }
        }

        public string pDescripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public float pTarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }

        private CAD_ITBIS objcad = new CAD_ITBIS();
        // Metodos CRUD
        /// <summary>
        /// Mostrar registro
        /// </summary>
        /// <returns>todos los registro</returns>
        public DataTable MostrarITBIS()
        {
            DataTable tabla = new DataTable();
            tabla = objcad.MostrarDatos();
            return tabla;
        }

        public void InsertarITBIS()
        {
            objcad.Insertar(pDescripcion, pTarifa);
        }
        public void EditarITBIS()
        {
            objcad.Editar(pId, pDescripcion, pTarifa);
        }
    }
}
