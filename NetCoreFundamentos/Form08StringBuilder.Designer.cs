namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            lblCopiar = new Label();
            txtRich = new RichTextBox();
            lblTiempo = new Label();
            btnString = new Button();
            btnStringBuilder = new Button();
            SuspendLayout();
            // 
            // lblCopiar
            // 
            lblCopiar.AutoSize = true;
            lblCopiar.Location = new Point(15, 18);
            lblCopiar.Name = "lblCopiar";
            lblCopiar.Size = new Size(149, 15);
            lblCopiar.TabIndex = 0;
            lblCopiar.Text = "Copie el texto para trabajar";
            // 
            // txtRich
            // 
            txtRich.Location = new Point(15, 55);
            txtRich.Name = "txtRich";
            txtRich.Size = new Size(187, 127);
            txtRich.TabIndex = 1;
            txtRich.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(40, 209);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(60, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "lblTiempo";
            // 
            // btnString
            // 
            btnString.Location = new Point(12, 252);
            btnString.Name = "btnString";
            btnString.Size = new Size(103, 23);
            btnString.TabIndex = 3;
            btnString.Text = "invertir String ";
            btnString.UseVisualStyleBackColor = true;
            // 
            // btnStringBuilder
            // 
            btnStringBuilder.Location = new Point(144, 252);
            btnStringBuilder.Name = "btnStringBuilder";
            btnStringBuilder.Size = new Size(159, 23);
            btnStringBuilder.TabIndex = 4;
            btnStringBuilder.Text = "Invertir stringBuilder";
            btnStringBuilder.UseVisualStyleBackColor = true;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 287);
            Controls.Add(btnStringBuilder);
            Controls.Add(btnString);
            Controls.Add(lblTiempo);
            Controls.Add(txtRich);
            Controls.Add(lblCopiar);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCopiar;
        private RichTextBox txtRich;
        private Label lblTiempo;
        private Button btnString;
        private Button btnStringBuilder;
    }
}