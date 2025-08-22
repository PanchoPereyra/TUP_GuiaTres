namespace WinFormsApp1
{
    partial class FormAgregar
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbLargo = new TextBox();
            tbDescripcion = new TextBox();
            tbPrecio = new TextBox();
            cbProducto = new ComboBox();
            cbMaterial = new ComboBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(25, 252);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 36);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(204, 252);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 76);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Largo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 118);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 160);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 202);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 6;
            label5.Text = "Material:";
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(135, 65);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(144, 23);
            tbLargo.TabIndex = 8;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(135, 107);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(144, 23);
            tbDescripcion.TabIndex = 9;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(135, 148);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(144, 23);
            tbPrecio.TabIndex = 10;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Items.AddRange(new object[] { "Mesa" });
            cbProducto.Location = new Point(135, 26);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(144, 23);
            cbProducto.TabIndex = 12;
            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Location = new Point(135, 194);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(144, 23);
            cbMaterial.TabIndex = 13;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 329);
            Controls.Add(cbMaterial);
            Controls.Add(cbProducto);
            Controls.Add(tbPrecio);
            Controls.Add(tbDescripcion);
            Controls.Add(tbLargo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TextBox tbLargo;
        public TextBox tbDescripcion;
        public TextBox tbPrecio;
        public ComboBox cbProducto;
        public ComboBox cbMaterial;
    }
}