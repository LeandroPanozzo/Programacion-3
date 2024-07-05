using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace tateti_winforms
{
    public partial class TatetiForm : Form
    {
        public int ConteoBotonesEnable { get; set; }
        public int FilaAsignar { get; set; }
        public int ColumnaAsignar { get; set; }
        private Form1 form1 = new Form1();
        private string[,] tablero = new string[3, 3];
        // Crear una instancia de Stopwatch
        Stopwatch stopwatch = new Stopwatch();
        public TatetiForm(Form1 form1Instance)
        {
            InitializeComponent();
            stopwatch.Start();
            FilaAsignar = 3;
            ColumnaAsignar = 3;
            ConteoBotonesEnable = 0;
            form1 = form1Instance; // Asigna la instancia de Form1 pasada como parámetro a la variable form1
        }
        private void IniciarTablero()
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    tablero[i, j] = " ";
                }
            }
        }
        private void TatetiForm_Load(object sender, EventArgs e)
        {

        }

        private void TurnoJugadoreslabel1_Click(object sender, EventArgs e)
        {

            if (form1.EmpezarJugador1 == true)
            {
                ActualizarLabel();
            }
            else
            {
                ActualizarLabel();
            }
        }
        private void ActualizarLabel()
        {
            if (form1.EmpezarJugador1)
            {
                TurnoJugadoreslabel1.Text = "Turno jugador 1";
            }
            else 
            {
                TurnoJugadoreslabel1.Text = "Turno jugador 2";
            }

            //TurnoJugadoreslabel1.Text = EmpezarJugador1 ? "Turno jugador 1" : "Turno jugador 2";
        }

        private void Btn_1_1_Click(object sender, EventArgs e)
        {
            Poner_X_o_O_enBotones(Btn_1_1,0,0);
            ConteoBotonesEnable++;
        }

        private void Btn_1_2_Click(object sender, EventArgs e)
        {
            Poner_X_o_O_enBotones(Btn_1_2, 0, 1);
            ConteoBotonesEnable++;
        }

        private void Btn_1_3_Click(object sender, EventArgs e)
        {
            Poner_X_o_O_enBotones(Btn_1_3, 0, 2);
            ConteoBotonesEnable++;
        }

        private void Btn_2_1_Click(object sender, EventArgs e)
        {
            Poner_X_o_O_enBotones(Btn_2_1, 1, 0);
            ConteoBotonesEnable++;
        }

        private void Btn_2_2_Click(object sender, EventArgs e)
        {
            Poner_X_o_O_enBotones(Btn_2_2, 1, 1);
            ConteoBotonesEnable++;
        }

        private void Btn_2_3_Click(object sender, EventArgs e)
        {
            Poner_X_o_O_enBotones(Btn_2_3, 1, 2);
            ConteoBotonesEnable++;
        }

        private void Btn_3_1_Click(object sender, EventArgs e)
        {
            Poner_X_o_O_enBotones(Btn_3_1, 2, 0);
            ConteoBotonesEnable++;
        }

        private void Btn_3_2_Click(object sender, EventArgs e)
        {
            Poner_X_o_O_enBotones(Btn_3_2, 2, 1);
            ConteoBotonesEnable++;
        }

        private void Btn_3_3_Click(object sender, EventArgs e)
        {
            Poner_X_o_O_enBotones(Btn_3_3, 2, 2);
            ConteoBotonesEnable++;
        }

        private void Poner_X_o_O_enBotones(Button btn, int fila, int columna)
        {
            if (btn != null && btn.Text == "")
            {
                btn.Text = form1.EmpezarJugador1 ? "X" : "O"; //si empezarJugador1 es true se pone X, si no O
                tablero[fila, columna] = btn.Text; //asigno el valor X o O al arreglo
                form1.EmpezarJugador1 = !form1.EmpezarJugador1; //lo mismo que asignarle un false
                if (btn.Text == "X")
                {
                    btn.BackColor= Color.IndianRed;
                }
                else
                {
                    btn.BackColor=Color.CadetBlue;
                }
                btn.Enabled = false;
                ActualizarLabel();
                VerificarGanador(tablero, fila, columna);
            }
        }

        private void VerificarGanador(string[,] arrayCopia, int valorX, int valorY)
        {
            string simbolo = arrayCopia[valorX, valorY];

            // Verificar fila
            if (arrayCopia[valorX, 0] == simbolo && arrayCopia[valorX, 1] == simbolo && arrayCopia[valorX, 2] == simbolo)
            {
                MostrarGanador(simbolo);
                return;
            }

            // Verificar columna
            if (arrayCopia[0, valorY] == simbolo && arrayCopia[1, valorY] == simbolo && arrayCopia[2, valorY] == simbolo)
            {
                MostrarGanador(simbolo);
                return;
            }

            // Verificar diagonal principal
            if (arrayCopia[0, 0] == simbolo && arrayCopia[1, 1] == simbolo && arrayCopia[2, 2] == simbolo)
            {
                MostrarGanador(simbolo);
                return;
            }

            // Verificar diagonal secundaria
            if (arrayCopia[0, 2] == simbolo && arrayCopia[1, 1] == simbolo && arrayCopia[2, 0] == simbolo)
            {
                MostrarGanador(simbolo);
                return;
            }

            // Verificar empate
            if (ConteoBotonesEnable == 8)//porque empieza en 0
            {
                MessageBox.Show("Empate!");
                Close();
            }
        }

        private void MostrarGanador(string simbolo)
        {
            // Detener el cronómetro
            stopwatch.Stop();
            // Mostrar el tiempo transcurrido
            TimeSpan ts = stopwatch.Elapsed;
            int horas = ts.Hours;
            int minutos = ts.Minutes;
            int segundos = ts.Seconds;
            int milisegundos = ts.Milliseconds;
            string ganador = simbolo == "X" ? form1.NombreJugador1 : form1.NombreJugador2;
            MessageBox.Show($"Ganaste jugador: {ganador}, el tiempo transcurrido fue de: {horas} Horas, {minutos} minutos, {segundos} segundos, {milisegundos} milisegundos");
            Close();
        }



    }
}
