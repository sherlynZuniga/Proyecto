Public Class Form7
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'mostrar editar perfil 
        Me.Close()
        Form8.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'mostrar libros prestados 


        Form9.Show()
        Me.Close()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'mostrar prestar libros 


        Form10.Show()
        Me.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'regresar

        Form1.Show()
        Me.Close()


    End Sub
End Class