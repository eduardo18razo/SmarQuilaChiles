namespace SmartQuilaChiles.Catalogos
{
    partial class FrmCategorias
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbNegocioRegistro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbNegocios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvCategorias = new System.Windows.Forms.ListView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRegistro = new System.Windows.Forms.TabPage();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbLogoCategoria = new System.Windows.Forms.PictureBox();
            this.tbCategorias = new System.Windows.Forms.TabControl();
            this.ofdLogo = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1.SuspendLayout();
            this.tbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCategoria)).BeginInit();
            this.tbCategorias.SuspendLayout();
            this.SuspendLayout();
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
            // cmbNegocioRegistro
            // 
            this.cmbNegocioRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNegocioRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocioRegistro.FormattingEnabled = true;
            this.cmbNegocioRegistro.Location = new System.Drawing.Point(198, 81);
            this.cmbNegocioRegistro.Name = "cmbNegocioRegistro";
            this.cmbNegocioRegistro.Size = new System.Drawing.Size(169, 21);
            this.cmbNegocioRegistro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 84);
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
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos de Categoria";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Image = global::SmartQuilaChiles.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(327, 92);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 32);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvCategorias);
            this.tabPage1.Controls.Add(this.txtFiltro);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.cmbNegocios);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categorias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvCategorias
            // 
            this.lvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCategorias.AutoArrange = false;
            this.lvCategorias.Location = new System.Drawing.Point(38, 92);
            this.lvCategorias.MultiSelect = false;
            this.lvCategorias.Name = "lvCategorias";
            this.lvCategorias.Size = new System.Drawing.Size(283, 302);
            this.lvCategorias.TabIndex = 8;
            this.lvCategorias.UseCompatibleStateImageBehavior = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Location = new System.Drawing.Point(106, 53);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(182, 20);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // tbRegistro
            // 
            this.tbRegistro.Controls.Add(this.txtLogo);
            this.tbRegistro.Controls.Add(this.btnBuscar);
            this.tbRegistro.Controls.Add(this.txtNombre);
            this.tbRegistro.Controls.Add(this.label5);
            this.tbRegistro.Controls.Add(this.label6);
            this.tbRegistro.Controls.Add(this.pbLogoCategoria);
            this.tbRegistro.Controls.Add(this.btnNuevo);
            this.tbRegistro.Controls.Add(this.btnGuardar);
            this.tbRegistro.Controls.Add(this.cmbNegocioRegistro);
            this.tbRegistro.Controls.Add(this.label3);
            this.tbRegistro.Controls.Add(this.label2);
            this.tbRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbRegistro.Name = "tbRegistro";
            this.tbRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistro.Size = new System.Drawing.Size(380, 411);
            this.tbRegistro.TabIndex = 1;
            this.tbRegistro.Text = "Descripcion";
            this.tbRegistro.UseVisualStyleBackColor = true;
            // 
            // txtLogo
            // 
            this.txtLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogo.Location = new System.Drawing.Point(198, 134);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.ReadOnly = true;
            this.txtLogo.Size = new System.Drawing.Size(125, 20);
            this.txtLogo.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(332, 134);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 23);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(198, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Logo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre";
            // 
            // pbLogoCategoria
            // 
            this.pbLogoCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogoCategoria.Location = new System.Drawing.Point(24, 71);
            this.pbLogoCategoria.Name = "pbLogoCategoria";
            this.pbLogoCategoria.Size = new System.Drawing.Size(100, 100);
            this.pbLogoCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoCategoria.TabIndex = 25;
            this.pbLogoCategoria.TabStop = false;
            // 
            // tbCategorias
            // 
            this.tbCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategorias.Controls.Add(this.tabPage1);
            this.tbCategorias.Controls.Add(this.tbRegistro);
            this.tbCategorias.Location = new System.Drawing.Point(25, 26);
            this.tbCategorias.Name = "tbCategorias";
            this.tbCategorias.SelectedIndex = 0;
            this.tbCategorias.Size = new System.Drawing.Size(388, 437);
            this.tbCategorias.TabIndex = 1;
            // 
            // ofdLogo
            // 
            this.ofdLogo.FileName = "openFileDialog1";
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 489);
            this.Controls.Add(this.tbCategorias);
            this.Name = "FrmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbRegistro.ResumeLayout(false);
            this.tbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCategoria)).EndInit();
            this.tbCategorias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbNegocioRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbNegocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbRegistro;
        private System.Windows.Forms.TabControl tbCategorias;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbLogoCategoria;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvCategorias;
        private System.Windows.Forms.OpenFileDialog ofdLogo;

    }
}