namespace Figuras_2D
{
    partial class FrmHeart
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
            this.PanelGrafico = new System.Windows.Forms.Panel();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelGrafico
            // 
            this.PanelGrafico.Location = new System.Drawing.Point(42, 178);
            this.PanelGrafico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelGrafico.Name = "PanelGrafico";
            this.PanelGrafico.Size = new System.Drawing.Size(0, 0);
            this.PanelGrafico.TabIndex = 37;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(259, 79);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(84, 29);
            this.btnGraficar.TabIndex = 36;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "cm";
            // 
            // txtTamano
            // 
            this.txtTamano.Location = new System.Drawing.Point(125, 79);
            this.txtTamano.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(58, 26);
            this.txtTamano.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tamaño:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gráfico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Inputs:";
            // 
            // FrmHeart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2007, 1326);
            this.Controls.Add(this.PanelGrafico);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTamano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHeart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGrafico;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}