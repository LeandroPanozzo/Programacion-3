namespace juego_del_ahorcado
{
    public partial class Form1 : Form
    {
        public string Palabra { get; set; }
        public List<string> listaPalabra= new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxPalabraIngresada_TextChanged(object sender, EventArgs e)
        {
            Palabra=textBoxPalabraIngresada.Text;
            Palabra.ToLower();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Palabra))
            {
                listaPalabra.Add(Palabra);
                Ahorcado ahorcado = new Ahorcado(this);
                this.Hide(); // Oculta el formulario Form1
                ahorcado.ShowDialog();
                this.Show(); // Muestra de nuevo el formulario Form1 después de cerrar Ahorcado
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una palabra antes de continuar.");
            }
        }
    }
}
