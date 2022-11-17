using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        private void logo_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                Inicio x = new Inicio();
                x.labelName.Text = txtName.Text;

                x.Show();

                
            }
            else
            {
                MessageBox.Show("Ingresa tu nombre para poder ingresar","Error");
            }

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.Text != "")
                {
                    Inicio x = new Inicio();
                    x.labelName.Text = txtName.Text;
                    x.Show();
                }
                else
                {
                    MessageBox.Show("Ingresa tu nombre para poder ingresar", "Error");
                }

            }
        }
    }
}
