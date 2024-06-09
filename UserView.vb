Public Class UserView

    Inherits Form
    Private EditMode As Boolean = False
    Private userController As UserController
    Private user As User
    Private UserId As Integer


    Public Sub New()
        InitializeComponent()
        userController = New UserController((""))
    End Sub

    Public Sub New(id As Integer)
        InitializeComponent()
        userController = New UserController((""))
        Me.user = userController.GetUserById(id)
        UserId = Me.user.Id
    End Sub

    Private Sub UserView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserId > 0 Then
            Dim user As User = userController.GetUserById(UserId)
            Dim isAdmin = userController.IsAdmin(user.Username)
            If isAdmin Then
                Dim users As List(Of User) = userController.GetAllUsers()
                LblTitle.Enabled = False
                LblTitle.Visible = False
                CmbUser.Enabled = True
                CmbUser.Visible = True
                CmbUser.DataSource = users
                CmbUser.DisplayMember = "Username"
                CmbUser.ValueMember = "Id"
                CmbUser.SelectedValue = user.Id
                BtnEdit.Enabled = True
                BtnDelete.Enabled = True
                EditMode = True
                TxtId.Text = user.Id
                LinkUsername.Text = user.Username
                TxtEmail.Text = user.Email
                TxtAd.Text = user.Name
                TxtSoyad.Text = user.Surname
                TxtYetki.Text = If(user.Role = 1, "ADMIN", "USER")
                TxtKayitTarih.Text = user.CreatedAt
                TxtGuncellemeTarih.Text = user.UpdatedAt
                Return
            Else
                CmbUser.Enabled = False
                CmbUser.Visible = False
                TxtId.Text = user.Id
                LinkUsername.Text = user.Username
                TxtEmail.Text = user.Email
                TxtAd.Text = user.Name
                TxtSoyad.Text = user.Surname
                TxtYetki.Text = If(user.Role = 1, "ADMIN", "USER")
                TxtKayitTarih.Text = user.CreatedAt
                TxtGuncellemeTarih.Text = user.UpdatedAt
                BtnEdit.Enabled = True
                BtnDelete.Enabled = True
                EditMode = True
            End If
        Else
            MessageBox.Show("Kullanıcı bulunamadı.")
            TxtId.Text = "-"
            LinkUsername.Text = "-"
            TxtEmail.Text = "-"
            TxtAd.Text = "-"
            TxtSoyad.Text = "-"
            TxtYetki.Text = "-"
            TxtKayitTarih.Text = "-"
            TxtGuncellemeTarih.Text = "-"
            BtnEdit.Enabled = False
            CmbUser.Enabled = False
            CmbUser.Visible = False
            BtnEdit.Enabled = False
            BtnDelete.Enabled = False
            EditMode = False
            BtnEdit.Visible = False
            BtnDelete.Visible = False
        End If


    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim user As User = userController.GetUserById(UserId)
        Dim data As New AddUser(UserId)
        If Not userController.IsAdmin(user.Username) Then
            data.RdAdmin.Enabled = False
            data.RdAdmin.Visible = False
            data.LblUser.Enabled = False
            data.LblUser.Visible = False
            data.CmbUser.Enabled = False
            data.CmbUser.Visible = False
        End If
        data.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcı Silme", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim delete As Boolean = userController.DeleteUser(UserId)
            If delete Then
                MessageBox.Show("Kullanıcı başarıyla silindi.")
                Me.Close()
            Else
                MessageBox.Show("Kullanıcı silinirken bir hata oluştu.")
            End If
        End If

    End Sub

    Private Sub LinkUsername_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkUsername.LinkClicked
        Dim data As New AddUser(UserId)
        data.ShowDialog()
    End Sub


    Private Sub ShowForm(pageForm As Form)
        pageForm.TopLevel = True
        pageForm.Show()
        pageForm.BringToFront()
        pageForm.Focus()
    End Sub


    Private Sub CmbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUser.SelectedIndexChanged
        Dim user As User = CmbUser.SelectedItem
        Dim isAdmin = userController.IsAdmin(user.Username)
        UserId = user.Id
        If isAdmin Then
            Dim users As List(Of User) = userController.GetAllUsers()
            LblTitle.Enabled = False
            LblTitle.Visible = False
            CmbUser.Enabled = True
            CmbUser.Visible = True
            CmbUser.DataSource = users
            CmbUser.DisplayMember = "Username"
            CmbUser.ValueMember = "Id"
            CmbUser.SelectedValue = user.Id
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
            EditMode = True
            TxtId.Text = user.Id
            LinkUsername.Text = user.Username
            TxtEmail.Text = user.Email
            TxtAd.Text = user.Name
            TxtSoyad.Text = user.Surname
            TxtYetki.Text = If(user.Role = 1, "ADMIN", "USER")
            TxtKayitTarih.Text = user.CreatedAt
            TxtGuncellemeTarih.Text = user.UpdatedAt
            Return
        Else
            TxtId.Text = user.Id
            LinkUsername.Text = user.Username
            TxtEmail.Text = user.Email
            TxtAd.Text = user.Name
            TxtSoyad.Text = user.Surname
            TxtYetki.Text = If(user.Role = 1, "ADMIN", "USER")
            TxtKayitTarih.Text = user.CreatedAt
            TxtGuncellemeTarih.Text = user.UpdatedAt
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
            EditMode = True
        End If
    End Sub





End Class
