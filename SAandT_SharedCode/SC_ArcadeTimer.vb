Public Class SC_ArcadeTimer

    Public Function HolaMundo(ByVal sNombre As String) As String
        Try

            Return "Hola mundo, te saluda: " & sNombre

        Catch ex As Exception
            Throw New ArgumentException("Problemas al ejecutar la instrucion HolaMundo, Error: " & ex.Message & " - " & ex.StackTrace.ToString.Trim)
        End Try
    End Function

End Class
