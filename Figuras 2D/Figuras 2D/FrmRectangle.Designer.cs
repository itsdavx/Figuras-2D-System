namespace Figuras_2D
{
    partial class FrmRectangle
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
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblProceso = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(34, 27);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(42, 13);
            this.lblEntradas.TabIndex = 0;
            this.lblEntradas.Text = "Inputs :";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(37, 59);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(56, 13);
            this.lblAncho.TabIndex = 1;
            this.lblAncho.Text = "Width (a) :";
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(37, 94);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(61, 13);
            this.lblLargo.TabIndex = 2;
            this.lblLargo.Text = "Length (b) :";
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(37, 148);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(51, 13);
            this.lblProceso.TabIndex = 3;
            this.lblProceso.Text = "Process :";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(40, 185);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calculate";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(155, 185);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 5;
            this.btnResetear.Text = "Reset";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(263, 184);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(38, 223);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(50, 13);
            this.lblSalida.TabIndex = 7;
            this.lblSalida.Text = "Outputs :";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(43, 253);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 8;
            this.lblPerimetro.Text = "Perimeter :";
            this.lblPerimetro.Click += new System.EventHandler(this.lblPerimetro_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(46, 286);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Area :";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(100, 52);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 10;
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(100, 86);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 20);
            this.txtLargo.TabIndex = 11;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(130, 253);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 12;
            this.txtPerimetro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(130, 286);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 13;
            this.txtArea.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Location = new System.Drawing.Point(370, 27);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(50, 13);
            this.lblGrafico.TabIndex = 14;
            this.lblGrafico.Text = "Graphic :";
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Location = new System.Drawing.Point(373, 52);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(316, 236);
            this.pnlGrafico.TabIndex = 15;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            // 
            // FrmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblEntradas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRectangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectangle";
            this.Load += new System.EventHandler(this.FrmRectangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.Panel pnlGrafico;
    }
}