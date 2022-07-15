<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCrearCuenta = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextSaldo = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtNumIdent = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnDetalleTransaccion = New System.Windows.Forms.Button()
        Me.BtnSaldoD = New System.Windows.Forms.Button()
        Me.BtnRetirarD = New System.Windows.Forms.Button()
        Me.BtnIngresarD = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LiRetiros = New System.Windows.Forms.ListBox()
        Me.LiIngresos = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.BtnCrearCuenta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextSaldo)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtNumIdent)
        Me.GroupBox1.Controls.Add(Me.TxtNombres)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(56, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 170)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Cuenta"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnNuevo.Location = New System.Drawing.Point(373, 116)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 32)
        Me.BtnNuevo.TabIndex = 11
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnCrearCuenta
        '
        Me.BtnCrearCuenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnCrearCuenta.Location = New System.Drawing.Point(249, 116)
        Me.BtnCrearCuenta.Name = "BtnCrearCuenta"
        Me.BtnCrearCuenta.Size = New System.Drawing.Size(101, 32)
        Me.BtnCrearCuenta.TabIndex = 10
        Me.BtnCrearCuenta.Text = "Crear Cuenta"
        Me.BtnCrearCuenta.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(576, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Saldo Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Número de Identificación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombres"
        '
        'TextSaldo
        '
        Me.TextSaldo.Location = New System.Drawing.Point(560, 66)
        Me.TextSaldo.Name = "TextSaldo"
        Me.TextSaldo.Size = New System.Drawing.Size(100, 23)
        Me.TextSaldo.TabIndex = 4
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(438, 66)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 23)
        Me.TxtTelefono.TabIndex = 3
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(318, 66)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(100, 23)
        Me.TxtDireccion.TabIndex = 2
        '
        'TxtNumIdent
        '
        Me.TxtNumIdent.Location = New System.Drawing.Point(161, 66)
        Me.TxtNumIdent.Name = "TxtNumIdent"
        Me.TxtNumIdent.Size = New System.Drawing.Size(142, 23)
        Me.TxtNumIdent.TabIndex = 1
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(31, 66)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(108, 23)
        Me.TxtNombres.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Controls.Add(Me.BtnDetalleTransaccion)
        Me.GroupBox2.Controls.Add(Me.BtnSaldoD)
        Me.GroupBox2.Controls.Add(Me.BtnRetirarD)
        Me.GroupBox2.Controls.Add(Me.BtnIngresarD)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 182)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transacciones"
        '
        'BtnDetalleTransaccion
        '
        Me.BtnDetalleTransaccion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnDetalleTransaccion.Location = New System.Drawing.Point(531, 64)
        Me.BtnDetalleTransaccion.Name = "BtnDetalleTransaccion"
        Me.BtnDetalleTransaccion.Size = New System.Drawing.Size(129, 46)
        Me.BtnDetalleTransaccion.TabIndex = 3
        Me.BtnDetalleTransaccion.Text = "Ver Detalle Transacciones"
        Me.BtnDetalleTransaccion.UseVisualStyleBackColor = False
        '
        'BtnSaldoD
        '
        Me.BtnSaldoD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnSaldoD.Location = New System.Drawing.Point(359, 64)
        Me.BtnSaldoD.Name = "BtnSaldoD"
        Me.BtnSaldoD.Size = New System.Drawing.Size(142, 46)
        Me.BtnSaldoD.TabIndex = 2
        Me.BtnSaldoD.Text = "Ver Saldo Disponible"
        Me.BtnSaldoD.UseVisualStyleBackColor = False
        '
        'BtnRetirarD
        '
        Me.BtnRetirarD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnRetirarD.Location = New System.Drawing.Point(188, 64)
        Me.BtnRetirarD.Name = "BtnRetirarD"
        Me.BtnRetirarD.Size = New System.Drawing.Size(144, 46)
        Me.BtnRetirarD.TabIndex = 1
        Me.BtnRetirarD.Text = "Retirar Dinero"
        Me.BtnRetirarD.UseVisualStyleBackColor = False
        '
        'BtnIngresarD
        '
        Me.BtnIngresarD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnIngresarD.Location = New System.Drawing.Point(31, 64)
        Me.BtnIngresarD.Name = "BtnIngresarD"
        Me.BtnIngresarD.Size = New System.Drawing.Size(124, 46)
        Me.BtnIngresarD.TabIndex = 0
        Me.BtnIngresarD.Text = "Ingreso Dinero"
        Me.BtnIngresarD.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Controls.Add(Me.LiRetiros)
        Me.GroupBox3.Controls.Add(Me.LiIngresos)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(57, 438)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(692, 337)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial de Transacciones Cuenta"
        '
        'LiRetiros
        '
        Me.LiRetiros.FormattingEnabled = True
        Me.LiRetiros.ItemHeight = 15
        Me.LiRetiros.Location = New System.Drawing.Point(342, 71)
        Me.LiRetiros.Name = "LiRetiros"
        Me.LiRetiros.Size = New System.Drawing.Size(329, 229)
        Me.LiRetiros.TabIndex = 3
        '
        'LiIngresos
        '
        Me.LiIngresos.FormattingEnabled = True
        Me.LiIngresos.ItemHeight = 15
        Me.LiIngresos.Location = New System.Drawing.Point(17, 71)
        Me.LiIngresos.Name = "LiIngresos"
        Me.LiIngresos.Size = New System.Drawing.Size(313, 229)
        Me.LiIngresos.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(461, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "RETIROS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(135, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "INGRESOS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 786)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCrearCuenta As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextSaldo As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtNumIdent As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnDetalleTransaccion As Button
    Friend WithEvents BtnSaldoD As Button
    Friend WithEvents BtnRetirarD As Button
    Friend WithEvents BtnIngresarD As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LiRetiros As ListBox
    Friend WithEvents LiIngresos As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
