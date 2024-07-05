using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_del_ahorcado
{
    public partial class Ahorcado : Form
    {
        Form1 f = new Form1();
        public char LetraElegida { get; set; }
        List<string> nuevaList = new List<string>();
        List<string> nuevaListOculta = new List<string>();
        public Ahorcado(Form1 f1)
        {
            InitializeComponent();
            f = f1;
            CopiaLista();
        }
        public void CopiaLista()
        {
            nuevaList.Clear();
            nuevaListOculta.Clear();
            foreach (var palabra in f.listaPalabra)
            {
                nuevaList.Add(palabra);
                string palabraOculta = new string('-', palabra.Length);
                nuevaListOculta.Add(palabraOculta);
            }

            for (int i = 0; i < nuevaList.Count; i++)
            {
                string palabra = nuevaList[i];
                char primeraLetra = palabra[0];
                char ultimaLetra = palabra[palabra.Length - 1];

                string palabraOculta = nuevaListOculta[i];
                nuevaListOculta[i] = primeraLetra + palabraOculta.Substring(1, palabraOculta.Length - 2) + ultimaLetra;
            }

            ActualizarLabel(); // Muestra la palabra ocultada inicialmente
        }
        private void Ahorcado_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLetraEscribir_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLetraEscribir.Text))
            {
                if (textBoxLetraEscribir.Text.Length == 1)
                {
                    LetraElegida = char.Parse(textBoxLetraEscribir.Text);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese solo un carácter.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxLetraEscribir.Clear();
                }
            }
        }

        private void labelMostrarPalabra_Click(object sender, EventArgs e)
        {
            
            ActualizarLabel();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            bool letraEncontrada = false;
            for (int i = 0; i < nuevaList.Count; i++)
            {
                string palabra = nuevaList[i];
                string palabraOculta = nuevaListOculta[i];

                for (int j = 0; j < palabra.Length; j++)
                {
                    if (palabra[j].ToString().Equals(LetraElegida.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        if (palabraOculta[j] == '-')
                        {
                            char[] charArray = palabraOculta.ToCharArray();
                            charArray[j] = LetraElegida;
                            nuevaListOculta[i] = new string(charArray);
                            letraEncontrada = true;
                        }
                    }
                }
            }

            if (letraEncontrada)
            {
                ActualizarLabel();
            }
            else
            {
                MessageBox.Show("Letra no encontrada.");
            }
        }
        private void ActualizarLabel()
        {
            labelMostrarPalabra.Text = string.Join(" ", nuevaListOculta);
        }
    }
}
