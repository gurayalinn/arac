Imports System.Net.Mail
Imports System.Net

Public Class ResetPassword
    Inherits Form
    Private userController As UserController
    Private user As User
    Private UserId As Integer
    Private resetCode As String

    Public Sub New()
        InitializeComponent()
        userController = New UserController((""))
    End Sub

    Public Sub New(id As Integer)
        UserId = id
        InitializeComponent()
        userController = New UserController((""))
    End Sub

    Private Sub ResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblMail.Enabled = True
        LblMail.Visible = True
        txtEmail.Enabled = True
        txtEmail.Visible = True

        BtnKod.Enabled = False
        BtnKod.Visible = True

        LblKod.Enabled = True
        LblKod.Visible = True
        TxtKod.Enabled = False
        TxtKod.Visible = True

        BtnKodDogrula.Enabled = False
        BtnKodDogrula.Visible = True


        LblPassword.Enabled = False
        LblPassword.Visible = False
        TxtPassword.Enabled = False
        TxtPassword.Visible = False
        BtnSifirla.Enabled = False
        BtnSifirla.Visible = False

    End Sub


    Private Function GenerateVerificationCode() As String
        Return New Random().Next(1000, 9999).ToString()
    End Function

    Private Sub BtnKod_Click(sender As Object, e As EventArgs) Handles BtnKod.Click
        Dim email As String = txtEmail.Text
        If ValidateEmail(email) Then
            If Not CheckUserExist(email) Then
                MessageBox.Show("Kullanıcı bulunamadı.")
                BtnKod.Enabled = False
                txtEmail.Enabled = True
                txtEmail.Text = ""
                txtEmail.Focus()
                Return
            End If
            resetCode = GenerateVerificationCode()
            SendVerificationCode(email, resetCode)
            BtnKod.Enabled = False
            txtEmail.Enabled = False
            TxtKod.Focus()
        Else
            MessageBox.Show("Geçerli bir e-posta adresi girin.")
            txtEmail.Focus()
        End If
    End Sub

    Private Sub BtnSifirla_Click(sender As Object, e As EventArgs) Handles BtnSifirla.Click
        Dim NewPassword As String = TxtPassword.Text
        Dim result As Boolean = userController.ChangePassword(UserId, NewPassword)
        If result Then
            MessageBox.Show("Şifre başarıyla değiştirildi.")
            Me.Close()
        Else
            MessageBox.Show("Şifre değiştirilemedi.")
            Me.Close()
        End If
    End Sub

    Private Sub BtnKodDogrula_Click(sender As Object, e As EventArgs) Handles BtnKodDogrula.Click
        Dim inputCode As String = TxtKod.Text
        If inputCode = resetCode Then
            LblPassword.Enabled = True
            LblPassword.Visible = True
            TxtPassword.Enabled = True
            TxtPassword.Visible = True
            BtnSifirla.Enabled = False
            BtnSifirla.Visible = True
            BtnKodDogrula.Enabled = False
            TxtKod.Enabled = False
            Dim user As User = userController.GetUserByEmail(txtEmail.Text)
            UserId = user.Id
            TxtPassword.Focus()
        Else
            MessageBox.Show("Doğrulama kodu yanlış.")
            BtnKod.Enabled = False
            TxtKod.Text = ""
            TxtKod.Focus()
        End If
    End Sub



    Private Function ValidateEmail(email As String) As Boolean
        Return email.Contains("@") And email.Contains(".")
    End Function

    Private Function ValidatePassword(password As String) As Boolean
        Return password.Length >= 8
    End Function

    Private Function CheckUserExist(email As String) As Boolean
        If userController.GetUserByEmail(email) Is Nothing Then
            Return False
        End If
        Return True
    End Function


    Private Sub SendVerificationCode(email As String, code As String)
        If email.Length = 0 Then
            MessageBox.Show("E-posta adresi boş olamaz.")
            Return
        End If

        BtnKodDogrula.Enabled = False
        TxtKod.Enabled = True
        TxtKod.Visible = True
        LblKod.Enabled = True
        LblKod.Visible = True

        'Dim smtpClient As New SmtpClient("smtp.gmail.com")
        'SmtpClient.Port = 587
        'SmtpClient.EnableSsl = True
        'SmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
        'Dim emailUser As String = Environment.GetEnvironmentVariable("GMAIL_USER")
        'Dim emailPassword As String = Environment.GetEnvironmentVariable("GMAIL_PASSWORD")
        'SmtpClient.Credentials = New NetworkCredential(emailUser, emailPassword)

        'Dim mail As New MailMessage()
        'Mail.From = New MailAddress(emailUser)
        'Mail.To.Add(email)
        'Mail.Subject = "Araç Kiralama Otomasyonu - Şifre Sıfırlama Kodu"
        'Mail.Body = $"Şifre sıfırlama kodunuz: {code}"
        'Mail.CC.Add("gurayalinw@gmail.com")

        'SmtpClient.Send(mail)

        MessageBox.Show("Doğrulama kodu e-posta adresinize gönderildi. : " + resetCode)
    End Sub


    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        BtnSifirla.Enabled = TxtPassword.Text.Length > 0
    End Sub

    Private Sub TxtKod_TextChanged(sender As Object, e As EventArgs) Handles TxtKod.TextChanged
        BtnKodDogrula.Enabled = TxtKod.Text.Length > 0
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        BtnKod.Enabled = txtEmail.Text.Length > 0
    End Sub


End Class
