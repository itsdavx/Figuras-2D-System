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
            this.pnlGrafico.BackColor = System.Drawing.Color.White;
            this.pnlGrafico.Location = new System.Drawing.Point(437, 48);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(555, 519);
            this.pnlGrafico.TabIndex = 47;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrafico.Location = new System.Drawing.Point(434, 23);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(82, 20);
            this.lblGrafico.TabIndex = 46;
            this.lblGrafico.Text = "Graphic :";
            // 
            // txtAnchoDelCuerpo
            // 
            this.txtAnchoDelCuerpo.Location = new System.Drawing.Point(206, 83);
            this.txtAnchoDelCuerpo.Name = "txtAnchoDelCuerpo";
            this.txtAnchoDelCuerpo.Size = new System.Drawing.Size(100, 20);
            this.txtAnchoDelCuerpo.TabIndex = 43;
            this.txtAnchoDelCuerpo.TextChanged += new System.EventHandler(this.txtAnchoDelCuerpo_TextChanged);
            // 
            // txtLargoDelCuerpo
            // 
            this.txtLargoDelCuerpo.Location = new System.Drawing.Point(206, 48);
            this.txtLargoDelCuerpo.Name = "txtLargoDelCuerpo";
            this.txtLargoDelCuerpo.Size = new System.Drawing.Size(100, 20);
            this.txtLargoDelCuerpo.TabIndex = 42;
            this.txtLargoDelCuerpo.TextChanged += new System.EventHandler(this.txtLargoDelCuerpo_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Thistle;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(86, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 32);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.AliceBlue;
            this.btnResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.Location = new System.Drawing.Point(86, 245);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(94, 33);
            this.btnResetear.TabIndex = 37;
            this.btnResetear.Text = "Reset";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(85, 181);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 38);
            this.btnCalcular.TabIndex = 36;
            this.btnCalcular.Text = "Calculate";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProceso.Location = new System.Drawing.Point(82, 152);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(83, 20);
            this.lblProceso.TabIndex = 35;
            this.lblProceso.Text = "Process :";
            // 
            // lblAnchoDelCuerpo
            // 
            this.lblAnchoDelCuerpo.AutoSize = true;
            this.lblAnchoDelCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnchoDelCuerpo.Location = new System.Drawing.Point(82, 90);
            this.lblAnchoDelCuerpo.Name = "lblAnchoDelCuerpo";
            this.lblAnchoDelCuerpo.Size = new System.Drawing.Size(112, 16);
            this.lblAnchoDelCuerpo.TabIndex = 34;
            this.lblAnchoDelCuerpo.Text = "Rectangle Width :";
            // 
            // lblLargoDelCuerpo
            // 
            this.lblLargoDelCuerpo.AutoSize = true;
            this.lblLargoDelCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargoDelCuerpo.Location = new System.Drawing.Point(82, 52);
            this.lblLargoDelCuerpo.Name = "lblLargoDelCuerpo";
            this.lblLargoDelCuerpo.Size = new System.Drawing.Size(118, 16);
            this.lblLargoDelCuerpo.TabIndex = 33;
            this.lblLargoDelCuerpo.Text = "Rectangle Length :";
            this.lblLargoDelCuerpo.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEntradas.Location = new System.Drawing.Point(79, 23);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(70, 20);
            this.lblEntradas.TabIndex = 32;
            this.lblEntradas.Text = "Inputs :";
            this.lblEntradas.Click += new System.EventHandler(this.lblEntradas_Click);
            // 
            // lblLadoDelTriangulo
            // 
            this.lblLadoDelTriangulo.AutoSize = true;
            this.lblLadoDelTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoDelTriangulo.Location = new System.Drawing.Point(83, 122);
            this.lblLadoDelTriangulo.Name = "lblLadoDelTriangulo";
            this.lblLadoDelTriangulo.Size = new System.Drawing.Size(94, 16);
            this.lblLadoDelTriangulo.TabIndex = 48;
            this.lblLadoDelTriangulo.Text = "Triangle Side :";
            // 
            // txtLadoDelTrianguloEquilatero
            // 
            this.txtLadoDelTrianguloEquilatero.Location = new System.Drawing.Point(206, 115);
            this.txtLadoDelTrianguloEquilatero.Name = "txtLadoDelTrianguloEquilatero";
            this.txtLadoDelTrianguloEquilatero.Size = new System.Drawing.Size(100, 20);
            this.txtLadoDelTrianguloEquilatero.TabIndex = 49;
            this.txtLadoDelTrianguloEquilatero.TextChanged += new System.EventHandler(this.txtLadoDelTrianguloEquilatero_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(91, 441);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 16);
            this.lblArea.TabIndex = 41;
            this.lblArea.Text = "Area :";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(88, 408);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(71, 16);
            this.lblPerimetro.TabIndex = 40;
            this.lblPerimetro.Text = "Perimeter :";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(83, 378);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(83, 20);
            this.lblSalida.TabIndex = 39;
            this.lblSalida.Text = "Outputs :";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(175, 441);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 45;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(175, 408);
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
            this.Load += new System.EventHandler(this.FrmArrow_Load);
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