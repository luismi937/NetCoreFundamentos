namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
           
        {
            //Solo escribimos aqui
            this.label1.Text = "Hola " + this.txtNombre.Text;
            this.txtNombre.Location = new Point(200, 100);
            this.txtNombre.Text = "Soy un texto cambiado";
            this.txtNombre.Width = 300;
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.txtNombre.BackColor = Color.Green;
            this.txtNombre.BackColor = Color.FromArgb(255, 128, 0);
            // es coversion automatica
            short pequeño = 88;
            int mayor = pequeño;
            // String a primitivo
            int mayor2 = 200;
            short pequeño2 = (short) mayor2;

            //string al primitivo
            string textoNumero = "Hoy es viernes";
            int numero = int.Parse(textoNumero);
            int numero2 = int.Parse(textoNumero);
            double otro = double.Parse(textoNumero);

            //convertir cualquier objeto a string
            string dato = pequeño.ToString();
            dato = btnPulsar.ToString();


            
           

        }
    }
}
