﻿namespace WFGit
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.butAceptar = new System.Windows.Forms.Button();
            this.butsegundo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(397, 135);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 0;
            this.butAceptar.Text = "aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            // 
            // butsegundo
            // 
            this.butsegundo.Location = new System.Drawing.Point(483, 245);
            this.butsegundo.Name = "butsegundo";
            this.butsegundo.Size = new System.Drawing.Size(75, 23);
            this.butsegundo.TabIndex = 1;
            this.butsegundo.Text = "segundo";
            this.butsegundo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butsegundo);
            this.Controls.Add(this.butAceptar);
            this.Name = "Form1";
            this.Text = "FORMULARIOejemModificado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butsegundo;
    }
}

