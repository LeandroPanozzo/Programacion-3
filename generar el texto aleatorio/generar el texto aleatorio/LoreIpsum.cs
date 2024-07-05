/*
 Generador Lorem Ipsum
Elabore un programa en C# y Windows Forms, que permita generar texto aleatorio en Latin de forma similar a Lorem Ipsum, de acuerdo con ciertos parámetros.
En caso de que no lo conozca, "Lorem ipsum es el texto que se usa habitualmente en diseño gráfico en demostraciones de tipografías o de borradores de diseño
para probar el diseño visual antes de insertar el texto final." (Wikipedia)
Consideraciones:
• Las palabras se extraerán de un archivo de texto, puede usareste archivo.
• Los parámetros de generación que podrá introducir el usuario son: cantidad párrafos o palabras (mutuamente excluyentes). Además si debe empezar o no con el texto "Lorem ipsum dolor sit amet consectetur adipiscing elit."
• Los parámetros internos serán: cantidad mínima y máxima de palabras de una oración y cantidad máxima de oraciones en un párrafo.
• En cuanto a los signos de puntuación sólo se contemplarán punto seguido y aparte. Recuerde colocar en mayúscula la primera letra de cada palabra después de un punto.
• El texto generado se mostrará por pantalla, con la posibilidad de guardarlo en un archivo de texto.
Finalmente deberá indicar la cantidad de párrafos, palabras y caracteres generados (incluyendo espacios y puntos).
• Utilice Menús donde crea conveniente.
• Los controles se deberán autoajustar si las dimensiones del formulario cambian.
• Además de la funcionalidad del código se valorará su correcto diseño.
• Adjunte todos los archivos de la solución en un archivo comprimido con su apellido y nombre, luego adjúntelo a la respuesta, por ejemplo: ApellidoNombre-
RecParcial2.zip
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace generar_el_texto_aleatorio
{

    public partial class AbrirArchivoBtn : Form
    {
        public bool CrearArchivo { get; set; } = false;
        public bool HabilitarLoreIpsum { get; set; } = false;
        public bool oracionesEnParrafo { get; set; } = false;
        public bool PalabrasEnOracion { get; set; } = false;
        public int MinPalabraoracion { get; set; }
        public int MaxPalabraoracion { get; set; }
        public string ContenidoArchivoAbierto { get; set; }
        Random r = new Random();
        public List<string> list = new List<string>();

        string[] latin = {"lorem","ipsum","dolor", "sit", "amet", "consectetur", "adipiscing", "elit","phasellus", "purus", "iaculis", "ante", "praesent", "diam", "ultrices", "eu", "eget", "magna", "commodo", "aliquet",
            "porta", "ligula", "hendrerit", "vehicula", "blandit", "non", "malesuada", "morbi", "finibus", "odio", "quisque",
            "imperdiet", "libero", "tincidunt", "volutpat", "nulla", "maecenas", "tristique", "in", "convallis", "nunc", "varius",
            "cursus" };

        List<string> listaNueva = new List<string>();
        public AbrirArchivoBtn()
        {
            InitializeComponent();
        }


        private void agregarALista()
        {
            for (int i = 0; i < latin.Length; i++)
            {
                list.Add(latin[i]);
            }
        }
        private void LoreIpsum_Load(object sender, EventArgs e)
        {

        }
        //oraciones en un parrafo:
        private void radioButtonParrafo_CheckedChanged(object sender, EventArgs e)
        {
            oracionesEnParrafo = true;
            PalabrasEnOracion = false; // Asegurar que solo un modo esté activo a la vez
            ActualizarUI();
        }

        private void textBoxMinOraciones_TextChanged(object sender, EventArgs e)
        {
            if (oracionesEnParrafo)
            {
                textBoxMinOraciones.Enabled = true;
                if (int.TryParse(textBoxMinOraciones.Text, out int result))
                {
                    MinPalabraoracion = result;
                    textBoxMaxOraciones.Enabled = true;
                }
                else
                {
                    MinPalabraoracion = 0;
                    textBoxMaxOraciones.Enabled = false; // Disable max text box if min value is invalid
                }
            }
            else
            {
                textBoxMinOraciones.Enabled = false;
            }

        }

        private void textBoxMaxOraciones_TextChanged(object sender, EventArgs e)
        {
            if (oracionesEnParrafo)
            {
                textBoxMaxOraciones.Enabled = true;
                if (int.TryParse(textBoxMaxOraciones.Text, out int result))
                {
                    MaxPalabraoracion = result;
                }
                else
                {
                    MaxPalabraoracion = 0;
                }
            }
            else
            {
                textBoxMaxOraciones.Enabled = false;
            }

        }
        // Palabras en una oracion
        private void radioButtonPalabra_CheckedChanged(object sender, EventArgs e)
        {
            PalabrasEnOracion = true;
            oracionesEnParrafo = false; // Asegurar que solo un modo esté activo a la vez
            ActualizarUI();
        }
        private void textBoxMinPalabras_TextChanged(object sender, EventArgs e)
        {
            if (PalabrasEnOracion)
            {

                textBoxMinPalabras.Enabled = true;
                if (int.TryParse(textBoxMinPalabras.Text, out int result))
                {
                    MinPalabraoracion = result;
                    textBoxMaxPalabras.Enabled = true;
                }
                else
                {
                    //verificarMenor(MinPalabraoracion, textBoxMinPalabras);
                    MinPalabraoracion = 0;
                    textBoxMaxPalabras.Enabled = false; // Disable max text box if min value is invalid
                }
            }



        }
        private void textBoxMaxPalabras_TextChanged(object sender, EventArgs e) //ingresar cantidad maxima de palabras
        {
            if (PalabrasEnOracion)
            {
                textBoxMaxPalabras.Enabled = true;
                if (int.TryParse(textBoxMaxPalabras.Text, out int result))
                {
                    MaxPalabraoracion = result;

                }
                else
                {
                    MaxPalabraoracion = 0;
                }
            }



        }

        private void ActualizarUI()
        {
            textBoxMinOraciones.Enabled = oracionesEnParrafo;

            textBoxMinPalabras.Enabled = PalabrasEnOracion;
        }
        private void EmpezarBtn_Click(object sender, EventArgs e)
        {
            list.Clear(); // Limpiar la lista antes de generar nuevo texto
            CrearArchivo = true;
            Random r = new Random(); // Crear una nueva instancia de Random
            int contadorParrafos = 0; // Inicializar el contador de párrafos
            if (PalabrasEnOracion)
            {
                // Generar un número aleatorio de palabras dentro del rango especificado
                int aleatorioPalabras = r.Next(MinPalabraoracion, MaxPalabraoracion + 1);

                // Generar el párrafo con palabras aleatorias
                for (int i = 0; i < aleatorioPalabras; i++)
                {
                    list.Add(latin[i % latin.Length]); // Usar módulo para repetir palabras si el número de palabras requerido es mayor que la longitud del array
                }

                list[list.Count - 1] += "."; // Agregar un punto al final del último párrafo
            }
            else if (oracionesEnParrafo)
            {
                // Generar un número aleatorio de párrafos dentro del rango especificado
                int aleatorioParrafos = r.Next(MinPalabraoracion, MaxPalabraoracion + 1);

                for (int j = 0; j < aleatorioParrafos; j++)
                {
                    // Generar un número aleatorio de palabras en el parrafo dentro del rango especificado
                    int aleatorioPalabras = r.Next(MinPalabraoracion, MaxPalabraoracion + 1);

                    // Generar el párrafo con palabras aleatorias
                    for (int i = 0; i < aleatorioPalabras; i++)
                    {
                        list.Add(latin[i % latin.Length]); // Usar módulo para repetir palabras si el número de palabras requerido es mayor que la longitud del array
                    }

                    list[list.Count - 1] += "."; // Agregar un punto al final del párrafo
                    list.Add(Environment.NewLine); // Agregar un salto de línea después de cada párrafo
                    contadorParrafos++; // Incrementar el contador de párrafos y luego sigue con el siguiente
                }
            }

            // Mostrar el formulario con el texto generado
            Form1 f1 = new Form1(this, contadorParrafos);
            if (f1.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void checkBoxLoreIpsum_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarLoreIpsum = true;
            for (int i = 0; i < 8; i++)
            {
                listaNueva.Add(latin[i]);

            }
        }

        private void AbrirBtn_Click(object sender, EventArgs e)
        {
            CrearArchivo = false;
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog1.Title = "Seleccionar archivo";
            int contadorParrafos = 0; // Inicializar el contador de párrafos
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Leer el contenido del archivo seleccionado
                ContenidoArchivoAbierto = File.ReadAllText(openFileDialog1.FileName);

                Form1 f1 = new Form1(this, contadorParrafos);
                if (f1.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }
    }
}
