using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parley
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void besibolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = false;
            foreach (Form formularios in Application.OpenForms)
            {
                if (formularios.GetType() == typeof(Beisbol))
                {
                    status = true;
                }
            }
            if (status == false)
            {
                Beisbol x = new Beisbol();
                x.MdiParent = this;
                x.Show();
            }
     
        }

        private void futbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = false;
            foreach (Form formularios in Application.OpenForms)
            {
                if (formularios.GetType() == typeof(Futbol))
                {
                    status = true;
                }
            }
            if (status == false)
            {
                Futbol x = new Futbol();
                x.MdiParent = this;
                x.Show();   
            }
          
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult salida = MessageBox.Show("¿Quiere usted salir del Parley?",
                "Pregunta de Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (salida == DialogResult.Yes) Close();
        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Epale {labelName.Text}, bienvendio, espero no pierdas mucha plata", "Saludo");
        }

    }
}
