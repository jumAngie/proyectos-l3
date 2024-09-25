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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblNombre = New Label()
        lblApellido = New Label()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        lstDatos = New ListBox()
        GroupBox1 = New GroupBox()
        lblErrorApellido = New Label()
        lblErrorNombre = New Label()
        btnLimpiar = New Button()
        btnAgregar = New Button()
        pnNombre = New Panel()
        pnApellido = New Panel()
        Label1 = New Label()
        lblSuccess = New Label()
        pctSuccess = New PictureBox()
        lblWarning = New Label()
        pctWarning = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        CType(pctSuccess, ComponentModel.ISupportInitialize).BeginInit()
        CType(pctWarning, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNombre.ForeColor = SystemColors.ButtonFace
        lblNombre.Location = New Point(44, 24)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(75, 21)
        lblNombre.TabIndex = 0
        lblNombre.Text = "Nombre:"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblApellido.ForeColor = SystemColors.ButtonFace
        lblApellido.Location = New Point(45, 58)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(76, 21)
        lblApellido.TabIndex = 1
        lblApellido.Text = "Apellido:"
        ' 
        ' txtNombre
        ' 
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtNombre.Location = New Point(127, 25)
        txtNombre.Margin = New Padding(3, 2, 3, 2)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(161, 18)
        txtNombre.TabIndex = 2
        ' 
        ' txtApellido
        ' 
        txtApellido.BorderStyle = BorderStyle.None
        txtApellido.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtApellido.Location = New Point(127, 61)
        txtApellido.Margin = New Padding(3, 2, 3, 2)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(161, 18)
        txtApellido.TabIndex = 2
        ' 
        ' lstDatos
        ' 
        lstDatos.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lstDatos.ForeColor = SystemColors.MenuHighlight
        lstDatos.FormattingEnabled = True
        lstDatos.ItemHeight = 21
        lstDatos.Location = New Point(438, 96)
        lstDatos.Margin = New Padding(3, 2, 3, 2)
        lstDatos.Name = "lstDatos"
        lstDatos.Size = New Size(257, 256)
        lstDatos.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblErrorApellido)
        GroupBox1.Controls.Add(lblErrorNombre)
        GroupBox1.Controls.Add(btnLimpiar)
        GroupBox1.Controls.Add(txtNombre)
        GroupBox1.Controls.Add(lblNombre)
        GroupBox1.Controls.Add(txtApellido)
        GroupBox1.Controls.Add(btnAgregar)
        GroupBox1.Controls.Add(lblApellido)
        GroupBox1.Controls.Add(pnNombre)
        GroupBox1.Controls.Add(pnApellido)
        GroupBox1.ForeColor = SystemColors.ControlLightLight
        GroupBox1.Location = New Point(48, 87)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(340, 179)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos Personales"
        ' 
        ' lblErrorApellido
        ' 
        lblErrorApellido.AutoSize = True
        lblErrorApellido.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblErrorApellido.ForeColor = Color.Red
        lblErrorApellido.Location = New Point(23, 49)
        lblErrorApellido.Name = "lblErrorApellido"
        lblErrorApellido.Size = New Size(25, 32)
        lblErrorApellido.TabIndex = 6
        lblErrorApellido.Text = "*"
        lblErrorApellido.Visible = False
        ' 
        ' lblErrorNombre
        ' 
        lblErrorNombre.AutoSize = True
        lblErrorNombre.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblErrorNombre.ForeColor = Color.Red
        lblErrorNombre.Location = New Point(23, 14)
        lblErrorNombre.Name = "lblErrorNombre"
        lblErrorNombre.Size = New Size(25, 32)
        lblErrorNombre.TabIndex = 5
        lblErrorNombre.Text = "*"
        lblErrorNombre.Visible = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = SystemColors.HotTrack
        btnLimpiar.Cursor = Cursors.Hand
        btnLimpiar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLimpiar.ForeColor = SystemColors.Window
        btnLimpiar.Location = New Point(192, 118)
        btnLimpiar.Margin = New Padding(3, 2, 3, 2)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(116, 38)
        btnLimpiar.TabIndex = 0
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = SystemColors.HotTrack
        btnAgregar.Cursor = Cursors.Hand
        btnAgregar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAgregar.ForeColor = SystemColors.Window
        btnAgregar.Location = New Point(23, 118)
        btnAgregar.Margin = New Padding(3, 2, 3, 2)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(116, 38)
        btnAgregar.TabIndex = 0
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' pnNombre
        ' 
        pnNombre.BackColor = Color.DarkRed
        pnNombre.Location = New Point(127, 35)
        pnNombre.Name = "pnNombre"
        pnNombre.Size = New Size(161, 10)
        pnNombre.TabIndex = 7
        pnNombre.Visible = False
        ' 
        ' pnApellido
        ' 
        pnApellido.BackColor = Color.DarkRed
        pnApellido.Location = New Point(127, 71)
        pnApellido.Name = "pnApellido"
        pnApellido.Size = New Size(161, 10)
        pnApellido.TabIndex = 8
        pnApellido.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightSkyBlue
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(279, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 37)
        Label1.TabIndex = 5
        Label1.Text = "Registro de Datos"
        ' 
        ' lblSuccess
        ' 
        lblSuccess.AutoSize = True
        lblSuccess.BackColor = Color.SeaGreen
        lblSuccess.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSuccess.ForeColor = SystemColors.Menu
        lblSuccess.Location = New Point(526, 63)
        lblSuccess.Name = "lblSuccess"
        lblSuccess.Size = New Size(169, 17)
        lblSuccess.TabIndex = 6
        lblSuccess.Text = "Registro añadido con éxito."
        lblSuccess.Visible = False
        ' 
        ' pctSuccess
        ' 
        pctSuccess.BackColor = Color.LightSkyBlue
        pctSuccess.BackgroundImageLayout = ImageLayout.Zoom
        pctSuccess.Image = My.Resources.Resources.comprobado
        pctSuccess.Location = New Point(505, 63)
        pctSuccess.Name = "pctSuccess"
        pctSuccess.Size = New Size(25, 17)
        pctSuccess.SizeMode = PictureBoxSizeMode.Zoom
        pctSuccess.TabIndex = 7
        pctSuccess.TabStop = False
        pctSuccess.Visible = False
        ' 
        ' lblWarning
        ' 
        lblWarning.AutoSize = True
        lblWarning.BackColor = Color.Orange
        lblWarning.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblWarning.ForeColor = Color.Transparent
        lblWarning.Location = New Point(138, 63)
        lblWarning.Name = "lblWarning"
        lblWarning.Size = New Size(176, 17)
        lblWarning.TabIndex = 6
        lblWarning.Text = "Complete todos los campos."
        lblWarning.Visible = False
        ' 
        ' pctWarning
        ' 
        pctWarning.BackColor = Color.LightSkyBlue
        pctWarning.BackgroundImageLayout = ImageLayout.Zoom
        pctWarning.Image = CType(resources.GetObject("pctWarning.Image"), Image)
        pctWarning.Location = New Point(117, 63)
        pctWarning.Name = "pctWarning"
        pctWarning.Size = New Size(25, 17)
        pctWarning.SizeMode = PictureBoxSizeMode.Zoom
        pctWarning.TabIndex = 7
        pctWarning.TabStop = False
        pctWarning.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightSkyBlue
        PictureBox1.Image = My.Resources.Resources._3456426
        PictureBox1.Location = New Point(229, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(44, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSkyBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(726, 82)
        Panel1.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightSkyBlue
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(0, 384)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(726, 35)
        Panel2.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightSkyBlue
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Highlight
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 11
        Label2.Text = "© Copyright 2024"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(723, 417)
        Controls.Add(Panel2)
        Controls.Add(pctWarning)
        Controls.Add(pctSuccess)
        Controls.Add(lblWarning)
        Controls.Add(lblSuccess)
        Controls.Add(lstDatos)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ActiveCaption
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registro"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pctSuccess, ComponentModel.ISupportInitialize).EndInit()
        CType(pctWarning, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lstDatos As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblErrorNombre As Label
    Friend WithEvents lblErrorApellido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSuccess As Label
    Friend WithEvents pctSuccess As PictureBox
    Friend WithEvents pnNombre As Panel
    Friend WithEvents pnApellido As Panel
    Friend WithEvents lblWarning As Label
    Friend WithEvents pctWarning As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
End Class
