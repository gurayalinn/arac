Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddCustomerView
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
        lblAdres = New Label()
        LblCustomer = New Label()
        LblMail = New Label()
        LblTel = New Label()
        LblAd = New Label()
        TxtAdres = New TextBox()
        CmbCustomer = New ComboBox()
        BtnKaydet = New Button()
        TxtMail = New TextBox()
        TxtSoyad = New TextBox()
        TxtAd = New TextBox()
        TxtTckn = New MaskedTextBox()
        LblTckn = New Label()
        DpBirth = New DateTimePicker()
        LblBirth = New Label()
        TxtTel = New MaskedTextBox()
        CmbCinsiyet = New ComboBox()
        LblCinsiyet = New Label()
        LblSoyad = New Label()
        SuspendLayout()
        ' 
        ' lblAdres
        ' 
        lblAdres.AutoSize = True
        lblAdres.BackColor = Color.Transparent
        lblAdres.Location = New Point(10, 250)
        lblAdres.Margin = New Padding(5, 0, 5, 0)
        lblAdres.Name = "lblAdres"
        lblAdres.Size = New Size(48, 17)
        lblAdres.TabIndex = 15
        lblAdres.Text = "Adres"
        ' 
        ' LblCustomer
        ' 
        LblCustomer.AutoSize = True
        LblCustomer.BackColor = Color.Transparent
        LblCustomer.Location = New Point(10, 10)
        LblCustomer.Margin = New Padding(5, 0, 5, 0)
        LblCustomer.Name = "LblCustomer"
        LblCustomer.Size = New Size(64, 17)
        LblCustomer.TabIndex = 0
        LblCustomer.Text = "Müşteri"
        ' 
        ' LblMail
        ' 
        LblMail.AutoSize = True
        LblMail.BackColor = Color.Transparent
        LblMail.Location = New Point(220, 130)
        LblMail.Margin = New Padding(5, 0, 5, 0)
        LblMail.Name = "LblMail"
        LblMail.Size = New Size(64, 17)
        LblMail.TabIndex = 9
        LblMail.Text = "E-Posta"
        ' 
        ' LblTel
        ' 
        LblTel.AutoSize = True
        LblTel.BackColor = Color.Transparent
        LblTel.Location = New Point(10, 130)
        LblTel.Margin = New Padding(5, 0, 5, 0)
        LblTel.Name = "LblTel"
        LblTel.Size = New Size(64, 17)
        LblTel.TabIndex = 8
        LblTel.Text = "Telefon"
        ' 
        ' LblAd
        ' 
        LblAd.AutoSize = True
        LblAd.BackColor = Color.Transparent
        LblAd.Location = New Point(10, 70)
        LblAd.Margin = New Padding(5, 0, 5, 0)
        LblAd.Name = "LblAd"
        LblAd.Size = New Size(24, 17)
        LblAd.TabIndex = 4
        LblAd.Text = "Ad"
        ' 
        ' TxtAdres
        ' 
        TxtAdres.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtAdres.Location = New Point(10, 270)
        TxtAdres.Multiline = True
        TxtAdres.Name = "TxtAdres"
        TxtAdres.PlaceholderText = "Ornek Mah. Giriş Sk. No:1 Osmangazi/Bursa"
        TxtAdres.Size = New Size(400, 60)
        TxtAdres.TabIndex = 16
        ' 
        ' CmbCustomer
        ' 
        CmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList
        CmbCustomer.FormattingEnabled = True
        CmbCustomer.Location = New Point(10, 30)
        CmbCustomer.Margin = New Padding(5, 3, 5, 3)
        CmbCustomer.Name = "CmbCustomer"
        CmbCustomer.Size = New Size(190, 25)
        CmbCustomer.TabIndex = 1
        ' 
        ' BtnKaydet
        ' 
        BtnKaydet.BackColor = Color.DarkGreen
        BtnKaydet.ForeColor = SystemColors.Control
        BtnKaydet.Location = New Point(10, 330)
        BtnKaydet.Margin = New Padding(5, 3, 5, 3)
        BtnKaydet.Name = "BtnKaydet"
        BtnKaydet.Size = New Size(400, 45)
        BtnKaydet.TabIndex = 17
        BtnKaydet.Text = "KAYDET"
        BtnKaydet.UseVisualStyleBackColor = False
        ' 
        ' TxtMail
        ' 
        TxtMail.Location = New Point(220, 150)
        TxtMail.Margin = New Padding(5, 3, 5, 3)
        TxtMail.MaxLength = 254
        TxtMail.Name = "TxtMail"
        TxtMail.PlaceholderText = "ornek@gmail.com"
        TxtMail.Size = New Size(190, 23)
        TxtMail.TabIndex = 10
        ' 
        ' TxtSoyad
        ' 
        TxtSoyad.Location = New Point(220, 90)
        TxtSoyad.Margin = New Padding(5, 3, 5, 3)
        TxtSoyad.Name = "TxtSoyad"
        TxtSoyad.PlaceholderText = "Soyad"
        TxtSoyad.Size = New Size(190, 23)
        TxtSoyad.TabIndex = 7
        ' 
        ' TxtAd
        ' 
        TxtAd.Location = New Point(10, 90)
        TxtAd.Margin = New Padding(5, 3, 5, 3)
        TxtAd.Name = "TxtAd"
        TxtAd.PlaceholderText = "Ad"
        TxtAd.Size = New Size(190, 23)
        TxtAd.TabIndex = 5
        ' 
        ' TxtTckn
        ' 
        TxtTckn.Location = New Point(220, 30)
        TxtTckn.Mask = "00000000000"
        TxtTckn.Name = "TxtTckn"
        TxtTckn.Size = New Size(190, 23)
        TxtTckn.TabIndex = 3
        ' 
        ' LblTckn
        ' 
        LblTckn.AutoSize = True
        LblTckn.BackColor = Color.Transparent
        LblTckn.Location = New Point(220, 10)
        LblTckn.Margin = New Padding(5, 0, 5, 0)
        LblTckn.Name = "LblTckn"
        LblTckn.Size = New Size(40, 17)
        LblTckn.TabIndex = 2
        LblTckn.Text = "TCKN"
        ' 
        ' DpBirth
        ' 
        DpBirth.Location = New Point(10, 210)
        DpBirth.MaxDate = New Date(2005, 12, 31, 0, 0, 0, 0)
        DpBirth.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        DpBirth.Name = "DpBirth"
        DpBirth.Size = New Size(190, 23)
        DpBirth.TabIndex = 12
        DpBirth.Value = New Date(2005, 12, 31, 0, 0, 0, 0)
        ' 
        ' LblBirth
        ' 
        LblBirth.AutoSize = True
        LblBirth.BackColor = Color.Transparent
        LblBirth.Location = New Point(10, 190)
        LblBirth.Margin = New Padding(5, 0, 5, 0)
        LblBirth.Name = "LblBirth"
        LblBirth.Size = New Size(104, 17)
        LblBirth.TabIndex = 11
        LblBirth.Text = "Doğum Tarihi"
        ' 
        ' TxtTel
        ' 
        TxtTel.Location = New Point(10, 150)
        TxtTel.Mask = "90000000000"
        TxtTel.Name = "TxtTel"
        TxtTel.Size = New Size(190, 23)
        TxtTel.TabIndex = 8
        TxtTel.Text = "05"
        ' 
        ' CmbCinsiyet
        ' 
        CmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList
        CmbCinsiyet.FormattingEnabled = True
        CmbCinsiyet.Items.AddRange(New Object() {"ERKEK", "KADIN", "DİĞER"})
        CmbCinsiyet.Location = New Point(220, 212)
        CmbCinsiyet.Margin = New Padding(5, 3, 5, 3)
        CmbCinsiyet.Name = "CmbCinsiyet"
        CmbCinsiyet.Size = New Size(190, 25)
        CmbCinsiyet.TabIndex = 14
        ' 
        ' LblCinsiyet
        ' 
        LblCinsiyet.AutoSize = True
        LblCinsiyet.BackColor = Color.Transparent
        LblCinsiyet.Location = New Point(220, 190)
        LblCinsiyet.Margin = New Padding(5, 0, 5, 0)
        LblCinsiyet.Name = "LblCinsiyet"
        LblCinsiyet.Size = New Size(72, 17)
        LblCinsiyet.TabIndex = 13
        LblCinsiyet.Text = "Cinsiyet"
        ' 
        ' LblSoyad
        ' 
        LblSoyad.AutoSize = True
        LblSoyad.BackColor = Color.Transparent
        LblSoyad.Location = New Point(220, 70)
        LblSoyad.Margin = New Padding(5, 0, 5, 0)
        LblSoyad.Name = "LblSoyad"
        LblSoyad.Size = New Size(48, 17)
        LblSoyad.TabIndex = 6
        LblSoyad.Text = "Soyad"
        ' 
        ' AddCustomerView
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.Silver
        ClientSize = New Size(414, 391)
        Controls.Add(LblSoyad)
        Controls.Add(LblCinsiyet)
        Controls.Add(CmbCinsiyet)
        Controls.Add(TxtTel)
        Controls.Add(LblBirth)
        Controls.Add(DpBirth)
        Controls.Add(LblTckn)
        Controls.Add(TxtTckn)
        Controls.Add(lblAdres)
        Controls.Add(LblCustomer)
        Controls.Add(LblMail)
        Controls.Add(LblTel)
        Controls.Add(LblAd)
        Controls.Add(TxtAdres)
        Controls.Add(CmbCustomer)
        Controls.Add(BtnKaydet)
        Controls.Add(TxtMail)
        Controls.Add(TxtSoyad)
        Controls.Add(TxtAd)
        Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = My.Resources.car1
        Name = "AddCustomerView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MÜŞTERİ EKLE"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblAdres As Label
    Friend WithEvents LblSinif As Label
    Friend WithEvents LbDurum As Label
    Friend WithEvents LblCustomer As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblTel As Label
    Friend WithEvents LblModel As Label
    Friend WithEvents LblAd As Label
    Friend WithEvents TxtAdres As TextBox
    Friend WithEvents CmbSinif As ComboBox
    Friend WithEvents CmbDurum As ComboBox
    Friend WithEvents CmbCustomer As ComboBox
    Friend WithEvents BtnKaydet As Button
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtSoyad As TextBox
    Friend WithEvents TxtAd As TextBox
    Friend WithEvents TxtTckn As MaskedTextBox
    Friend WithEvents LblTckn As Label
    Friend WithEvents DpBirth As DateTimePicker
    Friend WithEvents LblBirth As Label
    Friend WithEvents TxtTel As MaskedTextBox
    Friend WithEvents CmbCinsiyet As ComboBox
    Friend WithEvents LblCinsiyet As Label
    Friend WithEvents LblSoyad As Label
End Class
