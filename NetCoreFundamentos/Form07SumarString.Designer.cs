namespace NetCoreFundamentos
{
    partial class Form07SumarString
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
            lblIntroducir = new Label();
            txtNumeros = new TextBox();
            btnMostrar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblIntroducir
            // 
            lblIntroducir.AutoSize = true;
            lblIntroducir.Location = new Point(12, 23);
            lblIntroducir.Name = "lblIntroducir";
            lblIntroducir.Size = new Size(111, 15);
            lblIntroducir.TabIndex = 0;
            lblIntroducir.Text = "Introducir Numeros";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(12, 53);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 23);
            txtNumeros.TabIndex = 1;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(26, 152);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(36, 116);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 278);
            Controls.Add(lblResultado);
            Controls.Add(btnMostrar);
            Controls.Add(txtNumeros);
            Controls.Add(lblIntroducir);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIntroducir;
        private TextBox txtNumeros;
        private Button btnMostrar;
        private Label lblResultado;
    }
}