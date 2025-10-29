<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trigonometria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trigonometria))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CO = New System.Windows.Forms.TextBox()
        Me.CA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Hipo = New System.Windows.Forms.Label()
        Me.boton1 = New System.Windows.Forms.Button()
        Me.hipo2 = New System.Windows.Forms.Label()
        Me.boton2 = New System.Windows.Forms.Button()
        Me.boton3 = New System.Windows.Forms.Button()
        Me.boton4 = New System.Windows.Forms.Button()
        Me.R_SenB = New System.Windows.Forms.Label()
        Me.R_CosB = New System.Windows.Forms.Label()
        Me.R_TanB = New System.Windows.Forms.Label()
        Me.name1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._new
        Me.PictureBox1.Location = New System.Drawing.Point(42, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "C.O"
        '
        'CO
        '
        Me.CO.Location = New System.Drawing.Point(20, 114)
        Me.CO.Name = "CO"
        Me.CO.Size = New System.Drawing.Size(29, 20)
        Me.CO.TabIndex = 2
        Me.CO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CA
        '
        Me.CA.Location = New System.Drawing.Point(138, 218)
        Me.CA.Name = "CA"
        Me.CA.Size = New System.Drawing.Size(29, 20)
        Me.CA.TabIndex = 4
        Me.CA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "C.A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hipotenusa"
        '
        'Hipo
        '
        Me.Hipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hipo.Location = New System.Drawing.Point(161, 91)
        Me.Hipo.Name = "Hipo"
        Me.Hipo.Size = New System.Drawing.Size(85, 19)
        Me.Hipo.TabIndex = 6
        Me.Hipo.Text = "    "
        Me.Hipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boton1
        '
        Me.boton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.boton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boton1.FlatAppearance.BorderSize = 0
        Me.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.boton1.Location = New System.Drawing.Point(316, 41)
        Me.boton1.Name = "boton1"
        Me.boton1.Size = New System.Drawing.Size(86, 44)
        Me.boton1.TabIndex = 8
        Me.boton1.Text = "Hipotenusa"
        Me.boton1.UseVisualStyleBackColor = False
        '
        'hipo2
        '
        Me.hipo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.hipo2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hipo2.Location = New System.Drawing.Point(425, 52)
        Me.hipo2.Name = "hipo2"
        Me.hipo2.Size = New System.Drawing.Size(85, 19)
        Me.hipo2.TabIndex = 9
        Me.hipo2.Text = "    "
        Me.hipo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boton2
        '
        Me.boton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.boton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boton2.FlatAppearance.BorderSize = 0
        Me.boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.boton2.Location = New System.Drawing.Point(316, 110)
        Me.boton2.Name = "boton2"
        Me.boton2.Size = New System.Drawing.Size(86, 44)
        Me.boton2.TabIndex = 10
        Me.boton2.Text = "Sen B"
        Me.boton2.UseVisualStyleBackColor = False
        '
        'boton3
        '
        Me.boton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.boton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boton3.FlatAppearance.BorderSize = 0
        Me.boton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.boton3.Location = New System.Drawing.Point(316, 160)
        Me.boton3.Name = "boton3"
        Me.boton3.Size = New System.Drawing.Size(86, 44)
        Me.boton3.TabIndex = 11
        Me.boton3.Text = "Cos B"
        Me.boton3.UseVisualStyleBackColor = False
        '
        'boton4
        '
        Me.boton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.boton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boton4.FlatAppearance.BorderSize = 0
        Me.boton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.boton4.Location = New System.Drawing.Point(316, 210)
        Me.boton4.Name = "boton4"
        Me.boton4.Size = New System.Drawing.Size(86, 44)
        Me.boton4.TabIndex = 12
        Me.boton4.Text = "Tan B"
        Me.boton4.UseVisualStyleBackColor = False
        '
        'R_SenB
        '
        Me.R_SenB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.R_SenB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R_SenB.Location = New System.Drawing.Point(425, 121)
        Me.R_SenB.Name = "R_SenB"
        Me.R_SenB.Size = New System.Drawing.Size(85, 19)
        Me.R_SenB.TabIndex = 13
        Me.R_SenB.Text = "    "
        Me.R_SenB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_CosB
        '
        Me.R_CosB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.R_CosB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R_CosB.Location = New System.Drawing.Point(425, 171)
        Me.R_CosB.Name = "R_CosB"
        Me.R_CosB.Size = New System.Drawing.Size(85, 19)
        Me.R_CosB.TabIndex = 14
        Me.R_CosB.Text = "    "
        Me.R_CosB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_TanB
        '
        Me.R_TanB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.R_TanB.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R_TanB.Location = New System.Drawing.Point(425, 221)
        Me.R_TanB.Name = "R_TanB"
        Me.R_TanB.Size = New System.Drawing.Size(85, 19)
        Me.R_TanB.TabIndex = 15
        Me.R_TanB.Text = "    "
        Me.R_TanB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'name1
        '
        Me.name1.AutoSize = True
        Me.name1.Location = New System.Drawing.Point(210, 248)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(0, 13)
        Me.name1.TabIndex = 16
        '
        'trigonometria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 288)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.R_TanB)
        Me.Controls.Add(Me.R_CosB)
        Me.Controls.Add(Me.R_SenB)
        Me.Controls.Add(Me.boton4)
        Me.Controls.Add(Me.boton3)
        Me.Controls.Add(Me.boton2)
        Me.Controls.Add(Me.hipo2)
        Me.Controls.Add(Me.boton1)
        Me.Controls.Add(Me.Hipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "trigonometria"
        Me.Text = "Trigonometría"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CO As System.Windows.Forms.TextBox
    Friend WithEvents CA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Hipo As System.Windows.Forms.Label
    Friend WithEvents boton1 As System.Windows.Forms.Button
    Friend WithEvents hipo2 As System.Windows.Forms.Label
    Friend WithEvents boton2 As System.Windows.Forms.Button
    Friend WithEvents boton3 As System.Windows.Forms.Button
    Friend WithEvents boton4 As System.Windows.Forms.Button
    Friend WithEvents R_SenB As System.Windows.Forms.Label
    Friend WithEvents R_CosB As System.Windows.Forms.Label
    Friend WithEvents R_TanB As System.Windows.Forms.Label
    Friend WithEvents name1 As System.Windows.Forms.Label
End Class
