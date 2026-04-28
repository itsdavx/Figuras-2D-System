namespace Figuras_2D
{
    partial class FrmNonagon
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
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Location = new System.Drawing.Point(384, 41);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(264, 254);
            this.pnlGrafico.TabIndex = 49;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Location = new System.Drawing.Point(392, 23);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(50, 13);
            this.lblGrafico.TabIndex = 48;
            this.lblGrafico.Text = "Graphic :";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(156, 255);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 47;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(156, 217);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 46;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(141, 48);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 44;
            this.txtLado.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(82, 262);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 43;
            this.lblArea.Text = "Area :";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(76, 217);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(57, 13);
            this.lblPerimetro.TabIndex = 42;
            this.lblPerimetro.Text = "Perimeter :";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(76, 181);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(50, 13);
            this.lblSalida.TabIndex = 41;
            this.lblSalida.Text = "Outputs :";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(281, 133);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(181, 133);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(75, 23);
            this.btnResetear.TabIndex = 39;
            this.btnResetear.Text = "Reset";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(78, 133);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 38;
            this.btnCalcular.Text = "Calculate";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(75, 98);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(51, 13);
            this.lblProceso.TabIndex = 37;
            this.lblProceso.Text = "Process :";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(78, 55);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(49, 13);
            this.lblLado.TabIndex = 35;
            this.lblLado.Text = "Side (L) :";
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(75, 23);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(42, 13);
            this.lblEntradas.TabIndex = 34;
            this.lblEntradas.Text = "Inputs :";
            // 
            // FrmNonagon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblEntradas);
            this.Name = "FrmNonagon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nonagon";
            this.Load += new System.EventHandler(this.FrmNonagon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblEntradas;
    }
}