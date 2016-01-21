namespace SmartQuilaChiles.Configuracion
{
    partial class FrmFirstTime
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Apariencia");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Enviroment", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.chkEsServer = new System.Windows.Forms.CheckBox();
            this.chkTeclado = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathDb = new System.Windows.Forms.TextBox();
            this.btnBuscarbd = new System.Windows.Forms.Button();
            this.fd = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImgSplash = new System.Windows.Forms.Button();
            this.txtImageSplash = new System.Windows.Forms.TextBox();
            this.chkBloquearMenus = new System.Windows.Forms.CheckBox();
            this.tvConfiguracion = new System.Windows.Forms.TreeView();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblApartado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.pnlApariencia = new System.Windows.Forms.Panel();
            this.pnlContenedor.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEsServer
            // 
            this.chkEsServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkEsServer.AutoSize = true;
            this.chkEsServer.Checked = true;
            this.chkEsServer.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkEsServer.Location = new System.Drawing.Point(3, 3);
            this.chkEsServer.Name = "chkEsServer";
            this.chkEsServer.Size = new System.Drawing.Size(65, 17);
            this.chkEsServer.TabIndex = 0;
            this.chkEsServer.Text = "Servidor";
            this.chkEsServer.UseVisualStyleBackColor = true;
            this.chkEsServer.CheckedChanged += new System.EventHandler(this.chkEsServer_CheckedChanged);
            // 
            // chkTeclado
            // 
            this.chkTeclado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkTeclado.AutoSize = true;
            this.chkTeclado.Checked = true;
            this.chkTeclado.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkTeclado.Location = new System.Drawing.Point(3, 53);
            this.chkTeclado.Name = "chkTeclado";
            this.chkTeclado.Size = new System.Drawing.Size(120, 17);
            this.chkTeclado.TabIndex = 1;
            this.chkTeclado.Text = "Teclado en pantalla";
            this.chkTeclado.UseVisualStyleBackColor = true;
            this.chkTeclado.CheckedChanged += new System.EventHandler(this.chkTeclado_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(642, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Continuar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ubicacion base de datos";
            // 
            // txtPathDb
            // 
            this.txtPathDb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPathDb.Enabled = false;
            this.txtPathDb.Location = new System.Drawing.Point(150, 20);
            this.txtPathDb.Name = "txtPathDb";
            this.txtPathDb.ReadOnly = true;
            this.txtPathDb.Size = new System.Drawing.Size(312, 20);
            this.txtPathDb.TabIndex = 4;
            // 
            // btnBuscarbd
            // 
            this.btnBuscarbd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarbd.Enabled = false;
            this.btnBuscarbd.Location = new System.Drawing.Point(478, 18);
            this.btnBuscarbd.Name = "btnBuscarbd";
            this.btnBuscarbd.Size = new System.Drawing.Size(32, 23);
            this.btnBuscarbd.TabIndex = 5;
            this.btnBuscarbd.Text = "...";
            this.btnBuscarbd.UseVisualStyleBackColor = true;
            this.btnBuscarbd.Click += new System.EventHandler(this.btnBuscarbd_Click);
            // 
            // fd
            // 
            this.fd.DefaultExt = "*.mdf";
            this.fd.InitialDirectory = "C:\\";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fondo de carga";
            // 
            // btnImgSplash
            // 
            this.btnImgSplash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImgSplash.Location = new System.Drawing.Point(478, 68);
            this.btnImgSplash.Name = "btnImgSplash";
            this.btnImgSplash.Size = new System.Drawing.Size(32, 23);
            this.btnImgSplash.TabIndex = 8;
            this.btnImgSplash.Text = "...";
            this.btnImgSplash.UseVisualStyleBackColor = true;
            this.btnImgSplash.Click += new System.EventHandler(this.btnImgSplash_Click);
            // 
            // txtImageSplash
            // 
            this.txtImageSplash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImageSplash.Enabled = false;
            this.txtImageSplash.Location = new System.Drawing.Point(150, 70);
            this.txtImageSplash.Name = "txtImageSplash";
            this.txtImageSplash.ReadOnly = true;
            this.txtImageSplash.Size = new System.Drawing.Size(312, 20);
            this.txtImageSplash.TabIndex = 7;
            // 
            // chkBloquearMenus
            // 
            this.chkBloquearMenus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBloquearMenus.AutoSize = true;
            this.chkBloquearMenus.Location = new System.Drawing.Point(3, 111);
            this.chkBloquearMenus.Name = "chkBloquearMenus";
            this.chkBloquearMenus.Size = new System.Drawing.Size(102, 17);
            this.chkBloquearMenus.TabIndex = 9;
            this.chkBloquearMenus.Text = "Bloquear menus";
            this.chkBloquearMenus.UseVisualStyleBackColor = true;
            this.chkBloquearMenus.CheckedChanged += new System.EventHandler(this.chkBloquearMenus_CheckedChanged);
            // 
            // tvConfiguracion
            // 
            this.tvConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvConfiguracion.HideSelection = false;
            this.tvConfiguracion.LineColor = System.Drawing.Color.Maroon;
            this.tvConfiguracion.Location = new System.Drawing.Point(12, 21);
            this.tvConfiguracion.Name = "tvConfiguracion";
            treeNode1.Name = "tvnGeneral";
            treeNode1.Text = "General";
            treeNode2.Name = "tvnApariencia";
            treeNode2.Text = "Apariencia";
            treeNode3.Checked = true;
            treeNode3.Name = "tvnEnviroment";
            treeNode3.Text = "Enviroment";
            this.tvConfiguracion.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvConfiguracion.ShowPlusMinus = false;
            this.tvConfiguracion.ShowRootLines = false;
            this.tvConfiguracion.Size = new System.Drawing.Size(147, 394);
            this.tvConfiguracion.TabIndex = 10;
            this.tvConfiguracion.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvConfiguracion_AfterSelect);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedor.Controls.Add(this.pnlApariencia);
            this.pnlContenedor.Controls.Add(this.pnlGeneral);
            this.pnlContenedor.Controls.Add(this.lblApartado);
            this.pnlContenedor.Location = new System.Drawing.Point(169, 21);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(636, 365);
            this.pnlContenedor.TabIndex = 11;
            // 
            // lblApartado
            // 
            this.lblApartado.BackColor = System.Drawing.Color.DimGray;
            this.lblApartado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApartado.ForeColor = System.Drawing.Color.White;
            this.lblApartado.Location = new System.Drawing.Point(0, 0);
            this.lblApartado.Name = "lblApartado";
            this.lblApartado.Size = new System.Drawing.Size(634, 21);
            this.lblApartado.TabIndex = 0;
            this.lblApartado.Text = "General";
            this.lblApartado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(730, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGeneral.BackColor = System.Drawing.Color.Transparent;
            this.pnlGeneral.Controls.Add(this.chkEsServer);
            this.pnlGeneral.Controls.Add(this.label2);
            this.pnlGeneral.Controls.Add(this.btnBuscarbd);
            this.pnlGeneral.Controls.Add(this.chkTeclado);
            this.pnlGeneral.Controls.Add(this.chkBloquearMenus);
            this.pnlGeneral.Controls.Add(this.txtPathDb);
            this.pnlGeneral.Controls.Add(this.label1);
            this.pnlGeneral.Controls.Add(this.txtImageSplash);
            this.pnlGeneral.Controls.Add(this.btnImgSplash);
            this.pnlGeneral.Location = new System.Drawing.Point(18, 24);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(529, 135);
            this.pnlGeneral.TabIndex = 13;
            // 
            // pnlApariencia
            // 
            this.pnlApariencia.Location = new System.Drawing.Point(18, 177);
            this.pnlApariencia.Name = "pnlApariencia";
            this.pnlApariencia.Size = new System.Drawing.Size(529, 156);
            this.pnlApariencia.TabIndex = 14;
            // 
            // FrmFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 427);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.tvConfiguracion);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.FrmFirstTime_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEsServer;
        private System.Windows.Forms.CheckBox chkTeclado;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathDb;
        private System.Windows.Forms.Button btnBuscarbd;
        private System.Windows.Forms.OpenFileDialog fd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImgSplash;
        private System.Windows.Forms.TextBox txtImageSplash;
        private System.Windows.Forms.CheckBox chkBloquearMenus;
        private System.Windows.Forms.TreeView tvConfiguracion;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblApartado;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel pnlApariencia;
    }
}