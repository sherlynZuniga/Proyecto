Public Class Form4
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'regresar
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        'agregando los datos al datagridview

        DataGridView1.Rows.Add("Editorial Santillana, S.A", "26 av. 2-20; Ciudad de Guatemala")
        DataGridView1.Rows.Add("Ediciones Susaeta Guatemala", "Av 28 10-55 Z.4 de Mixco, El Naranjo")
        DataGridView1.Rows.Add("Editorial Sur, S.A", "13 calle 9 -31 zona 1 Edificio de Prensa ")



    End Sub
End Class