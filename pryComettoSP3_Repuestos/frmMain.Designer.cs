namespace pryComettoSP3_Repuestos
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.lblNumeroRepuesto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNumeroRepuesto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.mrcConsultaRepuestos = new System.Windows.Forms.GroupBox();
            this.lstDatosRepuestos = new System.Windows.Forms.ListBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblMarcaConsulta = new System.Windows.Forms.Label();
            this.cmbMarcaConsulta = new System.Windows.Forms.ComboBox();
            this.mrcOrigenConsulta = new System.Windows.Forms.GroupBox();
            this.optNacionalConsulta = new System.Windows.Forms.RadioButton();
            this.optImportadoConsulta = new System.Windows.Forms.RadioButton();
            this.lblDatosRepuestos = new System.Windows.Forms.Label();
            this.mrcOrigen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mrcConsultaRepuestos.SuspendLayout();
            this.mrcOrigenConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarca.Location = new System.Drawing.Point(95, 16);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(104, 21);
            this.cmbMarca.TabIndex = 0;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(52, 19);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Checked = true;
            this.optNacional.Location = new System.Drawing.Point(6, 19);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 2;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(6, 42);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 3;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Location = new System.Drawing.Point(95, 43);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(104, 70);
            this.mrcOrigen.TabIndex = 4;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // lblNumeroRepuesto
            // 
            this.lblNumeroRepuesto.AutoSize = true;
            this.lblNumeroRepuesto.Enabled = false;
            this.lblNumeroRepuesto.Location = new System.Drawing.Point(6, 122);
            this.lblNumeroRepuesto.Name = "lblNumeroRepuesto";
            this.lblNumeroRepuesto.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroRepuesto.TabIndex = 5;
            this.lblNumeroRepuesto.Text = "Nº de Repuesto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Enabled = false;
            this.lblDescripcion.Location = new System.Drawing.Point(222, 19);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Enabled = false;
            this.lblPrecio.Location = new System.Drawing.Point(248, 98);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // txtNumeroRepuesto
            // 
            this.txtNumeroRepuesto.Enabled = false;
            this.txtNumeroRepuesto.Location = new System.Drawing.Point(95, 119);
            this.txtNumeroRepuesto.MaxLength = 6;
            this.txtNumeroRepuesto.Name = "txtNumeroRepuesto";
            this.txtNumeroRepuesto.Size = new System.Drawing.Size(69, 20);
            this.txtNumeroRepuesto.TabIndex = 8;
            this.txtNumeroRepuesto.TextChanged += new System.EventHandler(this.txtNumeroRepuesto_TextChanged);
            this.txtNumeroRepuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroRepuesto_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(291, 16);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(163, 73);
            this.txtDescripcion.TabIndex = 9;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(291, 95);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(74, 20);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistro);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.mrcOrigen);
            this.groupBox1.Controls.Add(this.txtNumeroRepuesto);
            this.groupBox1.Controls.Add(this.lblNumeroRepuesto);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 159);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Repuestos";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Enabled = false;
            this.btnRegistro.Location = new System.Drawing.Point(384, 130);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 13;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // mrcConsultaRepuestos
            // 
            this.mrcConsultaRepuestos.Controls.Add(this.lstDatosRepuestos);
            this.mrcConsultaRepuestos.Controls.Add(this.btnConsulta);
            this.mrcConsultaRepuestos.Controls.Add(this.lblMarcaConsulta);
            this.mrcConsultaRepuestos.Controls.Add(this.cmbMarcaConsulta);
            this.mrcConsultaRepuestos.Controls.Add(this.mrcOrigenConsulta);
            this.mrcConsultaRepuestos.Controls.Add(this.lblDatosRepuestos);
            this.mrcConsultaRepuestos.Enabled = false;
            this.mrcConsultaRepuestos.Location = new System.Drawing.Point(12, 194);
            this.mrcConsultaRepuestos.Name = "mrcConsultaRepuestos";
            this.mrcConsultaRepuestos.Size = new System.Drawing.Size(465, 210);
            this.mrcConsultaRepuestos.TabIndex = 12;
            this.mrcConsultaRepuestos.TabStop = false;
            this.mrcConsultaRepuestos.Text = "Consulta de Repuestos";
            // 
            // lstDatosRepuestos
            // 
            this.lstDatosRepuestos.FormattingEnabled = true;
            this.lstDatosRepuestos.Location = new System.Drawing.Point(225, 35);
            this.lstDatosRepuestos.Name = "lstDatosRepuestos";
            this.lstDatosRepuestos.Size = new System.Drawing.Size(229, 134);
            this.lstDatosRepuestos.TabIndex = 15;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Enabled = false;
            this.btnConsulta.Location = new System.Drawing.Point(384, 181);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblMarcaConsulta
            // 
            this.lblMarcaConsulta.AutoSize = true;
            this.lblMarcaConsulta.Location = new System.Drawing.Point(52, 19);
            this.lblMarcaConsulta.Name = "lblMarcaConsulta";
            this.lblMarcaConsulta.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaConsulta.TabIndex = 1;
            this.lblMarcaConsulta.Text = "Marca";
            // 
            // cmbMarcaConsulta
            // 
            this.cmbMarcaConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaConsulta.FormattingEnabled = true;
            this.cmbMarcaConsulta.Items.AddRange(new object[] {
            "Peugeot",
            "Fiat",
            "Renault"});
            this.cmbMarcaConsulta.Location = new System.Drawing.Point(95, 16);
            this.cmbMarcaConsulta.Name = "cmbMarcaConsulta";
            this.cmbMarcaConsulta.Size = new System.Drawing.Size(104, 21);
            this.cmbMarcaConsulta.TabIndex = 0;
            this.cmbMarcaConsulta.SelectedIndexChanged += new System.EventHandler(this.cmbMarcaConsulta_SelectedIndexChanged);
            // 
            // mrcOrigenConsulta
            // 
            this.mrcOrigenConsulta.Controls.Add(this.optNacionalConsulta);
            this.mrcOrigenConsulta.Controls.Add(this.optImportadoConsulta);
            this.mrcOrigenConsulta.Location = new System.Drawing.Point(95, 43);
            this.mrcOrigenConsulta.Name = "mrcOrigenConsulta";
            this.mrcOrigenConsulta.Size = new System.Drawing.Size(104, 70);
            this.mrcOrigenConsulta.TabIndex = 4;
            this.mrcOrigenConsulta.TabStop = false;
            this.mrcOrigenConsulta.Text = "Origen";
            // 
            // optNacionalConsulta
            // 
            this.optNacionalConsulta.AutoSize = true;
            this.optNacionalConsulta.Checked = true;
            this.optNacionalConsulta.Location = new System.Drawing.Point(6, 19);
            this.optNacionalConsulta.Name = "optNacionalConsulta";
            this.optNacionalConsulta.Size = new System.Drawing.Size(67, 17);
            this.optNacionalConsulta.TabIndex = 2;
            this.optNacionalConsulta.TabStop = true;
            this.optNacionalConsulta.Text = "Nacional";
            this.optNacionalConsulta.UseVisualStyleBackColor = true;
            // 
            // optImportadoConsulta
            // 
            this.optImportadoConsulta.AutoSize = true;
            this.optImportadoConsulta.Location = new System.Drawing.Point(6, 42);
            this.optImportadoConsulta.Name = "optImportadoConsulta";
            this.optImportadoConsulta.Size = new System.Drawing.Size(72, 17);
            this.optImportadoConsulta.TabIndex = 3;
            this.optImportadoConsulta.Text = "Importado";
            this.optImportadoConsulta.UseVisualStyleBackColor = true;
            // 
            // lblDatosRepuestos
            // 
            this.lblDatosRepuestos.AutoSize = true;
            this.lblDatosRepuestos.Location = new System.Drawing.Point(222, 19);
            this.lblDatosRepuestos.Name = "lblDatosRepuestos";
            this.lblDatosRepuestos.Size = new System.Drawing.Size(104, 13);
            this.lblDatosRepuestos.TabIndex = 6;
            this.lblDatosRepuestos.Text = "Datos de Repuestos";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 419);
            this.Controls.Add(this.mrcConsultaRepuestos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Registro de Repuestos";
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mrcConsultaRepuestos.ResumeLayout(false);
            this.mrcConsultaRepuestos.PerformLayout();
            this.mrcOrigenConsulta.ResumeLayout(false);
            this.mrcOrigenConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.Label lblNumeroRepuesto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNumeroRepuesto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.GroupBox mrcConsultaRepuestos;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblMarcaConsulta;
        private System.Windows.Forms.ComboBox cmbMarcaConsulta;
        private System.Windows.Forms.GroupBox mrcOrigenConsulta;
        private System.Windows.Forms.RadioButton optNacionalConsulta;
        private System.Windows.Forms.RadioButton optImportadoConsulta;
        private System.Windows.Forms.Label lblDatosRepuestos;
        private System.Windows.Forms.ListBox lstDatosRepuestos;
    }
}

