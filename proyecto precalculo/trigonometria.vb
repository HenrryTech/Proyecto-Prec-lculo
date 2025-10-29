Public Class trigonometria

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CA.TextChanged

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton1.Click
        Dim C_O As Integer = Convert.ToInt64(CO.Text)
        Dim C_A As Integer = Convert.ToInt64(CA.Text)

        Dim CA_pow As Integer = Math.Pow(C_A, 2)
        Dim CO_pow As Integer = Math.Pow(C_O, 2)

        Dim hipotenusa As Integer = Math.Sqrt((CA_pow + CO_pow))

        Hipo.Text = hipotenusa.ToString
        hipo2.Text = hipotenusa.ToString
    End Sub

    Private Sub CO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CO.KeyDown
        If e.KeyCode = Keys.Enter Then
            CA.Focus()      ' Pasa el foco a TextBox2
            e.SuppressKeyPress = True  ' Evita el “ding” al presionar Enter
        End If
    End Sub

    Private Sub CO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CO.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton2.Click
        Dim C_O As Integer = Convert.ToInt64(CO.Text)
        Dim hipotenusa As Integer = Convert.ToInt64(Hipo.Text)

        Dim Sen_B As Double = C_O / hipotenusa

        R_SenB.Text = Sen_B.ToString

    End Sub

    Private Sub Cos_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton3.Click
        Dim C_A As Integer = Convert.ToInt64(CA.Text)
        Dim hipotenusa As Integer = Convert.ToInt64(Hipo.Text)

        Dim Cos_B As Double = C_A / hipotenusa

        R_CosB.Text = Cos_B.ToString
    End Sub

    Private Sub boton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton4.Click
        Dim C_O As Integer = Convert.ToInt64(CO.Text)
        Dim C_A As Integer = Convert.ToInt64(CA.Text)

        Dim Tan_B As Double = C_O / C_A

        R_TanB.Text = Tan_B.ToString
    End Sub
End Class