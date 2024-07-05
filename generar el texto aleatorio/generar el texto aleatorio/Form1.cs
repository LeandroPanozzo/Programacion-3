using System.Text;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace generar_el_texto_aleatorio
{
    public partial class Form1 : Form
    {
        public string Resultado { get; set; }
        private AbrirArchivoBtn lp = new AbrirArchivoBtn();
        private int contadorParrafos; // Variable para almacenar el contador de párrafos
        public Form1(AbrirArchivoBtn lore, int parrafos)
        {
            InitializeComponent();
            lp = lore;
            contadorParrafos = parrafos; // Asignar el contador de párrafos recibido
            if (lp.CrearArchivo)
            {
                Resultado = string.Join(" ", lp.list); //une los valores de la lista a un string
            }
            else
            {
                Resultado = lp.ContenidoArchivoAbierto;
            }
            
            textBoxMostrar.Text = Resultado;
            // Mostrar la cantidad de caracteres y párrafos
            MostrarCantidadCaracteresYPárrafos();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMostrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            // Configuramos el diálogo para guardar el archivo
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Guardamos el contenido del textBoxMostrar en el archivo seleccionado
                File.WriteAllText(saveFileDialog1.FileName, textBoxMostrar.Text);
            }
        }

        private void MostrarCantidadParafosYPalabrasLabel_Click(object sender, EventArgs e)
        {

        }
        private void MostrarCantidadCaracteresYPárrafos()
        {
            // Calcular cantidad de caracteres
            int caracteres = textBoxMostrar.Text.Length;

            // Mostrar los resultados en el Label
            MostrarCantidadParafosYPalabrasLabel.Text = $"Caracteres: {caracteres}, Párrafos: {contadorParrafos}";
        }
    }
}
