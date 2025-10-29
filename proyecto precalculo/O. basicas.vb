Public Class operaciones_basicas

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles variable1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Variable2.Focus()      ' Pasa el foco a TextBox2
            e.SuppressKeyPress = True  ' Evita el “ding” al presionar Enter
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles variable1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_multi.Click
        Dim num1 As Integer = Convert.ToInt64(variable1.Text)
        Dim num2 As Integer = Convert.ToInt64(Variable2.Text)
        Dim resutado As Integer = num1 * num2
        TextBox1.Text = resutado.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_suma.Click
        Dim num1 As Integer = Convert.ToInt64(variable1.Text)
        Dim num2 As Integer = Convert.ToInt64(Variable2.Text)
        Dim resutado As Integer = num1 + num2
        TextBox1.Text = resutado.ToString

    End Sub

    Private Sub Boton_resta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_resta.Click

        Dim num1 As Integer = Convert.ToInt64(variable1.Text)
        Dim num2 As Integer = Convert.ToInt64(Variable2.Text)
        Dim resutado As Integer = num1 - num2
        TextBox1.Text = resutado.ToString
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        variable1.Text = " "
        Variable2.Text = ""
        TextBox1.Text = ""
        variable1.Focus()


    End Sub

    Private Sub Boton_division_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_division.Click
        Dim num1 As Integer = Convert.ToInt64(variable1.Text)
        Dim num2 As Integer = Convert.ToInt64(Variable2.Text)

        If num2 = 0 Then
            MessageBox.Show("No puedes dividir dentro de 0", "Error")
        End If
        Dim resutado As Double = num1 / num2
        TextBox1.Text = resutado.ToString
        variable1.Text = ""
        Variable2.Text = ""

        End
    End Sub

    Private Sub Button4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button4.KeyDown
        
    End Sub
End Class