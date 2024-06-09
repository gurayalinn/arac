Imports System.Windows.Forms

Public Class LoginForm
    Private userController As UserController
    Private user As User
    Private UserId As Integer

    Public Sub New()
        InitializeComponent()
        userController = New UserController((""))
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        'Sql Injection Check
        If username.Contains("'") Or password.Contains("'") Then
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            MessageBox.Show("Kullanıcı adı veya şifre hatalı.")
            Return
        End If

        If isEmpty(username) Or isEmpty(password) Then
            MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.")
            Return
        End If

        Dim user = userController.Login(username, password)
        If user IsNot Nothing Then
            Dim isAdmin = userController.IsAdmin(username)
            If isAdmin Then
                DialogResult = DialogResult.OK
                Dim AdminHome As New AdminHome(user)
                ShowForm(AdminHome)
                Me.Hide()
                Return

            Else
                DialogResult = DialogResult.OK
                Dim Home As New Home(user)
                ShowForm(Home)
                Me.Hide()
                Return
            End If

        Else
            MessageBox.Show("Kullanıcı adı veya şifre hatalı.")
        End If


    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        AppNotifyIcon.Text = "Araç"
        AppNotifyIcon.Visible = True
        AppNotifyIcon.BalloonTipTitle = "Araç"
        AppNotifyIcon.BalloonTipText = "Uygulama tepsi modunda çalışmaya devam etmekte."


        AddHandler AppMenuItemCikis.Click, AddressOf AppMenuItemCikis_Click
        AppMenu.Items.Add(AppMenuItemCikis)

        AppNotifyIcon.ContextMenuStrip = AppMenu


        TransparentLabel(Label2, PictureBox1)
        TransparentLabel(Label3, PictureBox1)
        TransparentLabel(SplashTitle, PictureBox1)


    End Sub

    Private Function isEmpty(value As String) As Boolean
        Return value = ""
    End Function


    Private Sub ShowForm(pageForm As Form)
        pageForm.TopLevel = True
        pageForm.Show()
        pageForm.BringToFront()
        pageForm.Focus()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ShowForm(RegisterForm)
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        DialogResult = DialogResult.OK
        Dim user As New User
        user.Username = "admin"
        user.Role = 1
        user.Id = 1
        user.Name = "Admin"
        user.Surname = "Account"
        user.Email = "admin@arac.local"
        user.Password = "admin123"
        Dim AdminHome As New AdminHome(user)
        ShowForm(AdminHome)
        Me.Hide()
    End Sub


    Private Sub TransparentLabel(label As Label, parent As PictureBox)
        label.Parent = parent
        label.FlatStyle = FlatStyle.Standard
        label.BackColor = Color.Transparent
    End Sub

    Private Sub AppMenuItemCikis_Click(sender As Object, e As EventArgs) Handles AppMenuItemCikis.Click
        AppNotifyIcon.Visible = False
        Application.Exit()
    End Sub

    Private Sub AppNotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles AppNotifyIcon.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.Focus()
    End Sub


    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Me.WindowState = FormWindowState.Minimized Then
            AppNotifyIcon.ShowBalloonTip(1000)
            Me.Hide()
        End If
    End Sub


    Public Class UserInfo
        Public Property Username As String
        Public Property Role As String
        Public Property Id As Integer
    End Class

    Private Sub BtnSifre_Click(sender As Object, e As EventArgs) Handles BtnSifre.Click
        Dim data As New ResetPassword()
        data.ShowDialog()
    End Sub
End Class

