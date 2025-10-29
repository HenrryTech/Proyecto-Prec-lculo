Public Class principal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inicio.Click
        Me.Hide() ' Oculta el formulario actual (Form1)
        Dim f As New operaciones_basicas()
        f.ShowDialog() ' Muestra Form2 y bloquea la ejecución hasta que lo cierres
        Me.Show() ' Vuelve a mostrar Form1 cuando cierres Form2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide() ' Oculta el formulario actual (Form1)
        Dim f As New Ecuacion()
        f.ShowDialog() ' Muestra Form2 y bloquea la ejecución hasta que lo cierres
        Me.Show() ' Vuelve a mostrar Form1 cuando cierres Form2
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide() ' Oculta el formulario actual (Form1)
        Dim f As New trigonometria()
        f.ShowDialog() ' Muestra Form2 y bloquea la ejecución hasta que lo cierres
        Me.Show() ' Vuelve a mostrar Form1 cuando cierres Form2



    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide() ' Oculta el formulario actual (Form1)
        Dim f As New productos_notables()
        f.ShowDialog() ' Muestra Form2 y bloquea la ejecución hasta que lo cierres
        Me.Show() ' Vuelve a mostrar Form1 cuando cierres Form2
    End Sub
End Class
