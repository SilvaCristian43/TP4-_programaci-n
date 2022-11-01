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
    public partial class verlista : Form
    {
        
        public verlista()
        {
            InitializeComponent();

            dgvver.DataSource = inicio.lista.DT;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            inicio.datos.controlarventana = true;
            this.Close();
        }
    }
}
