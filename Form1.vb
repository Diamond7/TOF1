Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub txtLegajo_TextChanged(sender As Object, e As EventArgs) Handles txtLegajo.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resu As Int16

        resu = MsgBox("Cerrará la aplicación. ¿ Esta seguro de continuar con la operación ?", MsgBoxStyle.OkCancel, "Cerrar Aplicación")
        If resu = 1 Then  ' 1 es ok, 0 es cancelar 
            End
        End If


    End Sub

    Private Sub BuscarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarRegistroToolStripMenuItem.Click

    End Sub
End Class
