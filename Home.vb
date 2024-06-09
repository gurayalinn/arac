Imports Microsoft.VisualBasic.ApplicationServices

Public Class Home
    Inherits Form
    Private userController As UserController
    Private user As User
    Private UserId As Integer

    Public Sub New()
        InitializeComponent()
        lblUsername.Text = "USER"
        userController = New UserController("")
    End Sub

    Public Sub New(user As User)
        InitializeComponent()
        userController = New UserController("")
        Me.user = userController.GetUserByUsername(user.Username)
        UserId = Me.user.Id
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserId > 0 Then
            Dim user As User = userController.GetUserById(UserId)
            lblUsername.Text = user.Username
        End If

        TransparentLabel(SplashTitle, PictureBox1)
        BtnCustomers.PerformClick()
    End Sub


    Private Sub TransparentLabel(label As Label, parent As PictureBox)
        label.Parent = parent
        label.FlatStyle = FlatStyle.Standard
        label.BackColor = Color.Transparent
    End Sub

    Private Sub MenuSelected(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim selected As Color = Color.CornflowerBlue
        Dim unselected As Color = Color.White

        BtnCars.BackColor = unselected
        BtnCustomers.BackColor = unselected
        BtnSales.BackColor = unselected
        BtnRents.BackColor = unselected
        BtnPayments.BackColor = unselected
        BtnUser.BackColor = unselected
        BtnSaleRent.BackColor = unselected
        BtnPay.BackColor = unselected


        btn.BackColor = selected
    End Sub

    Private Sub OpenDetailForm(id As Integer)
        Dim data As New UserView(id)
        ShowPage(data)
    End Sub



    Private Sub BtnCars_Click(sender As Object, e As EventArgs) Handles BtnCars.Click
        Dim data As New VehiclesView
        ShowPage(data)
        MenuSelected(sender, e)
    End Sub

    Private Sub PicCars_Click(sender As Object, e As EventArgs) Handles PicCars.Click
        BtnCars.PerformClick()
    End Sub


    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Dim data As New CustomersView
        ShowPage(data)
        MenuSelected(sender, e)


    End Sub

    Private Sub PicCustomers_Click(sender As Object, e As EventArgs) Handles PicCustomers.Click

        BtnCustomers.PerformClick()
    End Sub


    Private Sub BtnSaleRent_Click(sender As Object, e As EventArgs) Handles BtnSaleRent.Click
        Dim data As New AddSaleRentView
        ShowPage(data)
        MenuSelected(sender, e)
    End Sub

    Private Sub PicSaleRent_Click(sender As Object, e As EventArgs) Handles PicSaleRent.Click
        BtnSaleRent.PerformClick()
    End Sub

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles BtnSales.Click
        Dim data As New SalesView
        ShowPage(data)
        MenuSelected(sender, e)
    End Sub

    Private Sub PicSales_Click(sender As Object, e As EventArgs) Handles PicSales.Click
        BtnSales.PerformClick()
    End Sub

    Private Sub BtnRents_Click(sender As Object, e As EventArgs) Handles BtnRents.Click
        Dim data As New RentsView
        ShowPage(data)
        MenuSelected(sender, e)
    End Sub

    Private Sub PicRents_Click(sender As Object, e As EventArgs) Handles PicRents.Click
        BtnRents.PerformClick()
    End Sub

    Private Sub BtnPayments_Click(sender As Object, e As EventArgs) Handles BtnPayments.Click
        Dim data As New PaymentsView
        ShowPage(data)
        MenuSelected(sender, e)
    End Sub

    Private Sub PicPayments_Click(sender As Object, e As EventArgs) Handles PicPayments.Click
        BtnPayments.PerformClick()
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click

        If UserId > 0 Then
            OpenDetailForm(UserId)
            MenuSelected(sender, e)
            Return
        End If


        Dim userView As New UserView()
        ShowPage(userView)
        MenuSelected(sender, e)
    End Sub

    Private Sub PicUser_Click(sender As Object, e As EventArgs) Handles PicUser.Click
        BtnUser.PerformClick()
    End Sub



    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        Dim data As New AddPaymentView
        ShowPage(data)
        MenuSelected(sender, e)
    End Sub

    Private Sub PicPay_Click(sender As Object, e As EventArgs) Handles PicPay.Click
        BtnPay.PerformClick()
    End Sub

    Private Sub ShowPage(pageForm As Form)
        PanelContainer.Controls.Clear()
        pageForm.TopLevel = False
        pageForm.Dock = DockStyle.Fill
        pageForm.FormBorderStyle = FormBorderStyle.None
        PanelContainer.Controls.Add(pageForm)
        pageForm.Show()
        pageForm.BringToFront()
        pageForm.Focus()
    End Sub

    Private Sub ShowForm(pageForm As Form)
        pageForm.TopLevel = True
        pageForm.Show()
        pageForm.BringToFront()
        pageForm.Focus()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        DialogResult = DialogResult.Cancel
        ShowForm(LoginForm)
        Me.Close()
    End Sub

    Private Sub PicLogout_Click(sender As Object, e As EventArgs) Handles PicLogout.Click
        BtnLogout.PerformClick()
    End Sub

End Class
