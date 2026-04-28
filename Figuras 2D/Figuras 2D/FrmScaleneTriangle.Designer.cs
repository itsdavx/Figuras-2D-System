namespace Figuras_2D
{
    partial class FrmScaleneTriangle
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
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Location = new System.Drawing.Point(428, 51);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(318, 293);
            this.pnlGrafico.TabIndex = 47;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Location = new System.Drawing.Point(415, 26);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(50, 13);
            this.lblGrafico.TabIndex = 46;
            this.lblGrafico.Text = "Graphic :";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(194, 285);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 45;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(194, 252);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 44;
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(164, 85);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(100, 20);
            this.txtLadoB.TabIndex = 43;
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(164, 51);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(100, 20);
            this.txtLadoA.TabIndex = 42;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(110, 285);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 41;
            this.lblArea.Text = "Area :";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(107, 252);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 40;
            this.lblPerimetro.Text = "Perimeter :";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(102, 222);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(50, 13);
            this.lblSalida.TabIndex = 39;
            this.lblSalida.Text = "Outputs :";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(327, 183);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(219, 184);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 37;
            this.btnResetear.Text = "Reset";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(104, 184);
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
            this.lblProceso.Location = new System.Drawing.Point(99, 156);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(51, 13);
            this.lblProceso.TabIndex = 35;
            this.lblProceso.Text = "Process :";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(103, 92);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(49, 13);
            this.lblLadoB.TabIndex = 34;
            this.lblLadoB.Text = "Side (b) :";
            this.lblLadoB.Click += new System.EventHandler(this.lblLadoB_Click);
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(101, 58);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(49, 13);
            this.lblLadoA.TabIndex = 33;
            this.lblLadoA.Text = "Side (a) :";
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(98, 26);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(42, 13);
            this.lblEntradas.TabIndex = 32;
            this.lblEntradas.Text = "Inputs :";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(103, 123);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(49, 13);
            this.lblLadoC.TabIndex = 50;
            this.lblLadoC.Text = "Side (c) ;";
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(164, 123);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(100, 20);
            this.txtLadoC.TabIndex = 51;
            // 
            // FrmScaleneTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.lblEntradas);
            this.Name = "FrmScaleneTriangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scalene Triangle";
            this.Load += new System.EventHandler(this.FrmScaleneTriangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtLadoC;
    }
}