namespace NetCoreFundamentos
{
    partial class Fom05Char
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
            lblLetras = new Label();
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            lblNumeros = new Label();
            txtSimbolos = new TextBox();
            lblSimbolos = new Label();
            txtPuntuacion = new TextBox();
            lblPuntuacion = new Label();
            btnASCII = new Button();
            SuspendLayout();
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Location = new Point(12, 40);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(38, 15);
            lblLetras.TabIndex = 0;
            lblLetras.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(12, 58);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(224, 133);
            txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(252, 58);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(224, 133);
            txtNumeros.TabIndex = 3;
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(252, 40);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(56, 15);
            lblNumeros.TabIndex = 2;
            lblNumeros.Text = "Numeros";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(12, 239);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(224, 133);
            txtSimbolos.TabIndex = 5;
            // 
            // lblSimbolos
            // 
            lblSimbolos.AutoSize = true;
            lblSimbolos.Location = new Point(12, 221);
            lblSimbolos.Name = "lblSimbolos";
            lblSimbolos.Size = new Size(56, 15);
            lblSimbolos.TabIndex = 4;
            lblSimbolos.Text = "Simbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(252, 239);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(224, 133);
            txtPuntuacion.TabIndex = 7;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(252, 221);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(62, 15);
            lblPuntuacion.TabIndex = 6;
            lblPuntuacion.Text = "Puntucion";
            // 
            // btnASCII
            // 
            btnASCII.Location = new Point(187, 417);
            btnASCII.Name = "btnASCII";
            btnASCII.Size = new Size(75, 49);
            btnASCII.TabIndex = 8;
            btnASCII.Text = "Boton ASCII";
            btnASCII.UseVisualStyleBackColor = true;
            // 
            // Fom05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 505);
            Controls.Add(btnASCII);
            Controls.Add(txtPuntuacion);
            Controls.Add(lblPuntuacion);
            Controls.Add(txtSimbolos);
            Controls.Add(lblSimbolos);
            Controls.Add(txtNumeros);
            Controls.Add(lblNumeros);
            Controls.Add(txtLetras);
            Controls.Add(lblLetras);
            Name = "Fom05Char";
            Text = "Fom05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLetras;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label lblNumeros;
        private TextBox txtSimbolos;
        private Label lblSimbolos;
        private TextBox txtPuntuacion;
        private Label lblPuntuacion;
        private Button btnASCII;
    }
}