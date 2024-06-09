Imports Font = System.Drawing.Font

Public Class PaymentsView
    Inherits Form
    Private operationController As OperationController
    Private customerController As CustomerController
    Private vehicleController As VehicleController
    Private sales As List(Of Sale)
    Private sale As Sale
    Private saleId As Integer
    Private rents As List(Of Rent)
    Private rent As Rent
    Private rentId As Integer
    Private customer As Customer
    Private vehicle As Vehicle
    Private paymentId As Integer
    Private payment As Payment
    Private payments As List(Of Payment)

    Public Sub New()
        InitializeComponent()
        operationController = New OperationController((""))
        customerController = New CustomerController((""))
        vehicleController = New VehicleController((""))
    End Sub


    Public Sub New(id As Integer)
        InitializeComponent()
        paymentId = id
        operationController = New OperationController((""))
        customerController = New CustomerController((""))
        vehicleController = New VehicleController((""))
    End Sub


    Private Sub PaymentsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CustomizeDataGridView(dgvPayments)
        LoadPayments()


        AddHandler dgvPayments.CellClick, Sub()
                                              If dgvPayments.SelectedRows.Count = 0 Then
                                                  Return
                                              End If
                                              Dim id As Integer = Integer.Parse(dgvPayments.SelectedRows(0).Cells(0).Value)
                                              Dim payment As Payment = operationController.GetPayment(id)
                                              If payment Is Nothing Then
                                                  Return
                                              End If

                                              Dim rentId As Integer = payment.RentId
                                              Dim saleId As Integer = payment.SaleId

                                              If rentId = 0 And saleId = 0 Then
                                                  Return
                                              End If

                                              If rentId > 0 Then
                                                  Dim kira = operationController.GetRent(rentId)
                                                  Dim renter = customerController.GetCustomer(kira.CustomerId)
                                                  Dim vehiclekira = vehicleController.GetVehicle(kira.VehicleId)
                                                  Dim selected As String = "Kira:" & renter.Ad & " " & renter.Soyad & " Araç:" & vehiclekira.Plaka & " " & If(payment.Status > 0, "Ödendi", "Ödenmedi")
                                                  LblSelected.ForeColor = Color.Blue
                                                  LblSelected.Text = selected.ToString()
                                                  Return
                                              End If

                                              If saleId > 0 Then
                                                  Dim satis = operationController.GetSale(saleId)
                                                  Dim seller = customerController.GetCustomer(satis.CustomerId)
                                                  Dim vehiclesatis = vehicleController.GetVehicle(satis.VehicleId)
                                                  Dim selected As String = "Satış:" & seller.Ad & " " & seller.Soyad & " Araç:" & vehiclesatis.Plaka & " " & If(payment.Status > 0, "Ödendi", "Ödenmedi")
                                                  LblSelected.ForeColor = Color.Blue
                                                  LblSelected.Text = selected.ToString()
                                                  Return
                                              End If

                                          End Sub

        AddHandler dgvPayments.CellDoubleClick, Sub()
                                                    If dgvPayments.SelectedRows.Count = 0 Then
                                                        Return
                                                    End If
                                                    Dim id As Integer = Integer.Parse(dgvPayments.SelectedRows(0).Cells(0).Value)
                                                    OpenEditForm(id)
                                                End Sub


    End Sub




    Private Sub LoadPayments()
        Try
            If paymentId = 0 Then
                payments = operationController.GetPayments()
                dgvPayments.DataSource = payments
            Else
                payment = operationController.GetPayment(paymentId)
                dgvPayments.DataSource = payment
            End If


            'dgvSales.Columns(11).DefaultCellStyle.Format = "c"
            'dgvSales.Columns(11).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("tr-TR")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Veritabanına bağlanırken bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub ReloadForm()
        LoadPayments()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReloadForm()
    End Sub

    Private Sub BtnInvoice_Click(sender As Object, e As EventArgs) Handles BtnInvoice.Click
        If dgvPayments.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id = Integer.Parse(dgvPayments.SelectedRows(0).Cells(0).Value)
        Dim data As New InvoiceView(id)
        data.ShowDialog()
    End Sub

    Private Sub OpenEditForm(id As Integer)
        If dgvPayments.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If
        'Dim data As New AddPaymentView(id)
        'Data.ShowDialog()
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If dgvPayments.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Kayıt silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If

        Dim id As Integer = Integer.Parse(dgvPayments.SelectedRows(0).Cells(0).Value)
        operationController.DeletePayment(id)
        ReloadForm()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text
        Dim filteredPayments As List(Of Payment) = payments.FindAll(Function(s) s.ToString().Contains(search))
        dgvPayments.DataSource = filteredPayments
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

