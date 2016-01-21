namespace SmartQuilaChiles.Configuracion
{
    partial class FrmSucursales
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
            this.tbSucursales = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lvSucursales = new System.Windows.Forms.ListView();
            this.cmbNegocios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRegistro = new System.Windows.Forms.TabPage();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbColonia = new System.Windows.Forms.ComboBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.cmbNegocioRegistro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSucursales.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSucursales
            // 
            this.tbSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSucursales.Controls.Add(this.tabPage1);
            this.tbSucursales.Controls.Add(this.tbRegistro);
            this.tbSucursales.Location = new System.Drawing.Point(25, 26);
            this.tbSucursales.Name = "tbSucursales";
            this.tbSucursales.SelectedIndex = 0;
            this.tbSucursales.Size = new System.Drawing.Size(361, 437);
            this.tbSucursales.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.lvSucursales);
            this.tabPage1.Controls.Add(this.cmbNegocios);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(353, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sucursales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Image = global::SmartQuilaChiles.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(300, 92);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 32);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lvSucursales
            // 
            this.lvSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSucursales.AutoArrange = false;
            this.lvSucursales.Location = new System.Drawing.Point(38, 69);
            this.lvSucursales.MultiSelect = false;
            this.lvSucursales.Name = "lvSucursales";
            this.lvSucursales.Size = new System.Drawing.Size(249, 275);
            this.lvSucursales.TabIndex = 3;
            this.lvSucursales.UseCompatibleStateImageBehavior = false;
            // 
            // cmbNegocios
            // 
            this.cmbNegocios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocios.FormattingEnabled = true;
            this.cmbNegocios.Location = new System.Drawing.Point(106, 26);
            this.cmbNegocios.Name = "cmbNegocios";
            this.cmbNegocios.Size = new System.Drawing.Size(182, 21);
            this.cmbNegocios.TabIndex = 1;
            this.cmbNegocios.SelectedIndexChanged += new System.EventHandler(this.cmbNegocios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Negocio";
            // 
            // tbRegistro
            // 
            this.tbRegistro.Controls.Add(this.btnNuevo);
            this.tbRegistro.Controls.Add(this.btnGuardar);
            this.tbRegistro.Controls.Add(this.chkActivo);
            this.tbRegistro.Controls.Add(this.txtCalle);
            this.tbRegistro.Controls.Add(this.txtNombre);
            this.tbRegistro.Controls.Add(this.cmbColonia);
            this.tbRegistro.Controls.Add(this.txtCp);
            this.tbRegistro.Controls.Add(this.cmbNegocioRegistro);
            this.tbRegistro.Controls.Add(this.label7);
            this.tbRegistro.Controls.Add(this.label6);
            this.tbRegistro.Controls.Add(this.label5);
            this.tbRegistro.Controls.Add(this.label4);
            this.tbRegistro.Controls.Add(this.label3);
            this.tbRegistro.Controls.Add(this.label2);
            this.tbRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbRegistro.Name = "tbRegistro";
            this.tbRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistro.Size = new System.Drawing.Size(353, 411);
            this.tbRegistro.TabIndex = 1;
            this.tbRegistro.Text = "Registro";
            this.tbRegistro.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SmartQuilaChiles.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(216, 343);
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
            this.btnGuardar.Image = global::SmartQuilaChiles.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(121, 343);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 46);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkActivo.Location = new System.Drawing.Point(123, 286);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(105, 17);
            this.chkActivo.TabIndex = 11;
            this.chkActivo.Text = "Sucursal activa?";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(123, 245);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(182, 20);
            this.txtCalle.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(123, 205);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // cmbColonia
            // 
            this.cmbColonia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColonia.FormattingEnabled = true;
            this.cmbColonia.Location = new System.Drawing.Point(123, 164);
            this.cmbColonia.Name = "cmbColonia";
            this.cmbColonia.Size = new System.Drawing.Size(182, 21);
            this.cmbColonia.TabIndex = 8;
            // 
            // txtCp
            // 
            this.txtCp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCp.Location = new System.Drawing.Point(123, 113);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(182, 20);
            this.txtCp.TabIndex = 7;
            this.txtCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCp_KeyPress);
            this.txtCp.Leave += new System.EventHandler(this.txtCp_Leave);
            // 
            // cmbNegocioRegistro
            // 
            this.cmbNegocioRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocioRegistro.FormattingEnabled = true;
            this.cmbNegocioRegistro.Location = new System.Drawing.Point(123, 73);
            this.cmbNegocioRegistro.Name = "cmbNegocioRegistro";
            this.cmbNegocioRegistro.Size = new System.Drawing.Size(182, 21);
            this.cmbNegocioRegistro.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Calle y No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Colonia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Negocio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos de Sucursal";
            // 
            // FrmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 489);
            this.Controls.Add(this.tbSucursales);
            this.Name = "FrmSucursales";
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.FrmSucursales_Load);
            this.tbSucursales.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbRegistro.ResumeLayout(false);
            this.tbRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbSucursales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbRegistro;
        private System.Windows.Forms.ComboBox cmbNegocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSucursales;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbColonia;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.ComboBox cmbNegocioRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
    }
}