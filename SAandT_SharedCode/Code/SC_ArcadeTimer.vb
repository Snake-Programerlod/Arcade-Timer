Public Class SC_ArcadeTimer

    Public Function GetLauncherPath() As String
        Try
            Return "F:\Games\RocketLauncher\RocketLauncher.exe"
        Catch ex As Exception
            Throw New ArgumentException("Problemas al ejecutar la instrucion GetLauncherPath, Error: " & ex.Message & " - " & ex.StackTrace.ToString.Trim)
        End Try
    End Function

End Class
