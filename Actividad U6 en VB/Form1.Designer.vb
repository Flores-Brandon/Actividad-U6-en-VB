<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.txtLibro = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.lblLibro = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(124, 232)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(319, 22)
        Me.txtAño.TabIndex = 18
        '
        'txtDirector
        '
        Me.txtDirector.Location = New System.Drawing.Point(124, 182)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(319, 22)
        Me.txtDirector.TabIndex = 17
        '
        'txtLibro
        '
        Me.txtLibro.Location = New System.Drawing.Point(124, 132)
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.Size = New System.Drawing.Size(319, 22)
        Me.txtLibro.TabIndex = 16
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(121, 9)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(399, 54)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Escribe el Nombre, su Director y Su año de estreno  "
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(43, 238)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(31, 16)
        Me.lblAño.TabIndex = 14
        Me.lblAño.Text = "Año"
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.Location = New System.Drawing.Point(43, 188)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(54, 16)
        Me.lblDirector.TabIndex = 13
        Me.lblDirector.Text = "Director"
        '
        'lblLibro
        '
        Me.lblLibro.AutoSize = True
        Me.lblLibro.Location = New System.Drawing.Point(43, 138)
        Me.lblLibro.Name = "lblLibro"
        Me.lblLibro.Size = New System.Drawing.Size(37, 16)
        Me.lblLibro.TabIndex = 12
        Me.lblLibro.Text = "Libro"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(627, 196)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 58)
        Me.btnMostrar.TabIndex = 11
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(627, 132)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 55)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtDirector)
        Me.Controls.Add(Me.txtLibro)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.lblDirector)
        Me.Controls.Add(Me.lblLibro)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtAño As TextBox
    Private WithEvents txtDirector As TextBox
    Private WithEvents txtLibro As TextBox
    Private WithEvents label4 As Label
    Private WithEvents lblAño As Label
    Private WithEvents lblDirector As Label
    Private WithEvents lblLibro As Label
    Private WithEvents btnMostrar As Button
    Private WithEvents btnGuardar As Button
End Class
