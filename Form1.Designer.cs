namespace Ejercicio23
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
            this.BotonIntro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonIntro
            // 
            this.BotonIntro.Location = new System.Drawing.Point(287, 141);
            this.BotonIntro.Name = "BotonIntro";
            this.BotonIntro.Size = new System.Drawing.Size(217, 107);
            this.BotonIntro.TabIndex = 0;
            this.BotonIntro.Text = "App Introducir Peso";
            this.BotonIntro.UseVisualStyleBackColor = true;
            this.BotonIntro.Click += new System.EventHandler(this.BotonIntro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonIntro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonIntro;
    }
}

