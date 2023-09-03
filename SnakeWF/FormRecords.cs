using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWF
{
    public partial class FormRecords : Form
    {
        public FormRecords()
        {
            InitializeComponent();
            CargarPuntuacionesMaximas();
            dataGridView1.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Puntuacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void CargarPuntuacionesMaximas()
        {
            try
            {
                using (WF_SnakeEntities contexto= new WF_SnakeEntities()) 
                {
                    var maxScores = contexto.Records
                        .GroupBy(record => record.Nombre)
                        .Select(group => group.OrderByDescending(record => record.Puntuacion).FirstOrDefault())
                        .OrderByDescending(record => record.Puntuacion)
                        .Take(10)
                        .ToList();

                    dataGridView1.DataSource = maxScores;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
            }
        }
    }
}
