/*
 TaTeTi.NET
Elabore un programa en C# y Windows Forms, que presente un tablero de 3 filas por 3 columnas y permita a dos personas jugar en la misma PC por turnos al TaTeTi.
Consideraciones:
Permitirá cargar el nombre de cada jugador al inicio del juego y le asignará una O o Χ.
Al finalizar cada partida indicará quien fue el ganador y el tiempo transcurrido.
No existirá juego contra la computadora.
Utilice Menús.
Los controles se deberán autoajustar si las dimensiones del formulario cambian.
Además de la funcionalidad del código se valorará su correcto diseño.
 */
namespace tateti_winforms
{
    public partial class Form1 : Form
    {
        public bool Empezar { get; set; }
        public bool EmpezarJugador1 { get; set; }
        public bool EmpezarJugador2 { get; set; }

        public string NombreJugador1 { get; set; }
        public string NombreJugador2 { get; set; }

        public Form1()
        {
            InitializeComponent();
            EmpezarBtn.Enabled = false;
            EmpezarJugador1 = true;
            EmpezarJugador2 = false;
        }

        private void Jugador1textBox1_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void Jugador2textBox2_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }
        private void VerificarCampos()
        {
            NombreJugador1 = Jugador1textBox1.Text;
            NombreJugador2 = Jugador2textBox2.Text;

            EmpezarBtn.Enabled = !string.IsNullOrWhiteSpace(NombreJugador1) && !string.IsNullOrWhiteSpace(NombreJugador2);
        }


        private void EmpezarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreJugador1) || string.IsNullOrWhiteSpace(NombreJugador2))
            {
                MessageBox.Show("Por favor ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TatetiForm ta = new TatetiForm(this);
            NombreJugador1 = Jugador1textBox1.Text;
            NombreJugador2 = Jugador2textBox2.Text;
            if (ta.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
