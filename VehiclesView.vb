Imports System.Drawing
Imports System.IO

Public Class VehiclesView
    Inherits Form
    Private vehicleController As VehicleController
    Private vehicles As List(Of Vehicle)
    Private customerController As CustomerController
    Private customers As List(Of Customer)


    Public Sub New()
        InitializeComponent()
        vehicleController = New VehicleController((""))
        customerController = New CustomerController((""))
    End Sub


    Private Sub VehiclesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CarsDefaultImage As String = Path.Combine(Application.StartupPath, "assets\img\car.png")

        If Not Directory.Exists(Path.Combine(Application.StartupPath, "assets\img")) Then
            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "assets\img"))
        End If

        If Not File.Exists(CarsDefaultImage) Then
            Dim resourceIcon As Image = Resources.car
            resourceIcon.Save(CarsDefaultImage)
        End If


        CustomizeDataGridView(DataGridViewVehicle)
        LoadVehicles()


        AddHandler DataGridViewVehicle.CellClick, Sub()
                                                      If DataGridViewVehicle.SelectedRows.Count = 0 Then
                                                          Return
                                                      End If
                                                      Dim id As Integer = Integer.Parse(DataGridViewVehicle.SelectedRows(0).Cells(0).Value)
                                                      Dim vehicle As Vehicle = vehicleController.GetVehicle(id)
                                                      If vehicle Is Nothing Then
                                                          Return
                                                      End If
                                                      Dim selected As String = vehicle.Marka + " " + vehicle.Model + " " + vehicle.Renk + " - " + vehicle.Plaka
                                                      LblSelected.ForeColor = Color.Blue
                                                      LblSelected.Text = selected.ToString()
                                                  End Sub

        AddHandler DataGridViewVehicle.CellDoubleClick, Sub()
                                                            If DataGridViewVehicle.SelectedRows.Count = 0 Then
                                                                Return
                                                            End If
                                                            Dim vehicleId As Integer = Integer.Parse(DataGridViewVehicle.SelectedRows(0).Cells(0).Value)
                                                            OpenDetailForm(vehicleId)
                                                        End Sub


    End Sub



    Public Shared Sub CustomizeDataGridView(ByRef dgv As DataGridView)
        dgv.AutoGenerateColumns = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ReadOnly = True
        dgv.MultiSelect = False
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False

        dgv.AllowUserToResizeColumns = True
        dgv.AllowUserToOrderColumns = False

        dgv.RowHeadersVisible = False
        dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgv.DefaultCellStyle.Font = New Font("Calibri", 10, FontStyle.Regular)
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font(dgv.Font, FontStyle.Bold)
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.ForeColor = Color.Black
        dgv.DefaultCellStyle.SelectionBackColor = Color.SteelBlue
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv.BackgroundColor = Color.White
        dgv.GridColor = Color.Black


        dgv.DefaultCellStyle.NullValue = "-"
        dgv.DefaultCellStyle.Padding = New Padding(2, 2, 2, 2)
        dgv.BorderStyle = BorderStyle.Fixed3D
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single
        dgv.RowTemplate.Height = 24
    End Sub

    Private Sub LoadVehicles()
        Try
            vehicles = vehicleController.GetAllVehicles()
            customers = customerController.GetAllCustomers()
            DataGridViewVehicle.DataSource = vehicles






            ' This is for the price column to show the price in the currency format (TL)
            DataGridViewVehicle.Columns(12).DefaultCellStyle.Format = "c"
            DataGridViewVehicle.Columns(12).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("tr-TR")
            DataGridViewVehicle.Columns(11).DefaultCellStyle.Format = "c"
            DataGridViewVehicle.Columns(11).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("tr-TR")


            ' This is for the date column to show the date in the date format
            'DataGridViewVehicle.Columns(16).DefaultCellStyle.Format = "dd/MM/yyyy"
            'DataGridViewVehicle.Columns(17).DefaultCellStyle.Format = "dd/MM/yyyy"
            DataGridViewVehicle.Columns(0).Visible = False
            DataGridViewVehicle.Columns(1).Visible = False
            DataGridViewVehicle.Columns(10).Visible = False
            DataGridViewVehicle.Columns(13).Visible = False
            DataGridViewVehicle.Columns(15).Visible = False
            DataGridViewVehicle.Columns(16).Visible = False
            DataGridViewVehicle.Columns(17).Visible = False

            DataGridViewVehicle.Columns(2).HeaderText = "Durum"
            DataGridViewVehicle.Columns(3).HeaderText = "Sınıf"
            DataGridViewVehicle.Columns(4).HeaderText = "Marka"
            DataGridViewVehicle.Columns(5).HeaderText = "Model"
            DataGridViewVehicle.Columns(6).HeaderText = "Renk"
            DataGridViewVehicle.Columns(7).HeaderText = "Yıl"
            DataGridViewVehicle.Columns(8).HeaderText = "Km"
            DataGridViewVehicle.Columns(9).HeaderText = "Plaka"
            DataGridViewVehicle.Columns(11).HeaderText = "Kira Ücreti"
            DataGridViewVehicle.Columns(12).HeaderText = "Satış Ücreti"
            DataGridViewVehicle.Columns(14).HeaderText = "Açıklama"







        Catch ex As Exception
            MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " & ex.Message)

        Finally
            vehicleController.CloseConnection()
        End Try
    End Sub

    Public Sub ReloadForm()
        LoadVehicles()
    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If DataGridViewVehicle.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id = Integer.Parse(DataGridViewVehicle.SelectedRows(0).Cells(0).Value)
        OpenEditForm(id)
        ReloadForm()
    End Sub


    Private Sub BtnSale_Click(sender As Object, e As EventArgs) Handles BtnSale.Click
        If DataGridViewVehicle.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id = Integer.Parse(DataGridViewVehicle.SelectedRows(0).Cells(0).Value)
        Dim vehicle As Vehicle = vehicleController.GetVehicle(id)
        Dim data As New AddSaleRentView(vehicle.Id)
        data.SaleRentControl.SelectedTab = data.SaleRentControl.TabPages(0)
        data.SaleRentControl.TabPages(1).Enabled = False
        data.SaleRentControl.TabPages(1).Visible = False
        data.ShowDialog()
    End Sub


    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        If DataGridViewVehicle.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id = Integer.Parse(DataGridViewVehicle.SelectedRows(0).Cells(0).Value)
        Dim vehicle As Vehicle = vehicleController.GetVehicle(id)
        Dim data As New AddSaleRentView(vehicle.Id)
        data.SaleRentControl.SelectedTab = data.SaleRentControl.TabPages(1)
        data.SaleRentControl.TabPages(0).Enabled = False
        data.SaleRentControl.TabPages(0).Visible = False
        data.ShowDialog()
    End Sub


    Private Sub OpenEditForm(id As Integer)
        Dim vehicle As Vehicle = vehicleController.GetVehicle(id)
        Dim AddVehicleView As New AddVehicleView(id)
        AddVehicleView.ShowDialog()
        ReloadForm()
    End Sub

    Private Sub OpenDetailForm(id As Integer)
        Dim vehicle As Vehicle = vehicleController.GetVehicle(id)
        Dim VehicleDetailView As New VehicleDetailView(id)
        VehicleDetailView.ShowDialog()
        ReloadForm()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        OpenAddForm()
        ReloadForm()
    End Sub


    Private Sub OpenAddForm()
        Dim AddVehicleView As New AddVehicleView()
        AddVehicleView.ShowDialog()
        ReloadForm()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DataGridViewVehicle.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Kayıt silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If

        Dim id As Integer = Integer.Parse(DataGridViewVehicle.SelectedRows(0).Cells(0).Value)
        vehicleController.DeleteVehicle(id)
        ReloadForm()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text
        Dim filteredVehicles As List(Of Vehicle) = vehicles.FindAll(Function(vehicle) vehicle.Marka.Contains(search) Or vehicle.Model.Contains(search) Or vehicle.Renk.Contains(search) Or vehicle.Plaka.Contains(search) Or vehicle.Durum.Contains(search) Or vehicle.Aciklama.Contains(search))
        DataGridViewVehicle.DataSource = filteredVehicles
    End Sub


    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReloadForm()
    End Sub

    Private Sub ShowForm(pageForm As Form)
        pageForm.TopLevel = True
        pageForm.Show()
        pageForm.BringToFront()
        pageForm.Focus()
    End Sub

End Class
