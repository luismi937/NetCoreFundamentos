namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            lblElementos = new Label();
            lstElementos = new ListBox();
            lblElemento = new Label();
            txtNuevo = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lblItem = new Label();
            lblIndex = new Label();
            SuspendLayout();
            // 
            // lblElementos
            // 
            lblElementos.AutoSize = true;
            lblElementos.Location = new Point(12, 27);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(62, 15);
            lblElementos.TabIndex = 0;
            lblElementos.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(12, 66);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 1;
            // 
            // lblElemento
            // 
            lblElemento.AutoSize = true;
            lblElemento.Location = new Point(255, 27);
            lblElemento.Name = "lblElemento";
            lblElemento.Size = new Size(95, 15);
            lblElemento.TabIndex = 2;
            lblElemento.Text = "Nuevo Elemento";
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(255, 66);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(100, 23);
            txtNuevo.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(255, 109);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(255, 138);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(255, 167);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(95, 23);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(36, 186);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(44, 15);
            lblItem.TabIndex = 7;
            lblItem.Text = "lblItem";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(36, 221);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(49, 15);
            lblIndex.TabIndex = 8;
            lblIndex.Text = "lblIndex";
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 282);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevo);
            Controls.Add(lblElemento);
            Controls.Add(lstElementos);
            Controls.Add(lblElementos);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblElementos;
        private ListBox lstElementos;
        private Label lblElemento;
        private TextBox txtNuevo;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblItem;
        private Label lblIndex;
    }
}