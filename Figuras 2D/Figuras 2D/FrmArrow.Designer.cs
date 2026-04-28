namespace Figuras_2D
{
    partial class FrmArrow
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
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.txtAnchoDelCuerpo = new System.Windows.Forms.TextBox();
            this.txtLargoDelCuerpo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lblAnchoDelCuerpo = new System.Windows.Forms.Label();
            this.lblLargoDelCuerpo = new System.Windows.Forms.Label();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblLadoDelTriangulo = new System.Windows.Forms.Label();
            this.txtLadoDelTrianguloEquilatero = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Location = new System.Drawing.Point(437, 48);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(282, 247);
            this.pnlGrafico.TabIndex = 47;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Location = new System.Drawing.Point(434, 23);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(50, 13);
            this.lblGrafico.TabIndex = 46;
            this.lblGrafico.Text = "Graphic :";
            // 
            // txtAnchoDelCuerpo
            // 
            this.txtAnchoDelCuerpo.Location = new System.Drawing.Point(186, 83);
            this.txtAnchoDelCuerpo.Name = "txtAnchoDelCuerpo";
            this.txtAnchoDelCuerpo.Size = new System.Drawing.Size(100, 20);
            this.txtAnchoDelCuerpo.TabIndex = 43;
            this.txtAnchoDelCuerpo.TextChanged += new System.EventHandler(this.txtAnchoDelCuerpo_TextChanged);
            // 
            // txtLargoDelCuerpo
            // 
            this.txtLargoDelCuerpo.Location = new System.Drawing.Point(186, 48);
            this.txtLargoDelCuerpo.Name = "txtLargoDelCuerpo";
            this.txtLargoDelCuerpo.Size = new System.Drawing.Size(100, 20);
            this.txtLargoDelCuerpo.TabIndex = 42;
            this.txtLargoDelCuerpo.TextChanged += new System.EventHandler(this.txtLargoDelCuerpo_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(308, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(200, 181);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 37;
            this.btnResetear.Text = "Reset";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(85, 181);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 36;
            this.btnCalcular.Text = "Calculate";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(82, 152);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(51, 13);
            this.lblProceso.TabIndex = 35;
            this.lblProceso.Text = "Process :";
            // 
            // lblAnchoDelCuerpo
            // 
            this.lblAnchoDelCuerpo.AutoSize = true;
            this.lblAnchoDelCuerpo.Location = new System.Drawing.Point(82, 90);
            this.lblAnchoDelCuerpo.Name = "lblAnchoDelCuerpo";
            this.lblAnchoDelCuerpo.Size = new System.Drawing.Size(93, 13);
            this.lblAnchoDelCuerpo.TabIndex = 34;
            this.lblAnchoDelCuerpo.Text = "Rectangle Width :";
            // 
            // lblLargoDelCuerpo
            // 
            this.lblLargoDelCuerpo.AutoSize = true;
            this.lblLargoDelCuerpo.Location = new System.Drawing.Point(82, 55);
            this.lblLargoDelCuerpo.Name = "lblLargoDelCuerpo";
            this.lblLargoDelCuerpo.Size = new System.Drawing.Size(98, 13);
            this.lblLargoDelCuerpo.TabIndex = 33;
            this.lblLargoDelCuerpo.Text = "Rectangle Length :";
            this.lblLargoDelCuerpo.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(79, 23);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(42, 13);
            this.lblEntradas.TabIndex = 32;
            this.lblEntradas.Text = "Inputs :";
            // 
            // lblLadoDelTriangulo
            // 
            this.lblLadoDelTriangulo.AutoSize = true;
            this.lblLadoDelTriangulo.Location = new System.Drawing.Point(83, 122);
            this.lblLadoDelTriangulo.Name = "lblLadoDelTriangulo";
            this.lblLadoDelTriangulo.Size = new System.Drawing.Size(75, 13);
            this.lblLadoDelTriangulo.TabIndex = 48;
            this.lblLadoDelTriangulo.Text = "Triangle Side :";
            // 
            // txtLadoDelTrianguloEquilatero
            // 
            this.txtLadoDelTrianguloEquilatero.Location = new System.Drawing.Point(186, 122);
            this.txtLadoDelTrianguloEquilatero.Name = "txtLadoDelTrianguloEquilatero";
            this.txtLadoDelTrianguloEquilatero.Size = new System.Drawing.Size(100, 20);
            this.txtLadoDelTrianguloEquilatero.TabIndex = 49;
            this.txtLadoDelTrianguloEquilatero.TextChanged += new System.EventHandler(this.txtLadoDelTrianguloEquilatero_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(91, 282);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 41;
            this.lblArea.Text = "Area :";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(88, 249);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 40;
            this.lblPerimetro.Text = "Perimeter :";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(83, 219);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(50, 13);
            this.lblSalida.TabIndex = 39;
            this.lblSalida.Text = "Outputs :";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(175, 282);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 45;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(175, 249);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 44;
            // 
            // FrmArrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.txtLadoDelTrianguloEquilatero);
            this.Controls.Add(this.lblLadoDelTriangulo);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtAnchoDelCuerpo);
            this.Controls.Add(this.txtLargoDelCuerpo);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.lblAnchoDelCuerpo);
            this.Controls.Add(this.lblLargoDelCuerpo);
            this.Controls.Add(this.lblEntradas);
            this.Name = "FrmArrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.TextBox txtAnchoDelCuerpo;
        private System.Windows.Forms.TextBox txtLargoDelCuerpo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lblAnchoDelCuerpo;
        private System.Windows.Forms.Label lblLargoDelCuerpo;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblLadoDelTriangulo;
        private System.Windows.Forms.TextBox txtLadoDelTrianguloEquilatero;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
    }
}