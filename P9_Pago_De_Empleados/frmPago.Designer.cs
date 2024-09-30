
namespace P9_Pago_De_Empleados
{
    partial class frmPago
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lvPagos = new System.Windows.Forms.ListView();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.clhEmpleado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhSueldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDescuento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE PAGO DE EMPLEADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(63, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA DE REGISTRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(36, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE DEL EMPLEADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(118, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CATEGORÍA";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(209, 101);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(470, 20);
            this.txtEmpleado.TabIndex = 4;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Jefe",
            "Administrativo",
            "Técnico",
            "Operativo"});
            this.cboCategoria.Location = new System.Drawing.Point(209, 139);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(145, 21);
            this.cboCategoria.TabIndex = 5;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(376, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "SUELDO";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.BackColor = System.Drawing.Color.Crimson;
            this.lblSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSueldo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblSueldo.Location = new System.Drawing.Point(441, 139);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(2, 27);
            this.lblSueldo.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Crimson;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnRegistrar.Location = new System.Drawing.Point(39, 182);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 38);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnCancelar.Location = new System.Drawing.Point(174, 182);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 38);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lvPagos
            // 
            this.lvPagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhEmpleado,
            this.clhCategoria,
            this.clhSueldo,
            this.clhDescuento,
            this.clhNeto});
            this.lvPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPagos.ForeColor = System.Drawing.Color.Crimson;
            this.lvPagos.GridLines = true;
            this.lvPagos.HideSelection = false;
            this.lvPagos.Location = new System.Drawing.Point(39, 226);
            this.lvPagos.Name = "lvPagos";
            this.lvPagos.Size = new System.Drawing.Size(640, 171);
            this.lvPagos.TabIndex = 10;
            this.lvPagos.UseCompatibleStateImageBehavior = false;
            this.lvPagos.View = System.Windows.Forms.View.Details;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Crimson;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnSair.Location = new System.Drawing.Point(39, 403);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 38);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SALIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Crimson;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblFecha.Location = new System.Drawing.Point(206, 62);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 18);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha";
            // 
            // clhEmpleado
            // 
            this.clhEmpleado.Text = "EMPLEADO";
            this.clhEmpleado.Width = 150;
            // 
            // clhCategoria
            // 
            this.clhCategoria.Text = "CATEGORIA";
            this.clhCategoria.Width = 120;
            // 
            // clhSueldo
            // 
            this.clhSueldo.Text = "SUELDO";
            this.clhSueldo.Width = 110;
            // 
            // clhDescuento
            // 
            this.clhDescuento.Text = "DESCUENTO";
            this.clhDescuento.Width = 150;
            // 
            // clhNeto
            // 
            this.clhNeto.Text = "NETO";
            this.clhNeto.Width = 102;
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(715, 464);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lvPagos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPago";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView lvPagos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ColumnHeader clhEmpleado;
        private System.Windows.Forms.ColumnHeader clhCategoria;
        private System.Windows.Forms.ColumnHeader clhSueldo;
        private System.Windows.Forms.ColumnHeader clhDescuento;
        private System.Windows.Forms.ColumnHeader clhNeto;
    }
}

