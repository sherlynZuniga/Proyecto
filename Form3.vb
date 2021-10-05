Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'abrir formulario gestionar editoriales

        Form4.Show()
        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'abrir formulario gestionar libros 

        Form12.Show()
        Me.Close()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'abrir formulario reportes

        Form6.Show()
        Me.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'regresar

        Form1.Show()
        Me.Close()



    End Sub
End Class