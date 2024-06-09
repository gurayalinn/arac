Imports System.Drawing.Text

Public Class UsersView
    Inherits Form
    Private userController As UserController
    Private users As List(Of User)


    Public Sub New()
        InitializeComponent()
        userController = New UserController((""))
    End Sub

    Private Sub UsersView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        users = userController.GetAllUsers()

        LoadUsers()
        CustomView()
    End Sub

    Private Sub LoadUsers()
        For Each user As User In users
            Dim row As String() = New String() {user.Id.ToString(), user.Username, user.Password, user.Email, user.Name, user.Surname, user.Role, user.CreatedAt.ToString(), user.UpdatedAt.ToString()}
            Dim listViewItem As New ListViewItem(row)
            ListViewUsers.Items.Add(listViewItem)

        Next
    End Sub

    Private Sub ReloadForm()
        ListViewUsers.Items.Clear()
        users = userController.GetAllUsers()
        LoadUsers()
    End Sub


    Private Sub CustomView()

        ListViewUsers.View = View.Details
        ListViewUsers.GridLines = True
        ListViewUsers.FullRowSelect = True
        ListViewUsers.HideSelection = False
        ListViewUsers.MultiSelect = False
        ListViewUsers.AutoArrange = True

        ListViewUsers.Columns.Add("ID", 30)
        ListViewUsers.Columns.Add("Kullanıcı Adı", 100)
        ListViewUsers.Columns.Add("Şifre", 100)
        ListViewUsers.Columns.Add("E-Posta", 100)
        ListViewUsers.Columns.Add("Ad", 100)
        ListViewUsers.Columns.Add("Soyad", 100)
        ListViewUsers.Columns.Add("Rol", 100)
        ListViewUsers.Columns.Add("Kayıt", 100)
        ListViewUsers.Columns.Add("Güncelleme", 100)

        ListViewUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListViewUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)


        AddHandler ListViewUsers.ColumnClick, Sub(sender As Object, e As ColumnClickEventArgs)
                                                  Dim column As Integer = e.Column
                                                  ListViewUsers.ListViewItemSorter = New ListViewItemComparer(column)
                                                  ListViewUsers.Sort()
                                              End Sub



        AddHandler ListViewUsers.SelectedIndexChanged, Sub()
                                                           If ListViewUsers.SelectedItems.Count = 0 Then
                                                               LblSelectedUser.Text = ""
                                                               Return
                                                           End If
                                                           Dim id As Integer = Integer.Parse(ListViewUsers.SelectedItems(0).SubItems(0).Text)
                                                           Dim user As User = userController.GetUserById(id)
                                                           Dim username As String = user.Username
                                                           LblSelectedUser.ForeColor = Color.Blue
                                                           LblSelectedUser.Text = username.ToString()
                                                       End Sub

        AddHandler ListViewUsers.DoubleClick, Sub()
                                                  If ListViewUsers.SelectedItems.Count = 0 Then
                                                      Return
                                                  End If
                                                  Dim id As Integer = Integer.Parse(ListViewUsers.SelectedItems(0).SubItems(0).Text)
                                                  OpenEditForm(id)
                                              End Sub


    End Sub

    Private Sub BtnEditUser_Click(sender As Object, e As EventArgs) Handles BtnEditUser.Click
        If ListViewUsers.SelectedItems.Count = 0 Then
            MessageBox.Show("Lütfen bir kullanıcı seçin.")
            Return
        End If
        Dim id = Integer.Parse(ListViewUsers.SelectedItems(0).SubItems(0).Text)
        OpenEditForm(id)
        ReloadForm()
    End Sub

    Private Sub OpenEditForm(id As Integer)
        If ListViewUsers.SelectedItems.Count = 0 Then
            MessageBox.Show("Lütfen bir kullanıcı seçin.")
            Return
        End If
        Dim data As New AddUser(id)
        data.ShowDialog()
    End Sub

    Private Sub OpenAddForm()
        Dim data As New AddUser()
        data.ShowDialog()
    End Sub



    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        OpenAddForm()
        ReloadForm()
    End Sub

    Private Sub BtnDeleteUser_Click(sender As Object, e As EventArgs) Handles BtnDeleteUser.Click
        If ListViewUsers.SelectedItems.Count = 0 Then
            MessageBox.Show("Lütfen bir kullanıcı seçin.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcı Sil", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If

        Dim id As Integer = Integer.Parse(ListViewUsers.SelectedItems(0).SubItems(0).Text)
        userController.DeleteUser(id)
        ReloadForm()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text
        Dim filteredUsers As List(Of User) = users.FindAll(Function(user) user.Username.Contains(search) Or user.Email.Contains(search) Or user.Name.Contains(search) Or user.Surname.Contains(search) Or user.Role.Contains(search))
        ListViewUsers.Items.Clear()
        For Each user As User In filteredUsers
            Dim row As String() = New String() {user.Id.ToString(), user.Username, user.Password, user.Email, user.Name, user.Surname, user.Role, user.CreatedAt.ToString(), user.UpdatedAt.ToString()}
            Dim listViewItem As New ListViewItem(row)
            ListViewUsers.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReloadForm()
    End Sub

End Class

Public Class ListViewItemComparer
    Implements IComparer

    Private ReadOnly column As Integer

    Public Sub New()
        column = 0
    End Sub

    Public Sub New(column As Integer)
        Me.column = column
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Return [String].Compare(CType(x, ListViewItem).SubItems(column).Text, CType(y, ListViewItem).SubItems(column).Text)
    End Function


End Class
