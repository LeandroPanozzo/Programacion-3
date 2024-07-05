/*
 Calculadora.NET

Desarrolle una calculadora que

Imite las funcionalidades de la calculadora estándar de Windows.
Permita además ver y seleccionar los valores guardados en memoria a través de un menú.
Agregue funcionalidad para calcular diferencias entre fechas (DateTimePicker).
Se redimensione automáticamente.
Solo debe manejarse con el mouse.
 */

using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private List<string> val = new List<string>();
        private List<string> historial = new List<string>();  
        private decimal primerNum = 0;
        private decimal segundoNum = 0;
        private string operacion = "";
        private bool operacionEnCurso = false;

        public Form1()
        {
            InitializeComponent();
            // Agregar manejador de evento para el Historial
            HistorialToolStripMenuItem.Click += new EventHandler(HistorialToolStripMenuItem_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void UnoBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("1");
        }

        private void CeroBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("0");
        }

        private void PuntoBtn_Click(object sender, EventArgs e)
        {
            if (!val.Contains("."))
            {
                ProcesarClick(".");
            }
        }

        private void DosBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("2");
        }

        private void TresBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("3");
        }

        private void CuatroBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("4");
        }

        private void CincoBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("5");
        }

        private void SeisBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("6");
        }

        private void SieteBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("7");
        }

        private void OchoBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("8");
        }

        private void NueveBtn_Click(object sender, EventArgs e)
        {
            ProcesarClick("9");
        }

        public void ProcesarClick(string numero)
        {
            val.Add(numero);
            MostrarEntextBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            if (val.Count > 0)
            {
                val.RemoveAt(val.Count - 1);
                MostrarEntextBox();
            }
        }

        private void BorrarTodoBtn_Click(object sender, EventArgs e)
        {
            val.Clear();
            primerNum = 0;
            segundoNum = 0;
            operacion = "";
            operacionEnCurso = false;
            MostrarEntextBox();
        }
        private void MostrarEntextBox()
        {
            /*
             string.Join es un método estático de la clase String que combina todos los elementos de una colección (en este caso, val) en
            una sola cadena.
            El primer parámetro, "", es el delimitador que se usa entre los elementos. Aquí es una cadena vacía, lo que significa que los
            elementos de val se concatenarán sin ningún separador.
            val es una lista de cadenas (List<string>) que contiene los dígitos y el punto decimal que el usuario ha ingresado.
             */
            textBox1.Text = string.Join("", val);
        }
        private void ResultBtn_Click(object sender, EventArgs e)
        {
            /*
             Comprueba si hay una operación en curso (operacionEnCurso es true), lo que indica que ya se ingresó un primer número y
            se seleccionó una operación
             */
            if (operacionEnCurso)
            {
                //Une todos los elementos de la lista val en una sola cadena sin separadores. Esta lista contiene los dígitos y el
                //punto decimal que se han ingresado
                string concatenacion = string.Join("", val);
                try
                {
                    /*
                     Intenta convertir la cadena concatenada en un número decimal (segundoNum) usando Convert.ToDecimal con la cultura 
                    invariable para asegurar que el punto decimal se interprete correctamente. primerNum ya se lo convirtio en decimal en
                    el metodo GuardarNumeroYOperacion(string op)
                     */
                    segundoNum = Convert.ToDecimal(concatenacion, CultureInfo.InvariantCulture);

                    decimal resultado = 0; //variable resultado
                    switch (operacion)
                    {
                        case "+":
                            resultado = primerNum + segundoNum;
                            break;
                        case "-":
                            resultado = primerNum - segundoNum;
                            break;
                        case "*":
                            resultado = primerNum * segundoNum;
                            break;
                        case "/":
                            if (segundoNum != 0)
                            {
                                resultado = primerNum / segundoNum;
                            }
                            else
                            {
                                textBox1.Text = "Error";
                                return;
                            }
                            break;
                        default:
                            //Si la operación no es reconocida, muestra el primerNum en textBox1 y retorna ( finalizará su ejecución en
                            //ese punto y no continuará con las siguientes instrucciones)
                            textBox1.Text = primerNum.ToString();
                            return;
                    }

                    val.Clear(); //limpio la lista
                    val.Add(resultado.ToString()); // agrego el resultado como nuevo valor de la lista para seguir operando
                    operacionEnCurso = false;

                    //Guardar la Operación en el Historial
                    string operacionRealizada = $"{primerNum} {operacion} {segundoNum} = {resultado}";
                    historial.Add(operacionRealizada);  // Guardar la operación en el historial

                    textBox1.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    textBox1.Text = "Error";
                }
            }
        }

        private void MultiplicacionBtn_Click(object sender, EventArgs e)
        {
            GuardarNumeroYOperacion("*");
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            GuardarNumeroYOperacion("/");
        }

        private void RestaBtn_Click(object sender, EventArgs e)
        {
            GuardarNumeroYOperacion("-");
        }

        private void SumaBtn_Click(object sender, EventArgs e)
        {
            GuardarNumeroYOperacion("+");
        }

        

        private void GuardarNumeroYOperacion(string op)
        {
            /*
             Esta condición verifica si la lista val contiene algún valor. Si la lista está vacía, no se realiza ninguna acción
             */
            if (val.Count > 0)
            {
                /*
                 string.Join("", val): Combina todos los elementos de la lista val en una sola cadena sin separadores. Por ejemplo, si
                val contiene ["1", "2", "."], el resultado será "12.

                decimal.Parse(..., CultureInfo.InvariantCulture): Convierte la cadena resultante en un número decimal usando la 
                cultura invariable (independiente de configuraciones regionales específicas), garantizando que el punto decimal se 
                interprete correctamente
                 */
                primerNum = decimal.Parse(string.Join("", val), CultureInfo.InvariantCulture);
                /*
                 El nombre de la función, que toma un parámetro op de tipo string, representando la operación matemática seleccionada
                (por ejemplo, "+", "-", "*", "/").
                 */
                operacion = op;
                //Limpia la lista val, preparándola para la entrada del segundo número
                val.Clear();
                MostrarEntextBox();
                //Establece la variable operacionEnCurso a true, indicando que una operación matemática está en progreso.
                operacionEnCurso = true;
            }
        }

        private void CalcularFechas_Click(object sender, EventArgs e)
        {
            CalculoFechas cf = new CalculoFechas();

            if (cf.ShowDialog() == DialogResult.OK)
            {
                TimeSpan diferencia = cf.Resultado;
                int años = diferencia.Days / 365;
                int meses = (diferencia.Days % 365) / 30;
                int dias = (diferencia.Days % 365) % 30;

                string resultadoFormateado = $"{años} años, {meses} meses, {dias} días";
                textBox1.Text = resultadoFormateado;
            }
        }

        private void Historial_Click(object sender, EventArgs e)
        {
            //Este método es un manejador de eventos que se ejecuta cuando el usuario hace clic en el boton Historial
            HistorialForm historialForm = new HistorialForm(historial);  // Pasar los valores de list historial a HistorialForm
            historialForm.Show(); //abre el form historial
        }
        // Manejador de evento para ekl  Historial
        private void HistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Este método es un manejador de eventos específicamente para un elemento de menú (ToolStripMenuItem) que permite al usuario
             * ver el historial de operaciones. (son los 3 puntos que se vera en la parte de arriba de la calculadora)*/

            ////Este método simplemente llama al método Historial_Click, pasando los mismos parámetros (sender y e).
            //Esto significa que la lógica para mostrar el historial no se duplica. En lugar de eso, se reutiliza el método Historial_Click
            Historial_Click(sender, e); //estamos llamando a la funcion del boton
        }
    }
}

