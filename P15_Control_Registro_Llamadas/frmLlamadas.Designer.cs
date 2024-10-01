namespace P15_Control_Registro_Llamadas
{
    partial class frmLlamadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLlamadas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbmInternacional = new System.Windows.Forms.RadioButton();
            this.rbmNacional = new System.Windows.Forms.RadioButton();
            this.rbfInternacional = new System.Windows.Forms.RadioButton();
            this.rbfNacional = new System.Windows.Forms.RadioButton();
            this.lvLlamadas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsRegistrar = new System.Windows.Forms.ToolStripButton();
            this.tsCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(326, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE REGISTRO DE LLAMADAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(174, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Minutos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtTelefono.Location = new System.Drawing.Point(28, 42);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 23);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtMinutos
            // 
            this.txtMinutos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtMinutos.Location = new System.Drawing.Point(176, 42);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(121, 23);
            this.txtMinutos.TabIndex = 4;
            this.txtMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutos_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbmInternacional);
            this.groupBox1.Controls.Add(this.rbmNacional);
            this.groupBox1.Controls.Add(this.rbfInternacional);
            this.groupBox1.Controls.Add(this.rbfNacional);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(28, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE LLAMADA";
            // 
            // rbmInternacional
            // 
            this.rbmInternacional.AutoSize = true;
            this.rbmInternacional.ForeColor = System.Drawing.Color.Peru;
            this.rbmInternacional.Location = new System.Drawing.Point(546, 32);
            this.rbmInternacional.Name = "rbmInternacional";
            this.rbmInternacional.Size = new System.Drawing.Size(132, 20);
            this.rbmInternacional.TabIndex = 9;
            this.rbmInternacional.TabStop = true;
            this.rbmInternacional.Text = "Movil Internacional";
            this.rbmInternacional.UseVisualStyleBackColor = true;
            // 
            // rbmNacional
            // 
            this.rbmNacional.AutoSize = true;
            this.rbmNacional.ForeColor = System.Drawing.Color.Peru;
            this.rbmNacional.Location = new System.Drawing.Point(375, 32);
            this.rbmNacional.Name = "rbmNacional";
            this.rbmNacional.Size = new System.Drawing.Size(106, 20);
            this.rbmNacional.TabIndex = 8;
            this.rbmNacional.TabStop = true;
            this.rbmNacional.Text = "Movil Nacional";
            this.rbmNacional.UseVisualStyleBackColor = true;
            // 
            // rbfInternacional
            // 
            this.rbfInternacional.AutoSize = true;
            this.rbfInternacional.ForeColor = System.Drawing.Color.Peru;
            this.rbfInternacional.Location = new System.Drawing.Point(191, 32);
            this.rbfInternacional.Name = "rbfInternacional";
            this.rbfInternacional.Size = new System.Drawing.Size(124, 20);
            this.rbfInternacional.TabIndex = 7;
            this.rbfInternacional.TabStop = true;
            this.rbfInternacional.Text = "Fijo Internacional";
            this.rbfInternacional.UseVisualStyleBackColor = true;
            // 
            // rbfNacional
            // 
            this.rbfNacional.AutoSize = true;
            this.rbfNacional.ForeColor = System.Drawing.Color.Peru;
            this.rbfNacional.Location = new System.Drawing.Point(25, 32);
            this.rbfNacional.Name = "rbfNacional";
            this.rbfNacional.Size = new System.Drawing.Size(98, 20);
            this.rbfNacional.TabIndex = 6;
            this.rbfNacional.TabStop = true;
            this.rbfNacional.Text = "Fijo Nacional";
            this.rbfNacional.UseVisualStyleBackColor = true;
            // 
            // lvLlamadas
            // 
            this.lvLlamadas.BackColor = System.Drawing.Color.Moccasin;
            this.lvLlamadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLlamadas.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lvLlamadas.GridLines = true;
            this.lvLlamadas.HideSelection = false;
            this.lvLlamadas.Location = new System.Drawing.Point(28, 163);
            this.lvLlamadas.Name = "lvLlamadas";
            this.lvLlamadas.Size = new System.Drawing.Size(719, 147);
            this.lvLlamadas.TabIndex = 6;
            this.lvLlamadas.UseCompatibleStateImageBehavior = false;
            this.lvLlamadas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NUMERO TELF.";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TIPO LLAMADA";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MINUTOS";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IMPORTE";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DESCUENTO";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NETO A PAGAR";
            this.columnHeader6.Width = 122;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRegistrar,
            this.tsCancelar,
            this.tsSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 339);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(774, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.UseWaitCursor = true;
            // 
            // tsRegistrar
            // 
            this.tsRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("tsRegistrar.Image")));
            this.tsRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRegistrar.Name = "tsRegistrar";
            this.tsRegistrar.Size = new System.Drawing.Size(152, 22);
            this.tsRegistrar.Text = "REGISTRAR LLAMADA";
            this.tsRegistrar.Click += new System.EventHandler(this.tsRegistrar_Click);
            // 
            // tsCancelar
            // 
            this.tsCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsCancelar.Image")));
            this.tsCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCancelar.Name = "tsCancelar";
            this.tsCancelar.Size = new System.Drawing.Size(152, 22);
            this.tsCancelar.Text = "CANCELAR REGISTRO";
            this.tsCancelar.Click += new System.EventHandler(this.tsCancelar_Click);
            // 
            // tsSalir
            // 
            this.tsSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsSalir.Image")));
            this.tsSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(61, 22);
            this.tsSalir.Text = "SALIR";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // frmLlamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(774, 364);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvLlamadas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLlamadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbmInternacional;
        private System.Windows.Forms.RadioButton rbmNacional;
        private System.Windows.Forms.RadioButton rbfInternacional;
        private System.Windows.Forms.RadioButton rbfNacional;
        private System.Windows.Forms.ListView lvLlamadas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsRegistrar;
        private System.Windows.Forms.ToolStripButton tsCancelar;
        private System.Windows.Forms.ToolStripButton tsSalir;
    }
}

