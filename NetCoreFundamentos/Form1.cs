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
           

        }
    }
}
