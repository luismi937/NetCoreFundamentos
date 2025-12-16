namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            lblNumeros = new Label();
            lstNumeros = new ListBox();
            lblSuma = new Label();
            btnGenerar = new Button();
            btnMostrar = new Button();
            lblPares = new Label();
            lblimpares = new Label();
            txtPares = new TextBox();
            txtSuma = new TextBox();
            txtImpares = new TextBox();
            SuspendLayout();
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(12, 32);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(56, 15);
            lblNumeros.TabIndex = 0;
            lblNumeros.Text = "Numeros";
            lblNumeros.Click += label1_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(0, 60);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(120, 94);
            lstNumeros.TabIndex = 1;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(142, 110);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(37, 15);
            lblSuma.TabIndex = 2;
            lblSuma.Text = "Suma";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(195, 12);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(123, 23);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Generar Numeros";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(195, 41);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(123, 23);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblPares
            // 
            lblPares.AutoSize = true;
            lblPares.Location = new Point(142, 139);
            lblPares.Name = "lblPares";
            lblPares.Size = new Size(35, 15);
            lblPares.TabIndex = 6;
            lblPares.Text = "Pares";
            // 
            // lblimpares
            // 
            lblimpares.AutoSize = true;
            lblimpares.Location = new Point(142, 164);
            lblimpares.Name = "lblimpares";
            lblimpares.Size = new Size(49, 15);
            lblimpares.TabIndex = 7;
            lblimpares.Text = "Impares";
            // 
            // txtPares
            // 
            txtPares.Location = new Point(186, 131);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 8;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(186, 102);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 9;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(186, 156);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 10;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 218);
            Controls.Add(txtImpares);
            Controls.Add(txtSuma);
            Controls.Add(txtPares);
            Controls.Add(lblimpares);
            Controls.Add(lblPares);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(lblSuma);
            Controls.Add(lstNumeros);
            Controls.Add(lblNumeros);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeros;
        private ListBox lstNumeros;
        private Label lblSuma;
        private Button btnGenerar;
        private Button btnMostrar;
        private Label lblPares;
        private Label lblimpares;
        private TextBox txtPares;
        private TextBox txtSuma;
        private TextBox txtImpares;
    }
}