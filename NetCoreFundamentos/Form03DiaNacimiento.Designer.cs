namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDia = new Label();
            lblMes = new Label();
            lblAño = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAño = new TextBox();
            btnMostrar = new Button();
            lblSolucion = new Label();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(46, 53);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(24, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Dia";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(46, 96);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(46, 143);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(29, 15);
            lblAño.TabIndex = 2;
            lblAño.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(88, 53);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(88, 93);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 4;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(88, 135);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 5;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(59, 186);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(129, 62);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar Dia";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // lblSolucion
            // 
            lblSolucion.AutoSize = true;
            lblSolucion.Location = new Point(105, 270);
            lblSolucion.Name = "lblSolucion";
            lblSolucion.Size = new Size(0, 15);
            lblSolucion.TabIndex = 8;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 300);
            Controls.Add(lblSolucion);
            Controls.Add(btnMostrar);
            Controls.Add(txtAño);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblAño);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Name = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblMes;
        private Label lblAño;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAño;
        private Button btnMostrar;
        private Label lblSolucion;
    }
}