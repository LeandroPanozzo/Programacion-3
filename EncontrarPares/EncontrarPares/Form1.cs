/*
 Juego de memoria
Elabore un programa en C# y Windows Forms (o WCF), que presente un tablero de 4 filas por 5 columnas, el cual ocultará 10 pares de palabras. El jugador deberá encontrar todos los pares existentes antes que se le terminen la cantidad de movimientos establecidos.
Un movimiento consiste en descubrir dos celdas, si las palabras ocultas en ellas coinciden se las marca como apareadas, si las palabras no coinciden las fichas se vuelven a ocultar, en cualquiera de los dos casos de descuenta un movimiento
Consideraciones:
El gráfico incluido es ilustrativo y contiene los elementos mínimos, podrá agregar aquellos que crea necesario
La ubicación inicial de las palabras deberá ser aleatoria
Las palabras deberán estar almacenadas en un archivo de texto, dicho archivo podrá cargarse al inicio en una colección
Además de la funcionalidad del código se valorará su correcto diseño.
 */
namespace EncontrarPares
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int cont = 0;
        int contGanador = 0;
        int contVidas = 3;
        Button b1 = null;
        Button b2 = null;
        int valor1 = 0;
        List<int> list = new List<int>();
        List<int> listaGanadores = new List<int>();
        private Form2 form2 = new Form2();
        public Form1(Form2 form1Instance)
        {
            InitializeComponent();
            Empezar_Click();
            timer1.Interval = 1000; // 1 segundo
            timer1.Tick += Timer1_Tick;
            form2 = form1Instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Empezar_Click()
        {
            
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                list.Add(i);
            }
            // Mezclar la lista aleatoriamente
            list = list.OrderBy(x => r.Next()).ToList();
        }

        

        private void Mostrar(Button btn, int valor) //metodo para mostrar el valor del boton
        {
            if (true)
            {
                btn.Text = list[valor].ToString();
                btn.BackColor = Color.AliceBlue;
            }
        }

        private bool AllPairsMatched() //verifico si todos los pares fueron encontrados
        {
            //en el foreach recorro todos los controles dentro del formulario, this.controls es una coleccion que
            //contiene todos los controles del formulario
            foreach (Control control in this.Controls)
            {
                //verifica si tiene un valor asignado y convierte ese valor en un booleano para saver si es false para
                //ver si el boton esta emparejado (le hicimos click
                if (control is Button btn && btn.Tag != null && (bool)btn.Tag == false)
                {
                    return false;
                }
            }
            return true;
        }

        private void verificar(Button btn, int Posicion)
        {
            if (cont == 0)
            {
                valor1 = list[Posicion];
                b1 = btn;
                b1.Enabled = false;
                cont++;
            }
            else if (cont == 1)
            {
                b2 = btn;
                if (valor1 == list[Posicion]) //verifico si el primer boton y el segundo que aprete tienen el mismo valor
                {
                    b2.Enabled = false;
                    b2.Tag = true;
                    b1.Tag = true;

                    // Reset counter
                    cont = 0;
                    b1 = null;
                    b2 = null;

                    if (AllPairsMatched())
                    {
                        contGanador++;
                        listaGanadores.Add(contGanador);
                        VerSiGano();
                    }
                }
                else
                {
                    b2.Tag = false; //si no lo pongo en falso para que no queden asignados esos valores
                    b1.Tag = false;
                    form2.vidas -= 1;
                    // Start the timer to reset buttons after 1 second
                    timer1.Start();
                }
            }
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            //paro el tiempo
            timer1.Stop();

            // resetear botones
            if (b1 != null)
            {
                b1.Enabled = true;
                b1.Text = "";
                b1.BackColor = Color.Orange;
                b1 = null;
            }

            if (b2 != null)
            {
                b2.Text = "";
                b2.BackColor = Color.Orange;
                b2 = null;
            }

            //resetear contador
            cont = 0;

            // decrementar vidas
            
            
            label1.Text = "Vidas: " + form2.vidas.ToString();
            if (form2.vidas <= 0)
            {
                MessageBox.Show("Perdiste");
                ReiniciarJuego();
            }
            
        }
        private void VerSiGano()
        {
            if (listaGanadores.Count == 20)
            {
                MessageBox.Show("Ganaste");
                ReiniciarJuego();
            }
        }
        private void ReiniciarJuego()
        {
            Close();

        }

        private void button_1_1_Click(object sender, EventArgs e)
        {
            Mostrar(button_1_1, 0);
            verificar(button_1_1, 0);
        }

        private void button_1_2_Click(object sender, EventArgs e)
        {
            Mostrar(button_1_2, 1);
            verificar(button_1_2, 1);
        }

        private void button_1_3_Click(object sender, EventArgs e)
        {
            Mostrar(button_1_3, 2);
            verificar(button_1_3, 2);
        }

        private void button_1_4_Click(object sender, EventArgs e)
        {
            Mostrar(button_1_4, 3);
            verificar(button_1_4, 3);
        }

        private void button_1_5_Click(object sender, EventArgs e)
        {
            Mostrar(button_1_5, 4);
            verificar(button_1_5, 4);
        }

        private void button_2_1_Click(object sender, EventArgs e)
        {
            Mostrar(button_2_1, 5);
            verificar(button_2_1, 5);
        }

        private void button_2_2_Click(object sender, EventArgs e)
        {
            Mostrar(button_2_2, 6);
            verificar(button_2_2, 6);
        }

        private void button_2_3_Click(object sender, EventArgs e)
        {
            Mostrar(button_2_3, 7);
            verificar(button_2_3, 7);
        }

        private void button_2_4_Click(object sender, EventArgs e)
        {
            Mostrar(button_2_4, 8);
            verificar(button_2_4, 8);
        }

        private void button_2_5_Click(object sender, EventArgs e)
        {
            Mostrar(button_2_5, 9);
            verificar(button_2_5, 9);
        }

        private void button_3_1_Click(object sender, EventArgs e)
        {
            Mostrar(button_3_1, 10);
            verificar(button_3_1, 10);
        }

        private void button_3_2_Click(object sender, EventArgs e)
        {
            Mostrar(button_3_2, 11);
            verificar(button_3_2, 11);
        }

        private void button_3_3_Click(object sender, EventArgs e)
        {
            Mostrar(button_3_3, 12);
            verificar(button_3_3, 12);
        }

        private void button_3_4_Click(object sender, EventArgs e)
        {
            Mostrar(button_3_4, 13);
            verificar(button_3_4, 13);
        }

        private void button_3_5_Click(object sender, EventArgs e)
        {
            Mostrar(button_3_5, 14);
            verificar(button_3_5, 14);
        }

        private void button_4_1_Click(object sender, EventArgs e)
        {
            Mostrar(button_4_1, 15);
            verificar(button_4_1, 15);
        }

        private void button_4_2_Click(object sender, EventArgs e)
        {
            Mostrar(button_4_2, 16);
            verificar(button_4_2, 16);
        }

        private void button_4_3_Click(object sender, EventArgs e)
        {
            Mostrar(button_4_3, 17);
            verificar(button_4_3, 17);
        }

        private void button_4_4_Click(object sender, EventArgs e)
        {
            Mostrar(button_4_4, 18);
            verificar(button_4_4, 18);
        }

        private void button_4_5_Click(object sender, EventArgs e)
        {
            Mostrar(button_4_5, 19);
            verificar(button_4_5, 19);
        }
    }
}
