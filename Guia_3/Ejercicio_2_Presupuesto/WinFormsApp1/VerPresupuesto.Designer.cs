﻿namespace WinFormsApp1
{
    partial class VerPresupuesto
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
            tbPresupuesto = new TextBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // tbPresupuesto
            // 
            tbPresupuesto.Location = new Point(21, 12);
            tbPresupuesto.Multiline = true;
            tbPresupuesto.Name = "tbPresupuesto";
            tbPresupuesto.Size = new Size(489, 195);
            tbPresupuesto.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(185, 232);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(160, 45);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // VerPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 303);
            Controls.Add(btnCerrar);
            Controls.Add(tbPresupuesto);
            Name = "VerPresupuesto";
            Text = "VerPresupuesto";
            Load += VerPresupuesto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrar;
        public TextBox tbPresupuesto;
    }
}