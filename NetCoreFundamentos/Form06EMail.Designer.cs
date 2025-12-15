namespace NetCoreFundamentos
{
    partial class Form06EMail
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
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnValidar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(21, 34);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(90, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Introduce Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(21, 64);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(134, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(36, 168);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(100, 25);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar email";
            btnValidar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(52, 227);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form06EMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 299);
            Controls.Add(lblResultado);
            Controls.Add(btnValidar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "Form06EMail";
            Text = "Form06EMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnValidar;
        private Label lblResultado;
    }
}