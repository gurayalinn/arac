Imports Font = System.Drawing.Font

Public Class RentsView
    Inherits Form
    Private operationController As OperationController
    Private customerController As CustomerController
    Private vehicleController As VehicleController

    Private rents As List(Of Rent)
    Private rent As Rent
    Private rentId As Integer
    Private customer As Customer
    Private vehicle As Vehicle
    Private EditMode As Boolean = False

    Public Sub New()
        InitializeComponent()
        operationController = New OperationController((""))
        customerController = New CustomerController((""))
        vehicleController = New VehicleController((""))
    End Sub


    Public Sub New(id As Integer)
        InitializeComponent()
        rentId = id
        operationController = New OperationController((""))
        customerController = New CustomerController((""))
        vehicleController = New VehicleController((""))
    End Sub


    Private Sub RentsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CustomizeDataGridView(dgvRents)
        LoadRents()

        AddHandler dgvRents.CellClick, Sub()
                                           If dgvRents.SelectedRows.Count = 0 Then
                                               Return
                                           End If
                                           Dim id As Integer = Integer.Parse(dgvRents.SelectedRows(0).Cells(0).Value)
                                           Dim rent As Rent = operationController.GetRent(id)
                                           If rent Is Nothing Then
                                               Return
                                           End If
                                           Dim vehicle As Vehicle = vehicleController.GetVehicle(rent.VehicleId)
                                           Dim customer As Customer = customerController.GetCustomer(rent.CustomerId)
                                           Dim selected As String = "Müşteri: " & customer.Ad & " " & customer.Soyad & " Araç: " & vehicle.Plaka
                                           LblSelected.ForeColor = Color.Blue
                                           LblSelected.Text = selected.ToString()
                                       End Sub

        AddHandler dgvRents.CellDoubleClick, Sub()
                                                 If dgvRents.SelectedRows.Count = 0 Then
                                                     Return
                                                 End If
                                                 Dim id As Integer = Integer.Parse(dgvRents.SelectedRows(0).Cells(0).Value)
                                                 OpenEditForm(id)
                                             End Sub

    End Sub


    Private Sub LoadRents()
        Try

            If rentId > 0 Then
                EditMode = True
                rent = operationController.GetRent(rentId)
                Dim vehicle As Vehicle = vehicleController.GetVehicle(rent.VehicleId)
                Dim customer As Customer = customerController.GetCustomer(rent.CustomerId)
                dgvRents.DataSource = rent

            ElseIf rentId = 0 Then
                rents = operationController.GetRents()
                If rents Is Nothing Then
                    MessageBox.Show("Kiralama kayıtları bulunamadı.")
                    Return
                Else
                    rents = operationController.GetRents()
                    dgvRents.DataSource = rents
                End If
            End If

            'dgvRents.Columns(11).DefaultCellStyle.Format = "c"
            'dgvRents.Columns(11).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("tr-TR")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Veritabanına bağlanırken bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub ReloadForm()
        LoadRents()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReloadForm()
    End Sub


    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        If dgvRents.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id = Integer.Parse(dgvRents.SelectedRows(0).Cells(0).Value)
        Dim data As New AddPaymentView(id)
        data.RdKira.Enabled = True
        data.RdKira.Visible = True
        data.RdKira.Checked = True
        data.CmbKira.Enabled = True
        data.CmbKira.Visible = True
        data.CmbSat.Enabled = False
        data.CmbSat.Visible = False
        data.RdSat.Enabled = False
        data.RdSat.Visible = False
        data.RdSat.Checked = False
        data.ShowDialog()
        ReloadForm()
    End Sub


    Private Sub OpenEditForm(id As Integer)
        If dgvRents.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If


        Dim rent As Rent = operationController.GetRent(id)
        Dim data As New AddSaleRentView(rent.VehicleId)
        data.SaleRentControl.SelectedTab = data.SaleRentControl.TabPages(1)
        data.ShowDialog()
        ReloadForm()
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If dgvRents.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Kayıt silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If

        Dim id As Integer = Integer.Parse(dgvRents.SelectedRows(0).Cells(0).Value)
        operationController.DeleteRent(id)
        ReloadForm()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text
        Dim filteredRents As List(Of Rent) = rents.FindAll(Function(r) r.ToString().Contains(search))
        dgvRents.DataSource = filteredRents
    End Sub


    Private Sub ShowForm(pageForm As Form)
        pageForm.TopLevel = True
        pageForm.Show()
        pageForm.BringToFront()
        pageForm.Focus()
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
End Class
