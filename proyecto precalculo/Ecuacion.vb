Public Class Ecuacion

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles caja_x1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Caja_x2.Focus()      ' Pasa el foco a TextBox2
            e.SuppressKeyPress = True  ' Evita el “ding” al presionar Enter
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caja_x1.TextChanged

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub inicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inicio.Click

        Dim y1 As Integer = Convert.ToInt64(Caja_y1.Text)
        Dim y2 As Integer = Convert.ToInt64(Caja_y2.Text)
        Dim resta_Y As Integer = y2 - y1

        Dim x1 As Integer = Convert.ToInt64(caja_x1.Text)
        Dim x2 As Integer = Convert.ToInt64(Caja_x2.Text)

        Dim resta_X As Integer = x2 - x1

        arriba.Text = resta_Y.ToString
        abajo.Text = resta_X.ToString

        Dim resultado_división As Double = resta_Y / resta_X
        Resultado.Text = resultado_división.ToString








    End Sub

    Private Sub x2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub x2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub x2_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Caja_x2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Caja_y1.Focus()      ' Pasa el foco a TextBox2
            e.SuppressKeyPress = True  ' Evita el “ding” al presionar Enter
        End If
    End Sub

    Private Sub x2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caja_x2.TextChanged

    End Sub

    Private Sub y1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Caja_y1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Caja_y2.Focus()      ' Pasa el foco a TextBox2
            e.SuppressKeyPress = True  ' Evita el “ding” al presionar Enter
        End If
    End Sub

    Private Sub y1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caja_y1.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Caja_y2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caja_y2.TextChanged

    End Sub

    Private Sub Ecuacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub arriba_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arriba.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        caja_x1.Text = ""
        Caja_x2.Text = ""
        Caja_y1.Text = ""
        Caja_y2.Text = ""
        arriba.Text = ""
        abajo.Text = ""
        Resultado.Text = ""



    End Sub
End Class