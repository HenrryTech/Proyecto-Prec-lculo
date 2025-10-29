Public Class productos_notables

    Private Sub inicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inicio.Click
        Me.Hide() ' Oculta el formulario actual (Form1)
        Dim f As New suma_cuadrada()
        f.ShowDialog() ' Muestra Form2 y bloquea la ejecución hasta que lo cierres
        Me.Show() ' Vuelve a mostrar Form1 cuando cierres Form2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide() ' Oculta el formulario actual (Form1)
        Dim f As New resta_cuadrada()
        f.ShowDialog() ' Muestra Form2 y bloquea la ejecución hasta que lo cierres
        Me.Show() ' Vuelve a mostrar Form1 cuando cierres Form2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide() ' Oculta el formulario actual (Form1)
        Dim f As New suma_cubo()
        f.ShowDialog() ' Muestra Form2 y bloquea la ejecución hasta que lo cierres
        Me.Show() ' Vuelve a mostrar Form1 cuando cierres Form2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide() ' Oculta el formulario actual (Form1)
        Dim f As New resta_cubo()
        f.ShowDialog() ' Muestra Form2 y bloquea la ejecución hasta que lo cierres
        Me.Show() ' Vuelve a mostrar Form1 cuando cierres Form2
    End Sub

    Private Sub productos_notables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class