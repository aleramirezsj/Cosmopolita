namespace Desktop.Views
{
    partial class CobranzaView
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
            this.lblSocio = new System.Windows.Forms.Label();
            this.cboCobrador = new System.Windows.Forms.ComboBox();
            this.txtBuscarSocio = new System.Windows.Forms.TextBox();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.gridSocios = new System.Windows.Forms.DataGridView();
            this.lblCobrador = new System.Windows.Forms.Label();
            this.gridCuotasAdeudadas = new System.Windows.Forms.DataGridView();
            this.lblCuotasAdeudadas = new System.Windows.Forms.Label();
            this.lblCuotasPagas = new System.Windows.Forms.Label();
            this.gridCuotasPagas = new System.Windows.Forms.DataGridView();
            this.btnAnularPago = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotasAdeudadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotasPagas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(41, 17);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(77, 15);
            this.lblSocio.TabIndex = 0;
            this.lblSocio.Text = "Buscar Socio:";
            // 
            // cboCobrador
            // 
            this.cboCobrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCobrador.FormattingEnabled = true;
            this.cboCobrador.Location = new System.Drawing.Point(696, 35);
            this.cboCobrador.Name = "cboCobrador";
            this.cboCobrador.Size = new System.Drawing.Size(158, 23);
            this.cboCobrador.TabIndex = 1;
            // 
            // txtBuscarSocio
            // 
            this.txtBuscarSocio.Location = new System.Drawing.Point(41, 35);
            this.txtBuscarSocio.Name = "txtBuscarSocio";
            this.txtBuscarSocio.Size = new System.Drawing.Size(200, 23);
            this.txtBuscarSocio.TabIndex = 2;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(772, 193);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(101, 36);
            this.btnRegistrarPago.TabIndex = 3;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // gridSocios
            // 
            this.gridSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSocios.Location = new System.Drawing.Point(41, 79);
            this.gridSocios.Name = "gridSocios";
            this.gridSocios.RowTemplate.Height = 25;
            this.gridSocios.Size = new System.Drawing.Size(265, 346);
            this.gridSocios.TabIndex = 4;
            this.gridSocios.Click += new System.EventHandler(this.gridSocios_Click);
            this.gridSocios.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridSocios_KeyUp);
            // 
            // lblCobrador
            // 
            this.lblCobrador.AutoSize = true;
            this.lblCobrador.Location = new System.Drawing.Point(696, 17);
            this.lblCobrador.Name = "lblCobrador";
            this.lblCobrador.Size = new System.Drawing.Size(60, 15);
            this.lblCobrador.TabIndex = 6;
            this.lblCobrador.Text = "Cobrador:";
            // 
            // gridCuotasAdeudadas
            // 
            this.gridCuotasAdeudadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCuotasAdeudadas.Location = new System.Drawing.Point(312, 79);
            this.gridCuotasAdeudadas.Name = "gridCuotasAdeudadas";
            this.gridCuotasAdeudadas.RowTemplate.Height = 25;
            this.gridCuotasAdeudadas.Size = new System.Drawing.Size(421, 150);
            this.gridCuotasAdeudadas.TabIndex = 7;
            this.gridCuotasAdeudadas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridCuotasAdeudadas_DataBindingComplete);
            // 
            // lblCuotasAdeudadas
            // 
            this.lblCuotasAdeudadas.AutoSize = true;
            this.lblCuotasAdeudadas.Location = new System.Drawing.Point(312, 58);
            this.lblCuotasAdeudadas.Name = "lblCuotasAdeudadas";
            this.lblCuotasAdeudadas.Size = new System.Drawing.Size(109, 15);
            this.lblCuotasAdeudadas.TabIndex = 8;
            this.lblCuotasAdeudadas.Text = "Cuotas Adeudadas:";
            // 
            // lblCuotasPagas
            // 
            this.lblCuotasPagas.AutoSize = true;
            this.lblCuotasPagas.Location = new System.Drawing.Point(312, 254);
            this.lblCuotasPagas.Name = "lblCuotasPagas";
            this.lblCuotasPagas.Size = new System.Drawing.Size(81, 15);
            this.lblCuotasPagas.TabIndex = 10;
            this.lblCuotasPagas.Text = "Cuotas Pagas:";
            // 
            // gridCuotasPagas
            // 
            this.gridCuotasPagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCuotasPagas.Location = new System.Drawing.Point(312, 275);
            this.gridCuotasPagas.Name = "gridCuotasPagas";
            this.gridCuotasPagas.RowTemplate.Height = 25;
            this.gridCuotasPagas.Size = new System.Drawing.Size(421, 150);
            this.gridCuotasPagas.TabIndex = 9;
            this.gridCuotasPagas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridCuotasPagas_DataBindingComplete);
            // 
            // btnAnularPago
            // 
            this.btnAnularPago.Location = new System.Drawing.Point(772, 389);
            this.btnAnularPago.Name = "btnAnularPago";
            this.btnAnularPago.Size = new System.Drawing.Size(101, 36);
            this.btnAnularPago.TabIndex = 11;
            this.btnAnularPago.Text = "Anular Pago";
            this.btnAnularPago.UseVisualStyleBackColor = true;
            this.btnAnularPago.Click += new System.EventHandler(this.btnAnularPago_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(247, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CobranzaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAnularPago);
            this.Controls.Add(this.lblCuotasPagas);
            this.Controls.Add(this.gridCuotasPagas);
            this.Controls.Add(this.lblCuotasAdeudadas);
            this.Controls.Add(this.gridCuotasAdeudadas);
            this.Controls.Add(this.lblCobrador);
            this.Controls.Add(this.gridSocios);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.txtBuscarSocio);
            this.Controls.Add(this.cboCobrador);
            this.Controls.Add(this.lblSocio);
            this.Name = "CobranzaView";
            this.Text = "CobaranzaView";
            ((System.ComponentModel.ISupportInitialize)(this.gridSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotasAdeudadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotasPagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSocio;
        private ComboBox cboCobrador;
        private TextBox txtBuscarSocio;
        private Button btnRegistrarPago;
        private DataGridView gridSocios;
        private Label lblCobrador;
        private DataGridView gridCuotasAdeudadas;
        private Label lblCuotasAdeudadas;
        private Label lblCuotasPagas;
        private DataGridView gridCuotasPagas;
        private Button btnAnularPago;
        private Button btnBuscar;
    }
}