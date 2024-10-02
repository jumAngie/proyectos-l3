namespace P19_Seguros_De_Vida
{
    partial class frmProformas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProformas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lvProforma = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsGeneral = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAnular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE PROFORMA DE SEGUROS DE VIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAZON SOCIAL";
            // 
            // txtRazon
            // 
            this.txtRazon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazon.Location = new System.Drawing.Point(35, 81);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(659, 29);
            this.txtRazon.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(35, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de seguro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "TIPO DE SEGURO";
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Inversión Clásica",
            "Inversión Platino",
            "Inversión Oro"});
            this.cboTipo.Location = new System.Drawing.Point(30, 52);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(273, 26);
            this.cboTipo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(315, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CANT. EMPLEADOS";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(318, 52);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(174, 26);
            this.txtCantidad.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnRegistrar.Location = new System.Drawing.Point(521, 35);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 43);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lvProforma
            // 
            this.lvProforma.BackColor = System.Drawing.Color.SeaShell;
            this.lvProforma.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvProforma.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lvProforma.GridLines = true;
            this.lvProforma.HideSelection = false;
            this.lvProforma.Location = new System.Drawing.Point(35, 244);
            this.lvProforma.Name = "lvProforma";
            this.lvProforma.Size = new System.Drawing.Size(659, 127);
            this.lvProforma.TabIndex = 4;
            this.lvProforma.UseCompatibleStateImageBehavior = false;
            this.lvProforma.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TIPO DE SEGURO";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CANT. EMPLEADOS";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PAGO MENSUAL";
            this.columnHeader3.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(31, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "ESTADISTICAS";
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.BackColor = System.Drawing.Color.SaddleBrown;
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvEstadisticas.ForeColor = System.Drawing.Color.SeaShell;
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.HideSelection = false;
            this.lvEstadisticas.Location = new System.Drawing.Point(35, 416);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(659, 127);
            this.lvEstadisticas.TabIndex = 6;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CONCEPTO";
            this.columnHeader4.Width = 450;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TOTAL";
            this.columnHeader5.Width = 200;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SaddleBrown;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGeneral,
            this.toolStripSeparator1,
            this.tsAnular,
            this.toolStripSeparator2,
            this.tsSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 584);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(739, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsGeneral
            // 
            this.tsGeneral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsGeneral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsGeneral.Image = ((System.Drawing.Image)(resources.GetObject("tsGeneral.Image")));
            this.tsGeneral.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGeneral.Name = "tsGeneral";
            this.tsGeneral.Size = new System.Drawing.Size(83, 22);
            this.tsGeneral.Text = "GENERAL";
            this.tsGeneral.Click += new System.EventHandler(this.tsGeneral_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsAnular
            // 
            this.tsAnular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAnular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsAnular.Image")));
            this.tsAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAnular.Name = "tsAnular";
            this.tsAnular.Size = new System.Drawing.Size(150, 22);
            this.tsAnular.Text = "ANULAR PROFORMA";
            this.tsAnular.Click += new System.EventHandler(this.tsAnular_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSalir
            // 
            this.tsSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsSalir.Image")));
            this.tsSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(60, 22);
            this.tsSalir.Text = "SALIR";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // frmProformas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(739, 609);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvProforma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProformas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Proforma de seguros de vida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvProforma;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvEstadisticas;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsGeneral;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsAnular;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsSalir;
    }
}

