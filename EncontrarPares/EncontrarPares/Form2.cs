using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncontrarPares
{
    public partial class Form2 : Form
    {
        public int vidas { get; set; }
        public bool BotonEmpezar { get; set; } = false;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void EmpezarBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(this);
            
            if (f1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void radioButtonDificultadFacil_CheckedChanged(object sender, EventArgs e)
        {
            vidas = 10;
            BotonEmpezar=true;
            habilitarBoton();
        }

        private void radioButtonDificultadMedia_CheckedChanged(object sender, EventArgs e)
        {
            vidas = 5;
            BotonEmpezar = true;
            habilitarBoton();
        }

        private void radioButtonDificultadDificil_CheckedChanged(object sender, EventArgs e)
        {
            vidas = 3;
            BotonEmpezar = true;
            habilitarBoton();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void habilitarBoton()
        {
            if (BotonEmpezar)
            {
                EmpezarBtn.Enabled = true;
            }
        }
    }
}
