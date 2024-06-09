Public Class AddPaymentView
    Inherits Form
    Private vehicleController As VehicleController
    Private customerController As CustomerController
    Private operationController As OperationController
    Private payment As Payment
    Private sale As Sale
    Private rent As Rent
    Private sales As List(Of Sale)
    Private rents As List(Of Rent)
    Private payments As List(Of Payment)
    Private EditMode As Boolean = False
    Private SaleMode As Boolean = False
    Private RentMode As Boolean = False
    Private PaymentId As Integer = 0

    Public Sub New()
        InitializeComponent()
        vehicleController = New VehicleController((""))
        customerController = New CustomerController((""))
        operationController = New OperationController((""))
    End Sub

    Public Sub New(id As Integer)
        InitializeComponent()
        PaymentId = id ' rent or sale id
        vehicleController = New VehicleController((""))
        customerController = New CustomerController((""))
        operationController = New OperationController((""))
    End Sub


    Private Sub AddPaymentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtOdemeNo.Enabled = False
        sales = operationController.GetSales()
        rents = operationController.GetRents()
        payments = operationController.GetPayments()


        DtpPaymentDate.Value = Format(DateTime.Now, "dd/MM/yyyy")
        DtpPaymentDate.MinDate = Format(DateTime.Now, "dd/MM/yyyy")
        DtpPaymentDate.MaxDate = DtpPaymentDate.Value.AddYears(1)

        If PaymentId > 0 Then
            If RdKira.Checked Then
                RentMode = True
                rent = operationController.GetRent(PaymentId)
                CmbKira.Enabled = True
                CmbSat.Enabled = False
                CmbKira.SelectedItem = rents.Find(Function(x) x.Id = rent.Id)
                BtnPay.Enabled = True
                CheckDurum.Enabled = True
                Return
            ElseIf RdSat.Checked Then
                SaleMode = True
                sale = operationController.GetSale(PaymentId)
                CmbKira.Enabled = False
                CmbSat.Enabled = True
                CmbSat.SelectedItem = sales.Find(Function(x) x.Id = sale.Id)
                BtnPay.Enabled = True
                CheckDurum.Enabled = True
                Return
            Else
                RentMode = False
                SaleMode = False
                CmbKira.Enabled = False
                CmbSat.Enabled = False
                BtnPay.Enabled = False
            End If

            'TxtOdemeNo.Text = payment.TransactionNo
            'TxtAciklama.Text = payment.Description
            'DtpPaymentDate.Value = payment.paymentDate
            'CheckDurum.Checked = If(payment.Status = 1, True, False)
        Else
            CheckDurum.Enabled = False
            If RdKira.Checked Then
                RentMode = True
                For Each rent As Rent In rents
                    CmbKira.Items.Add(rent)
                Next
                CmbKira.Enabled = True
                CmbSat.Enabled = False
                CmbKira.SelectedItem = rents(0)
                GenerateTransactionNo()
                BtnPay.Enabled = True
                CheckDurum.Enabled = True

            ElseIf RdSat.Checked Then
                SaleMode = True
                For Each sale As Sale In sales
                    CmbSat.Items.Add(sale)
                Next
                CmbKira.Enabled = False
                CmbSat.Enabled = True
                CmbSat.SelectedItem = sales(0)
                GenerateTransactionNo()
                BtnPay.Enabled = True
                CheckDurum.Enabled = True
            Else
                BtnPay.Enabled = False
                RentMode = False
                SaleMode = False
            End If
        End If

        If EditMode Then
            BtnPay.Text = "GÜNCELLE"
        End If
    End Sub



    Private Sub GenerateTransactionNo()
        If EditMode Then
            Return
        End If

        If RdKira.Checked Then
            Dim rent As Rent = CType(CmbKira.SelectedItem, Rent)
            Dim transactionNo As String = "KIRA" & PaymentId & "-" & DateTime.Now.ToString("ddMMyyyy")
            TxtOdemeNo.Text = transactionNo
        ElseIf RdSat.Checked Then
            Dim sale As Sale = CType(CmbSat.SelectedItem, Sale)
            Dim transactionNo As String = "SAT" & PaymentId & "-" & DateTime.Now.ToString("ddMMyyyy")
            TxtOdemeNo.Text = transactionNo
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtOdemeNo.Text = ""
        TxtAciklama.Text = ""
        LinkIslem.Text = "-"
        DtpPaymentDate.Value = Format(DateTime.Now, "dd/MM/yyyy")
        CheckDurum.Checked = False
        BtnPay.Enabled = False
        RdKira.Checked = False
        RdSat.Checked = False
        CmbKira.Enabled = False
        CmbSat.Enabled = False
        CheckDurum.Enabled = False
        LblIslem.Text = "İşlem: "
        Me.Close()
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        Dim transactionNo As String = TxtOdemeNo.Text
        Dim description As String = TxtAciklama.Text
        Dim paymentDate As Date = Format(DtpPaymentDate.Value, "dd/MM/yyyy")
        Dim status As Integer = If(CheckDurum.Checked, 1, 0)
        Dim payment As Payment = New Payment()
        If RdKira.Checked Then
            Dim rent As Rent = CType(CmbKira.SelectedItem, Rent)
            If rent Is Nothing Then
                MessageBox.Show("Kiralama seçiniz.")
                Return
            End If
            payment.RentId = rent.Id
            payment.SaleId = 0
            'MessageBox.Show(paymentDate & " - " & PaymentId & " - " & rent.Id & " - " & status & " - " & description)
        ElseIf RdSat.Checked Then
            Dim sale As Sale = CType(CmbSat.SelectedItem, Sale)
            If sale Is Nothing Then
                MessageBox.Show("Satış seçiniz.")
                Return
            End If
            payment.RentId = 0
            payment.SaleId = sale.Id
        End If

        payment.TransactionNo = transactionNo
        payment.Status = status
        payment.Description = description
        payment.paymentDate = paymentDate
        Try
            operationController.AddPayment(payment)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Ödeme kaydedilirken hata oluştu: " & ex.Message)
        End Try
        Me.Close()

    End Sub


    Private Sub CmbKira_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbKira.SelectedIndexChanged
        GenerateTransactionNo()
    End Sub

    Private Sub CmbSat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSat.SelectedIndexChanged
        GenerateTransactionNo()
    End Sub

    Private Sub RdKira_CheckedChanged(sender As Object, e As EventArgs) Handles RdKira.CheckedChanged
        If RdKira.Checked Then
            rents = operationController.GetRents()
            If rents Is Nothing Then
                MessageBox.Show("Kiralama kayıtları bulunamadı.")
                Return
            End If

            If rents.Count = 0 Then
                MessageBox.Show("Kiralama kayıtları bulunamadı.")
                Return
            End If

            If PaymentId > 0 Then
                RentMode = True
                rent = operationController.GetRent(PaymentId)
                Dim Customer As Customer = customerController.GetCustomer(rent.CustomerId)
                Dim Vehicle As Vehicle = vehicleController.GetVehicle(rent.VehicleId)
                Dim IslemDetay As String = " " & Customer.Ad & " " & Customer.Soyad & " - " & Vehicle.Plaka
                LblIslem.Text = "Kiralama: "
                LinkIslem.Text = IslemDetay

                For Each rent As Rent In rents
                    CmbKira.Items.Add(rent)
                Next
                CmbKira.Enabled = True
                CmbSat.Enabled = False
                CmbKira.SelectedItem = rents.Find(Function(x) x.Id = PaymentId)
                BtnPay.Enabled = True
                CheckDurum.Enabled = True
                Return
            End If

            For Each rent As Rent In rents
                CmbKira.Items.Add(rent)
            Next
            CmbKira.Enabled = True
            CmbSat.Enabled = False
            BtnPay.Enabled = True
            GenerateTransactionNo()
        End If
    End Sub

    Private Sub RdSat_CheckedChanged(sender As Object, e As EventArgs) Handles RdSat.CheckedChanged
        If RdSat.Checked Then
            sales = operationController.GetSales()
            If sales Is Nothing Then
                MessageBox.Show("Satış kayıtları bulunamadı.")
                Return
            End If

            If sales.Count = 0 Then
                MessageBox.Show("Satış kayıtları bulunamadı.")
                Return
            End If

            If PaymentId > 0 Then
                SaleMode = True
                sale = operationController.GetSale(PaymentId)
                Dim Customer As Customer = customerController.GetCustomer(sale.CustomerId)
                Dim Vehicle As Vehicle = vehicleController.GetVehicle(sale.VehicleId)
                Dim IslemDetay As String = " " & Customer.Ad & " " & Customer.Soyad & " - " & Vehicle.Plaka
                LblIslem.Text = "Satış: "
                LinkIslem.Text = IslemDetay
                For Each sale As Sale In sales
                    CmbSat.Items.Add(sale)
                Next
                CmbKira.Enabled = False
                CmbSat.Enabled = True
                CmbSat.SelectedItem = sales.Find(Function(x) x.Id = PaymentId)
                BtnPay.Enabled = True
                CheckDurum.Enabled = True
                Return
            End If

            For Each sale As Sale In sales
                CmbSat.Items.Add(sale)
            Next
            CmbKira.Enabled = False
            CmbSat.Enabled = True
            BtnPay.Enabled = True
            GenerateTransactionNo()
        End If
    End Sub

    Private Sub LinkIslem_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkIslem.LinkClicked

        If RentMode Then
            Dim data As New AddSaleRentView(PaymentId)
            data.SaleRentControl.SelectedTab = data.SaleRentControl.TabPages(1)
            data.SaleRentControl.TabPages(0).Enabled = False
            data.SaleRentControl.TabPages(0).Visible = False
            data.ShowDialog()
        ElseIf SaleMode Then
            Dim data As New AddSaleRentView(PaymentId)
            data.SaleRentControl.SelectedTab = data.SaleRentControl.TabPages(0)
            data.SaleRentControl.TabPages(1).Enabled = False
            data.SaleRentControl.TabPages(1).Visible =
            data.ShowDialog()
        End If

    End Sub
End Class
