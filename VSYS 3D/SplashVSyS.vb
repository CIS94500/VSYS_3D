Public NotInheritable Class SplashVSyS

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Configurez le texte de la boîte de dialogue au moment de l'exécution en fonction des informations d'assembly de l'application.  
        Version.Text = CDbl2(My.Application.Info.Version.Major & "." & _
                             My.Application.Info.Version.Minor & _
                             My.Application.Info.Version.Build & _
                             My.Application.Info.Version.Revision).ToString
        'Informations de copyright
        Copyright.Text = My.Application.Info.Copyright
    End Sub

End Class
