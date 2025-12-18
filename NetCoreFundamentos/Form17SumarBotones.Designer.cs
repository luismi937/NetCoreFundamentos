namespace NetCoreFundamentos
{
    partial class Form17SumarBotones
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
            btnIniciar = new Button();
            lblSuma = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(271, 20);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(82, 23);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar App";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(24, 20);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(37, 15);
            lblSuma.TabIndex = 1;
            lblSuma.Text = "Suma";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 203);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(37, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(61, 70);
            button2.Name = "button2";
            button2.Size = new Size(38, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(19, 70);
            button3.Name = "button3";
            button3.Size = new Size(30, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(61, 41);
            button4.Name = "button4";
            button4.Size = new Size(30, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(16, 41);
            button5.Name = "button5";
            button5.Size = new Size(33, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(56, 12);
            button6.Name = "button6";
            button6.Size = new Size(35, 23);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form17SumarBotones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 292);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(lblSuma);
            Controls.Add(btnIniciar);
            Name = "Form17SumarBotones";
            Text = "Form17SumarBotones";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Label lblSuma;
        private TextBox textBox1;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}