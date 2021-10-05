
'conectar a base de datos 
Imports System.Data.SqlClient

Public Class Form1



    'objetos de sql
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'abrir formulario de registro
        Form2.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'abrir segundo formulario SI es admin
        If (TextBox1.Text = "administrador") Then

            Form3.Show()
        End If


        'abrir formulario SI es cliente 
        If (TextBox1.Text = "cliente") Then

            Form7.Show()
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'abrir formulario de salida 


        Form11.Show()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=BD_201904030;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try
            'Open the connection.
            myConn.Open()

            'msgbox para ver conexion de db
            If myConn.State() = 1 Then
                MsgBox("Conexión con éxito ")
            Else
                MsgBox("Conexión falló")
            End If

            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo salió mal")
        End Try





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=BD_201904030;" &
        "Data Source=localhost;Integrated Security=SSPI;")

        Try
            'Open the connection.
            myConn.Open()

            'Create a Command object.
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT nombre, apellido, tipo_usr FROM Usuario"

            'Open the connection.
            myConn.Open()
            myReader = myCmd.ExecuteReader()

            'Concatenate the query result into a string.
            Do While myReader.Read()
                results = results & myReader.GetString(0) & vbTab &
        myReader.GetString(1) & vbTab &
        myReader.GetString(2) & vbLf
            Loop

            'Display results.
            MsgBox(results)

            'Close the reader and the database connection.
            myReader.Close()
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), , "Algo salió mal")
        End Try
    End Sub
End Class
