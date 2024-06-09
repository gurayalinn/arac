Imports System.Drawing

Public Class VehicleDetailView
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
    Private renter As Customer
    Private vehicleId As Integer
    Private renterId As Integer
    Private customerId As Integer
    Private EditMode As Boolean = False


    Public Sub New()
        InitializeComponent()
        vehicleController = New VehicleController((""))
        customerController = New CustomerController((""))
        operationController = New OperationController((""))
    End Sub

    Public Sub New(id As Integer)
        vehicleId = id
        InitializeComponent()
        vehicleController = New VehicleController((""))
        customerController = New CustomerController((""))
        operationController = New OperationController((""))
    End Sub

    Private Sub VehicleDetailView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vehicles = vehicleController.GetAllVehicles()
        customers = customerController.GetAllCustomers()
        sales = operationController.GetSales()
        rents = operationController.GetRents()

        For Each vehicle As Vehicle In vehicles
            CmbArac.Items.Add(vehicle.Id & " " & vehicle.Marka & " " & vehicle.Model & " " & vehicle.Plaka)
        Next


        Dim isAllFieldsFilled As Func(Of Boolean) = Function()
                                                        If CmbArac.SelectedIndex = -1 Then
                                                            Return False
                                                        End If

                                                        Return True
                                                    End Function


        If Not isAllFieldsFilled() Then
            BtnRent.Enabled = False
            BtnSale.Enabled = False
            BtnEdit.Enabled = False
            BtnDelete.Enabled = False
        End If

        AddHandler CmbArac.SelectedIndexChanged, Sub()
                                                     BtnSale.Enabled = isAllFieldsFilled()
                                                     BtnRent.Enabled = isAllFieldsFilled()
                                                 End Sub

        AddHandler CmbArac.SelectedIndexChanged, Sub()
                                                     BtnEdit.Enabled = isAllFieldsFilled()
                                                     BtnDelete.Enabled = isAllFieldsFilled()
                                                 End Sub


        If vehicleId > 0 Then
            EditMode = True
            Dim vehicle As Vehicle = vehicleController.GetVehicle(vehicleId)
            CmbArac.SelectedIndex = vehicles.FindIndex(Function(x) x.Id = vehicle.Id)
            Dim kiralayan As Customer = customerController.GetCustomer(vehicle.Kiralayan)
            Dim sahibi As Customer = customerController.GetCustomer(vehicle.Sahibi)
            Dim sale As Sale = operationController.GetSaleByVehicleId(vehicle.Id)
            Dim rent As Rent = operationController.GetRentByVehicleId(vehicle.Id)

            If vehicle.Kiralayan = 0 Then
                LinkMusteri.Text = "Müşteri Yok"
            Else
                LinkMusteri.Text = kiralayan.Ad & " " & kiralayan.Soyad
            End If

            If vehicle.Sahibi = 0 Then
                LinkSahip.Text = "Sahibi Yok"
            Else
                LinkSahip.Text = sahibi.Ad & " " & sahibi.Soyad
            End If


            TxtId.Text = vehicle.Id
            TxtSinif.Text = vehicle.Sinif
            TxtDurum.Text = vehicle.Durum
            TxtMarka.Text = vehicle.Marka
            TxtModel.Text = vehicle.Model
            TxtYil.Text = vehicle.Yil
            TxtRenk.Text = vehicle.Renk
            TxtPlaka.Text = vehicle.Plaka
            TxtKm.Text = vehicle.Km
            TxtSasi.Text = vehicle.Sasi
            TxtAciklama.Text = vehicle.Aciklama
            PicGorsel.Image = Image.FromFile(vehicle.Gorsel)
            TxtSatisUcret.Text = vehicle.SatisUcreti & " ₺"
            TxtKiraUcret.Text = vehicle.KiralamaUcreti & " ₺"
            TxtKayitTarih.Text = vehicle.CreatedAt.ToString("dd/MM/yyyy")
            TxtGuncellemeTarih.Text = vehicle.UpdatedAt.ToString("dd/MM/yyyy")

            If sale Is Nothing Then
                TxtSatisTarih.Text = "-"
            Else
                TxtSatisTarih.Text = sale.SaleDate.ToString("dd/MM/yyyy")
            End If

            If rent Is Nothing Then
                TxtKiraTarih.Text = "-"
                TxtIadeTarih.Text = "-"
            Else
                TxtKiraTarih.Text = rent.RentDate.ToString("dd/MM/yyyy")
                TxtIadeTarih.Text = rent.ReturnDate.ToString("dd/MM/yyyy")
            End If

        End If




    End Sub

    Private Sub LinkMusteri_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkMusteri.LinkClicked
        If renterId = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim customer As Customer = customerController.GetCustomer(customerId)
        Dim data As New AddCustomerView(customerId)
        data.ShowDialog()

    End Sub

    Private Sub LinkSahip_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSahip.LinkClicked
        If customerId = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim customer As Customer = customerController.GetCustomer(customerId)
        Dim data As New AddCustomerView(customerId)
        data.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim vehicle As Vehicle = vehicleController.GetVehicle(vehicleId)
        Dim AddVehicleView As New AddVehicleView(vehicleId)
        AddVehicleView.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If vehicleId = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Kayıt silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If

        vehicleController.DeleteVehicle(vehicleId)
    End Sub

    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        If vehicleId = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id As Integer = vehicleId
        Dim data As New AddSaleRentView(id)
        data.SaleRentControl.SelectedTab = data.SaleRentControl.TabPages(1)
        data.SaleRentControl.TabPages(0).Enabled = False
        data.SaleRentControl.TabPages(0).Visible = False

        data.ShowDialog()
    End Sub

    Private Sub BtnSale_Click(sender As Object, e As EventArgs) Handles BtnSale.Click
        If vehicleId = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id As Integer = vehicleId
        Dim data As New AddSaleRentView(id)
        data.SaleRentControl.SelectedTab = data.SaleRentControl.TabPages(0)
        data.SaleRentControl.TabPages(1).Enabled = False
        data.SaleRentControl.TabPages(1).Visible = False

        data.ShowDialog()
    End Sub

    Private Sub CmbArac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbArac.SelectedIndexChanged
        vehicleId = GetVehicleId(CmbArac.SelectedItem)
        vehicle = vehicleController.GetVehicle(vehicleId)
        customerId = vehicle.Sahibi
        renterId = vehicle.Kiralayan
        Dim sale As Sale = operationController.GetSaleByVehicleId(vehicle.Id)
        Dim rent As Rent = operationController.GetRentByVehicleId(vehicle.Id)

        If renterId = 0 Or renterId = -1 Or renterId = Nothing Then
            LinkMusteri.Text = "Müşteri Yok"
        Else
            Dim renter As Customer = customerController.GetCustomer(renterId)
            LinkMusteri.Text = renter.Ad & " " & renter.Soyad
        End If

        If customerId = 0 Or customerId = -1 Or customerId = Nothing Then
            LinkSahip.Text = "Sahibi Yok"
        Else
            Dim customer As Customer = customerController.GetCustomer(customerId)
            LinkSahip.Text = customer.Ad & " " & customer.Soyad
        End If

        TxtId.Text = vehicle.Id
        TxtSinif.Text = vehicle.Sinif
        TxtDurum.Text = vehicle.Durum
        TxtMarka.Text = vehicle.Marka
        TxtModel.Text = vehicle.Model
        TxtYil.Text = vehicle.Yil
        TxtRenk.Text = vehicle.Renk
        TxtPlaka.Text = vehicle.Plaka
        TxtKm.Text = vehicle.Km
        TxtSasi.Text = vehicle.Sasi
        TxtAciklama.Text = vehicle.Aciklama
        TxtKayitTarih.Text = vehicle.CreatedAt.ToString("dd/MM/yyyy")
        TxtGuncellemeTarih.Text = vehicle.UpdatedAt.ToString("dd/MM/yyyy")
        If sale Is Nothing Then
            TxtSatisTarih.Text = "-"
        Else
            TxtSatisTarih.Text = sale.SaleDate.ToString("dd/MM/yyyy")
        End If

        If rent Is Nothing Then
            TxtKiraTarih.Text = "-"
            TxtIadeTarih.Text = "-"
        Else
            TxtKiraTarih.Text = rent.RentDate.ToString("dd/MM/yyyy")
            TxtIadeTarih.Text = rent.ReturnDate.ToString("dd/MM/yyyy")
        End If
        PicGorsel.Image = Image.FromFile(vehicle.Gorsel)
        TxtSatisUcret.Text = vehicle.SatisUcreti
        TxtKiraUcret.Text = vehicle.KiralamaUcreti
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
End Class
