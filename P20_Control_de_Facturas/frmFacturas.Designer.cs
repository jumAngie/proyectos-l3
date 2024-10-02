namespace P20_Control_de_Facturas
{
    partial class frmFacturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarItem = new System.Windows.Forms.Button();
            this.btnNuevaFact = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(190, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE REGISTRO DE FACTURAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DEL VENDEDOR";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(42, 82);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(454, 30);
            this.txtVendedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(528, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "FECHA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Ivory;
            this.lblFecha.Location = new System.Drawing.Point(536, 82);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(81, 19);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "lblFecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarItem);
            this.groupBox1.Controls.Add(this.btnNuevaFact);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.txtUnidades);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumFact);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Location = new System.Drawing.Point(42, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(751, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE FACTURAS";
            // 
            // btnRegistrarItem
            // 
            this.btnRegistrarItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegistrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarItem.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnRegistrarItem.Location = new System.Drawing.Point(579, 67);
            this.btnRegistrarItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegistrarItem.Name = "btnRegistrarItem";
            this.btnRegistrarItem.Size = new System.Drawing.Size(148, 34);
            this.btnRegistrarItem.TabIndex = 12;
            this.btnRegistrarItem.Text = "REGISTRAR ITEM";
            this.btnRegistrarItem.UseVisualStyleBackColor = false;
            this.btnRegistrarItem.Click += new System.EventHandler(this.btnRegistrarItem_Click);
            // 
            // btnNuevaFact
            // 
            this.btnNuevaFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevaFact.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFact.Location = new System.Drawing.Point(579, 26);
            this.btnNuevaFact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevaFact.Name = "btnNuevaFact";
            this.btnNuevaFact.Size = new System.Drawing.Size(148, 34);
            this.btnNuevaFact.TabIndex = 11;
            this.btnNuevaFact.Text = "OTRA FACTURA";
            this.btnNuevaFact.UseVisualStyleBackColor = true;
            this.btnNuevaFact.Click += new System.EventHandler(this.btnNuevaFact_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Cobre",
            "Bronce",
            "Silver",
            "Gold"});
            this.cboTipo.Location = new System.Drawing.Point(194, 54);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(198, 23);
            this.cboTipo.TabIndex = 10;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidades.Location = new System.Drawing.Point(412, 54);
            this.txtUnidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(137, 23);
            this.txtUnidades.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(408, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "UNIDADES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(190, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "TIPO DE LICENCIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(28, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "N° FACT.";
            // 
            // txtNumFact
            // 
            this.txtNumFact.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFact.Location = new System.Drawing.Point(31, 54);
            this.txtNumFact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(137, 23);
            this.txtNumFact.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(37, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "LISTADO DE REGISTROS";
            // 
            // lvRegistro
            // 
            this.lvRegistro.BackColor = System.Drawing.Color.Cornsilk;
            this.lvRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvRegistro.GridLines = true;
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(41, 286);
            this.lvRegistro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(752, 104);
            this.lvRegistro.TabIndex = 7;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NUM FACT.";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TIPO LICENCIA";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UNIDADES";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SUBTOTAL";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(510, 409);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "MONTO TOTAL";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblMonto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Ivory;
            this.lblMonto.Location = new System.Drawing.Point(617, 404);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(82, 24);
            this.lblMonto.TabIndex = 14;
            this.lblMonto.Text = "label9";
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lvEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvEstadisticas.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEstadisticas.ForeColor = System.Drawing.SystemColors.Window;
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.HideSelection = false;
            this.lvEstadisticas.Location = new System.Drawing.Point(41, 481);
            this.lvEstadisticas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(752, 104);
            this.lvEstadisticas.TabIndex = 16;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TIPO LICENCIA";
            this.columnHeader6.Width = 300;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TOTAL UNIDADES";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 250;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "MONTO TOTAL";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 200;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(37, 454);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "ESTADISTICA DE VENTA";
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(825, 621);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de registro de facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumFact;
        private System.Windows.Forms.Button btnRegistrarItem;
        private System.Windows.Forms.Button btnNuevaFact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvRegistro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ListView lvEstadisticas;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label9;
    }
}

