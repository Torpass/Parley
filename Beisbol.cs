using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parley
{
    public partial class Beisbol : Form
    {
        Clubs clubs= new Clubs();


        public Beisbol()
        {
            InitializeComponent();
        }


        private void bRegistrar_Click(object sender, EventArgs e)
        {
            beisbol_team auxiliar = new beisbol_team();
            string name = txtName.Text;

            try
            {
                if (clubs.find(name) == false)
                {
                    auxiliar._nombre_club = txtName.Text.ToLower();
                    auxiliar._ciudad = txtCity.Text;
                    auxiliar._liga = liga.Text;
                    auxiliar._juegos_ganados = Convert.ToInt32(txtWon.Text);
                    auxiliar._juegos_perdidos = Convert.ToInt32(txtLost.Text);

                    if (auxiliar._juegos_ganados > 0 && auxiliar._juegos_perdidos > 0)
                    {
                        MessageBox.Show("Equipo registrado");
                        clubs.Create(auxiliar);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("ERROR: No pueden haber numeros negativos o iguales a 0", "Fatal error");
                        error1.SetError(txtLost, "No numeros negativos o iguales a 0");
                        error1.SetError(txtWon, "No numeros negativos o iguales a 0");
                        txtWon.Focus();
                        txtWon.Text = ""; txtLost.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El equipo ya se había registrado", "Registro");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("ERROR: No puedes ingresar letras en los campos de juegos ganados o perdidos", "Fatal error");
            }
            error1.SetError(txtLost, "");
            error2.SetError(txtLost, "");
        }


        private void bActualizar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            beisbol_team auxiliar = new beisbol_team();
            try
            {
                if (clubs.find(name) == true)
                {
                    auxiliar._nombre_club = txtName.Text;
                    auxiliar._ciudad = txtCity.Text;
                    auxiliar._liga = liga.Text;
                    auxiliar._juegos_ganados = Convert.ToInt32(txtWon.Text);
                    auxiliar._juegos_perdidos = Convert.ToInt32(txtLost.Text);

                    if (auxiliar._juegos_ganados >= 0 && auxiliar._juegos_perdidos >= 0)
                    {
                        clubs.update(auxiliar);
                        MessageBox.Show("Datos actualizados", "Registro");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("ERROR: No pueden haber numeros negativos", "Fatal error");
                        error1.SetError(txtLost, "No numeros negativos ");
                        error1.SetError(txtWon, "No numeros negativos ");
                        txtWon.Focus();
                        txtWon.Text = ""; txtLost.Text = "";
                    }
                }
                else { MessageBox.Show("ERROR: Nombre no registrado o invalido", "Registro"); }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("ERROR: No puedes ingresar letras en los campos de juegos ganados o perdidos", "Fatal error");
            }

        }


        private void bBuscar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToLower();
            if (clubs.find(name) == true)
            {
                beisbol_team auxiliar = clubs.show(name);
                txtName.Text = auxiliar._nombre_club;
                txtCity.Text = auxiliar._ciudad;
                liga.Text= auxiliar._liga;
                txtWon.Text = Convert.ToString(auxiliar._juegos_ganados);
                txtLost.Text = Convert.ToString(auxiliar._juegos_perdidos);
                bRegistrar.Enabled = false;
            }
            else
            {
                MessageBox.Show("ERROR: Equipo no encontrado", "Fatal error");
                Limpiar();
            }
        }


        private void bEliminar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.ToLower();
            if (clubs.find(name) == true)
            {
                DialogResult delete = MessageBox.Show("¿Seguro que desea eliminar los datos del equipo?",
                    "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    clubs.remove(name);
                    MessageBox.Show("Equipo eliminado");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("ERROR: Equipo no encontrado o nombre invalido");
                }

            }
        }



        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtName.Text = "";
            txtCity.Text = "";
            liga.Text = "";
            txtWon.Text = "0";
            txtLost.Text = "0";
            bRegistrar.Enabled = Enabled;

        }


    }
}
