Imports System.IO

Public Class AddVehicleView
    Inherits Form
    Private vehicleController As VehicleController
    Private customerController As CustomerController
    Private vehicles As List(Of Vehicle)
    Private customers As List(Of Customer)
    Private vehicle As Vehicle
    Private customer As Customer
    Private EditMode As Boolean = False
    Private vehicleId As Integer
    Private customerId As Integer

    Public Sub New()
        InitializeComponent()
        vehicleController = New VehicleController((""))
        customerController = New CustomerController((""))
    End Sub

    Public Sub New(id As Integer)
        vehicleId = id
        InitializeComponent()
        vehicleController = New VehicleController((""))
        customerController = New CustomerController((""))
    End Sub

    Private Sub AddVehicleView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customers = customerController.GetAllCustomers()

        For Each customer As Customer In customers
            CmbSahip.Items.Add(customer.Ad + " " + customer.Soyad)
        Next

        If vehicleId > 0 Then
            EditMode = True
        End If

        If EditMode Then
            Dim vehicle As Vehicle = vehicleController.GetVehicle(vehicleId)
            Dim customer As Customer = customerController.GetCustomer(vehicle.Sahibi)
            Dim OwnerIndex As Integer = customers.FindIndex(Function(c) c.Id = customer.Id)
            Me.Text = "ARAÇ DÜZENLE"


            TxtMarka.Text = vehicle.Marka
            TxtModel.Text = vehicle.Model
            TxtYil.Text = vehicle.Yil
            TxtPlaka.Text = vehicle.Plaka
            TxtRenk.Text = vehicle.Renk
            TxtKm.Text = vehicle.Km
            PicSelectedGorsel.ImageLocation = vehicle.Gorsel
            CmbSinif.SelectedIndex = CmbSinif.FindString(vehicle.Sinif)
            TxtSatis.Text = vehicle.SatisUcreti
            TxtKira.Text = vehicle.KiralamaUcreti
            TxtAciklama.Text = vehicle.Aciklama
            TxtSasi.Text = vehicle.Sasi
            CmbDurum.SelectedIndex = CmbDurum.FindString(vehicle.Durum)
            CmbSahip.SelectedIndex = OwnerIndex

            Dim BtnGuncelle As New Button()
            BtnGuncelle.Text = "GÜNCELLE"
            BtnGuncelle.Location = New Point(10, 500)
            BtnGuncelle.Size = New Size(390, 40)
            BtnGuncelle.BackColor = Color.FromArgb(0, 123, 255)
            BtnGuncelle.ForeColor = Color.White
            BtnGuncelle.FlatStyle = FlatStyle.Flat

            Me.Controls.Add(BtnGuncelle)
            BtnKaydet.Visible = False
            BtnKaydet.Enabled = False

            AddHandler BtnGuncelle.Click, Sub()
                                              Dim Owner As Customer = customers(CmbSahip.SelectedIndex)
                                              Dim YilText As String = TxtYil.Text
                                              Dim Yil As Integer = Integer.Parse(YilText)
                                              Dim KmText As String = TxtKm.Text
                                              Dim Km As Integer = Integer.Parse(KmText)
                                              Dim SatisText As String = TxtSatis.Text
                                              Dim Satis As Decimal = Decimal.Parse(SatisText)
                                              Dim KiraText As String = TxtKira.Text
                                              Dim Kira As Decimal = Decimal.Parse(KiraText)
                                              Dim Sasi As String = TxtSasi.Text
                                              Dim Sahip As Integer = Owner.Id
                                              Dim Sinif As String = CmbSinif.Text
                                              Dim Durum As String = CmbDurum.Text
                                              Dim Marka As String = TxtMarka.Text
                                              Dim Model As String = TxtModel.Text
                                              Dim Plaka As String = TxtPlaka.Text
                                              Dim Renk As String = TxtRenk.Text
                                              Dim Aciklama As String = TxtAciklama.Text
                                              Dim Gorsel As String = PicSelectedGorsel.ImageLocation
                                              Dim CreatedAt As DateTime = vehicle.CreatedAt
                                              Dim UpdatedAt As DateTime = DateTime.Now

                                              Dim updatedVehicle As New Vehicle()
                                              updatedVehicle.Sahibi = Sahip
                                              updatedVehicle.Sinif = Sinif
                                              updatedVehicle.Durum = Durum
                                              updatedVehicle.Marka = Marka
                                              updatedVehicle.Model = Model
                                              updatedVehicle.Yil = Yil
                                              updatedVehicle.Sasi = Sasi
                                              updatedVehicle.Plaka = Plaka
                                              updatedVehicle.Renk = Renk
                                              updatedVehicle.Km = Km
                                              updatedVehicle.SatisUcreti = Satis
                                              updatedVehicle.KiralamaUcreti = Kira
                                              updatedVehicle.Gorsel = Gorsel
                                              updatedVehicle.Sahibi = Sahip
                                              updatedVehicle.Aciklama = Aciklama
                                              updatedVehicle.Sinif = Sinif
                                              updatedVehicle.CreatedAt = CreatedAt
                                              updatedVehicle.UpdatedAt = UpdatedAt
                                              vehicleController.UpdateVehicle(VehicleId, updatedVehicle)
                                              Me.Close()
                                          End Sub

            AddHandler BtnGuncelle.Click, Sub()
                                              Me.Close()

                                          End Sub

        End If

        AddHandler BtnKaydet.Click, Sub()
                                        Me.Close()
                                    End Sub

        Dim isAllFieldsFilled As Func(Of Boolean) = Function()
                                                        Return TxtMarka.Text.Length > 0 And TxtModel.Text.Length > 0 And TxtYil.Text.Length > 0 And TxtPlaka.Text.Length > 0 And TxtRenk.Text.Length > 0 And TxtKm.Text.Length > 0 And TxtSatis.Text.Length > 0 And TxtKira.Text.Length > 0 And CmbSahip.SelectedIndex > -1 And CmbSinif.SelectedIndex > -1 And CmbDurum.SelectedIndex > -1 And TxtSasi.Text.Length > 0
                                                    End Function

        If Not isAllFieldsFilled() Then
            BtnKaydet.Enabled = False
        End If

        AddHandler TxtMarka.TextChanged, Sub()
                                             BtnKaydet.Enabled = isAllFieldsFilled()
                                         End Sub

        AddHandler TxtModel.TextChanged, Sub()
                                             BtnKaydet.Enabled = isAllFieldsFilled()
                                         End Sub

        AddHandler TxtYil.TextChanged, Sub()
                                           BtnKaydet.Enabled = isAllFieldsFilled()
                                       End Sub

        AddHandler TxtPlaka.TextChanged, Sub()
                                             BtnKaydet.Enabled = isAllFieldsFilled()
                                         End Sub

        AddHandler TxtRenk.TextChanged, Sub()
                                            BtnKaydet.Enabled = isAllFieldsFilled()
                                        End Sub

        AddHandler TxtKm.TextChanged, Sub()
                                          BtnKaydet.Enabled = isAllFieldsFilled()
                                      End Sub

        AddHandler TxtSatis.TextChanged, Sub()
                                             BtnKaydet.Enabled = isAllFieldsFilled()
                                         End Sub

        AddHandler TxtKira.TextChanged, Sub()
                                            BtnKaydet.Enabled = isAllFieldsFilled()
                                        End Sub

        AddHandler CmbSahip.SelectedIndexChanged, Sub()
                                                      BtnKaydet.Enabled = isAllFieldsFilled()
                                                  End Sub

        AddHandler CmbSinif.SelectedIndexChanged, Sub()
                                                      BtnKaydet.Enabled = isAllFieldsFilled()
                                                  End Sub

        AddHandler CmbDurum.SelectedIndexChanged, Sub()
                                                      BtnKaydet.Enabled = isAllFieldsFilled()
                                                  End Sub

        AddHandler TxtSasi.TextChanged, Sub()
                                            BtnKaydet.Enabled = isAllFieldsFilled()
                                        End Sub

        AddHandler BtnGorselSec.Click, Sub()
                                           Dim openFileDialog As New OpenFileDialog()
                                           openFileDialog.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp;)|*.jpg; *.png; *.jpeg; *.gif; *.bmp;"
                                           If openFileDialog.ShowDialog() = DialogResult.OK Then
                                               'Dim SelectedImage As Image = Image.FromFile(openFileDialog.FileName)
                                               Dim fileName As String = openFileDialog.FileName
                                               Dim randomFileName As String = GenerateRandomFileName(Path.GetExtension(fileName))
                                               Dim assetsPath As String = Path.Combine(Application.StartupPath, "assets")
                                               Dim imagesPath As String = Path.Combine(assetsPath, "img")
                                               If Not Directory.Exists(imagesPath) Then
                                                   Directory.CreateDirectory(imagesPath)
                                               End If

                                               Dim destFile As String = Path.Combine(imagesPath, randomFileName)
                                               File.Copy(fileName, destFile, True)
                                               PicSelectedGorsel.ImageLocation = destFile

                                           End If
                                       End Sub


        If Not EditMode Then
            BtnKaydet.Text = "KAYDET"

            AddHandler BtnKaydet.Click, Sub()

                                            Dim Owner As Customer = customers(CmbSahip.SelectedIndex)
                                            Dim YilText As String = TxtYil.Text
                                            Dim Yil As Integer = Integer.Parse(YilText)
                                            Dim KmText As String = TxtKm.Text
                                            Dim Km As Integer = Integer.Parse(KmText)
                                            Dim SatisText As String = TxtSatis.Text
                                            Dim Satis As Decimal = Decimal.Parse(SatisText)
                                            Dim KiraText As String = TxtKira.Text
                                            Dim Kira As Decimal = Decimal.Parse(KiraText)
                                            Dim Sasi As String = TxtSasi.Text
                                            Dim Sahip As Integer = Owner.Id
                                            Dim Sinif As String = CmbSinif.Text
                                            Dim Durum As String = CmbDurum.Text
                                            Dim Marka As String = TxtMarka.Text
                                            Dim Model As String = TxtModel.Text
                                            Dim Plaka As String = TxtPlaka.Text
                                            Dim Renk As String = TxtRenk.Text
                                            Dim Aciklama As String = TxtAciklama.Text
                                            Dim Gorsel As String = PicSelectedGorsel.ImageLocation
                                            Dim CreatedAt As DateTime = DateTime.Now
                                            Dim UpdatedAt As DateTime = DateTime.Now

                                            Dim vehicle As New Vehicle()
                                            vehicle.Marka = Marka
                                            vehicle.Model = Model
                                            vehicle.Yil = Yil
                                            vehicle.Plaka = Plaka
                                            vehicle.Renk = Renk
                                            vehicle.Km = Km
                                            vehicle.Gorsel = Gorsel
                                            vehicle.Sasi = Sasi
                                            vehicle.Sahibi = Sahip
                                            vehicle.Durum = Durum
                                            vehicle.Sinif = Sinif
                                            vehicle.SatisUcreti = Satis
                                            vehicle.KiralamaUcreti = Kira
                                            vehicle.Aciklama = Aciklama
                                            vehicle.CreatedAt = CreatedAt
                                            vehicle.UpdatedAt = UpdatedAt

                                            vehicleController.AddVehicle(vehicle)
                                            Me.Close()
                                        End Sub
        End If
        Me.Controls.Add(TxtMarka)
        Me.Controls.Add(TxtModel)
        Me.Controls.Add(TxtYil)
        Me.Controls.Add(TxtPlaka)
        Me.Controls.Add(TxtRenk)
        Me.Controls.Add(TxtKm)
        Me.Controls.Add(TxtSasi)
        Me.Controls.Add(CmbDurum)
        Me.Controls.Add(LblSasi)
        Me.Controls.Add(CmbSahip)
        Me.Controls.Add(CmbSinif)
        Me.Controls.Add(TxtSatis)
        Me.Controls.Add(TxtKira)
        Me.Controls.Add(TxtAciklama)
        Me.Controls.Add(LblMarka)
        Me.Controls.Add(LblModel)
        Me.Controls.Add(LblYil)
        Me.Controls.Add(LblPlaka)
        Me.Controls.Add(LblRenk)
        Me.Controls.Add(LblKm)
        Me.Controls.Add(LblSahip)
        Me.Controls.Add(LblSinif)
        Me.Controls.Add(LblSatis)
        Me.Controls.Add(LblKira)
        Me.Controls.Add(lblAciklama)
        Me.Controls.Add(BtnGorselSec)
        Me.Controls.Add(PicSelectedGorsel)
        Me.Controls.Add(BtnKaydet)
    End Sub

    Private Sub VehiclePicture_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VehiclePicture.FileOk

    End Sub

    Public Function GenerateRandomFileName(extension As String) As String
        Return $"{Guid.NewGuid().ToString()}{extension}"
    End Function



    Private Sub PicSelectedGorsel_Click(sender As Object, e As EventArgs) Handles PicSelectedGorsel.Click
        BtnGorselSec.PerformClick()
    End Sub


End Class
