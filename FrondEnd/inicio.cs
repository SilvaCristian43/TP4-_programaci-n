using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace FrondEnd
{
    public partial class inicio : Form
    {
        public static ListaJugadoresSuspendidos lista = new ListaJugadoresSuspendidos();

        public static Jugadores datos { get; set; } = new Jugadores();

        Color[] colores = new Color[3];


        public inicio()
        {
            InitializeComponent();

            colores[0] = Color.Yellow;
            colores[1] = Color.Red;
            colores[2] = Color.White;


            dgvprincipal.DataSource = lista.DT;


            cmbactualizartarjetas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcargartarjetas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            datos.DNI = Convert.ToInt32(txtcargardni.Text);
            datos.NOMBRE = txtcargarnombre.Text;
            datos.EQUIPO = txtcargarequipo.Text;
            datos.TARJETAS = cmbcargartarjetas.Text;
            datos.DIASSUSPENCION = Convert.ToInt32(txtcargarsuspencion.Text);







            lista.Comprobar(datos);

            if (lista.comprobar == true)
            {
                lista.Cargardatos(datos);


                txtcargardni.Text = "";
                txtcargarnombre.Text = "";
                txtcargarequipo.Text = "";
                cmbcargartarjetas.Text = "";
                txtcargarsuspencion.Text = "";
                lbtexto.Text = "";

                txtcargardni.Focus();
            }
            else
            {
                lbtexto.Text = "DNI REPETIDO";

            }




        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            datos.DNI = Convert.ToInt32(txtactualizardni.Text);
            datos.NOMBRE = txtactualizarnombre.Text;
            datos.EQUIPO = txtactualizarequipo.Text;
            datos.TARJETAS = cmbactualizartarjetas.Text;
            datos.DIASSUSPENCION = Convert.ToInt32(txtactualizarsuspencion.Text);



            lista.Comprobar(datos);

            if (lista.comprobar == false)
            {
                lista.Actualizardatos(datos);


                txtactualizardni.Text = "";
                txtactualizarnombre.Text = "";
                txtactualizarequipo.Text = "";
                cmbactualizartarjetas.Text = "";
                txtactualizarsuspencion.Text = "";
                lbtexto.Text = "";

                txtactualizardni.Focus();
            }
            else
            {
                lbtexto.Text = "NO EXISTE DNI";

            }


        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            datos.DNI = Convert.ToInt32(txtborrardni.Text);

            lista.Comprobar(datos);

            if (lista.comprobar == false)
            {
                lista.Borrardatos(datos);


                txtborrardni.Text = "";
                lbtexto.Text = "";

                txtborrardni.Focus();
            }
            else
            {
                lbtexto.Text = "NO EXISTE DNI";

            }



        }

        private void btmostrar_Click(object sender, EventArgs e)
        {

            if (datos.controlarventana == true)
            {
                verlista ver = new verlista();
                ver.Show();
                datos.controlarventana = false;
            }


        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cmbcargartarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcargartarjetas.Text == "1 AMARILLA" || cmbcargartarjetas.Text == "2 AMARILLA")
            {
                t1.BackColor = colores[0];

            }
            else if (cmbcargartarjetas.Text == "1 ROJA")
            {
                t1.BackColor = colores[1];
            }
            else
            {
                t1.BackColor = colores[2];
            }
        }

        private void cmbactualizartarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbactualizartarjetas.Text == "1 AMARILLA" || cmbactualizartarjetas.Text == "2 AMARILLA")
            {
                t2.BackColor = colores[0];
            }
            else if (cmbactualizartarjetas.Text == "1 ROJA")
            {
                t2.BackColor = colores[1];
            }
            else
            {
                t2.BackColor = colores[2];
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
