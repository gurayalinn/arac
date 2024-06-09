Imports System.Numerics
Imports System.Windows

Public Class AddCustomerView
    Inherits Form
    Private customerController As CustomerController
    Private customers As List(Of Customer)
    Private customer As Customer
    Private EditMode As Boolean = False
    Private customerId As Integer

    Public Sub New()
        InitializeComponent()
        customerController = New CustomerController((""))
    End Sub

    Public Sub New(id As Integer)
        customerId = id
        InitializeComponent()
        customerController = New CustomerController((""))
    End Sub

    Private Sub AddCustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customers = customerController.GetAllCustomers()
        Dim legalDateOfBirth As DateTime = Format(DateTime.Now.AddYears(-18), "dd.MM.yyyy")
        DpBirth.MaxDate = legalDateOfBirth

        For Each customer As Customer In customers
            CmbCustomer.Items.Add(customer.Ad + " " + customer.Soyad)
        Next

        If customerId > 0 Then
            EditMode = True
        End If

        If EditMode Then

            Dim customer As Customer = customerController.GetCustomer(customerId)
            CmbCustomer.SelectedItem = customer.Ad + " " + customer.Soyad
            TxtAd.Text = customer.Ad
            TxtSoyad.Text = customer.Soyad
            TxtTckn.Text = customer.Tckn
            TxtTel.Text = customer.Telefon
            TxtAdres.Text = customer.Adres
            TxtMail.Text = customer.Email
            DpBirth.Value = customer.Dogum
            CmbCinsiyet.Text = customer.Cinsiyet

            Me.Text = "MÜŞTERİ DÜZENLE"
            Dim BtnGuncelle As New Button With {
                .Text = "GÜNCELLE",
                .Location = New Point(10, 330),
                .Size = New Size(400, 45),
                .BackColor = Color.FromArgb(0, 123, 255),
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat,
                .TabIndex = 18
            }
            AddHandler BtnGuncelle.Click, AddressOf BtnGuncelle_Click
            Me.Controls.Add(BtnGuncelle)
            BtnKaydet.Visible = False
            BtnKaydet.Enabled = False

            Dim isAllFieldsFilled As Func(Of Boolean) = Function()
                                                            Return CmbCustomer.SelectedIndex > -1
                                                        End Function

            If Not isAllFieldsFilled() Then
                BtnGuncelle.Enabled = False
            End If

            AddHandler CmbCustomer.SelectedIndexChanged, Sub()
                                                             BtnGuncelle.Enabled = isAllFieldsFilled()
                                                         End Sub

        End If

        If Not EditMode Then
            BtnKaydet.Text = "KAYDET"
            Me.Text = "MÜŞTERİ EKLE"
            CmbCustomer.Enabled = False
            CmbCinsiyet.SelectedIndex = 0
            DpBirth.Value = legalDateOfBirth
            AddHandler BtnKaydet.Click, AddressOf BtnGuncelle_Click
            Dim isAllFieldsFilled As Func(Of Boolean) = Function()
                                                            Return TxtAd.Text.Length > 0 And TxtSoyad.Text.Length > 0 And TxtTckn.Text.Length > 0 And TxtTel.Text.Length > 0 And TxtAdres.Text.Length > 0 And TxtMail.Text.Length > 0 And DpBirth.Value.Year > 1900 And CmbCinsiyet.Text.Length > 0
                                                        End Function

            If Not isAllFieldsFilled() Then
                BtnKaydet.Enabled = False
            End If


            AddHandler TxtAd.TextChanged, Sub()
                                              BtnKaydet.Enabled = isAllFieldsFilled()
                                          End Sub

            AddHandler TxtSoyad.TextChanged, Sub()
                                                 BtnKaydet.Enabled = isAllFieldsFilled()
                                             End Sub

            AddHandler TxtTckn.TextChanged, Sub()
                                                BtnKaydet.Enabled = isAllFieldsFilled()
                                            End Sub

            AddHandler TxtTel.TextChanged, Sub()
                                               BtnKaydet.Enabled = isAllFieldsFilled()
                                           End Sub

            AddHandler TxtAdres.TextChanged, Sub()
                                                 BtnKaydet.Enabled = isAllFieldsFilled()
                                             End Sub

            AddHandler TxtMail.TextChanged, Sub()
                                                BtnKaydet.Enabled = isAllFieldsFilled()
                                            End Sub

            AddHandler DpBirth.ValueChanged, Sub()
                                                 BtnKaydet.Enabled = isAllFieldsFilled()
                                             End Sub

            AddHandler CmbCinsiyet.TextChanged, Sub()
                                                    BtnKaydet.Enabled = isAllFieldsFilled()
                                                End Sub

        End If



    End Sub

    Private Sub BtnGuncelle_Click(sender As Object, e As EventArgs)
        Dim customer As Customer = customerController.GetCustomer(customerId)
        Dim updatedCustomer As New Customer()
        updatedCustomer.Ad = TxtAd.Text
        updatedCustomer.Soyad = TxtSoyad.Text
        updatedCustomer.Tckn = TxtTckn.Text
        updatedCustomer.Tckn = updatedCustomer.Tckn.Replace(" ", "")
        updatedCustomer.Telefon = TxtTel.Text
        updatedCustomer.Telefon = updatedCustomer.Telefon.Replace(" ", "")
        updatedCustomer.Adres = TxtAdres.Text
        updatedCustomer.Email = TxtMail.Text
        updatedCustomer.Email = updatedCustomer.Email.Replace(" ", "")
        updatedCustomer.Dogum = Format(DpBirth.Value, "dd.MM.yyyy")
        updatedCustomer.Cinsiyet = CmbCinsiyet.Text
        customerController.UpdateCustomer(customerId, updatedCustomer)
        Me.Close()

    End Sub

    Private Sub BtnKaydet_Click(sender As Object, e As EventArgs) Handles BtnKaydet.Click
        Dim customer As New Customer()
        customer.Ad = TxtAd.Text
        customer.Soyad = TxtSoyad.Text
        customer.Tckn = TxtTckn.Text
        customer.Tckn = customer.Tckn.Replace(" ", "")
        customer.Telefon = TxtTel.Text
        customer.Telefon = customer.Telefon.Replace(" ", "")
        customer.Adres = TxtAdres.Text
        customer.Email = TxtMail.Text
        customer.Email = customer.Email.Replace(" ", "")
        customer.Tarih = DateTime.Now
        customer.Dogum = Format(DpBirth.Value, "dd.MM.yyyy")
        customer.Cinsiyet = CmbCinsiyet.Text
        customerController.AddCustomer(customer)
        Me.Close()
    End Sub

    Private Sub CmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCustomer.SelectedIndexChanged
        Dim customer = customers(CmbCustomer.SelectedIndex)
        CmbCustomer.SelectedItem = customer.Ad + " " + customer.Soyad
        TxtAd.Text = customer.Ad
        TxtSoyad.Text = customer.Soyad
        TxtTckn.Text = customer.Tckn
        TxtTel.Text = customer.Telefon
        TxtAdres.Text = customer.Adres
        TxtMail.Text = customer.Email
        DpBirth.Value = Format(customer.Dogum, "dd.MM.yyyy")
        CmbCinsiyet.Text = customer.Cinsiyet
        EditMode = True
    End Sub

End Class

