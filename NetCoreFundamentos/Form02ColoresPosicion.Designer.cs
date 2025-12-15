namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            lblX = new Label();
            lblY = new Label();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            btnPosicion = new Button();
            lblRojo = new Label();
            lblVerde = new Label();
            lblAzul = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            buttonCambiar = new Button();
            SuspendLayout();
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(57, 47);
            lblX.Name = "lblX";
            lblX.Size = new Size(62, 15);
            lblX.TabIndex = 0;
            lblX.Text = "Posicion X";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(57, 108);
            lblY.Name = "lblY";
            lblY.Size = new Size(62, 15);
            lblY.TabIndex = 1;
            lblY.Text = "Posicion Y";
            lblY.Click += label2_Click;
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(57, 65);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 2;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(57, 126);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 3;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(57, 286);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(87, 46);
            btnPosicion.TabIndex = 4;
            btnPosicion.Text = "Cambiar Posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // lblRojo
            // 
            lblRojo.AutoSize = true;
            lblRojo.Location = new Point(398, 47);
            lblRojo.Name = "lblRojo";
            lblRojo.Size = new Size(31, 15);
            lblRojo.TabIndex = 5;
            lblRojo.Text = "Rojo";
            // 
            // lblVerde
            // 
            lblVerde.AutoSize = true;
            lblVerde.Location = new Point(398, 108);
            lblVerde.Name = "lblVerde";
            lblVerde.Size = new Size(36, 15);
            lblVerde.TabIndex = 6;
            lblVerde.Text = "Verde";
            lblVerde.Click += label2_Click_1;
            // 
            // lblAzul
            // 
            lblAzul.AutoSize = true;
            lblAzul.Location = new Point(398, 169);
            lblAzul.Name = "lblAzul";
            lblAzul.Size = new Size(30, 15);
            lblAzul.TabIndex = 7;
            lblAzul.Text = "Azul";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(398, 65);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(398, 126);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(398, 187);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 10;
            // 
            // buttonCambiar
            // 
            buttonCambiar.Location = new Point(398, 275);
            buttonCambiar.Name = "buttonCambiar";
            buttonCambiar.Size = new Size(75, 57);
            buttonCambiar.TabIndex = 11;
            buttonCambiar.Text = "Cambiar Fondo";
            buttonCambiar.UseVisualStyleBackColor = true;
            buttonCambiar.Click += buttonCambiar_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCambiar);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(lblAzul);
            Controls.Add(lblVerde);
            Controls.Add(lblRojo);
            Controls.Add(btnPosicion);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblX;
        private Label lblY;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private Button btnPosicion;
        private Label lblRojo;
        private Label lblVerde;
        private Label lblAzul;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button buttonCambiar;
    }
}