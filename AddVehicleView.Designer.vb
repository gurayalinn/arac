Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddVehicleView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddVehicleView))
        LblMarka = New Label()
        TxtMarka = New TextBox()
        LblModel = New Label()
        LblRenk = New Label()
        LblYil = New Label()
        LblKm = New Label()
        TxtModel = New TextBox()
        TxtRenk = New TextBox()
        TxtYil = New TextBox()
        TxtKm = New TextBox()
        LblPlaka = New Label()
        LblSatis = New Label()
        LblKira = New Label()
        TxtPlaka = New TextBox()
        TxtSatis = New TextBox()
        TxtKira = New TextBox()
        BtnKaydet = New Button()
        LblSahip = New Label()
        CmbSahip = New ComboBox()
        CmbDurum = New ComboBox()
        LbDurum = New Label()
        VehiclePicture = New OpenFileDialog()
        LblSinif = New Label()
        CmbSinif = New ComboBox()
        BtnGorselSec = New Button()
        TxtAciklama = New TextBox()
        lblAciklama = New Label()
        CustomerBindingSource = New BindingSource(components)
        TxtSasi = New TextBox()
        LblSasi = New Label()
        PicSelectedGorsel = New PictureBox()
        CType(CustomerBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSelectedGorsel, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblMarka
        ' 
        LblMarka.AutoSize = True
        LblMarka.BackColor = Color.Transparent
        LblMarka.Location = New Point(10, 70)
        LblMarka.Margin = New Padding(4, 0, 4, 0)
        LblMarka.Name = "LblMarka"
        LblMarka.Size = New Size(48, 18)
        LblMarka.TabIndex = 4
        LblMarka.Text = "Marka"
        ' 
        ' TxtMarka
        ' 
        TxtMarka.CharacterCasing = CharacterCasing.Upper
        TxtMarka.Location = New Point(10, 90)
        TxtMarka.Margin = New Padding(4, 3, 4, 3)
        TxtMarka.Name = "TxtMarka"
        TxtMarka.PlaceholderText = "FORD"
        TxtMarka.Size = New Size(180, 23)
        TxtMarka.TabIndex = 5
        ' 
        ' LblModel
        ' 
        LblModel.AutoSize = True
        LblModel.BackColor = Color.Transparent
        LblModel.Location = New Point(220, 70)
        LblModel.Margin = New Padding(4, 0, 4, 0)
        LblModel.Name = "LblModel"
        LblModel.Size = New Size(48, 18)
        LblModel.TabIndex = 6
        LblModel.Text = "Model"
        ' 
        ' LblRenk
        ' 
        LblRenk.AutoSize = True
        LblRenk.BackColor = Color.Transparent
        LblRenk.Location = New Point(10, 130)
        LblRenk.Margin = New Padding(4, 0, 4, 0)
        LblRenk.Name = "LblRenk"
        LblRenk.Size = New Size(40, 18)
        LblRenk.TabIndex = 8
        LblRenk.Text = "Renk"
        ' 
        ' LblYil
        ' 
        LblYil.AutoSize = True
        LblYil.BackColor = Color.Transparent
        LblYil.Location = New Point(220, 130)
        LblYil.Margin = New Padding(4, 0, 4, 0)
        LblYil.Name = "LblYil"
        LblYil.Size = New Size(32, 18)
        LblYil.TabIndex = 10
        LblYil.Text = "Yıl"
        ' 
        ' LblKm
        ' 
        LblKm.AutoSize = True
        LblKm.BackColor = Color.Transparent
        LblKm.Location = New Point(10, 190)
        LblKm.Margin = New Padding(4, 0, 4, 0)
        LblKm.Name = "LblKm"
        LblKm.Size = New Size(24, 18)
        LblKm.TabIndex = 12
        LblKm.Text = "Km"
        ' 
        ' TxtModel
        ' 
        TxtModel.CharacterCasing = CharacterCasing.Upper
        TxtModel.Location = New Point(220, 90)
        TxtModel.Margin = New Padding(4, 3, 4, 3)
        TxtModel.Name = "TxtModel"
        TxtModel.PlaceholderText = "RANGER"
        TxtModel.Size = New Size(180, 23)
        TxtModel.TabIndex = 7
        ' 
        ' TxtRenk
        ' 
        TxtRenk.CharacterCasing = CharacterCasing.Upper
        TxtRenk.Location = New Point(10, 150)
        TxtRenk.Margin = New Padding(4, 3, 4, 3)
        TxtRenk.Name = "TxtRenk"
        TxtRenk.PlaceholderText = "SİYAH"
        TxtRenk.Size = New Size(180, 23)
        TxtRenk.TabIndex = 9
        ' 
        ' TxtYil
        ' 
        TxtYil.Location = New Point(220, 150)
        TxtYil.Margin = New Padding(4, 3, 4, 3)
        TxtYil.MaxLength = 4
        TxtYil.Name = "TxtYil"
        TxtYil.PlaceholderText = "2020"
        TxtYil.Size = New Size(180, 23)
        TxtYil.TabIndex = 11
        ' 
        ' TxtKm
        ' 
        TxtKm.Location = New Point(10, 210)
        TxtKm.Margin = New Padding(4, 3, 4, 3)
        TxtKm.MaxLength = 9
        TxtKm.Name = "TxtKm"
        TxtKm.PlaceholderText = "123456"
        TxtKm.Size = New Size(180, 23)
        TxtKm.TabIndex = 13
        ' 
        ' LblPlaka
        ' 
        LblPlaka.AutoSize = True
        LblPlaka.BackColor = Color.Transparent
        LblPlaka.Location = New Point(220, 190)
        LblPlaka.Margin = New Padding(4, 0, 4, 0)
        LblPlaka.Name = "LblPlaka"
        LblPlaka.Size = New Size(48, 18)
        LblPlaka.TabIndex = 14
        LblPlaka.Text = "Plaka"
        ' 
        ' LblSatis
        ' 
        LblSatis.AutoSize = True
        LblSatis.BackColor = Color.Transparent
        LblSatis.Location = New Point(10, 250)
        LblSatis.Margin = New Padding(4, 0, 4, 0)
        LblSatis.Name = "LblSatis"
        LblSatis.Size = New Size(104, 18)
        LblSatis.TabIndex = 16
        LblSatis.Text = "Satış Ücreti"
        ' 
        ' LblKira
        ' 
        LblKira.AutoSize = True
        LblKira.BackColor = Color.Transparent
        LblKira.Location = New Point(220, 250)
        LblKira.Margin = New Padding(4, 0, 4, 0)
        LblKira.Name = "LblKira"
        LblKira.Size = New Size(128, 18)
        LblKira.TabIndex = 18
        LblKira.Text = "Kiralama Ücreti"
        ' 
        ' TxtPlaka
        ' 
        TxtPlaka.CharacterCasing = CharacterCasing.Upper
        TxtPlaka.Location = New Point(220, 210)
        TxtPlaka.Margin = New Padding(4, 3, 4, 3)
        TxtPlaka.MaxLength = 10
        TxtPlaka.Name = "TxtPlaka"
        TxtPlaka.PlaceholderText = "16ABC01"
        TxtPlaka.Size = New Size(180, 23)
        TxtPlaka.TabIndex = 15
        ' 
        ' TxtSatis
        ' 
        TxtSatis.Location = New Point(10, 270)
        TxtSatis.Margin = New Padding(4, 3, 4, 3)
        TxtSatis.MaxLength = 11
        TxtSatis.Name = "TxtSatis"
        TxtSatis.PlaceholderText = "123456,50"
        TxtSatis.Size = New Size(180, 23)
        TxtSatis.TabIndex = 17
        ' 
        ' TxtKira
        ' 
        TxtKira.Location = New Point(220, 270)
        TxtKira.Margin = New Padding(4, 3, 4, 3)
        TxtKira.MaxLength = 11
        TxtKira.Name = "TxtKira"
        TxtKira.PlaceholderText = "1400,50"
        TxtKira.Size = New Size(180, 23)
        TxtKira.TabIndex = 19
        ' 
        ' BtnKaydet
        ' 
        BtnKaydet.BackColor = Color.DarkGreen
        BtnKaydet.ForeColor = SystemColors.Control
        BtnKaydet.Location = New Point(10, 500)
        BtnKaydet.Margin = New Padding(4, 3, 4, 3)
        BtnKaydet.Name = "BtnKaydet"
        BtnKaydet.Size = New Size(390, 40)
        BtnKaydet.TabIndex = 29
        BtnKaydet.Text = "KAYDET"
        BtnKaydet.UseVisualStyleBackColor = False
        ' 
        ' LblSahip
        ' 
        LblSahip.AutoSize = True
        LblSahip.BackColor = Color.Transparent
        LblSahip.Location = New Point(10, 10)
        LblSahip.Margin = New Padding(4, 0, 4, 0)
        LblSahip.Name = "LblSahip"
        LblSahip.Size = New Size(56, 18)
        LblSahip.TabIndex = 0
        LblSahip.Text = "Sahibi"
        ' 
        ' CmbSahip
        ' 
        CmbSahip.DropDownStyle = ComboBoxStyle.DropDownList
        CmbSahip.FormattingEnabled = True
        CmbSahip.Location = New Point(10, 30)
        CmbSahip.Margin = New Padding(4, 3, 4, 3)
        CmbSahip.Name = "CmbSahip"
        CmbSahip.Size = New Size(180, 26)
        CmbSahip.TabIndex = 1
        ' 
        ' CmbDurum
        ' 
        CmbDurum.DropDownStyle = ComboBoxStyle.DropDownList
        CmbDurum.FormattingEnabled = True
        CmbDurum.Items.AddRange(New Object() {"KİRALIK", "SATILIK", "KİRALANDI", "SATILDI", "DİĞER"})
        CmbDurum.Location = New Point(10, 330)
        CmbDurum.Margin = New Padding(4, 3, 4, 3)
        CmbDurum.Name = "CmbDurum"
        CmbDurum.Size = New Size(180, 26)
        CmbDurum.TabIndex = 21
        ' 
        ' LbDurum
        ' 
        LbDurum.AutoSize = True
        LbDurum.BackColor = Color.Transparent
        LbDurum.Location = New Point(10, 310)
        LbDurum.Margin = New Padding(4, 0, 4, 0)
        LbDurum.Name = "LbDurum"
        LbDurum.Size = New Size(48, 18)
        LbDurum.TabIndex = 20
        LbDurum.Text = "Durum"
        ' 
        ' VehiclePicture
        ' 
        VehiclePicture.FileName = "VehiclePicture"
        VehiclePicture.ShowPreview = True
        VehiclePicture.Title = "VehiclePicture"
        ' 
        ' LblSinif
        ' 
        LblSinif.AutoSize = True
        LblSinif.BackColor = Color.Transparent
        LblSinif.Location = New Point(220, 10)
        LblSinif.Margin = New Padding(4, 0, 4, 0)
        LblSinif.Name = "LblSinif"
        LblSinif.Size = New Size(48, 18)
        LblSinif.TabIndex = 2
        LblSinif.Text = "Sınıf"
        ' 
        ' CmbSinif
        ' 
        CmbSinif.DropDownStyle = ComboBoxStyle.DropDownList
        CmbSinif.FormattingEnabled = True
        CmbSinif.Items.AddRange(New Object() {"OTOMOBİL", "MOTOSİKLET", "SUV", "KAMYONET", "KAMYON", "OTOBÜS", "MİNİBÜS", "TIR", "TİCARİ", "DİĞER"})
        CmbSinif.Location = New Point(220, 30)
        CmbSinif.Margin = New Padding(4, 3, 4, 3)
        CmbSinif.Name = "CmbSinif"
        CmbSinif.Size = New Size(180, 26)
        CmbSinif.TabIndex = 3
        ' 
        ' BtnGorselSec
        ' 
        BtnGorselSec.ForeColor = SystemColors.Highlight
        BtnGorselSec.Location = New Point(220, 464)
        BtnGorselSec.Name = "BtnGorselSec"
        BtnGorselSec.Size = New Size(180, 30)
        BtnGorselSec.TabIndex = 27
        BtnGorselSec.Text = "Görsel Seç"
        BtnGorselSec.UseVisualStyleBackColor = True
        ' 
        ' TxtAciklama
        ' 
        TxtAciklama.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtAciklama.Location = New Point(10, 390)
        TxtAciklama.Multiline = True
        TxtAciklama.Name = "TxtAciklama"
        TxtAciklama.PlaceholderText = "Araç bilgisi..."
        TxtAciklama.Size = New Size(180, 80)
        TxtAciklama.TabIndex = 25
        ' 
        ' lblAciklama
        ' 
        lblAciklama.AutoSize = True
        lblAciklama.BackColor = Color.Transparent
        lblAciklama.Location = New Point(10, 370)
        lblAciklama.Margin = New Padding(4, 0, 4, 0)
        lblAciklama.Name = "lblAciklama"
        lblAciklama.Size = New Size(72, 18)
        lblAciklama.TabIndex = 24
        lblAciklama.Text = "Açıklama"
        ' 
        ' TxtSasi
        ' 
        TxtSasi.Location = New Point(220, 333)
        TxtSasi.Margin = New Padding(4, 3, 4, 3)
        TxtSasi.MaxLength = 17
        TxtSasi.Name = "TxtSasi"
        TxtSasi.PlaceholderText = "12345678901234567"
        TxtSasi.Size = New Size(180, 23)
        TxtSasi.TabIndex = 23
        ' 
        ' LblSasi
        ' 
        LblSasi.AutoSize = True
        LblSasi.BackColor = Color.Transparent
        LblSasi.Location = New Point(220, 310)
        LblSasi.Margin = New Padding(4, 0, 4, 0)
        LblSasi.Name = "LblSasi"
        LblSasi.Size = New Size(64, 18)
        LblSasi.TabIndex = 22
        LblSasi.Text = "Şasi No"
        ' 
        ' PicSelectedGorsel
        ' 
        PicSelectedGorsel.BorderStyle = BorderStyle.FixedSingle
        PicSelectedGorsel.Image = My.Resources.cars
        PicSelectedGorsel.InitialImage = My.Resources.cars
        PicSelectedGorsel.Location = New Point(220, 390)
        PicSelectedGorsel.Name = "PicSelectedGorsel"
        PicSelectedGorsel.Size = New Size(180, 80)
        PicSelectedGorsel.SizeMode = PictureBoxSizeMode.Zoom
        PicSelectedGorsel.TabIndex = 30
        PicSelectedGorsel.TabStop = False
        ' 
        ' AddVehicleView
        ' 
        AcceptButton = BtnKaydet
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(414, 551)
        Controls.Add(LblSasi)
        Controls.Add(lblAciklama)
        Controls.Add(LblSinif)
        Controls.Add(LbDurum)
        Controls.Add(LblSahip)
        Controls.Add(LblKira)
        Controls.Add(LblSatis)
        Controls.Add(LblPlaka)
        Controls.Add(LblKm)
        Controls.Add(LblYil)
        Controls.Add(LblRenk)
        Controls.Add(LblModel)
        Controls.Add(LblMarka)
        Controls.Add(PicSelectedGorsel)
        Controls.Add(TxtSasi)
        Controls.Add(TxtAciklama)
        Controls.Add(BtnGorselSec)
        Controls.Add(CmbSinif)
        Controls.Add(CmbDurum)
        Controls.Add(CmbSahip)
        Controls.Add(BtnKaydet)
        Controls.Add(TxtKira)
        Controls.Add(TxtSatis)
        Controls.Add(TxtPlaka)
        Controls.Add(TxtKm)
        Controls.Add(TxtYil)
        Controls.Add(TxtRenk)
        Controls.Add(TxtModel)
        Controls.Add(TxtMarka)
        Font = New Font("Cascadia Mono SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "AddVehicleView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ARAÇ EKLE"
        CType(CustomerBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSelectedGorsel, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LblMarka As Label
    Friend WithEvents TxtMarka As TextBox
    Friend WithEvents LblModel As Label
    Friend WithEvents LblRenk As Label
    Friend WithEvents LblYil As Label
    Friend WithEvents LblKm As Label
    Friend WithEvents TxtModel As TextBox
    Friend WithEvents TxtRenk As TextBox
    Friend WithEvents TxtYil As TextBox
    Friend WithEvents TxtKm As TextBox
    Friend WithEvents LblPlaka As Label
    Friend WithEvents LblSatis As Label
    Friend WithEvents LblKira As Label
    Friend WithEvents TxtPlaka As TextBox
    Friend WithEvents TxtSatis As TextBox
    Friend WithEvents TxtKira As TextBox
    Friend WithEvents BtnKaydet As Button
    Friend WithEvents LblSahip As Label
    Friend WithEvents CmbSahip As ComboBox
    Friend WithEvents CmbDurum As ComboBox
    Friend WithEvents LbDurum As Label
    Friend WithEvents VehiclePicture As OpenFileDialog
    Friend WithEvents LblSinif As Label
    Friend WithEvents CmbSinif As ComboBox
    Friend WithEvents BtnGorselSec As Button
    Friend WithEvents TxtAciklama As TextBox
    Friend WithEvents lblAciklama As Label
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents TxtSasi As TextBox
    Friend WithEvents LblSasi As Label
    Friend WithEvents PicSelectedGorsel As PictureBox
End Class
