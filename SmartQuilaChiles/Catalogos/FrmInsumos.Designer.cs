namespace SmartQuilaChiles.Catalogos
{
    partial class FrmInsumos
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
            this.tcInsumos = new System.Windows.Forms.TabControl();
            this.tbInsumos = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.txtInsumoFiltro = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPresentacion = new System.Windows.Forms.Button();
            this.btnEditPresentacion = new System.Windows.Forms.Button();
            this.btnDelPresentacion = new System.Windows.Forms.Button();
            this.dgPresentacionesInsumo = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRendimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtRendimiento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPresentaciones = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStockMaximo = new System.Windows.Forms.TextBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.cmbUnidades = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbNegociosRegistro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcInsumos.SuspendLayout();
            this.tbInsumos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresentacionesInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcInsumos
            // 
            this.tcInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcInsumos.Controls.Add(this.tbInsumos);
            this.tcInsumos.Controls.Add(this.tabPage2);
            this.tcInsumos.Location = new System.Drawing.Point(12, 12);
            this.tcInsumos.Name = "tcInsumos";
            this.tcInsumos.SelectedIndex = 0;
            this.tcInsumos.Size = new System.Drawing.Size(482, 491);
            this.tcInsumos.TabIndex = 0;
            // 
            // tbInsumos
            // 
            this.tbInsumos.Controls.Add(this.btnEditar);
            this.tbInsumos.Controls.Add(this.dgvInsumos);
            this.tbInsumos.Controls.Add(this.txtInsumoFiltro);
            this.tbInsumos.Controls.Add(this.Label1);
            this.tbInsumos.Location = new System.Drawing.Point(4, 22);
            this.tbInsumos.Name = "tbInsumos";
            this.tbInsumos.Padding = new System.Windows.Forms.Padding(3);
            this.tbInsumos.Size = new System.Drawing.Size(474, 465);
            this.tbInsumos.TabIndex = 0;
            this.tbInsumos.Text = "Insumos";
            this.tbInsumos.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Image = global::SmartQuilaChiles.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(514, 94);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 32);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Location = new System.Drawing.Point(6, 94);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.Size = new System.Drawing.Size(407, 308);
            this.dgvInsumos.TabIndex = 2;
            // 
            // txtInsumoFiltro
            // 
            this.txtInsumoFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsumoFiltro.Location = new System.Drawing.Point(108, 47);
            this.txtInsumoFiltro.Name = "txtInsumoFiltro";
            this.txtInsumoFiltro.Size = new System.Drawing.Size(305, 20);
            this.txtInsumoFiltro.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(52, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Insumo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtStockMaximo);
            this.tabPage2.Controls.Add(this.txtStockMinimo);
            this.tabPage2.Controls.Add(this.cmbUnidades);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.cmbNegociosRegistro);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SmartQuilaChiles.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(204, 407);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 46);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::SmartQuilaChiles.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(88, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 46);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddPresentacion);
            this.groupBox1.Controls.Add(this.btnEditPresentacion);
            this.groupBox1.Controls.Add(this.btnDelPresentacion);
            this.groupBox1.Controls.Add(this.dgPresentacionesInsumo);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.txtRendimiento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbPresentaciones);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(33, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 219);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presentaciones";
            // 
            // btnAddPresentacion
            // 
            this.btnAddPresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPresentacion.Image = global::SmartQuilaChiles.Properties.Resources.Plus;
            this.btnAddPresentacion.Location = new System.Drawing.Point(384, 29);
            this.btnAddPresentacion.Name = "btnAddPresentacion";
            this.btnAddPresentacion.Size = new System.Drawing.Size(32, 32);
            this.btnAddPresentacion.TabIndex = 43;
            this.btnAddPresentacion.UseVisualStyleBackColor = true;
            this.btnAddPresentacion.Click += new System.EventHandler(this.btnAddPresentacion_Click);
            // 
            // btnEditPresentacion
            // 
            this.btnEditPresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPresentacion.Image = global::SmartQuilaChiles.Properties.Resources.editar;
            this.btnEditPresentacion.Location = new System.Drawing.Point(384, 82);
            this.btnEditPresentacion.Name = "btnEditPresentacion";
            this.btnEditPresentacion.Size = new System.Drawing.Size(32, 32);
            this.btnEditPresentacion.TabIndex = 41;
            this.btnEditPresentacion.UseVisualStyleBackColor = true;
            this.btnEditPresentacion.Click += new System.EventHandler(this.btnEditPresentacion_Click);
            // 
            // btnDelPresentacion
            // 
            this.btnDelPresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelPresentacion.Image = global::SmartQuilaChiles.Properties.Resources.eliminar;
            this.btnDelPresentacion.Location = new System.Drawing.Point(384, 120);
            this.btnDelPresentacion.Name = "btnDelPresentacion";
            this.btnDelPresentacion.Size = new System.Drawing.Size(32, 32);
            this.btnDelPresentacion.TabIndex = 42;
            this.btnDelPresentacion.UseVisualStyleBackColor = true;
            this.btnDelPresentacion.Click += new System.EventHandler(this.btnDelPresentacion_Click);
            // 
            // dgPresentacionesInsumo
            // 
            this.dgPresentacionesInsumo.AllowUserToAddRows = false;
            this.dgPresentacionesInsumo.AllowUserToDeleteRows = false;
            this.dgPresentacionesInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPresentacionesInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDesc,
            this.colRendimiento,
            this.colCosto});
            this.dgPresentacionesInsumo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgPresentacionesInsumo.Location = new System.Drawing.Point(9, 82);
            this.dgPresentacionesInsumo.MultiSelect = false;
            this.dgPresentacionesInsumo.Name = "dgPresentacionesInsumo";
            this.dgPresentacionesInsumo.ReadOnly = true;
            this.dgPresentacionesInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPresentacionesInsumo.Size = new System.Drawing.Size(359, 131);
            this.dgPresentacionesInsumo.TabIndex = 6;
            // 
            // colId
            // 
            this.colId.HeaderText = "IdPresentacion";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "Descripcion";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colRendimiento
            // 
            this.colRendimiento.HeaderText = "Rendimiento";
            this.colRendimiento.Name = "colRendimiento";
            this.colRendimiento.ReadOnly = true;
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.ReadOnly = true;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(232, 56);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 5;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // txtRendimiento
            // 
            this.txtRendimiento.Location = new System.Drawing.Point(85, 56);
            this.txtRendimiento.Name = "txtRendimiento";
            this.txtRendimiento.Size = new System.Drawing.Size(100, 20);
            this.txtRendimiento.TabIndex = 4;
            this.txtRendimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Costo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rendimiento";
            // 
            // cmbPresentaciones
            // 
            this.cmbPresentaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresentaciones.FormattingEnabled = true;
            this.cmbPresentaciones.Location = new System.Drawing.Point(85, 29);
            this.cmbPresentaciones.Name = "cmbPresentaciones";
            this.cmbPresentaciones.Size = new System.Drawing.Size(283, 21);
            this.cmbPresentaciones.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Presentacion";
            // 
            // txtStockMaximo
            // 
            this.txtStockMaximo.Location = new System.Drawing.Point(316, 156);
            this.txtStockMaximo.Name = "txtStockMaximo";
            this.txtStockMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtStockMaximo.TabIndex = 37;
            this.txtStockMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(118, 156);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtStockMinimo.TabIndex = 36;
            this.txtStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // cmbUnidades
            // 
            this.cmbUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidades.FormattingEnabled = true;
            this.cmbUnidades.Location = new System.Drawing.Point(118, 129);
            this.cmbUnidades.Name = "cmbUnidades";
            this.cmbUnidades.Size = new System.Drawing.Size(100, 21);
            this.cmbUnidades.TabIndex = 35;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(118, 103);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 20);
            this.txtDescripcion.TabIndex = 34;
            // 
            // cmbNegociosRegistro
            // 
            this.cmbNegociosRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNegociosRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegociosRegistro.FormattingEnabled = true;
            this.cmbNegociosRegistro.Location = new System.Drawing.Point(118, 76);
            this.cmbNegociosRegistro.Name = "cmbNegociosRegistro";
            this.cmbNegociosRegistro.Size = new System.Drawing.Size(300, 21);
            this.cmbNegociosRegistro.TabIndex = 33;
            this.cmbNegociosRegistro.SelectedIndexChanged += new System.EventHandler(this.cmbNegociosRegistro_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Stock maximo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Stock minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Negocio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Datos de Insumo";
            // 
            // FrmInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 512);
            this.Controls.Add(this.tcInsumos);
            this.MinimumSize = new System.Drawing.Size(520, 551);
            this.Name = "FrmInsumos";
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.FrmInsumos_Load);
            this.tcInsumos.ResumeLayout(false);
            this.tbInsumos.ResumeLayout(false);
            this.tbInsumos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresentacionesInsumo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcInsumos;
        private System.Windows.Forms.TabPage tbInsumos;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.TextBox txtInsumoFiltro;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgPresentacionesInsumo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtRendimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPresentaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStockMaximo;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.ComboBox cmbUnidades;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbNegociosRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAddPresentacion;
        private System.Windows.Forms.Button btnEditPresentacion;
        private System.Windows.Forms.Button btnDelPresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRendimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCosto;
    }
}