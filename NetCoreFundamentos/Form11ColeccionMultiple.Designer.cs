namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblIndex = new Label();
            lblItem = new Label();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtNuevo = new TextBox();
            lblElemento = new Label();
            lstElementos = new ListBox();
            lblElementos = new Label();
            label1 = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(49, 246);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(49, 15);
            lblIndex.TabIndex = 27;
            lblIndex.Text = "lblIndex";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(49, 211);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(44, 15);
            lblItem.TabIndex = 26;
            lblItem.Text = "lblItem";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(268, 192);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(95, 23);
            btnBorrarTodo.TabIndex = 25;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(268, 163);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(268, 134);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 23;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(268, 91);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(100, 23);
            txtNuevo.TabIndex = 22;
            // 
            // lblElemento
            // 
            lblElemento.AutoSize = true;
            lblElemento.Location = new Point(268, 52);
            lblElemento.Name = "lblElemento";
            lblElemento.Size = new Size(95, 15);
            lblElemento.TabIndex = 21;
            lblElemento.Text = "Nuevo Elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(25, 91);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 20;
            // 
            // lblElementos
            // 
            lblElementos.AutoSize = true;
            lblElementos.Location = new Point(25, 52);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(62, 15);
            lblElementos.TabIndex = 19;
            lblElementos.Text = "Elementos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 45);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(268, 221);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(75, 24);
            btnSeleccionados.TabIndex = 28;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 307);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevo);
            Controls.Add(lblElemento);
            Controls.Add(lstElementos);
            Controls.Add(lblElementos);
            Controls.Add(label1);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndex;
        private Label lblItem;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtNuevo;
        private Label lblElemento;
        private ListBox lstElementos;
        private Label lblElementos;
        private Label label1;
        private Button btnSeleccionados;
    }
}