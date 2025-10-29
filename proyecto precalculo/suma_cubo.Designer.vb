<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suma_cubo
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.resultado = New System.Windows.Forms.Label()
        Me.ValorB = New System.Windows.Forms.TextBox()
        Me.valorA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(76, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 44)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Resolver"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'resultado
        '
        Me.resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultado.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(47, 92)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(218, 59)
        Me.resultado.TabIndex = 27
        Me.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValorB
        '
        Me.ValorB.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorB.Location = New System.Drawing.Point(196, 42)
        Me.ValorB.Multiline = True
        Me.ValorB.Name = "ValorB"
        Me.ValorB.Size = New System.Drawing.Size(69, 36)
        Me.ValorB.TabIndex = 26
        Me.ValorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'valorA
        '
        Me.valorA.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorA.Location = New System.Drawing.Point(49, 42)
        Me.valorA.Multiline = True
        Me.valorA.Name = "valorA"
        Me.valorA.Size = New System.Drawing.Size(69, 36)
        Me.valorA.TabIndex = 25
        Me.valorA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "b"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "a"
        '
        'suma_cubo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 288)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.ValorB)
        Me.Controls.Add(Me.valorA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "suma_cubo"
        Me.Text = "Suma Cubo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents resultado As System.Windows.Forms.Label
    Friend WithEvents ValorB As System.Windows.Forms.TextBox
    Friend WithEvents valorA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
