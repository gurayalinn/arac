
Imports Font = System.Drawing.Font

Public Class SalesView
    Inherits Form
    Private operationController As OperationController
    Private customerController As CustomerController
    Private vehicleController As VehicleController
    Private EditMode As Boolean = False

    Private sales As List(Of Sale)
    Private sale As Sale
    Private saleId As Integer
    Private customer As Customer
    Private vehicle As Vehicle

    Public Sub New()
        InitializeComponent()
        operationController = New OperationController((""))
        customerController = New CustomerController((""))
        vehicleController = New VehicleController((""))
    End Sub


    Public Sub New(id As Integer)
        InitializeComponent()
        saleId = id
        operationController = New OperationController((""))
        customerController = New CustomerController((""))
        vehicleController = New VehicleController((""))
    End Sub


    Private Sub SalesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CustomizeDataGridView(dgvSales)
        LoadSales()


        AddHandler dgvSales.CellClick, Sub()
                                           If dgvSales.SelectedRows.Count = 0 Then
                                               Return
                                           End If
                                           Dim id As Integer = Integer.Parse(dgvSales.SelectedRows(0).Cells(0).Value)
                                           Dim sale As Sale = operationController.GetSale(id)
                                           If sale Is Nothing Then
                                               Return
                                           End If
                                           Dim vehicle As Vehicle = vehicleController.GetVehicle(sale.VehicleId)
                                           Dim customer As Customer = customerController.GetCustomer(sale.CustomerId)
                                           Dim selected As String = "Müşteri: " & customer.Ad & " " & customer.Soyad & " Araç: " & vehicle.Plaka
                                           LblSelected.ForeColor = Color.Blue
                                           LblSelected.Text = selected.ToString()
                                       End Sub

        AddHandler dgvSales.CellDoubleClick, Sub()
                                                 If dgvSales.SelectedRows.Count = 0 Then
                                                     Return
                                                 End If
                                                 Dim id As Integer = Integer.Parse(dgvSales.SelectedRows(0).Cells(0).Value)
                                                 If id = 0 Then
                                                     Return
                                                 End If
                                                 OpenEditForm(id)
                                             End Sub


    End Sub




    Private Sub LoadSales()
        Try

            If saleId > 0 Then
                EditMode = True
                sale = operationController.GetSale(saleId)
                Dim vehicle As Vehicle = vehicleController.GetVehicle(sale.VehicleId)
                Dim customer As Customer = customerController.GetCustomer(sale.CustomerId)
                dgvSales.DataSource = sale
            ElseIf saleId = 0 Then
                sales = operationController.GetSales()
                If sales Is Nothing Then
                    MessageBox.Show("Satış kayıtları bulunamadı.")
                    Return
                Else
                    sales = operationController.GetSales()
                    dgvSales.DataSource = sales
                End If
            End If

            'dgvSales.Columns(11).DefaultCellStyle.Format = "c"
            'dgvSales.Columns(11).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("tr-TR")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Veritabanına bağlanırken bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub ReloadForm()
        LoadSales()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReloadForm()
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        If dgvSales.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id = Integer.Parse(dgvSales.SelectedRows(0).Cells(0).Value)
        Dim data As New AddPaymentView(id)
        data.RdKira.Enabled = False
        data.RdKira.Visible = False
        data.RdKira.Checked = False
        data.CmbKira.Enabled = False
        data.CmbKira.Visible = False
        data.CmbSat.Enabled = True
        data.CmbSat.Visible = True
        data.RdSat.Enabled = True
        data.RdSat.Visible = True
        data.RdSat.Checked = True
        data.ShowDialog()
        ReloadForm()
    End Sub

    Private Sub OpenEditForm(id As Integer)
        If dgvSales.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If


        Dim sale As Sale = operationController.GetSale(id)
        Dim data As New AddSaleRentView(sale.VehicleId)
        data.SaleRentControl.SelectedTab = data.SaleRentControl.TabPages(0)
        data.ShowDialog()
        ReloadForm()
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If dgvSales.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Kayıt silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If

        Dim id As Integer = Integer.Parse(dgvSales.SelectedRows(0).Cells(0).Value)
        operationController.DeleteSale(id)
        ReloadForm()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text
        Dim filteredSales As List(Of Sale) = sales.FindAll(Function(s) s.ToString().Contains(search))
        dgvSales.DataSource = filteredSales
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
