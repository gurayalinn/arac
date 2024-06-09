
Imports Image = System.Drawing.Image

Public Class AddSaleRentView
    Inherits Form
    Private vehicleController As VehicleController
    Private customerController As CustomerController
    Private operationController As OperationController
    Private vehicles As List(Of Vehicle)
    Private customers As List(Of Customer)
    Private sales As List(Of Sale)
    Private rents As List(Of Rent)
    Private sale As Sale
    Private rent As Rent
    Private vehicle As Vehicle
    Private customer As Customer
    Private EditMode As Boolean = False
    Private saleMode As Boolean = False
    Private rentMode As Boolean = False
    Private vehicleId As Integer
    Private renterId As Integer
    Private customerId As Integer
    Private ErrorProvider1 As New ErrorProvider()
    Private ParseUpdatedPrice As Decimal
    Private ParseUpdatedPriceSale As Decimal

    Public Sub New()
        InitializeComponent()
        vehicleController = New VehicleController((""))
        customerController = New CustomerController((""))
        operationController = New OperationController((""))
    End Sub

    Public Sub New(id As Integer)
        InitializeComponent()
        vehicleId = id
        vehicleController = New VehicleController((""))
        customerController = New CustomerController((""))
        operationController = New OperationController((""))
    End Sub







    ' AddHandler btnSaleAdd.Click, Sub()
    '                                      Dim sale As New Sale(
    '                                      Id,
    '                                      cmbCustomer.SelectedIndex,
    '                                      saleDate.Value,
    '                                      txtPrice.Text,
    '                                      If(radioCash.Checked, "NAKIT", If(radioCreditCard.Checked, "KREDİ KARTI", If(radioTransfer.Checked, "HAVALE", "ÇEK")))
    '                                      )
    '                                       operationController.AddSale(sale)
    '                                       vehicleController.UpdateVehicleStatus(id, "SATILDI")
    '                                   End Sub

    Private Sub AddSaleRentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink
        AddHandler ComboBoxVehicleSale.SelectedIndexChanged, AddressOf ComboBoxVehicleSale_SelectedIndexChanged
        AddHandler ComboBoxOwnerSale.SelectedIndexChanged, AddressOf ComboBoxOwnerSale_SelectedIndexChanged
        AddHandler ComboBoxVehicleRent.SelectedIndexChanged, AddressOf ComboBoxVehicleRent_SelectedIndexChanged
        AddHandler ComboBoxOwnerRent.SelectedIndexChanged, AddressOf ComboBoxOwnerRent_SelectedIndexChanged
        vehicles = vehicleController.GetAllVehicles()
        customers = customerController.GetAllCustomers()
        sales = operationController.GetSales()
        rents = operationController.GetRents()



        TextBoxPriceRent.TextAlign = HorizontalAlignment.Right
        TextBoxPriceSale.TextAlign = HorizontalAlignment.Right

        For Each vehicle As Vehicle In vehicles
            ComboBoxVehicleSale.Items.Add(vehicle.Id & " " & vehicle.Marka & " " & vehicle.Model & " " & vehicle.Plaka)
            ComboBoxVehicleRent.Items.Add(vehicle.Id & " " & vehicle.Marka & " " & vehicle.Model & " " & vehicle.Plaka)
        Next

        For Each customer As Customer In customers
            ComboBoxOwnerSale.Items.Add(customer.Id & " " & customer.Ad & " " & customer.Soyad)
            ComboBoxOwnerRent.Items.Add(customer.Id & " " & customer.Ad & " " & customer.Soyad)
        Next
        Dim isAllFieldsFilled As Func(Of Boolean) = Function()
                                                        If SaleRentControl.SelectedTab Is TabPageRent Then
                                                            Return ComboBoxVehicleRent.SelectedIndex > -1 AndAlso ComboBoxOwnerRent.SelectedIndex > -1
                                                        ElseIf SaleRentControl.SelectedTab Is TabPageSale Then
                                                            Return ComboBoxVehicleSale.SelectedIndex > -1 AndAlso ComboBoxOwnerSale.SelectedIndex > -1
                                                        Else
                                                            Return False
                                                        End If
                                                    End Function

        If Not isAllFieldsFilled() Then
            ButtonSaveRent.Enabled = False
            ButtonSaveSale.Enabled = False
        End If

        AddHandler ComboBoxVehicleRent.SelectedIndexChanged, Sub()
                                                                 ButtonSaveRent.Enabled = isAllFieldsFilled()
                                                             End Sub

        AddHandler ComboBoxOwnerRent.SelectedIndexChanged, Sub()
                                                               ButtonSaveRent.Enabled = isAllFieldsFilled()
                                                           End Sub
        AddHandler ComboBoxVehicleSale.SelectedIndexChanged, Sub()
                                                                 ButtonSaveSale.Enabled = isAllFieldsFilled()
                                                             End Sub
        AddHandler ComboBoxOwnerSale.SelectedIndexChanged, Sub()
                                                               ButtonSaveSale.Enabled = isAllFieldsFilled()
                                                           End Sub

        If vehicleId > 0 Then
            EditMode = True
        End If

        AddHandler SaleRentControl.SelectedIndexChanged, Sub()
                                                             If SaleRentControl.SelectedTab Is TabPageRent Then
                                                                 rentMode = True
                                                                 saleMode = False
                                                             ElseIf SaleRentControl.SelectedTab Is TabPageSale Then
                                                                 saleMode = True
                                                                 rentMode = False
                                                             End If
                                                         End Sub


        If EditMode Then

            If SaleRentControl.SelectedTab Is TabPageRent Then
                'Dim rent As Rent = operationController.GetRentByVehicleId(vehicleId)
                Dim vehicle As Vehicle = vehicleController.GetVehicle(vehicleId)
                If vehicle Is Nothing Then
                    ComboBoxVehicleRent.SelectedIndex = 0
                Else
                    ComboBoxVehicleRent.SelectedItem = vehicle.Id & " " & vehicle.Marka & " " & vehicle.Model & " " & vehicle.Plaka
                End If
                Dim customer As Customer = customerController.GetCustomer(vehicle.Kiralayan)
                If customer Is Nothing Then
                    ComboBoxOwnerRent.SelectedIndex = 0

                Else
                    ComboBoxOwnerRent.SelectedItem = customer.Id & " " & customer.Ad & " " & customer.Soyad
                End If
                DateTimePickerRent.Value = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerRent.MinDate = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerRent.MaxDate = DateTimePickerRent.Value.AddYears(3)
                DateTimePickerSale.Value = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerSale.MinDate = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerSale.MaxDate = DateTimePickerSale.Value.AddYears(1)
                CmbSayi.SelectedIndex = 1
                CmbTarih.SelectedIndex = 1
                ComboBoxPaymentTypeRent.SelectedIndex = 1
                ComboBoxPaymentTypeSale.SelectedIndex = 1
                BtnSaveTarih.Enabled = False
                TextBoxPriceRent.Text = vehicle.KiralamaUcreti
                PictureBoxRent.Image = Image.FromFile(vehicle.Gorsel)
                rentMode = True
                saleMode = False

            ElseIf SaleRentControl.SelectedTab Is TabPageSale Then
                'Dim sale As Sale = operationController.GetSaleByVehicleId(vehicleId)
                Dim vehicle As Vehicle = vehicleController.GetVehicle(vehicleId)

                If vehicle Is Nothing Then
                    ComboBoxVehicleSale.SelectedIndex = 0
                Else
                    ComboBoxVehicleSale.SelectedItem = vehicle.Id & " " & vehicle.Marka & " " & vehicle.Model & " " & vehicle.Plaka
                End If
                Dim customer As Customer = customerController.GetCustomer(vehicle.Sahibi)
                If customer Is Nothing Then
                    ComboBoxOwnerSale.SelectedIndex = 0
                Else
                    ComboBoxOwnerSale.SelectedItem = customer.Id & " " & customer.Ad & " " & customer.Soyad
                End If

                DateTimePickerRent.Value = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerRent.MinDate = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerRent.MaxDate = DateTimePickerRent.Value.AddYears(3)
                DateTimePickerSale.Value = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerSale.MinDate = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerSale.MaxDate = DateTimePickerSale.Value.AddYears(1)
                TextBoxPriceSale.Text = vehicle.SatisUcreti
                PictureBoxSale.Image = Image.FromFile(vehicle.Gorsel)
                CmbSayi.SelectedIndex = 1
                CmbTarih.SelectedIndex = 1
                ComboBoxPaymentTypeRent.SelectedIndex = 1
                ComboBoxPaymentTypeSale.SelectedIndex = 1
                BtnSaveTarih.Enabled = False
                rentMode = False
                saleMode = True
            Else
                MessageBox.Show("Hata")


            End If
        Else


            If SaleRentControl.SelectedTab Is TabPageRent Then
                CmbSayi.SelectedIndex = 1
                CmbTarih.SelectedIndex = 1
                ComboBoxPaymentTypeRent.SelectedIndex = 1
                ComboBoxPaymentTypeSale.SelectedIndex = 1
                BtnSaveTarih.Enabled = False
                saleMode = False
                rentMode = True
                DateTimePickerRent.Value = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerRent.MinDate = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerRent.MaxDate = DateTimePickerRent.Value.AddYears(3)
                DateTimePickerRent.MaxDate = DateTimePickerRent.Value.AddYears(3)
                DateTimePickerSale.Value = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerSale.MinDate = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerSale.MaxDate = DateTimePickerSale.Value.AddYears(1)
                vehicleId = ComboBoxVehicleRent.SelectedIndex
                customerId = ComboBoxOwnerRent.SelectedIndex


            ElseIf SaleRentControl.SelectedTab Is TabPageSale Then
                CmbSayi.SelectedIndex = 1
                CmbTarih.SelectedIndex = 1
                ComboBoxPaymentTypeRent.SelectedIndex = 1
                ComboBoxPaymentTypeSale.SelectedIndex = 1
                BtnSaveTarih.Enabled = False
                saleMode = True
                rentMode = False
                DateTimePickerRent.Value = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerRent.MinDate = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerRent.MaxDate = DateTimePickerRent.Value.AddYears(3)
                DateTimePickerRent.MaxDate = DateTimePickerRent.Value.AddYears(3)
                DateTimePickerSale.Value = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerSale.MinDate = Format(DateTime.Now, "dd/MM/yyyy")
                DateTimePickerSale.MaxDate = DateTimePickerSale.Value.AddYears(1)
                vehicleId = ComboBoxVehicleSale.SelectedIndex
                customerId = ComboBoxOwnerSale.SelectedIndex
            Else
                MessageBox.Show("Hata")
            End If


        End If

    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles ButtonAddOwnerSale.Click
        Dim data As New AddCustomerView
        data.ShowDialog()
    End Sub

    Private Sub ButtonSaveSale_Click(sender As Object, e As EventArgs) Handles ButtonSaveSale.Click
        Dim sale As New Sale()

        Dim PaymentTypeComboBox As Integer = ComboBoxPaymentTypeSale.SelectedIndex
        Dim PaymentType As String = ""
        Dim VehicleId As Integer = ComboBoxVehicleSale.SelectedIndex
        Dim CustomerId As Integer = ComboBoxOwnerSale.SelectedIndex


        Select Case PaymentTypeComboBox
            Case 0 ' -
                MessageBox.Show("Lütfen bir ödeme türü seçin.")
            Case 1 ' Nakit
                PaymentType = "NAKIT"
            Case 2 ' Kredi Kartı
                PaymentType = "KREDİ"
            Case 3 ' Havale
                PaymentType = "HAVALE"
            Case 4 ' Çek
                PaymentType = "ÇEK"
            Case 5 ' Diğer
                PaymentType = "DİĞER"
            Case Else ' Hata
                MessageBox.Show("Lütfen bir ödeme türü seçin.")
        End Select

        If PaymentType = "" Then
            MessageBox.Show("Lütfen bir ödeme türü seçin.")
            Return
        End If

        If ComboBoxVehicleSale.SelectedIndex = Nothing Or ComboBoxVehicleSale.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen bir araç seçin.")
            Return
        End If

        If ComboBoxOwnerSale.SelectedIndex = Nothing Or ComboBoxOwnerSale.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen bir müşteri seçin.")
            Return
        End If


        sale.PaymentType = PaymentType

        sale.VehicleId = Convert.ToInt32(VehicleId)
        sale.CustomerId = Convert.ToInt32(CustomerId)
        If Not Decimal.TryParse(ParseUpdatedPriceSale, sale.Price) Then
            MessageBox.Show("Lütfen geçerli bir fiyat girin.")
            Return
        End If
        sale.SaleDate = Format(DateTimePickerSale.Value, "dd/MM/yyyy")
        sale.PaymentType = PaymentType

        operationController.AddSale(sale)
        Me.Close()
    End Sub

    Private Sub ButtonSaveRent_Click(sender As Object, e As EventArgs) Handles ButtonSaveRent.Click
        Dim rent As New Rent()
        Dim PaymentTypeComboBox As Integer = ComboBoxPaymentTypeRent.SelectedIndex
        Dim PaymentType As String = ""
        Dim VehicleId As Integer = ComboBoxVehicleRent.SelectedIndex
        Dim CustomerId As Integer = ComboBoxOwnerRent.SelectedIndex



        Select Case PaymentTypeComboBox
            Case 0 ' -
                MessageBox.Show("Lütfen bir ödeme türü seçin.")
            Case 1 ' Nakit
                PaymentType = "NAKIT"
            Case 2 ' Kredi Kartı
                PaymentType = "KREDİ"
            Case 3 ' Havale
                PaymentType = "HAVALE"
            Case 4 ' Çek
                PaymentType = "ÇEK"
            Case 5 ' Diğer
                PaymentType = "DİĞER"
            Case Else ' Hata
                MessageBox.Show("Lütfen bir ödeme türü seçin.")
        End Select

        If PaymentType = "" Then
            MessageBox.Show("Lütfen bir ödeme türü seçin.")
            Return
        End If

        If ComboBoxVehicleRent.SelectedIndex = Nothing Or ComboBoxVehicleRent.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen bir araç seçin.")
            Return
        End If

        If ComboBoxOwnerRent.SelectedIndex = Nothing Or ComboBoxOwnerRent.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen bir müşteri seçin.")
            Return
        End If


        rent.PaymentType = PaymentType

        rent.VehicleId = Convert.ToInt32(VehicleId)
        rent.CustomerId = Convert.ToInt32(CustomerId)
        If Not Decimal.TryParse(ParseUpdatedPrice, rent.Price) Then
            MessageBox.Show("Lütfen geçerli bir fiyat girin.")
            Return
        End If
        rent.RentDate = Format(DateTime.Now, "dd/MM/yyyy")
        rent.ReturnDate = Format(DateTimePickerRent.Value, "dd/MM/yyyy")

        operationController.AddRent(rent)
        Me.Close()
    End Sub

    Private Function GetVehicleId(vehicle As String) As Integer
        Dim vehicleId As Integer = 0
        For Each v As Vehicle In vehicles
            If vehicle = v.Id & " " & v.Marka & " " & v.Model & " " & v.Plaka Then
                vehicleId = v.Id
            End If
        Next
        Return vehicleId
    End Function

    Private Function GetCustomerId(customer As String) As Integer
        Dim customerId As Integer = 0
        For Each c As Customer In customers
            If customer = c.Id & " " & c.Ad & " " & c.Soyad Then
                customerId = c.Id
            End If
        Next
        Return customerId
    End Function



    Private Sub ComboBoxVehicleSale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVehicleSale.SelectedIndexChanged
        vehicleId = GetVehicleId(ComboBoxVehicleSale.SelectedItem)
        vehicle = vehicleController.GetVehicle(vehicleId)
        PictureBoxSale.Image = Image.FromFile(vehicle.Gorsel)
        TextBoxPriceSale.Text = vehicle.SatisUcreti
    End Sub

    Private Sub ComboBoxOwnerSale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOwnerSale.SelectedIndexChanged
        customerId = GetCustomerId(ComboBoxOwnerSale.SelectedItem)
    End Sub

    Private Sub ComboBoxVehicleRent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVehicleRent.SelectedIndexChanged
        vehicleId = GetVehicleId(ComboBoxVehicleRent.SelectedItem)
        vehicle = vehicleController.GetVehicle(vehicleId)
        PictureBoxRent.Image = Image.FromFile(vehicle.Gorsel)
        TextBoxPriceRent.Text = vehicle.KiralamaUcreti
    End Sub

    Private Sub ComboBoxOwnerRent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOwnerRent.SelectedIndexChanged
        customerId = GetCustomerId(ComboBoxOwnerRent.SelectedItem)
    End Sub


    Private Sub ButtonAddOwnerRent_Click(sender As Object, e As EventArgs) Handles ButtonAddOwnerRent.Click
        Dim data As New AddCustomerView
        data.ShowDialog()
    End Sub

    Private Sub ButtonAddVehicleRent_Click(sender As Object, e As EventArgs) Handles ButtonAddVehicleRent.Click
        Dim data As New AddVehicleView
        data.ShowDialog()
    End Sub

    Private Sub ButtonAddVehicleSale_Click(sender As Object, e As EventArgs) Handles ButtonAddVehicleSale.Click
        Dim data As New AddVehicleView
        data.ShowDialog()
    End Sub



    Private Sub MaskedTextBoxPriceSale_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub


    Private Sub PictureBoxSale_Click(sender As Object, e As EventArgs) Handles PictureBoxSale.Click

        If Not vehicleId = Nothing And vehicleId > 0 Then
            Dim data As New VehicleDetailView(vehicleId)
            data.ShowDialog()
        Else
            MessageBox.Show("Önce araç seçiniz.")
            Return
        End If
    End Sub

    Private Sub PictureBoxRent_Click(sender As Object, e As EventArgs) Handles PictureBoxRent.Click
        If Not vehicleId = Nothing And vehicleId > 0 Then
            Dim data As New VehicleDetailView(vehicleId)
            data.ShowDialog()
        Else
            MessageBox.Show("Önce araç seçiniz.")
            Return
        End If
    End Sub

    Private Sub BtnSaveTarih_Click(sender As Object, e As EventArgs) Handles BtnSaveTarih.Click
        Dim Sayi As Integer = CmbSayi.SelectedIndex
        Dim Birim As String = CmbTarih.SelectedIndex
        Dim BirimText As String = CmbTarih.SelectedItem
        Dim Tarih As Date = Format(DateTimePickerRent.Value, "dd/MM/yyyy")
        Dim Bugun As Date = Format(DateTime.Now, "dd/MM/yyyy")
        Dim MaxTarih As Date = DateTimePickerRent.MaxDate

        Dim Gun As Integer = Tarih.Day
        Dim Hafta As Integer = Tarih.DayOfWeek
        Dim Ay As Integer = Tarih.Month
        Dim Yil As Integer = Tarih.Year


        Select Case Birim
            Case 0 ' -
                MessageBox.Show("Lütfen bir birim seçin.")
            Case 1 ' Gün
                If Sayi = 0 Or Sayi = Nothing Then
                    MessageBox.Show("Lütfen bir sayı seçin.")
                End If
                If Not Sayi > 30 Then
                    Tarih = Tarih.AddDays(Sayi)
                Else
                    MessageBox.Show("Lütfen 30 günü geçmeyecek bir sayı seçin.")
                    BtnClearTarih.PerformClick()
                End If
            Case 2 ' Hafta
                If Sayi = 0 Or Sayi = Nothing Then
                    MessageBox.Show("Lütfen bir sayı seçin.")
                End If
                If Not Sayi > 4 Then
                    Tarih = Tarih.AddDays(Sayi * 7)
                Else
                    MessageBox.Show("Lütfen 4 haftayı geçmeyecek bir sayı seçin.")
                    BtnClearTarih.PerformClick()
                End If
            Case 3 ' Ay
                If Sayi = 0 Or Sayi = Nothing Then
                    MessageBox.Show("Lütfen bir sayı seçin.")
                End If
                If Not Sayi > 12 Then
                    Tarih = Tarih.AddMonths(Sayi)
                Else
                    MessageBox.Show("Lütfen 12 ayı geçmeyecek bir sayı seçin.")
                    BtnClearTarih.PerformClick()
                End If
            Case 4 ' Yıl
                If Sayi = 0 Or Sayi = Nothing Then
                    MessageBox.Show("Lütfen bir sayı seçin.")
                End If
                If Not Sayi > 3 Then
                    Tarih = Tarih.AddYears(Sayi)
                Else
                    MessageBox.Show("Lütfen 3 yılı geçmeyecek bir sayı seçin.")
                    BtnClearTarih.PerformClick()
                End If

            Case Else ' Hata
                MessageBox.Show("Lütfen bir birim seçin.")
        End Select

        If Not Tarih > MaxTarih Then
            DateTimePickerRent.Value = Tarih
            Dim Fark As Integer = (Tarih - Bugun).Days
            Dim UpdatedPrice As Decimal = Fark * Decimal.Parse(vehicle.KiralamaUcreti)
            TextBoxPriceRent.Text = UpdatedPrice.ToString()
            ParseUpdatedPrice = UpdatedPrice
        Else
            MessageBox.Show("Kiralama süresi 3 yıldan fazla olamaz.")
            BtnClearTarih.PerformClick()
        End If


    End Sub

    Private Sub DateTimePickerRent_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerRent.ValueChanged
        Dim Today As Date = Format(DateTime.Now, "dd/MM/yyyy")
        Dim Tarih As Date = Format(DateTimePickerRent.Value, "dd/MM/yyyy")
        Dim Fark As Integer = (Tarih - Today).Days
    End Sub

    Private Sub BtnClearTarih_Click(sender As Object, e As EventArgs) Handles BtnClearTarih.Click
        DateTimePickerRent.Value = Format(DateTime.Now, "dd/MM/yyyy")
        CmbSayi.SelectedIndex = 0
        CmbTarih.SelectedIndex = 0
        BtnSaveTarih.Enabled = False
        TextBoxPriceRent.Text = vehicle.KiralamaUcreti
    End Sub


    Private Sub CmbSayi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSayi.SelectedIndexChanged

        Try
            If CmbSayi.SelectedIndex = 0 And CmbTarih.SelectedIndex = 0 And ComboBoxVehicleRent.SelectedIndex = 0 Then
                BtnSaveTarih.Enabled = False

            ElseIf CmbSayi.SelectedIndex > 0 And CmbTarih.SelectedIndex > 0 And ComboBoxVehicleRent.SelectedIndex > 0 Then
                BtnSaveTarih.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Hata")
        End Try

    End Sub


    Private Sub CmbTarih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTarih.SelectedIndexChanged
        Try
            If CmbSayi.SelectedIndex = 0 And CmbTarih.SelectedIndex = 0 And ComboBoxVehicleRent.SelectedIndex = 0 Then
                BtnSaveTarih.Enabled = False

            ElseIf CmbSayi.SelectedIndex > 0 And CmbTarih.SelectedIndex > 0 And ComboBoxVehicleRent.SelectedIndex > 0 Then
                BtnSaveTarih.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Hata")
        End Try
    End Sub




    Private Sub TextBoxPriceRent_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPriceRent.TextChanged
        ' Kullanıcı TextBox'tan çıktığında girdiği değeri kontrol edin ve formatlayın
        Dim enteredValue As Decimal

        ' Girdiği değerin geçerli bir decimal sayı olup olmadığını kontrol edin
        If Decimal.TryParse(TextBoxPriceRent.Text.Replace("₺", "").Trim(), enteredValue) Then
            ' Geçerli ise, değeri Türk Lirası formatında göstermek için formatlayın
            TextBoxPriceRent.Text = $"{enteredValue:N2} ₺"
        Else
            ' Geçersiz ise, uyarı verin ve TextBox'ı temizleyin
            MessageBox.Show("Geçersiz fiyat formatı. Lütfen geçerli bir fiyat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxPriceRent.Clear()
            TextBoxPriceRent.Focus()
        End If
    End Sub

    Private Sub TextBoxPriceSale_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPriceSale.TextChanged
        Dim enteredValue As Decimal

        ' Girdiği değerin geçerli bir decimal sayı olup olmadığını kontrol edin
        If Decimal.TryParse(TextBoxPriceSale.Text.Replace("₺", "").Trim(), enteredValue) Then
            TextBoxPriceSale.Text = $"{enteredValue:N2} ₺"
        Else
            MessageBox.Show("Geçersiz fiyat formatı. Lütfen geçerli bir fiyat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxPriceSale.Clear()
            TextBoxPriceSale.Focus()
        End If
        ParseUpdatedPriceSale = enteredValue
    End Sub

End Class
