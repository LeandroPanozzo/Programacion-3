using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CalculoFechas : Form
    {
        private DateTime valor1;
        private DateTime valor2;
        private TimeSpan resultado;
        public CalculoFechas()
        {
            InitializeComponent();
        }

        public DateTime Valor1 { get => valor1; set => valor1 = value; }
        public DateTime Valor2 { get => valor2; set => valor2 = value; }
        public TimeSpan Resultado { get => resultado; set => resultado = value; }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value==null)
            {
                valor1= DateTime.Now;
            }
            else
            {
                valor1 = dateTimePicker1.Value;
            }
            if (dateTimePicker2.Value == null)
            {
                valor2 = DateTime.Now;
            }
            else
            {
                valor2 = dateTimePicker2.Value;
            }
            
            resultado = valor1 - valor2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CalculoFechas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
