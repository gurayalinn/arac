Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VehicleDetailView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VehicleDetailView))
        PicGorsel = New PictureBox()
        lblAciklama = New Label()
        LblDurum = New Label()
        LblSasi = New Label()
        LblSahip = New Label()
        LblSinif = New Label()
        LblModel = New Label()
        LblMarka = New Label()
        LblRenk = New Label()
        LblYil = New Label()
        LblPlaka = New Label()
        LblKm = New Label()
        LblSatisUcret = New Label()
        LblKiraUcret = New Label()
        LblMusteri = New Label()
        LblKiraTarih = New Label()
        LblIadeTarih = New Label()
        LblSatisTarih = New Label()
        LblKayitTarih = New Label()
        LblGuncellemeTarih = New Label()
        BtnRent = New Button()
        BtnSale = New Button()
        BtnDelete = New Button()
        BtnEdit = New Button()
        LblId = New Label()
        LinkMusteri = New LinkLabel()
        LinkSahip = New LinkLabel()
        TxtDurum = New Label()
        TxtPlaka = New Label()
        TxtSinif = New Label()
        TxtMarka = New Label()
        TxtModel = New Label()
        TxtYil = New Label()
        TxtRenk = New Label()
        TxtKm = New Label()
        TxtSatisUcret = New Label()
        TxtSatisTarih = New Label()
        TxtKiraUcret = New Label()
        TxtKiraTarih = New Label()
        TxtSasi = New Label()
        TxtIadeTarih = New Label()
        TxtKayitTarih = New Label()
        TxtGuncellemeTarih = New Label()
        TxtId = New Label()
        TxtAciklama = New TextBox()
        CmbArac = New ComboBox()
        VehicleBindingSource = New BindingSource(components)
        CType(PicGorsel, ComponentModel.ISupportInitialize).BeginInit()
        CType(VehicleBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicGorsel
        ' 
        PicGorsel.BorderStyle = BorderStyle.FixedSingle
        PicGorsel.Image = My.Resources.cars
        PicGorsel.InitialImage = My.Resources.cars
        PicGorsel.Location = New Point(260, 120)
        PicGorsel.Name = "PicGorsel"
        PicGorsel.Size = New Size(226, 234)
        PicGorsel.SizeMode = PictureBoxSizeMode.Zoom
        PicGorsel.TabIndex = 31
        PicGorsel.TabStop = False
        ' 
        ' lblAciklama
        ' 
        lblAciklama.AutoSize = True
        lblAciklama.BackColor = Color.Transparent
        lblAciklama.ForeColor = Color.DarkRed
        lblAciklama.Location = New Point(10, 220)
        lblAciklama.Margin = New Padding(4, 0, 4, 0)
        lblAciklama.Name = "lblAciklama"
        lblAciklama.Size = New Size(72, 17)
        lblAciklama.TabIndex = 32
        lblAciklama.Text = "Açıklama"
        ' 
        ' LblDurum
        ' 
        LblDurum.AutoSize = True
        LblDurum.BackColor = Color.Transparent
        LblDurum.ForeColor = Color.DarkRed
        LblDurum.Location = New Point(140, 140)
        LblDurum.Margin = New Padding(4, 0, 4, 0)
        LblDurum.Name = "LblDurum"
        LblDurum.Size = New Size(48, 17)
        LblDurum.TabIndex = 31
        LblDurum.Text = "Durum"
        ' 
        ' LblSasi
        ' 
        LblSasi.AutoSize = True
        LblSasi.BackColor = Color.Transparent
        LblSasi.ForeColor = Color.DarkRed
        LblSasi.Location = New Point(10, 120)
        LblSasi.Margin = New Padding(4, 0, 4, 0)
        LblSasi.Name = "LblSasi"
        LblSasi.Size = New Size(40, 17)
        LblSasi.TabIndex = 33
        LblSasi.Text = "Şasi"
        ' 
        ' LblSahip
        ' 
        LblSahip.AutoSize = True
        LblSahip.BackColor = Color.Transparent
        LblSahip.ForeColor = Color.RoyalBlue
        LblSahip.Location = New Point(10, 50)
        LblSahip.Margin = New Padding(4, 0, 4, 0)
        LblSahip.Name = "LblSahip"
        LblSahip.Size = New Size(56, 17)
        LblSahip.TabIndex = 34
        LblSahip.Text = "Sahibi"
        ' 
        ' LblSinif
        ' 
        LblSinif.AutoSize = True
        LblSinif.BackColor = Color.Transparent
        LblSinif.ForeColor = Color.DarkRed
        LblSinif.Location = New Point(10, 140)
        LblSinif.Margin = New Padding(4, 0, 4, 0)
        LblSinif.Name = "LblSinif"
        LblSinif.Size = New Size(48, 17)
        LblSinif.TabIndex = 35
        LblSinif.Text = "Sınıf"
        ' 
        ' LblModel
        ' 
        LblModel.AutoSize = True
        LblModel.BackColor = Color.Transparent
        LblModel.ForeColor = Color.DarkRed
        LblModel.Location = New Point(140, 160)
        LblModel.Margin = New Padding(4, 0, 4, 0)
        LblModel.Name = "LblModel"
        LblModel.Size = New Size(48, 17)
        LblModel.TabIndex = 36
        LblModel.Text = "Model"
        ' 
        ' LblMarka
        ' 
        LblMarka.AutoSize = True
        LblMarka.BackColor = Color.Transparent
        LblMarka.ForeColor = Color.DarkRed
        LblMarka.Location = New Point(10, 160)
        LblMarka.Margin = New Padding(4, 0, 4, 0)
        LblMarka.Name = "LblMarka"
        LblMarka.Size = New Size(48, 17)
        LblMarka.TabIndex = 37
        LblMarka.Text = "Marka"
        ' 
        ' LblRenk
        ' 
        LblRenk.AutoSize = True
        LblRenk.BackColor = Color.Transparent
        LblRenk.ForeColor = Color.DarkRed
        LblRenk.Location = New Point(140, 180)
        LblRenk.Margin = New Padding(4, 0, 4, 0)
        LblRenk.Name = "LblRenk"
        LblRenk.Size = New Size(40, 17)
        LblRenk.TabIndex = 38
        LblRenk.Text = "Renk"
        ' 
        ' LblYil
        ' 
        LblYil.AutoSize = True
        LblYil.BackColor = Color.Transparent
        LblYil.ForeColor = Color.DarkRed
        LblYil.Location = New Point(10, 180)
        LblYil.Margin = New Padding(4, 0, 4, 0)
        LblYil.Name = "LblYil"
        LblYil.Size = New Size(32, 17)
        LblYil.TabIndex = 39
        LblYil.Text = "Yıl"
        ' 
        ' LblPlaka
        ' 
        LblPlaka.AutoSize = True
        LblPlaka.BackColor = Color.Transparent
        LblPlaka.ForeColor = Color.DarkRed
        LblPlaka.Location = New Point(140, 200)
        LblPlaka.Margin = New Padding(4, 0, 4, 0)
        LblPlaka.Name = "LblPlaka"
        LblPlaka.Size = New Size(48, 17)
        LblPlaka.TabIndex = 40
        LblPlaka.Text = "Plaka"
        ' 
        ' LblKm
        ' 
        LblKm.AutoSize = True
        LblKm.BackColor = Color.Transparent
        LblKm.ForeColor = Color.DarkRed
        LblKm.Location = New Point(10, 200)
        LblKm.Margin = New Padding(4, 0, 4, 0)
        LblKm.Name = "LblKm"
        LblKm.Size = New Size(24, 17)
        LblKm.TabIndex = 41
        LblKm.Text = "Km"
        ' 
        ' LblSatisUcret
        ' 
        LblSatisUcret.AutoSize = True
        LblSatisUcret.BackColor = Color.Transparent
        LblSatisUcret.ForeColor = Color.RoyalBlue
        LblSatisUcret.Location = New Point(10, 70)
        LblSatisUcret.Margin = New Padding(4, 0, 4, 0)
        LblSatisUcret.Name = "LblSatisUcret"
        LblSatisUcret.Size = New Size(104, 17)
        LblSatisUcret.TabIndex = 42
        LblSatisUcret.Text = "Satış Ücreti"
        ' 
        ' LblKiraUcret
        ' 
        LblKiraUcret.AutoSize = True
        LblKiraUcret.BackColor = Color.Transparent
        LblKiraUcret.ForeColor = Color.Tomato
        LblKiraUcret.Location = New Point(260, 30)
        LblKiraUcret.Margin = New Padding(4, 0, 4, 0)
        LblKiraUcret.Name = "LblKiraUcret"
        LblKiraUcret.Size = New Size(96, 17)
        LblKiraUcret.TabIndex = 43
        LblKiraUcret.Text = "Kira Ücreti"
        ' 
        ' LblMusteri
        ' 
        LblMusteri.AutoSize = True
        LblMusteri.BackColor = Color.Transparent
        LblMusteri.ForeColor = Color.Tomato
        LblMusteri.Location = New Point(260, 10)
        LblMusteri.Margin = New Padding(4, 0, 4, 0)
        LblMusteri.Name = "LblMusteri"
        LblMusteri.Size = New Size(64, 17)
        LblMusteri.TabIndex = 44
        LblMusteri.Text = "Müşteri"
        ' 
        ' LblKiraTarih
        ' 
        LblKiraTarih.AutoSize = True
        LblKiraTarih.BackColor = Color.Transparent
        LblKiraTarih.ForeColor = Color.Tomato
        LblKiraTarih.Location = New Point(260, 50)
        LblKiraTarih.Margin = New Padding(4, 0, 4, 0)
        LblKiraTarih.Name = "LblKiraTarih"
        LblKiraTarih.Size = New Size(96, 17)
        LblKiraTarih.TabIndex = 45
        LblKiraTarih.Text = "Kira Tarihi"
        ' 
        ' LblIadeTarih
        ' 
        LblIadeTarih.AutoSize = True
        LblIadeTarih.BackColor = Color.Transparent
        LblIadeTarih.ForeColor = Color.Tomato
        LblIadeTarih.Location = New Point(260, 70)
        LblIadeTarih.Margin = New Padding(4, 0, 4, 0)
        LblIadeTarih.Name = "LblIadeTarih"
        LblIadeTarih.Size = New Size(96, 17)
        LblIadeTarih.TabIndex = 46
        LblIadeTarih.Text = "İade Tarihi"
        ' 
        ' LblSatisTarih
        ' 
        LblSatisTarih.AutoSize = True
        LblSatisTarih.BackColor = Color.Transparent
        LblSatisTarih.ForeColor = Color.RoyalBlue
        LblSatisTarih.Location = New Point(10, 90)
        LblSatisTarih.Margin = New Padding(4, 0, 4, 0)
        LblSatisTarih.Name = "LblSatisTarih"
        LblSatisTarih.Size = New Size(104, 17)
        LblSatisTarih.TabIndex = 47
        LblSatisTarih.Text = "Satış Tarihi"
        ' 
        ' LblKayitTarih
        ' 
        LblKayitTarih.AutoSize = True
        LblKayitTarih.BackColor = Color.Transparent
        LblKayitTarih.ForeColor = Color.RoyalBlue
        LblKayitTarih.Location = New Point(10, 10)
        LblKayitTarih.Margin = New Padding(4, 0, 4, 0)
        LblKayitTarih.Name = "LblKayitTarih"
        LblKayitTarih.Size = New Size(104, 17)
        LblKayitTarih.TabIndex = 48
        LblKayitTarih.Text = "Kayıt Tarihi"
        ' 
        ' LblGuncellemeTarih
        ' 
        LblGuncellemeTarih.AutoSize = True
        LblGuncellemeTarih.BackColor = Color.Transparent
        LblGuncellemeTarih.ForeColor = Color.RoyalBlue
        LblGuncellemeTarih.Location = New Point(10, 30)
        LblGuncellemeTarih.Margin = New Padding(4, 0, 4, 0)
        LblGuncellemeTarih.Name = "LblGuncellemeTarih"
        LblGuncellemeTarih.Size = New Size(88, 17)
        LblGuncellemeTarih.TabIndex = 49
        LblGuncellemeTarih.Text = "Güncelleme"
        ' 
        ' BtnRent
        ' 
        BtnRent.BackColor = Color.Tomato
        BtnRent.FlatStyle = FlatStyle.Flat
        BtnRent.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRent.ForeColor = SystemColors.ControlLight
        BtnRent.Location = New Point(180, 310)
        BtnRent.Margin = New Padding(3, 2, 3, 2)
        BtnRent.Name = "BtnRent"
        BtnRent.Size = New Size(80, 44)
        BtnRent.TabIndex = 53
        BtnRent.Text = "KİRALA"
        BtnRent.UseVisualStyleBackColor = False
        ' 
        ' BtnSale
        ' 
        BtnSale.BackColor = SystemColors.HotTrack
        BtnSale.FlatStyle = FlatStyle.Flat
        BtnSale.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSale.ForeColor = SystemColors.ControlLight
        BtnSale.Location = New Point(130, 310)
        BtnSale.Margin = New Padding(3, 2, 3, 2)
        BtnSale.Name = "BtnSale"
        BtnSale.Size = New Size(47, 44)
        BtnSale.TabIndex = 52
        BtnSale.Text = "SAT"
        BtnSale.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.Transparent
        BtnDelete.BackgroundImage = My.Resources.delete1
        BtnDelete.BackgroundImageLayout = ImageLayout.Zoom
        BtnDelete.Location = New Point(70, 310)
        BtnDelete.Margin = New Padding(3, 2, 3, 2)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(60, 44)
        BtnDelete.TabIndex = 51
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackColor = Color.Transparent
        BtnEdit.BackgroundImage = My.Resources.edit
        BtnEdit.BackgroundImageLayout = ImageLayout.Zoom
        BtnEdit.Location = New Point(10, 310)
        BtnEdit.Margin = New Padding(3, 2, 3, 2)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(60, 44)
        BtnEdit.TabIndex = 50
        BtnEdit.UseVisualStyleBackColor = False
        ' 
        ' LblId
        ' 
        LblId.AutoSize = True
        LblId.BackColor = Color.Transparent
        LblId.ForeColor = Color.DarkRed
        LblId.Location = New Point(140, 220)
        LblId.Margin = New Padding(4, 0, 4, 0)
        LblId.Name = "LblId"
        LblId.Size = New Size(40, 17)
        LblId.TabIndex = 54
        LblId.Text = "ID #"
        ' 
        ' LinkMusteri
        ' 
        LinkMusteri.AutoSize = True
        LinkMusteri.Location = New Point(370, 10)
        LinkMusteri.Name = "LinkMusteri"
        LinkMusteri.Size = New Size(64, 17)
        LinkMusteri.TabIndex = 55
        LinkMusteri.TabStop = True
        LinkMusteri.Text = "MUSTERI"
        ' 
        ' LinkSahip
        ' 
        LinkSahip.AutoSize = True
        LinkSahip.Location = New Point(120, 50)
        LinkSahip.Name = "LinkSahip"
        LinkSahip.Size = New Size(48, 17)
        LinkSahip.TabIndex = 56
        LinkSahip.TabStop = True
        LinkSahip.Text = "SAHIP"
        ' 
        ' TxtDurum
        ' 
        TxtDurum.AutoSize = True
        TxtDurum.Location = New Point(190, 140)
        TxtDurum.Name = "TxtDurum"
        TxtDurum.Size = New Size(64, 17)
        TxtDurum.TabIndex = 57
        TxtDurum.Text = "SATILIK"
        ' 
        ' TxtPlaka
        ' 
        TxtPlaka.AutoSize = True
        TxtPlaka.Location = New Point(190, 200)
        TxtPlaka.Name = "TxtPlaka"
        TxtPlaka.Size = New Size(64, 17)
        TxtPlaka.TabIndex = 58
        TxtPlaka.Text = "16ABC16"
        ' 
        ' TxtSinif
        ' 
        TxtSinif.AutoSize = True
        TxtSinif.Location = New Point(60, 140)
        TxtSinif.Name = "TxtSinif"
        TxtSinif.Size = New Size(72, 17)
        TxtSinif.TabIndex = 59
        TxtSinif.Text = "OTOMOBİL"
        ' 
        ' TxtMarka
        ' 
        TxtMarka.AutoSize = True
        TxtMarka.Location = New Point(60, 160)
        TxtMarka.Name = "TxtMarka"
        TxtMarka.Size = New Size(48, 17)
        TxtMarka.TabIndex = 60
        TxtMarka.Text = "HONDA"
        ' 
        ' TxtModel
        ' 
        TxtModel.AutoSize = True
        TxtModel.Location = New Point(190, 160)
        TxtModel.Name = "TxtModel"
        TxtModel.Size = New Size(48, 17)
        TxtModel.TabIndex = 61
        TxtModel.Text = "CIVIC"
        ' 
        ' TxtYil
        ' 
        TxtYil.AutoSize = True
        TxtYil.Location = New Point(60, 180)
        TxtYil.Name = "TxtYil"
        TxtYil.Size = New Size(40, 17)
        TxtYil.TabIndex = 62
        TxtYil.Text = "2012"
        ' 
        ' TxtRenk
        ' 
        TxtRenk.AutoSize = True
        TxtRenk.Location = New Point(190, 180)
        TxtRenk.Name = "TxtRenk"
        TxtRenk.Size = New Size(48, 17)
        TxtRenk.TabIndex = 63
        TxtRenk.Text = "SIYAH"
        ' 
        ' TxtKm
        ' 
        TxtKm.AutoSize = True
        TxtKm.Location = New Point(60, 200)
        TxtKm.Name = "TxtKm"
        TxtKm.Size = New Size(64, 17)
        TxtKm.TabIndex = 64
        TxtKm.Text = "128.000"
        ' 
        ' TxtSatisUcret
        ' 
        TxtSatisUcret.AutoSize = True
        TxtSatisUcret.Location = New Point(120, 70)
        TxtSatisUcret.Name = "TxtSatisUcret"
        TxtSatisUcret.Size = New Size(88, 17)
        TxtSatisUcret.TabIndex = 65
        TxtSatisUcret.Text = "240.000,00"
        ' 
        ' TxtSatisTarih
        ' 
        TxtSatisTarih.AutoSize = True
        TxtSatisTarih.Location = New Point(120, 90)
        TxtSatisTarih.Name = "TxtSatisTarih"
        TxtSatisTarih.Size = New Size(88, 17)
        TxtSatisTarih.TabIndex = 66
        TxtSatisTarih.Text = "03.02.2024"
        ' 
        ' TxtKiraUcret
        ' 
        TxtKiraUcret.AutoSize = True
        TxtKiraUcret.Location = New Point(370, 30)
        TxtKiraUcret.Name = "TxtKiraUcret"
        TxtKiraUcret.Size = New Size(40, 17)
        TxtKiraUcret.TabIndex = 67
        TxtKiraUcret.Text = "1200"
        ' 
        ' TxtKiraTarih
        ' 
        TxtKiraTarih.AutoSize = True
        TxtKiraTarih.Location = New Point(370, 50)
        TxtKiraTarih.Name = "TxtKiraTarih"
        TxtKiraTarih.Size = New Size(88, 17)
        TxtKiraTarih.TabIndex = 68
        TxtKiraTarih.Text = "02.01.2024"
        ' 
        ' TxtSasi
        ' 
        TxtSasi.AutoSize = True
        TxtSasi.Location = New Point(60, 120)
        TxtSasi.Name = "TxtSasi"
        TxtSasi.Size = New Size(144, 17)
        TxtSasi.TabIndex = 70
        TxtSasi.Text = "00000000000000000"
        ' 
        ' TxtIadeTarih
        ' 
        TxtIadeTarih.AutoSize = True
        TxtIadeTarih.Location = New Point(370, 70)
        TxtIadeTarih.Name = "TxtIadeTarih"
        TxtIadeTarih.Size = New Size(88, 17)
        TxtIadeTarih.TabIndex = 71
        TxtIadeTarih.Text = "01.02.2024"
        ' 
        ' TxtKayitTarih
        ' 
        TxtKayitTarih.AutoSize = True
        TxtKayitTarih.Location = New Point(120, 10)
        TxtKayitTarih.Name = "TxtKayitTarih"
        TxtKayitTarih.Size = New Size(88, 17)
        TxtKayitTarih.TabIndex = 72
        TxtKayitTarih.Text = "01.01.2024"
        ' 
        ' TxtGuncellemeTarih
        ' 
        TxtGuncellemeTarih.AutoSize = True
        TxtGuncellemeTarih.Location = New Point(120, 30)
        TxtGuncellemeTarih.Name = "TxtGuncellemeTarih"
        TxtGuncellemeTarih.Size = New Size(88, 17)
        TxtGuncellemeTarih.TabIndex = 73
        TxtGuncellemeTarih.Text = "02.01.2024"
        ' 
        ' TxtId
        ' 
        TxtId.AutoSize = True
        TxtId.Location = New Point(190, 220)
        TxtId.Name = "TxtId"
        TxtId.Size = New Size(24, 17)
        TxtId.TabIndex = 74
        TxtId.Text = "00"
        ' 
        ' TxtAciklama
        ' 
        TxtAciklama.BackColor = Color.Silver
        TxtAciklama.Location = New Point(10, 240)
        TxtAciklama.Multiline = True
        TxtAciklama.Name = "TxtAciklama"
        TxtAciklama.PlaceholderText = "Açıklama"
        TxtAciklama.Size = New Size(250, 60)
        TxtAciklama.TabIndex = 75
        TxtAciklama.Text = "Sol kapı boyalı temiz araç."
        ' 
        ' CmbArac
        ' 
        CmbArac.BackColor = Color.Silver
        CmbArac.FormattingEnabled = True
        CmbArac.Location = New Point(260, 90)
        CmbArac.Name = "CmbArac"
        CmbArac.Size = New Size(200, 25)
        CmbArac.TabIndex = 76
        ' 
        ' VehicleDetailView
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.Silver
        ClientSize = New Size(484, 361)
        Controls.Add(CmbArac)
        Controls.Add(TxtAciklama)
        Controls.Add(TxtId)
        Controls.Add(TxtGuncellemeTarih)
        Controls.Add(TxtKayitTarih)
        Controls.Add(TxtIadeTarih)
        Controls.Add(TxtSasi)
        Controls.Add(TxtKiraTarih)
        Controls.Add(TxtKiraUcret)
        Controls.Add(TxtSatisTarih)
        Controls.Add(TxtSatisUcret)
        Controls.Add(TxtKm)
        Controls.Add(TxtRenk)
        Controls.Add(TxtYil)
        Controls.Add(TxtModel)
        Controls.Add(TxtMarka)
        Controls.Add(TxtSinif)
        Controls.Add(TxtPlaka)
        Controls.Add(TxtDurum)
        Controls.Add(LinkSahip)
        Controls.Add(LinkMusteri)
        Controls.Add(LblId)
        Controls.Add(BtnRent)
        Controls.Add(BtnSale)
        Controls.Add(BtnDelete)
        Controls.Add(BtnEdit)
        Controls.Add(LblGuncellemeTarih)
        Controls.Add(LblKayitTarih)
        Controls.Add(LblSatisTarih)
        Controls.Add(LblIadeTarih)
        Controls.Add(LblKiraTarih)
        Controls.Add(LblMusteri)
        Controls.Add(LblKiraUcret)
        Controls.Add(LblSatisUcret)
        Controls.Add(LblKm)
        Controls.Add(LblPlaka)
        Controls.Add(LblYil)
        Controls.Add(LblRenk)
        Controls.Add(LblMarka)
        Controls.Add(LblModel)
        Controls.Add(LblSinif)
        Controls.Add(LblSahip)
        Controls.Add(LblSasi)
        Controls.Add(LblDurum)
        Controls.Add(lblAciklama)
        Controls.Add(PicGorsel)
        Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Black
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "VehicleDetailView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ARAÇ DETAY"
        CType(PicGorsel, ComponentModel.ISupportInitialize).EndInit()
        CType(VehicleBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicGorsel As PictureBox
    Friend WithEvents lblAciklama As Label
    Friend WithEvents LblDurum As Label
    Friend WithEvents LblSasi As Label
    Friend WithEvents LblSahip As Label
    Friend WithEvents LblSinif As Label
    Friend WithEvents LblModel As Label
    Friend WithEvents LblMarka As Label
    Friend WithEvents LblRenk As Label
    Friend WithEvents LblYil As Label
    Friend WithEvents LblPlaka As Label
    Friend WithEvents LblKm As Label
    Friend WithEvents LblSatisUcret As Label
    Friend WithEvents LblKiraUcret As Label
    Friend WithEvents LblMusteri As Label
    Friend WithEvents LblKiraTarih As Label
    Friend WithEvents LblIadeTarih As Label
    Friend WithEvents LblSatisTarih As Label
    Friend WithEvents LblKayitTarih As Label
    Friend WithEvents LblGuncellemeTarih As Label
    Friend WithEvents BtnRent As Button
    Friend WithEvents BtnSale As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents LblId As Label
    Friend WithEvents LinkMusteri As LinkLabel
    Friend WithEvents LinkSahip As LinkLabel
    Friend WithEvents TxtDurum As Label
    Friend WithEvents TxtPlaka As Label
    Friend WithEvents TxtSinif As Label
    Friend WithEvents TxtMarka As Label
    Friend WithEvents TxtModel As Label
    Friend WithEvents TxtYil As Label
    Friend WithEvents TxtRenk As Label
    Friend WithEvents TxtKm As Label
    Friend WithEvents TxtSatisUcret As Label
    Friend WithEvents TxtSatisTarih As Label
    Friend WithEvents TxtKiraUcret As Label
    Friend WithEvents TxtKiraTarih As Label
    Friend WithEvents TxtSasi As Label
    Friend WithEvents TxtIadeTarih As Label
    Friend WithEvents TxtKayitTarih As Label
    Friend WithEvents TxtGuncellemeTarih As Label
    Friend WithEvents TxtId As Label
    Friend WithEvents TxtAciklama As TextBox
    Friend WithEvents CmbArac As ComboBox
    Friend WithEvents VehicleBindingSource As BindingSource
End Class
