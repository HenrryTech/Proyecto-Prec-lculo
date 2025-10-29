Public Class resta_cuadrada

    Private Sub valorA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles valorA.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValorB.Focus()      ' Pasa el foco a TextBox2
            e.SuppressKeyPress = True  ' Evita el “ding” al presionar Enter
        End If
    End Sub

    Private Sub valorA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valorA.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim A As Integer = Convert.ToInt64(valorA.Text)
        Dim B As Integer = Convert.ToInt64(ValorB.Text)

        Dim a_alcuadrado As Integer = Math.Pow(A, 2) - ((2 * A) * B) - Math.Pow(B, 2)
        resultado.Text = a_alcuadrado.ToString


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class