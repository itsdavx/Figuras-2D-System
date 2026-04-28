namespace Figuras_2D
{
    partial class FrmRightTriangle
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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblHipotenusa = new System.Windows.Forms.Label();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Location = new System.Drawing.Point(379, 49);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(200, 100);
            this.pnlGrafico.TabIndex = 31;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Location = new System.Drawing.Point(387, 31);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(50, 13);
            this.lblGrafico.TabIndex = 30;
            this.lblGrafico.Text = "Graphic :";
            this.lblGrafico.Click += new System.EventHandler(this.lblGrafico_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(166, 290);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 29;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(166, 257);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 28;
            this.txtPerimetro.TextChanged += new System.EventHandler(this.txtPerimetro_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(136, 90);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 27;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(136, 56);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 26;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(82, 290);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 25;
            this.lblArea.Text = "Area :";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(79, 257);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 24;
            this.lblPerimetro.Text = "Perimeter :";
            this.lblPerimetro.Click += new System.EventHandler(this.lblPerimetro_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(74, 227);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(50, 13);
            this.lblSalida.TabIndex = 23;
            this.lblSalida.Text = "Outputs :";
            this.lblSalida.Click += new System.EventHandler(this.lblSalida_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(299, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(191, 189);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 21;
            this.btnResetear.Text = "Reset";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(76, 189);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calculate";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(73, 152);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(51, 13);
            this.lblProceso.TabIndex = 19;
            this.lblProceso.Text = "Process :";
            this.lblProceso.Click += new System.EventHandler(this.lblProceso_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(73, 98);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(59, 13);
            this.lblAltura.TabIndex = 18;
            this.lblAltura.Text = "Height (h) :";
            this.lblAltura.Click += new System.EventHandler(this.lblLargo_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(73, 63);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(52, 13);
            this.lblBase.TabIndex = 17;
            this.lblBase.Text = "Base (b) :";
            this.lblBase.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(70, 31);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(42, 13);
            this.lblEntradas.TabIndex = 16;
            this.lblEntradas.Text = "Inputs :";
            this.lblEntradas.Click += new System.EventHandler(this.lblEntradas_Click);
            // 
            // lblHipotenusa
            // 
            this.lblHipotenusa.AutoSize = true;
            this.lblHipotenusa.Location = new System.Drawing.Point(84, 328);
            this.lblHipotenusa.Name = "lblHipotenusa";
            this.lblHipotenusa.Size = new System.Drawing.Size(67, 13);
            this.lblHipotenusa.TabIndex = 32;
            this.lblHipotenusa.Text = "Hypotenuse:";
            this.lblHipotenusa.Click += new System.EventHandler(this.lblHipotenusa_Click);
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.Location = new System.Drawing.Point(166, 321);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(100, 20);
            this.txtHipotenusa.TabIndex = 33;
            this.txtHipotenusa.TextChanged += new System.EventHandler(this.txtHipotenusa_TextChanged);
            // 
            // FrmRightTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.txtHipotenusa);
            this.Controls.Add(this.lblHipotenusa);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblEntradas);
            this.Name = "FrmRightTriangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Right Triangle";
            this.Load += new System.EventHandler(this.FrmRightTriangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblHipotenusa;
        private System.Windows.Forms.TextBox txtHipotenusa;
    }
}