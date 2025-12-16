namespace NetCoreFundamentos
{
    partial class Form09Isbn
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
            label1 = new Label();
            txtIsbn = new TextBox();
            label2 = new Label();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(12, 36);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(164, 23);
            txtIsbn.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 146);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(28, 100);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(81, 23);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 260);
            Controls.Add(btnValidar);
            Controls.Add(label2);
            Controls.Add(txtIsbn);
            Controls.Add(label1);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIsbn;
        private Label label2;
        private Button btnValidar;
    }
}