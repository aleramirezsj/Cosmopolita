namespace Desktop.Views
{
    partial class GeneradorDeCuotasView
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.gridCuotas = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.Importe = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(650, 184);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 34);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(334, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActividad.Location = new System.Drawing.Point(21, 26);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(74, 21);
            this.lblActividad.TabIndex = 5;
            this.lblActividad.Text = "Actividad";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAño.Location = new System.Drawing.Point(232, 26);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(38, 21);
            this.lblAño.TabIndex = 6;
            this.lblAño.Text = "Año";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMes.Location = new System.Drawing.Point(428, 26);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(39, 21);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes";
            // 
            // gridCuotas
            // 
            this.gridCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCuotas.Location = new System.Drawing.Point(21, 145);
            this.gridCuotas.Name = "gridCuotas";
            this.gridCuotas.RowTemplate.Height = 25;
            this.gridCuotas.Size = new System.Drawing.Size(602, 204);
            this.gridCuotas.TabIndex = 9;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.Location = new System.Drawing.Point(650, 244);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 34);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Importe
            // 
            this.Importe.AutoSize = true;
            this.Importe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Importe.Location = new System.Drawing.Point(21, 78);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(65, 21);
            this.Importe.TabIndex = 11;
            this.Importe.Text = "Importe";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVencimiento.Location = new System.Drawing.Point(232, 82);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(96, 21);
            this.lblVencimiento.TabIndex = 13;
            this.lblVencimiento.Text = "Vencimiento";
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuotas.Location = new System.Drawing.Point(21, 121);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(58, 21);
            this.lblCuotas.TabIndex = 14;
            this.lblCuotas.Text = "Cuotas";
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(94, 24);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(121, 23);
            this.cboActividad.TabIndex = 15;
            this.cboActividad.SelectionChangeCommitted += new System.EventHandler(this.cboActividad_SelectionChangeCommitted);
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(276, 24);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(121, 23);
            this.cboAño.TabIndex = 16;
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(473, 24);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 23);
            this.cboMes.TabIndex = 17;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // nudImporte
            // 
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Enabled = false;
            this.nudImporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudImporte.Location = new System.Drawing.Point(95, 78);
            this.nudImporte.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(120, 29);
            this.nudImporte.TabIndex = 19;
            this.nudImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GeneradorDeCuotasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.nudImporte);
            this.Controls.Add(this.cboMes);
            this.Controls.Add(this.cboAño);
            this.Controls.Add(this.cboActividad);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gridCuotas);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGenerar);
            this.Name = "GeneradorDeCuotasView";
            this.Text = "GeneradorView";
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerar;
        private DateTimePicker dateTimePicker1;
        private Label lblActividad;
        private Label lblAño;
        private Label lblMes;
        private DataGridView gridCuotas;
        private Button btnImprimir;
        private Label Importe;
        private Label lblVencimiento;
        private Label lblCuotas;
        private ComboBox cboActividad;
        private ComboBox cboAño;
        private ComboBox cboMes;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private NumericUpDown nudImporte;
    }
}