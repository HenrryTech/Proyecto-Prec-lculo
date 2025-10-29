Public Class suma_cubo

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim A As Integer = Convert.ToInt64(valorA.Text)
        Dim B As Integer = Convert.ToInt64(ValorB.Text)

        Dim a_alcuadrado As Double = Math.Pow(A, 3) + (3 * Math.Pow(A, 2) * B) + (3 * A * Math.Pow(B, 2)) + Math.Pow(B, 3)

        resultado.Text = a_alcuadrado.ToString()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub suma_cubo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub valorA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles valorA.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValorB.Focus()      ' Pasa el foco a TextBox2
            e.SuppressKeyPress = True  ' Evita el “ding” al presionar Enter
        End If
    End Sub

    Private Sub valorA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valorA.TextChanged

    End Sub
End Class