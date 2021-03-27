Imports SAandT_SharedCode

Public Class Frm_Timer

    Dim SC_ATimer As New SAandT_SharedCode.SC_ArcadeTimer

    Private Sub Frm_Timer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try



        Catch ex As Exception
            MessageBox.Show("Problemas al cargar el formulario, Error: " & ex.Message & " - " & ex.StackTrace.ToString)
        End Try
    End Sub
End Class