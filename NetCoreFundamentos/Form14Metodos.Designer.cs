namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            lblNumero = new Label();
            btnValor = new Button();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnReferencia = new Button();
            btnObjeto = new Button();
            lblRaton = new Label();
            lblNumeros = new Label();
            lblLetras = new Label();
            txtNumeros = new TextBox();
            txtLetras = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(23, 25);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero";
            // 
            // btnValor
            // 
            btnValor.Location = new Point(224, 43);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(75, 23);
            btnValor.TabIndex = 1;
            btnValor.Text = "Doble Valor";
            btnValor.UseVisualStyleBackColor = true;
            btnValor.Click += btnValor_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(23, 43);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(23, 109);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // btnReferencia
            // 
            btnReferencia.Location = new Point(224, 90);
            btnReferencia.Name = "btnReferencia";
            btnReferencia.Size = new Size(104, 23);
            btnReferencia.TabIndex = 4;
            btnReferencia.Text = "Doble Referencia";
            btnReferencia.UseVisualStyleBackColor = true;
            btnReferencia.Click += btnReferencia_Click;
            // 
            // btnObjeto
            // 
            btnObjeto.Location = new Point(224, 131);
            btnObjeto.Name = "btnObjeto";
            btnObjeto.Size = new Size(110, 23);
            btnObjeto.TabIndex = 5;
            btnObjeto.Text = "Objeto Referencia ";
            btnObjeto.UseVisualStyleBackColor = true;
            btnObjeto.Click += btnObjeto_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = SystemColors.ActiveCaption;
            lblRaton.ForeColor = SystemColors.ControlText;
            lblRaton.Location = new Point(359, 117);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(100, 37);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "lblRaton";
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(376, 25);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(80, 15);
            lblNumeros.TabIndex = 7;
            lblNumeros.Text = "Solo numeros";
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Location = new Point(376, 63);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(61, 15);
            lblLetras.TabIndex = 8;
            lblLetras.Text = "Solo letras";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(484, 22);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 23);
            txtNumeros.TabIndex = 9;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(484, 60);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(100, 23);
            txtLetras.TabIndex = 10;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 177);
            Controls.Add(txtLetras);
            Controls.Add(txtNumeros);
            Controls.Add(lblLetras);
            Controls.Add(lblNumeros);
            Controls.Add(lblRaton);
            Controls.Add(btnObjeto);
            Controls.Add(btnReferencia);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(btnValor);
            Controls.Add(lblNumero);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Button btnValor;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnReferencia;
        private Button btnObjeto;
        private Label lblRaton;
        private Label lblNumeros;
        private Label lblLetras;
        private TextBox txtNumeros;
        private TextBox txtLetras;
    }
}