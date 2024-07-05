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
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
        }
        public HistorialForm(List<string> historial)
        {
            /*
             Este constructor se llama cuando se crea una instancia de HistorialForm y se pasa una lista de cadenas 
            (List<string> historial), que contiene el historial de operaciones. que les pasamos desde form1
             */
            InitializeComponent();
            listBoxHistorial.DataSource = historial;
        }
        private void HistorialForm_Load(object sender, EventArgs e)
        {

        }
    }
}
