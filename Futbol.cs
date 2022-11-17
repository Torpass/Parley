using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parley
{
    public partial class Futbol : Form
    {
        public Futbol()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtTeam.Text != "")
                {
                    if (Confederacion.Text != "")
                    {
                        int cantidad_mundiales = Convert.ToInt16(txtMundial.Text);
                        int cantidad_federados = Convert.ToInt16(txtFederados.Text);

                        if (cantidad_federados <= 14 || cantidad_mundiales < 0 || cantidad_federados > 26 || cantidad_mundiales > 230)
                        {
                            error1.SetError(txtMundial, "No se pueden ingresar datos negativos y el equipo que más ha ido al mundial es brasíl con 230 participaciones");
                            error1.SetError(txtFederados, "No se pueden ingresar datos negativos y solo se pueden llevar entre 14 a 26 federados al mundial");
                            MessageBox.Show("Algunos datos pueden estar erroneos", "ERROR");
                            txtMundial.Focus();
                        }
                        else
                        {

                            MessageBox.Show("Datos guardados correctamente,", "MENSAJE:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();

                        }
                    }
                    else
                    {
                        error1.SetError(Confederacion, "Ingrese la confederacion del equipo");
                    }
                   
                }
                else
                {
                    error1.SetError(txtTeam, "Ingrese nombre del equipo");
                }

            }
            catch(System.FormatException)
            {
                error1.SetError(txtMundial, "No puedes ingresar letras o tener campos vacios");
                error1.SetError(txtFederados, "No puedes ingresar letras o tener campos vacios");
                MessageBox.Show("No se pueden ingresar letras", "ERROR");
                txtMundial.Focus();   
            }
            
        }


        private void bDelete_Click(object sender, EventArgs e)
        {
            if (txtTeam.Text == "" || txtMundial.Text == "" || txtFederados.Text == "0" || Confederacion.Text == "")
            {
                error1.SetError(txtFederados, "Este campo no puede estar vacio");
                error1.SetError(txtMundial, "Este campo no puede estar vacio");
                error1.SetError(txtTeam, "Este campo no puede estar vacio");
                error1.SetError(Confederacion, "Este campo no puede estar vacio");
            }
            else
            {
                DialogResult delete = MessageBox.Show("¿Quiere usted eliminar estos datos?",
               "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (delete == DialogResult.Yes) Limpiar();
            }

        }


        public void Limpiar()
        {
            txtFederados.Text = "0";
            txtTeam.Text = "";
            txtMundial.Text = "0";
            Confederacion.Text = "";
            error1.SetError(txtFederados, "");
            error1.SetError(Confederacion, "");
            error1.SetError(txtMundial, "");
            error1.SetError(txtTeam, "");
        }


        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (txtTeam.Text == "" || txtMundial.Text == "" || txtFederados.Text == "0" || Confederacion.Text == "")
            {

                error1.SetError(txtFederados, "Este campo no puede estar vacio");
                error1.SetError(txtMundial, "Este campo no puede estar vacio");
                error1.SetError(txtTeam, "Este campo no puede estar vacio");
                error1.SetError(Confederacion, "Este campo no puede estar vacio");

            }
            else
            {
                MessageBox.Show("Datos actualizados");
            }

            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            if (txtTeam.Text == "")
                {
                error1.SetError(txtFederados, "Este campo no puede estar vacio");
                }
            else
            {
                MessageBox.Show($"El equipo {txtTeam.Text} ha sido encontrado","Equipo encontrado");
            }
        }
    }
}
