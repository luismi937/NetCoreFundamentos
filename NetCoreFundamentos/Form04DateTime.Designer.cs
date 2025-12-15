namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            lblFecha = new Label();
            txtFecha = new TextBox();
            chkFormato = new CheckBox();
            lblIncremento = new Label();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            txtIncremento = new TextBox();
            btnIncremento = new Button();
            lblFechaFinal = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(53, 48);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(73, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha actual";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(53, 66);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(259, 23);
            txtFecha.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(53, 108);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(90, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "chkFormato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // lblIncremento
            // 
            lblIncremento.AutoSize = true;
            lblIncremento.Location = new Point(287, 163);
            lblIncremento.Name = "lblIncremento";
            lblIncremento.Size = new Size(81, 15);
            lblIncremento.TabIndex = 3;
            lblIncremento.Text = "lblIncremento";
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(53, 133);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(65, 19);
            rdbDias.TabIndex = 4;
            rdbDias.TabStop = true;
            rdbDias.Text = "rdbDias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(54, 159);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(76, 19);
            rdbMeses.TabIndex = 5;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "rdbMeses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(53, 184);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(76, 19);
            rdbAnyos.TabIndex = 6;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "rdbAnyos";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(390, 160);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(303, 212);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(138, 23);
            btnIncremento.TabIndex = 8;
            btnIncremento.Text = "Incremento";
            btnIncremento.UseVisualStyleBackColor = true;
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Location = new Point(59, 325);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(66, 15);
            lblFechaFinal.TabIndex = 9;
            lblFechaFinal.Text = "Fecha Final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(58, 351);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(343, 23);
            txtFechaFinal.TabIndex = 10;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 390);
            Controls.Add(txtFechaFinal);
            Controls.Add(lblFechaFinal);
            Controls.Add(btnIncremento);
            Controls.Add(txtIncremento);
            Controls.Add(rdbAnyos);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(lblIncremento);
            Controls.Add(chkFormato);
            Controls.Add(txtFecha);
            Controls.Add(lblFecha);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private TextBox txtFecha;
        private CheckBox chkFormato;
        private Label lblIncremento;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private TextBox txtIncremento;
        private Button btnIncremento;
        private Label lblFechaFinal;
        private TextBox txtFechaFinal;
    }
}