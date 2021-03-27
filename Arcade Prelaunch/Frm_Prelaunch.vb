Imports SAandT_SharedCode
Imports SAandT_SharedCode.SC_ArcadeTimer

Public Class Frm_Prelaunch

    Private _FullLauncherPath As String
    Public Property FullLauncherPath() As String
        Get
            Return _FullLauncherPath
        End Get
        Set(ByVal value As String)
            _FullLauncherPath = value
        End Set
    End Property

    Dim SC_ATimer As New SC_ArcadeTimer

    Private Sub Frm_Prelaunch_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim MyProcces As New Process
        Dim MyArguments As New ProcessStartInfo
        FullLauncherPath = SC_ATimer.GetLauncherPath()

        Try

            'Validamos que haya argumentos que procesar
            If My.Application.CommandLineArgs.Count = 0 Then
                Throw New ArgumentException("No se encontraron los argumentos necesarios para lanzar el emulador")
            End If

            'Asignamos el launcher
            MyArguments.FileName = FullLauncherPath

            'Obtenemos todos los argumentos
            For Each arrg As String In My.Application.CommandLineArgs
                MyArguments.Arguments = MyArguments.Arguments & """" & arrg & """" & " "
            Next

            'Limpiamos los argumentos
            MyArguments.Arguments = MyArguments.Arguments.ToString.Trim

            'Registramos el log
            Logger.i(MyArguments.Arguments)

            'Inicializamos los argumentos
            MyProcces.StartInfo = MyArguments

            'Ejecutamos el proceso.
            MyProcces.Start()

        Catch ex As Exception

            'Registramos el error en el log
            Logger.e("No se logro completar el lanzamiento", ex)

        Finally

            'Cerramos el formulario.
            Me.Close()

        End Try
    End Sub
End Class