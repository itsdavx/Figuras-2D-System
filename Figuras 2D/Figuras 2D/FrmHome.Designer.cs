namespace Figuras_2D
{
    partial class FrmHome
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
            this.miCircle = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // miCircle
            // 
            this.miCircle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miCircle.Location = new System.Drawing.Point(0, 0);
            this.miCircle.Name = "miCircle";
            this.miCircle.Size = new System.Drawing.Size(1326, 28);
            this.miCircle.TabIndex = 0;
            this.miCircle.Text = "Circle";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 825);
            this.Controls.Add(this.miCircle);
            this.MainMenuStrip = this.miCircle;
            this.Name = "FrmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip miCircle;
    }
}

