using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaProg4.CNegocio;


namespace SistemaProg4.Formularios
{
    public partial class frm_ITBIS : Form
    {
        private CN_ITBIS objCN = new CN_ITBIS();

        public frm_ITBIS()
        {
            InitializeComponent();
        }

        private void ITBIS_Load(object sender, EventArgs e)
        {
            MostrarITBIS();
        }

        private void MostrarITBIS()
        {
            dataGridView1.DataSource = objCN.MostrarITBIS();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            if (id > 0)
            {
                try
                {
                    objCN.pId = int.Parse(txt_ID.Text);
                    objCN.pDescripcion = txt_Drescripcion.Text.Trim();
                    objCN.pTarifa = float.Parse(txt_Tarifa.Text.Trim());
                    objCN.EditarITBIS();
                    MessageBox.Show("Datos registrado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    objCN.pDescripcion = txt_Drescripcion.Text.Trim();
                    objCN.pTarifa = float.Parse(txt_Tarifa.Text.Trim());
                    objCN.InsertarITBIS();
                    MessageBox.Show("Datos registrado");
                    MostrarITBIS();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            MostrarITBIS();
        }

        private void txt_Drescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView1.SelectedCells.Count > 0)
            {
                txt_ID.Text = dataGridView1.CurrentRow.Cells["Id_ITBIS"].Value.ToString();
                txt_Drescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txt_Tarifa.Text = dataGridView1.CurrentRow.Cells["Tarifa"].Value.ToString();
            }
        }
    }
}

