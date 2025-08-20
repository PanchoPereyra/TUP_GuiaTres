namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciar = new Button();
            btnAgregar = new Button();
            btnVer = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            lbCliente = new Label();
            lbDireccion = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(33, 44);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(141, 35);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Presupuesto";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 100);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 33);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(33, 148);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(141, 34);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver Presupuesto";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(33, 201);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(141, 31);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 100);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 147);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Dirección:";
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Location = new Point(272, 100);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(12, 15);
            lbCliente.TabIndex = 6;
            lbCliente.Text = "-";
            lbCliente.Click += label3_Click;
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Location = new Point(272, 148);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(12, 15);
            lbDireccion.TabIndex = 7;
            lbDireccion.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 271);
            Controls.Add(lbDireccion);
            Controls.Add(lbCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnVer);
            Controls.Add(btnAgregar);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnAgregar;
        private Button btnVer;
        private Button btnCerrar;
        private Label label1;
        private Label label2;
        public Label lbCliente;
        public Label lbDireccion;
    }
}
