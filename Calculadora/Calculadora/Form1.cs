/*
 Calculadora.NET

Desarrolle una calculadora que

Imite las funcionalidades de la calculadora est�ndar de Windows.
Permita adem�s ver y seleccionar los valores guardados en memoria a trav�s de un men�.
Agregue funcionalidad para calcular diferencias entre fechas (DateTimePicker).
Se redimensione autom�ticamente.
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
             string.Join es un m�todo est�tico de la clase String que combina todos los elementos de una colecci�n (en este caso, val) en
            una sola cadena.
            El primer par�metro, "", es el delimitador que se usa entre los elementos. Aqu� es una cadena vac�a, lo que significa que los
            elementos de val se concatenar�n sin ning�n separador.
            val es una lista de cadenas (List<string>) que contiene los d�gitos y el punto decimal que el usuario ha ingresado.
             */
            textBox1.Text = string.Join("", val);
        }
        private void ResultBtn_Click(object sender, EventArgs e)
        {
            /*
             Comprueba si hay una operaci�n en curso (operacionEnCurso es true), lo que indica que ya se ingres� un primer n�mero y
            se seleccion� una operaci�n
             */
            if (operacionEnCurso)
            {
                //Une todos los elementos de la lista val en una sola cadena sin separadores. Esta lista contiene los d�gitos y el
                //punto decimal que se han ingresado
                string concatenacion = string.Join("", val);
                try
                {
                    /*
                     Intenta convertir la cadena concatenada en un n�mero decimal (segundoNum) usando Convert.ToDecimal con la cultura 
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
                            //Si la operaci�n no es reconocida, muestra el primerNum en textBox1 y retorna ( finalizar� su ejecuci�n en
                            //ese punto y no continuar� con las siguientes instrucciones)
                            textBox1.Text = primerNum.ToString();
                            return;
                    }

                    val.Clear(); //limpio la lista
                    val.Add(resultado.ToString()); // agrego el resultado como nuevo valor de la lista para seguir operando
                    operacionEnCurso = false;

                    //Guardar la Operaci�n en el Historial
                    string operacionRealizada = $"{primerNum} {operacion} {segundoNum} = {resultado}";
                    historial.Add(operacionRealizada);  // Guardar la operaci�n en el historial

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
             Esta condici�n verifica si la lista val contiene alg�n valor. Si la lista est� vac�a, no se realiza ninguna acci�n
             */
            if (val.Count > 0)
            {
                /*
                 string.Join("", val): Combina todos los elementos de la lista val en una sola cadena sin separadores. Por ejemplo, si
                val contiene ["1", "2", "."], el resultado ser� "12.

                decimal.Parse(..., CultureInfo.InvariantCulture): Convierte la cadena resultante en un n�mero decimal usando la 
                cultura invariable (independiente de configuraciones regionales espec�ficas), garantizando que el punto decimal se 
                interprete correctamente
                 */
                primerNum = decimal.Parse(string.Join("", val), CultureInfo.InvariantCulture);
                /*
                 El nombre de la funci�n, que toma un par�metro op de tipo string, representando la operaci�n matem�tica seleccionada
                (por ejemplo, "+", "-", "*", "/").
                 */
                operacion = op;
                //Limpia la lista val, prepar�ndola para la entrada del segundo n�mero
                val.Clear();
                MostrarEntextBox();
                //Establece la variable operacionEnCurso a true, indicando que una operaci�n matem�tica est� en progreso.
                operacionEnCurso = true;
            }
        }

        private void CalcularFechas_Click(object sender, EventArgs e)
        {
            CalculoFechas cf = new CalculoFechas();

            if (cf.ShowDialog() == DialogResult.OK)
            {
                TimeSpan diferencia = cf.Resultado;
                int a�os = diferencia.Days / 365;
                int meses = (diferencia.Days % 365) / 30;
                int dias = (diferencia.Days % 365) % 30;

                string resultadoFormateado = $"{a�os} a�os, {meses} meses, {dias} d�as";
                textBox1.Text = resultadoFormateado;
            }
        }

        private void Historial_Click(object sender, EventArgs e)
        {
            //Este m�todo es un manejador de eventos que se ejecuta cuando el usuario hace clic en el boton Historial
            HistorialForm historialForm = new HistorialForm(historial);  // Pasar los valores de list historial a HistorialForm
            historialForm.Show(); //abre el form historial
        }
        // Manejador de evento para ekl  Historial
        private void HistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Este m�todo es un manejador de eventos espec�ficamente para un elemento de men� (ToolStripMenuItem) que permite al usuario
             * ver el historial de operaciones. (son los 3 puntos que se vera en la parte de arriba de la calculadora)*/

            ////Este m�todo simplemente llama al m�todo Historial_Click, pasando los mismos par�metros (sender y e).
            //Esto significa que la l�gica para mostrar el historial no se duplica. En lugar de eso, se reutiliza el m�todo Historial_Click
            Historial_Click(sender, e); //estamos llamando a la funcion del boton
        }
    }
}

