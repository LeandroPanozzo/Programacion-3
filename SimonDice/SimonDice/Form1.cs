/*
 Juego Simon

En la versión original el juego tiene cuatro botones, cada uno con un color distinto (verde, rojo, azul y amarillo), y cada botón tiene una
nota musical asignada.

Los botones van iluminándose de forma aleatoria creando un patrón cada vez más largo, el jugador tiene que repetir el patrón pulsando los
botones sin fallar, si el jugador lo hace correctamente sube un nivel sumando un color más al patrón, pero si falla, el juego termina y 
vuelve a empezar desde el principio.
 */

namespace SimonDice
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<int> list = new List<int>();
        List<int> listJugador = new List<int>();
        int cont = 0;
        bool continuar = true;
        bool mostrandoSecuencia = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; // Establece el intervalo en 1000 ms (1 segundo)
            timer1.Tick += new EventHandler(MostrarSecuencia);
        }

        public void AsignarValores()
        {
            int color = r.Next(0, 4);
            list.Add(color);
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            list.Clear();
            listJugador.Clear();
            cont = 0;
            mostrandoSecuencia = true;
            AsignarValores();
            timer1.Start();
        }

        private bool iluminado = false; // Estado de iluminación

        private void MostrarSecuencia(object sender, EventArgs e)
        {
            if (cont < list.Count)
            {
                if (!iluminado)
                {
                    int color = list[cont];
                    ResetColores();

                    switch (color)
                    {
                        case 0:
                            Azul.BackColor = Color.Blue;
                            break;
                        case 1:
                            Amarillo.BackColor = Color.LightYellow;
                            break;
                        case 2:
                            Rojo.BackColor = Color.IndianRed;
                            break;
                        case 3:
                            Verde.BackColor = Color.LightGreen;
                            break;
                    }

                    iluminado = true;
                }
                else
                {
                    ResetColores();
                    iluminado = false;
                    cont++;
                }
            }
            else
            {
                ResetColores();
                cont = 0;
                timer1.Stop();
                mostrandoSecuencia = false;
            }
        }

        private void ResetColores()
        {
            Azul.BackColor = SystemColors.Control;
            Amarillo.BackColor = SystemColors.Control;
            Rojo.BackColor = SystemColors.Control;
            Verde.BackColor = SystemColors.Control;
        }

        private void ProcesarClick(int color)//Se llama cuando el jugador hace clic en un botón de color
        {
            if (mostrandoSecuencia) return; //Si la secuencia aún se está mostrando, no hace nada

            listJugador.Add(color); //Agrega el color seleccionado por el jugador a su lista y comprueba si es correcto
            continuar = ComprobarEleccion();

            if (!continuar)
            {
                MessageBox.Show("¡Incorrecto! Perdiste.");
                listJugador.Clear();
            }
            else if (listJugador.Count == list.Count)
            {
                //Si la secuencia del jugador es correcta y completa, agrega un nuevo color a la secuencia y empieza a mostrarla nuevamente
                listJugador.Clear();
                AsignarValores();
                mostrandoSecuencia = true;
                timer1.Start();
            }
        }

        private bool ComprobarEleccion()
        {
            for (int i = 0; i < listJugador.Count; i++)
            {
                if (listJugador[i] != list[i])
                    return false;
            }
            return true;
        }

        private void Azul_Click(object sender, EventArgs e)
        {
            ProcesarClick(0);
        }

        private void Rojo_Click(object sender, EventArgs e)
        {
            ProcesarClick(2);
        }

        private void Amarillo_Click(object sender, EventArgs e)
        {
            ProcesarClick(1);
        }

        private void Verde_Click(object sender, EventArgs e)
        {
            ProcesarClick(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
