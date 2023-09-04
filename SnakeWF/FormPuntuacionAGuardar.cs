using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeWF
{
    public partial class FormPuntuacionAGuardar : Form
    {
        public FormPuntuacionAGuardar(int Puntuacion)
        {
            InitializeComponent();
            labelPuntuacionPartida.Text = Puntuacion.ToString();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
            Puntuacion puntuacion = new Puntuacion();
            puntuacion.Nombre = textBoxNombre.Text;
            puntuacion.Puntos = Convert.ToInt32(labelPuntuacionPartida.Text);
            Form1.records.Add(puntuacion);

            using (var WF_SnakeEntities = new WF_SnakeEntities())
            {
                foreach (var record in Form1.records)
                {
                    var nuevoRecord = new Records
                    {
                        Nombre = puntuacion.Nombre,
                        Puntuacion = puntuacion.Puntos
                    };
                    WF_SnakeEntities.Records.Add(nuevoRecord);
                }
                WF_SnakeEntities.SaveChanges();
            }
        }
    }
}
