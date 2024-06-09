Public Class Splash
    ' SplashTitle label background color is set to transparent

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashTitle.Parent = PictureBox1
        SplashTitle.FlatStyle = FlatStyle.Standard
        SplashTitle.BackColor = Color.Transparent
    End Sub

End Class
