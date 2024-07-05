using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2LeandroPanozzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void MostrarEstadisticasLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnProcessText_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text; //Obtiene el texto del textBox1

            // Cantidad de palabras
            //divide una cadena de texto en palabras usando varios delimitadores y omitiendo las entradas vacías
            //El método Split de la clase String en C# se utiliza para dividir una cadena en un array de
            //subcadenas basándose en delimitadores especificados
            //Este es un array de caracteres que define los delimitadores que se usarán para dividir la
            //cadena de texto. Los delimitadores especificados son: ' ' (espacio) '\t' (tabulador) '\n' (nueva línea) '\r' (retorno de carro)
            //StringSplitOptions.RemoveEmptyEntries
            //le dice al método Split que omita las entradas vacías en el array de resultados. Esto es útil
            //para evitar que se incluyan subcadenas vacías que podrían resultar de múltiples delimitadores
            //consecutivos o delimitadores al inicio o al final del texto.
            var words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = words.Length; //cantidad de caracteres del arreglo
            CantPalabras.Text = "Cantidad de palabras: " + wordCount; //cantPalabras es un label

            // Cantidad de caracteres con espacios
            var charCountWithSpaces = text.Length;
            CantCaracteresEspacio.Text = "Cantidad de caracteres (con espacios): " + charCountWithSpaces;

            // Cantidad de caracteres sin espacios
            //expresion con Linq en donde IsWhiteSpace es para que evite los espacion en blanco
            //es decir: aqui cuento cuenta el número de caracteres en la cadena text que no son espacios en blanco
            var charCountWithoutSpaces = text.Count(c => !char.IsWhiteSpace(c));
            CantCaracteresSinEspacio.Text = "Cantidad de caracteres (sin espacios): " + charCountWithoutSpaces;

            // Listado de las 10 palabras más repetidas
            var wordFrequency = words.GroupBy(w => w) //Agrupa las palabras del array words por su valor
                                                      //Word: La palabra (que es la clave del grupo)
                                                      //Count: El número de veces que aparece la palabra.
                                                      //Length: La longitud de la palabra
                                     .Select(g => new { Word = g.Key, Count = g.Count(), Length = g.Key.Length })
                                     //Ordena los resultados en orden descendente según el conteo de cada palabra
                                     .OrderByDescending(w => w.Count)
                                     //Si hay empates en el conteo, ordena alfabéticamente por la palabra
                                     .ThenBy(w => w.Word)
                                     //Selecciona solo los primeros 10 elementos de la lista ordenad
                                     .Take(10)
                                     //Convierte el resultado en una lista
                                     .ToList();

            dataGridView1.DataSource = wordFrequency;
        }
        /*
         como sabe el dataGrind que las columnas que tendra son 3 y se llaman: word, count y lenght?
        El DataGridView obtiene esta información del objeto que se le asigna como fuente de datos. En este caso, la fuente de datos
        se establece en la línea: dataGridView1.DataSource = wordFrequency;
        La clave está en esta parte: .Select(g => new { Word = g.Key, Count = g.Count(), Length = g.Key.Length })
        Aquí se está creando un objeto anónimo con tres propiedades: Word, Count y Length. Cuando este objeto se asigna como fuente 
        de datos al DataGridView, éste automáticamente crea columnas basadas en las propiedades del objeto
        El DataGridView utiliza reflexión para examinar el tipo de objetos en la lista wordFrequency y crea columnas basadas en las 
        propiedades públicas de estos objetos. En este caso, detecta las tres propiedades (Word, Count y Length) y crea una columna 
        para cada una
         */

        private void CargarArchivoBtn_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filePath);
                textBox1.Text = fileText;
            }
        }

        //guardar estadisticas del texto
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName; //Obtiene la ruta del archivo seleccionado por el usuario

                using (StreamWriter writer = new StreamWriter(filePath)) //Crea un StreamWriter para escribir en el archivo using para que se cierre correctamente
                {
                    //Escribe las estadísticas generales
                    writer.WriteLine("Estadísticas del Texto:");
                    writer.WriteLine(CantPalabras.Text);
                    writer.WriteLine(CantCaracteresEspacio.Text);
                    writer.WriteLine(CantCaracteresSinEspacio.Text);
                    //Escribe el encabezado para las palabras más repetidas
                    writer.WriteLine("Palabras más repetidas:");
                    int cont = 0;
                    //Recorre cada fila del DataGridView y escribe la información de cada palabra
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        cont++;
                        writer.WriteLine($"{row.Cells["Word"].Value} - Repeticiones: {row.Cells["Count"].Value} - Longitud: {row.Cells["Length"].Value}");
                    }
                }

                MessageBox.Show("Archivo guardado correctamente.", "Guardar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarTextoDeTextBox_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(textBox1.Text);
                    

                    
                }

                MessageBox.Show("Archivo guardado correctamente.", "Guardar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CantPalabras_Click(object sender, EventArgs e)
        {

        }

        private void CantCaracteresEspacio_Click(object sender, EventArgs e)
        {

        }

        private void CantCaracteresSinEspacio_Click(object sender, EventArgs e)
        {

        }
    }
}
