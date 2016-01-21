namespace SmartQuilaChiles.Catalogos
{
    partial class FrmPresentaciones
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
            this.tcPresentaciones = new System.Windows.Forms.TabControl();
            this.tpPresentaciones = new System.Windows.Forms.TabPage();
            this.dgvPresentaciones = new System.Windows.Forms.DataGridView();
            this.txtPresentacionFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNegocioFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpRegistro = new System.Windows.Forms.TabPage();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtPresentacionRegistro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMedidaRegistro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNegocioRegistro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tcPresentaciones.SuspendLayout();
            this.tpPresentaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentaciones)).BeginInit();
            this.tpRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPresentaciones
            // 
            this.tcPresentaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPresentaciones.Controls.Add(this.tpPresentaciones);
            this.tcPresentaciones.Controls.Add(this.tpRegistro);
            this.tcPresentaciones.Location = new System.Drawing.Point(12, 12);
            this.tcPresentaciones.Name = "tcPresentaciones";
            this.tcPresentaciones.SelectedIndex = 0;
            this.tcPresentaciones.Size = new System.Drawing.Size(502, 413);
            this.tcPresentaciones.TabIndex = 0;
            // 
            // tpPresentaciones
            // 
            this.tpPresentaciones.Controls.Add(this.dgvPresentaciones);
            this.tpPresentaciones.Controls.Add(this.txtPresentacionFiltro);
            this.tpPresentaciones.Controls.Add(this.label2);
            this.tpPresentaciones.Controls.Add(this.cmbNegocioFiltro);
            this.tpPresentaciones.Controls.Add(this.label1);
            this.tpPresentaciones.Location = new System.Drawing.Point(4, 22);
            this.tpPresentaciones.Name = "tpPresentaciones";
            this.tpPresentaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tpPresentaciones.Size = new System.Drawing.Size(494, 387);
            this.tpPresentaciones.TabIndex = 0;
            this.tpPresentaciones.Text = "Presentaciones";
            this.tpPresentaciones.UseVisualStyleBackColor = true;
            // 
            // dgvPresentaciones
            // 
            this.dgvPresentaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPresentaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresentaciones.Location = new System.Drawing.Point(44, 94);
            this.dgvPresentaciones.Name = "dgvPresentaciones";
            this.dgvPresentaciones.Size = new System.Drawing.Size(401, 287);
            this.dgvPresentaciones.TabIndex = 4;
            // 
            // txtPresentacionFiltro
            // 
            this.txtPresentacionFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPresentacionFiltro.Location = new System.Drawing.Point(130, 53);
            this.txtPresentacionFiltro.Name = "txtPresentacionFiltro";
            this.txtPresentacionFiltro.Size = new System.Drawing.Size(238, 20);
            this.txtPresentacionFiltro.TabIndex = 3;
            this.txtPresentacionFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresentacionFiltro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Presentación";
            // 
            // cmbNegocioFiltro
            // 
            this.cmbNegocioFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocioFiltro.FormattingEnabled = true;
            this.cmbNegocioFiltro.Location = new System.Drawing.Point(130, 27);
            this.cmbNegocioFiltro.Name = "cmbNegocioFiltro";
            this.cmbNegocioFiltro.Size = new System.Drawing.Size(238, 21);
            this.cmbNegocioFiltro.TabIndex = 1;
            this.cmbNegocioFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbNegocioFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Negocio";
            // 
            // tpRegistro
            // 
            this.tpRegistro.Controls.Add(this.btnNuevo);
            this.tpRegistro.Controls.Add(this.btnGuardar);
            this.tpRegistro.Controls.Add(this.txtCosto);
            this.tpRegistro.Controls.Add(this.txtCantidad);
            this.tpRegistro.Controls.Add(this.label7);
            this.tpRegistro.Controls.Add(this.Label6);
            this.tpRegistro.Controls.Add(this.txtPresentacionRegistro);
            this.tpRegistro.Controls.Add(this.label5);
            this.tpRegistro.Controls.Add(this.cmbMedidaRegistro);
            this.tpRegistro.Controls.Add(this.label4);
            this.tpRegistro.Controls.Add(this.cmbNegocioRegistro);
            this.tpRegistro.Controls.Add(this.label3);
            this.tpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tpRegistro.Name = "tpRegistro";
            this.tpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistro.Size = new System.Drawing.Size(494, 387);
            this.tpRegistro.TabIndex = 1;
            this.tpRegistro.Text = "Registro";
            this.tpRegistro.UseVisualStyleBackColor = true;
            // 
            // txtCosto
            // 
            this.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCosto.Location = new System.Drawing.Point(130, 137);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 9;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidad.Location = new System.Drawing.Point(130, 108);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Costo";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(55, 111);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(49, 13);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Cantidad";
            // 
            // txtPresentacionRegistro
            // 
            this.txtPresentacionRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPresentacionRegistro.Location = new System.Drawing.Point(130, 54);
            this.txtPresentacionRegistro.Name = "txtPresentacionRegistro";
            this.txtPresentacionRegistro.Size = new System.Drawing.Size(238, 20);
            this.txtPresentacionRegistro.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Presentación";
            // 
            // cmbMedidaRegistro
            // 
            this.cmbMedidaRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedidaRegistro.FormattingEnabled = true;
            this.cmbMedidaRegistro.Location = new System.Drawing.Point(130, 80);
            this.cmbMedidaRegistro.Name = "cmbMedidaRegistro";
            this.cmbMedidaRegistro.Size = new System.Drawing.Size(238, 21);
            this.cmbMedidaRegistro.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Medida";
            // 
            // cmbNegocioRegistro
            // 
            this.cmbNegocioRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocioRegistro.FormattingEnabled = true;
            this.cmbNegocioRegistro.Location = new System.Drawing.Point(130, 27);
            this.cmbNegocioRegistro.Name = "cmbNegocioRegistro";
            this.cmbNegocioRegistro.Size = new System.Drawing.Size(238, 21);
            this.cmbNegocioRegistro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Negocio";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Image = global::SmartQuilaChiles.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(382, 335);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 46);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = global::SmartQuilaChiles.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(279, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 46);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPresentaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 437);
            this.Controls.Add(this.tcPresentaciones);
            this.Name = "FrmPresentaciones";
            this.Text = "Presentaciones";
            this.Load += new System.EventHandler(this.FrmPresentaciones_Load);
            this.tcPresentaciones.ResumeLayout(false);
            this.tpPresentaciones.ResumeLayout(false);
            this.tpPresentaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentaciones)).EndInit();
            this.tpRegistro.ResumeLayout(false);
            this.tpRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPresentaciones;
        private System.Windows.Forms.TabPage tpPresentaciones;
        private System.Windows.Forms.TabPage tpRegistro;
        private System.Windows.Forms.DataGridView dgvPresentaciones;
        private System.Windows.Forms.TextBox txtPresentacionFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNegocioFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNegocioRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox txtPresentacionRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMedidaRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
    }
}