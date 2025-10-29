<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suma_cuadrada
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.valorA = New System.Windows.Forms.TextBox()
        Me.ValorB = New System.Windows.Forms.TextBox()
        Me.resultado = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(164, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "b"
        '
        'valorA
        '
        Me.valorA.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorA.Location = New System.Drawing.Point(43, 29)
        Me.valorA.Multiline = True
        Me.valorA.Name = "valorA"
        Me.valorA.Size = New System.Drawing.Size(69, 36)
        Me.valorA.TabIndex = 3
        Me.valorA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValorB
        '
        Me.ValorB.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorB.Location = New System.Drawing.Point(190, 29)
        Me.ValorB.Multiline = True
        Me.ValorB.Name = "ValorB"
        Me.ValorB.Size = New System.Drawing.Size(69, 36)
        Me.ValorB.TabIndex = 4
        Me.ValorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'resultado
        '
        Me.resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultado.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(41, 79)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(218, 59)
        Me.resultado.TabIndex = 5
        Me.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(70, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 44)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Resolver"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'suma_cuadrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 254)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.ValorB)
        Me.Controls.Add(Me.valorA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "suma_cuadrada"
        Me.Text = "Suma Cuadrada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents valorA As System.Windows.Forms.TextBox
    Friend WithEvents ValorB As System.Windows.Forms.TextBox
    Friend WithEvents resultado As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
