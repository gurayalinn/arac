Public Class RegisterForm
    Private userController As UserController

    Public Sub New()
        InitializeComponent()
        userController = New UserController((""))
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        Dim email = txtEmail.Text
        Dim name = txtName.Text
        Dim surname = txtSurname.Text
        Dim role = 0
        Dim createdAt = DateTime.Now
        Dim updatedAt = DateTime.Now

        If isEmpty(username) Or isEmpty(password) Or isEmpty(email) Or isEmpty(name) Or isEmpty(surname) Then
            MessageBox.Show("Tüm alanlar doldurulmalıdır.")
            Return
        End If

        ' Kullanıcı nesnesi oluştur
        Dim newUser As New User(username, password, email, name, surname, role)

        ' Kullanıcıyı kaydet
        Dim result = userController.Register(newUser)

        If result > 0 Then
            MessageBox.Show("Kullanıcı başarıyla kaydedildi.")
            DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show("Kullanıcı kaydedilirken bir hata oluştu.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Function isEmpty(value As String) As Boolean
        Return value = ""
    End Function

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TransparentLabel(txtUsernameLabel, PictureBox1)
        TransparentLabel(txtNameLabel, PictureBox1)
        TransparentLabel(txtSurnameLabel, PictureBox1)
        TransparentLabel(txtEmailLabel, PictureBox1)
        TransparentLabel(txtPasswordLabel, PictureBox1)
        TransparentLabel(SplashTitle, PictureBox1)



    End Sub

    Private Sub TransparentLabel(label As Label, parent As PictureBox)
        label.Parent = parent
        label.FlatStyle = FlatStyle.Standard
        label.BackColor = Color.Transparent
    End Sub


End Class

