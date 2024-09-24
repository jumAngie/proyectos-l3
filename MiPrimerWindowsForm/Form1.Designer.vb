<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNombre = New Label()
        lblApellido = New Label()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        lstDatos = New ListBox()
        GroupBox1 = New GroupBox()
        btnLimpiar = New Button()
        btnAgregar = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNombre.ForeColor = SystemColors.ButtonFace
        lblNombre.Location = New Point(50, 32)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(92, 28)
        lblNombre.TabIndex = 0
        lblNombre.Text = "Nombre:"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblApellido.ForeColor = SystemColors.ButtonFace
        lblApellido.Location = New Point(47, 80)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(92, 28)
        lblApellido.TabIndex = 1
        lblApellido.Text = "Apellido:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(145, 33)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(183, 27)
        txtNombre.TabIndex = 2
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(145, 84)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(183, 27)
        txtApellido.TabIndex = 2
        ' 
        ' lstDatos
        ' 
        lstDatos.FormattingEnabled = True
        lstDatos.ItemHeight = 20
        lstDatos.Location = New Point(482, 24)
        lstDatos.Name = "lstDatos"
        lstDatos.Size = New Size(391, 344)
        lstDatos.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnLimpiar)
        GroupBox1.Controls.Add(txtNombre)
        GroupBox1.Controls.Add(lblNombre)
        GroupBox1.Controls.Add(txtApellido)
        GroupBox1.Controls.Add(btnAgregar)
        GroupBox1.Controls.Add(lblApellido)
        GroupBox1.ForeColor = SystemColors.ControlLightLight
        GroupBox1.Location = New Point(36, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(389, 239)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos Personales"
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = SystemColors.Control
        btnLimpiar.FlatStyle = FlatStyle.Popup
        btnLimpiar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLimpiar.ForeColor = SystemColors.Highlight
        btnLimpiar.Location = New Point(220, 158)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(132, 50)
        btnLimpiar.TabIndex = 0
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = SystemColors.Control
        btnAgregar.FlatStyle = FlatStyle.Popup
        btnAgregar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAgregar.ForeColor = SystemColors.Highlight
        btnAgregar.Location = New Point(26, 158)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(132, 50)
        btnAgregar.TabIndex = 0
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(977, 415)
        Controls.Add(lstDatos)
        Controls.Add(GroupBox1)
        ForeColor = SystemColors.ActiveCaption
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registro"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lstDatos As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
End Class
