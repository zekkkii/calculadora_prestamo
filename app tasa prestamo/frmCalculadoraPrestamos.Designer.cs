
namespace app_tasa_prestamo
{
    partial class frmCalculadoraPrestamos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraPrestamos));
            this.lblMontoPrestamo = new System.Windows.Forms.Label();
            this.cbxCuotasMensuales = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.lblCuotasMensuales = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbCuotaMensual = new System.Windows.Forms.TextBox();
            this.lblTipoPrestamo = new System.Windows.Forms.Label();
            this.cbxTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.txbMonto = new System.Windows.Forms.NumericUpDown();
            this.txbTasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txbMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMontoPrestamo
            // 
            this.lblMontoPrestamo.AutoSize = true;
            this.lblMontoPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoPrestamo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontoPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMontoPrestamo.Location = new System.Drawing.Point(229, 112);
            this.lblMontoPrestamo.Name = "lblMontoPrestamo";
            this.lblMontoPrestamo.Size = new System.Drawing.Size(127, 20);
            this.lblMontoPrestamo.TabIndex = 0;
            this.lblMontoPrestamo.Text = "Monto prestamo";
            // 
            // cbxCuotasMensuales
            // 
            this.cbxCuotasMensuales.FormattingEnabled = true;
            this.cbxCuotasMensuales.Location = new System.Drawing.Point(359, 214);
            this.cbxCuotasMensuales.Name = "cbxCuotasMensuales";
            this.cbxCuotasMensuales.Size = new System.Drawing.Size(194, 23);
            this.cbxCuotasMensuales.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Location = new System.Drawing.Point(336, 261);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(247, 34);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.BackColor = System.Drawing.Color.Transparent;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuotaMensual.Location = new System.Drawing.Point(440, 382);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(130, 20);
            this.lblCuotaMensual.TabIndex = 4;
            this.lblCuotaMensual.Text = "Cuota mensual $:";
            // 
            // lblCuotasMensuales
            // 
            this.lblCuotasMensuales.AutoSize = true;
            this.lblCuotasMensuales.BackColor = System.Drawing.Color.Transparent;
            this.lblCuotasMensuales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuotasMensuales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCuotasMensuales.Location = new System.Drawing.Point(154, 217);
            this.lblCuotasMensuales.Name = "lblCuotasMensuales";
            this.lblCuotasMensuales.Size = new System.Drawing.Size(199, 20);
            this.lblCuotasMensuales.TabIndex = 5;
            this.lblCuotasMensuales.Text = "Cantidad cuotas mensuales";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(26, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(455, 47);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Calculadora de prestamos.";
            // 
            // txbCuotaMensual
            // 
            this.txbCuotaMensual.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbCuotaMensual.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txbCuotaMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbCuotaMensual.Location = new System.Drawing.Point(576, 377);
            this.txbCuotaMensual.Name = "txbCuotaMensual";
            this.txbCuotaMensual.ReadOnly = true;
            this.txbCuotaMensual.Size = new System.Drawing.Size(153, 29);
            this.txbCuotaMensual.TabIndex = 7;
            this.txbCuotaMensual.Text = "0";
            this.txbCuotaMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipoPrestamo
            // 
            this.lblTipoPrestamo.AutoSize = true;
            this.lblTipoPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPrestamo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipoPrestamo.Location = new System.Drawing.Point(221, 164);
            this.lblTipoPrestamo.Name = "lblTipoPrestamo";
            this.lblTipoPrestamo.Size = new System.Drawing.Size(132, 20);
            this.lblTipoPrestamo.TabIndex = 9;
            this.lblTipoPrestamo.Text = "Tipo de Prestamo";
            // 
            // cbxTipoPrestamo
            // 
            this.cbxTipoPrestamo.FormattingEnabled = true;
            this.cbxTipoPrestamo.Location = new System.Drawing.Point(359, 164);
            this.cbxTipoPrestamo.Name = "cbxTipoPrestamo";
            this.cbxTipoPrestamo.Size = new System.Drawing.Size(194, 23);
            this.cbxTipoPrestamo.TabIndex = 8;
            // 
            // txbMonto
            // 
            this.txbMonto.CausesValidation = false;
            this.txbMonto.Location = new System.Drawing.Point(362, 112);
            this.txbMonto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(191, 23);
            this.txbMonto.TabIndex = 10;
            // 
            // txbTasa
            // 
            this.txbTasa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTasa.Location = new System.Drawing.Point(576, 165);
            this.txbTasa.Name = "txbTasa";
            this.txbTasa.Size = new System.Drawing.Size(100, 27);
            this.txbTasa.TabIndex = 11;
            this.txbTasa.Text = "Tasa: 0%";
            this.txbTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(276, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // frmCalculadoraPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbTasa);
            this.Controls.Add(this.txbMonto);
            this.Controls.Add(this.lblTipoPrestamo);
            this.Controls.Add(this.cbxTipoPrestamo);
            this.Controls.Add(this.txbCuotaMensual);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCuotasMensuales);
            this.Controls.Add(this.lblCuotaMensual);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCuotasMensuales);
            this.Controls.Add(this.lblMontoPrestamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculadoraPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora De Prestamos";
            this.Load += new System.EventHandler(this.frmCalculadoraPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontoPrestamo;
        private System.Windows.Forms.ComboBox cbxCuotasMensuales;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Label lblCuotasMensuales;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbCuotaMensual;
        private System.Windows.Forms.Label lblTipoPrestamo;
        private System.Windows.Forms.ComboBox cbxTipoPrestamo;
        private System.Windows.Forms.NumericUpDown txbMonto;
        private System.Windows.Forms.TextBox txbTasa;
        private System.Windows.Forms.Label label1;
    }
}

