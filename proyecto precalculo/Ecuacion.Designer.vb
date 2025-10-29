<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ecuacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ecuacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.caja_x1 = New System.Windows.Forms.TextBox()
        Me.inicio = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Caja_x2 = New System.Windows.Forms.TextBox()
        Me.Caja_y1 = New System.Windows.Forms.TextBox()
        Me.Caja_y2 = New System.Windows.Forms.TextBox()
        Me.arriba = New System.Windows.Forms.TextBox()
        Me.abajo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " X2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " X1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Y2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 38)
        Me.Label5.TabIndex = 4
        '
        'caja_x1
        '
        Me.caja_x1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caja_x1.Location = New System.Drawing.Point(136, 33)
        Me.caja_x1.Multiline = True
        Me.caja_x1.Name = "caja_x1"
        Me.caja_x1.Size = New System.Drawing.Size(59, 25)
        Me.caja_x1.TabIndex = 13
        '
        'inicio
        '
        Me.inicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.inicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inicio.FlatAppearance.BorderSize = 0
        Me.inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inicio.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.inicio.Location = New System.Drawing.Point(92, 271)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(153, 44)
        Me.inicio.TabIndex = 17
        Me.inicio.Text = "Resolver"
        Me.inicio.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = " Y1"
        '
        'Caja_x2
        '
        Me.Caja_x2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caja_x2.Location = New System.Drawing.Point(278, 33)
        Me.Caja_x2.Multiline = True
        Me.Caja_x2.Name = "Caja_x2"
        Me.Caja_x2.Size = New System.Drawing.Size(59, 25)
        Me.Caja_x2.TabIndex = 19
        '
        'Caja_y1
        '
        Me.Caja_y1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caja_y1.Location = New System.Drawing.Point(136, 95)
        Me.Caja_y1.Multiline = True
        Me.Caja_y1.Name = "Caja_y1"
        Me.Caja_y1.Size = New System.Drawing.Size(59, 25)
        Me.Caja_y1.TabIndex = 20
        '
        'Caja_y2
        '
        Me.Caja_y2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caja_y2.Location = New System.Drawing.Point(278, 95)
        Me.Caja_y2.Multiline = True
        Me.Caja_y2.Name = "Caja_y2"
        Me.Caja_y2.Size = New System.Drawing.Size(59, 25)
        Me.Caja_y2.TabIndex = 21
        '
        'arriba
        '
        Me.arriba.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arriba.Location = New System.Drawing.Point(115, 154)
        Me.arriba.Multiline = True
        Me.arriba.Name = "arriba"
        Me.arriba.Size = New System.Drawing.Size(33, 34)
        Me.arriba.TabIndex = 22
        Me.arriba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'abajo
        '
        Me.abajo.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abajo.Location = New System.Drawing.Point(115, 194)
        Me.abajo.Multiline = True
        Me.abajo.Name = "abajo"
        Me.abajo.Size = New System.Drawing.Size(33, 34)
        Me.abajo.TabIndex = 23
        Me.abajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(154, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Dividendo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Divisor"
        '
        'Resultado
        '
        Me.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Resultado.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(243, 176)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(99, 25)
        Me.Resultado.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(269, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 25)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Ecuacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 371)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.abajo)
        Me.Controls.Add(Me.arriba)
        Me.Controls.Add(Me.Caja_y2)
        Me.Controls.Add(Me.Caja_y1)
        Me.Controls.Add(Me.Caja_x2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inicio)
        Me.Controls.Add(Me.caja_x1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ecuacion"
        Me.Text = " Ecuación de la Recta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents caja_x1 As System.Windows.Forms.TextBox
    Friend WithEvents inicio As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Caja_x2 As System.Windows.Forms.TextBox
    Friend WithEvents Caja_y1 As System.Windows.Forms.TextBox
    Friend WithEvents Caja_y2 As System.Windows.Forms.TextBox
    Friend WithEvents arriba As System.Windows.Forms.TextBox
    Friend WithEvents abajo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Resultado As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
