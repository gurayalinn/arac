Public Class AddUser
    Inherits Form
    Private EditMode As Boolean = False
    Private User As User
    Private Users As List(Of User)
    Private userController As UserController
    Private UserId As Integer

    Public Sub New()
        InitializeComponent()
        userController = New UserController((""))
    End Sub

    Public Sub New(id As Integer)
        UserId = id
        InitializeComponent()
        userController = New UserController((""))
    End Sub

    Private Sub AddUserView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Users = userController.GetAllUsers()

        For Each user As User In Users
            CmbUser.Items.Add(user.Username)
        Next

        If UserId > 0 Then
            EditMode = True
        End If

        If EditMode Then
            Dim user As User = userController.GetUser(UserId)

            If user Is Nothing Then
                MessageBox.Show("Kullanıcı bulunamadı.")
                Me.Close()
            End If

            If user.Role = 1 Then
                CmbUser.Enabled = True
                CmbUser.Visible = True
                LblUser.Enabled = True
                LblUser.Visible = True
                Dim users As List(Of User) = userController.GetAllUsers()
                CmbUser.DataSource = users
                CmbUser.DisplayMember = "Username"
                CmbUser.ValueMember = "Id"
                CmbUser.SelectedValue = user.Id
            End If



            Me.Text = "KULLANICI DÜZENLE"
            Dim BtnGuncelle As New Button()
            BtnGuncelle.Text = "GÜNCELLE"
            BtnGuncelle.Location = New Point(10, 250)
            BtnGuncelle.Size = New Size(400, 45)
            BtnGuncelle.BackColor = Color.FromArgb(0, 123, 255)
            BtnGuncelle.ForeColor = Color.White
            BtnGuncelle.FlatStyle = FlatStyle.Flat
            BtnGuncelle.TabIndex = 18
            AddHandler BtnGuncelle.Click, AddressOf BtnGuncelle_Click
            Me.Controls.Add(BtnGuncelle)
            BtnKaydet.Visible = False
            BtnKaydet.Enabled = False
            TxtPassword.PasswordChar = "*"

            Dim role As Integer = user.Role
            Select Case role
                Case 0
                    RdUser.Checked = True
                    RdAdmin.Checked = False
                Case 1
                    RdAdmin.Checked = True
                    RdUser.Checked = False
            End Select

            Dim username = user.Username
            Dim password = user.Password
            Dim email = user.Email
            Dim name = user.Name
            Dim surname = user.Surname

            CmbUser.SelectedItem = user.Username
            TxtUsername.Text = username
            TxtPassword.Text = password
            txtEmail.Text = email
            txtName.Text = name
            TxtSurname.Text = surname


            Dim isAllFieldsFilled As Func(Of Boolean) = Function()
                                                            Return CmbUser.SelectedIndex > -1 And username.Length > 0 And password.Length > 0 And email.Length > 0 And name.Length > 0 And surname.Length > 0
                                                        End Function

            If Not isAllFieldsFilled() Then
                BtnGuncelle.Enabled = False
            End If

            AddHandler CmbUser.SelectedIndexChanged, Sub()
                                                         BtnGuncelle.Enabled = isAllFieldsFilled()
                                                     End Sub

            AddHandler TxtUsername.TextChanged, Sub()
                                                    BtnGuncelle.Enabled = isAllFieldsFilled()
                                                End Sub

            AddHandler TxtPassword.TextChanged, Sub()
                                                    BtnGuncelle.Enabled = isAllFieldsFilled()
                                                End Sub

            AddHandler txtEmail.TextChanged, Sub()
                                                 BtnGuncelle.Enabled = isAllFieldsFilled()
                                             End Sub

            AddHandler txtName.TextChanged, Sub()
                                                BtnGuncelle.Enabled = isAllFieldsFilled()
                                            End Sub

            AddHandler TxtSurname.TextChanged, Sub()
                                                   BtnGuncelle.Enabled = isAllFieldsFilled()
                                               End Sub

        End If

        If Not EditMode Then
            CmbUser.Enabled = False
            CmbUser.Visible = False
            LblUser.Enabled = False
            LblUser.Visible = False
            Dim username = TxtUsername.Text
            Dim password = txtPassword.Text
            Dim email = txtEmail.Text
            Dim name = txtName.Text
            Dim surname = TxtSurname.Text
            Dim role As Integer = 0
            If RdAdmin.Checked Then
                role = 1
            End If

            Dim isAllFieldsFilled As Func(Of Boolean) = Function()
                                                            Return username.Length > 0 And password.Length > 0 And email.Length > 0 And name.Length > 0 And surname.Length > 0
                                                        End Function

            If Not isAllFieldsFilled() Then
                BtnKaydet.Enabled = False
            End If

            AddHandler TxtUsername.TextChanged, Sub()
                                                    BtnKaydet.Enabled = isAllFieldsFilled()
                                                End Sub

            AddHandler TxtPassword.TextChanged, Sub()
                                                    BtnKaydet.Enabled = isAllFieldsFilled()
                                                End Sub

            AddHandler txtEmail.TextChanged, Sub()
                                                 BtnKaydet.Enabled = isAllFieldsFilled()
                                             End Sub

            AddHandler txtName.TextChanged, Sub()
                                                BtnKaydet.Enabled = isAllFieldsFilled()
                                            End Sub

            AddHandler TxtSurname.TextChanged, Sub()
                                                   BtnKaydet.Enabled = isAllFieldsFilled()
                                               End Sub


            AddHandler BtnKaydet.Click, Sub()
                                            Dim newUser As New User(username, password, email, name, surname, role)

                                            Dim result = userController.Register(newUser)

                                            If result > 0 Then
                                                DialogResult = DialogResult.OK
                                                Close()
                                            Else
                                                MessageBox.Show("Kullanıcı kaydedilirken bir hata oluştu.")
                                            End If

                                        End Sub
        End If
    End Sub


    Private Sub BtnGuncelle_Click(sender As Object, e As EventArgs)
        Dim user As User = userController.GetUser(UserId)
        Dim updatedUser As New User()
        updatedUser.Username = TxtUsername.Text
        updatedUser.Password = TxtPassword.Text
        updatedUser.Email = txtEmail.Text
        updatedUser.Name = txtName.Text
        updatedUser.Surname = TxtSurname.Text
        Dim role As Integer = 0
        If RdAdmin.Checked Then
            role = 1
        End If
        updatedUser.Role = role
        userController.UpdateUser(UserId, updatedUser)
        Me.Close()
    End Sub





    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        Me.Close()
    End Sub

    Private Sub CmbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUser.SelectedIndexChanged
        Dim user As User = userController.GetUser(CmbUser.SelectedIndex + 1)
        EditMode = True
        CmbUser.SelectedItem = user.Username
        TxtUsername.Text = user.Username
        TxtPassword.Text = user.Password
        txtEmail.Text = user.Email
        txtName.Text = user.Name
        TxtSurname.Text = user.Surname
        Dim role As Integer = user.Role
        Select Case role
            Case 0
                RdUser.Checked = True
                RdAdmin.Checked = False
            Case 1
                RdAdmin.Checked = True
                RdUser.Checked = False
        End Select
    End Sub

End Class
