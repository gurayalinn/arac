Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserView
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
        CmbUser = New ComboBox()
        UserBindingSource = New BindingSource(components)
        TxtId = New Label()
        TxtGuncellemeTarih = New Label()
        TxtKayitTarih = New Label()
        TxtEmail = New Label()
        TxtYetki = New Label()
        TxtSoyad = New Label()
        TxtAd = New Label()
        LinkUsername = New LinkLabel()
        LblId = New Label()
        BtnDelete = New Button()
        BtnEdit = New Button()
        LblGuncellemeTarih = New Label()
        LblKayitTarih = New Label()
        LblYetki = New Label()
        LblSoyad = New Label()
        LblAd = New Label()
        LblUsername = New Label()
        LblEmail = New Label()
        LblTitle = New Label()
        CType(UserBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CmbUser
        ' 
        CmbUser.BackColor = Color.Silver
        CmbUser.DataSource = UserBindingSource
        CmbUser.FormattingEnabled = True
        CmbUser.Location = New Point(10, 10)
        CmbUser.Name = "CmbUser"
        CmbUser.Size = New Size(200, 25)
        CmbUser.TabIndex = 0
        ' 
        ' UserBindingSource
        ' 
        UserBindingSource.DataSource = GetType(User)
        ' 
        ' TxtId
        ' 
        TxtId.AutoSize = True
        TxtId.ForeColor = Color.Green
        TxtId.Location = New Point(70, 200)
        TxtId.Name = "TxtId"
        TxtId.Size = New Size(24, 17)
        TxtId.TabIndex = 12
        TxtId.Text = "00"
        ' 
        ' TxtGuncellemeTarih
        ' 
        TxtGuncellemeTarih.AutoSize = True
        TxtGuncellemeTarih.ForeColor = Color.MediumSeaGreen
        TxtGuncellemeTarih.Location = New Point(70, 260)
        TxtGuncellemeTarih.Name = "TxtGuncellemeTarih"
        TxtGuncellemeTarih.Size = New Size(88, 17)
        TxtGuncellemeTarih.TabIndex = 16
        TxtGuncellemeTarih.Text = "02.01.2024"
        ' 
        ' TxtKayitTarih
        ' 
        TxtKayitTarih.AutoSize = True
        TxtKayitTarih.ForeColor = Color.Green
        TxtKayitTarih.Location = New Point(70, 230)
        TxtKayitTarih.Name = "TxtKayitTarih"
        TxtKayitTarih.Size = New Size(88, 17)
        TxtKayitTarih.TabIndex = 14
        TxtKayitTarih.Text = "01.01.2024"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.AutoSize = True
        TxtEmail.Location = New Point(70, 80)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(128, 17)
        TxtEmail.TabIndex = 4
        TxtEmail.Text = "user@arac.local"
        ' 
        ' TxtYetki
        ' 
        TxtYetki.AutoSize = True
        TxtYetki.ForeColor = Color.Green
        TxtYetki.Location = New Point(70, 170)
        TxtYetki.Name = "TxtYetki"
        TxtYetki.Size = New Size(40, 17)
        TxtYetki.TabIndex = 10
        TxtYetki.Text = "USER"
        ' 
        ' TxtSoyad
        ' 
        TxtSoyad.AutoSize = True
        TxtSoyad.Location = New Point(70, 140)
        TxtSoyad.Name = "TxtSoyad"
        TxtSoyad.Size = New Size(64, 17)
        TxtSoyad.TabIndex = 8
        TxtSoyad.Text = "ACCOUNT"
        ' 
        ' TxtAd
        ' 
        TxtAd.AutoSize = True
        TxtAd.Location = New Point(70, 110)
        TxtAd.Name = "TxtAd"
        TxtAd.Size = New Size(40, 17)
        TxtAd.TabIndex = 6
        TxtAd.Text = "USER"
        ' 
        ' LinkUsername
        ' 
        LinkUsername.AutoSize = True
        LinkUsername.Location = New Point(70, 50)
        LinkUsername.Name = "LinkUsername"
        LinkUsername.Size = New Size(40, 17)
        LinkUsername.TabIndex = 2
        LinkUsername.TabStop = True
        LinkUsername.Text = "user"
        ' 
        ' LblId
        ' 
        LblId.AutoSize = True
        LblId.BackColor = Color.Transparent
        LblId.ForeColor = Color.DarkRed
        LblId.Location = New Point(10, 200)
        LblId.Margin = New Padding(4, 0, 4, 0)
        LblId.Name = "LblId"
        LblId.Size = New Size(40, 17)
        LblId.TabIndex = 11
        LblId.Text = "ID #"
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.Transparent
        BtnDelete.BackgroundImage = delete1
        BtnDelete.BackgroundImageLayout = ImageLayout.Zoom
        BtnDelete.Location = New Point(70, 300)
        BtnDelete.Margin = New Padding(3, 2, 3, 2)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(60, 44)
        BtnDelete.TabIndex = 18
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackColor = Color.Transparent
        BtnEdit.BackgroundImage = edit
        BtnEdit.BackgroundImageLayout = ImageLayout.Zoom
        BtnEdit.Location = New Point(10, 300)
        BtnEdit.Margin = New Padding(3, 2, 3, 2)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(60, 44)
        BtnEdit.TabIndex = 17
        BtnEdit.UseVisualStyleBackColor = False
        ' 
        ' LblGuncellemeTarih
        ' 
        LblGuncellemeTarih.AutoSize = True
        LblGuncellemeTarih.BackColor = Color.Transparent
        LblGuncellemeTarih.ForeColor = Color.DarkRed
        LblGuncellemeTarih.Location = New Point(10, 260)
        LblGuncellemeTarih.Margin = New Padding(4, 0, 4, 0)
        LblGuncellemeTarih.Name = "LblGuncellemeTarih"
        LblGuncellemeTarih.Size = New Size(64, 17)
        LblGuncellemeTarih.TabIndex = 15
        LblGuncellemeTarih.Text = "Güncel:"
        ' 
        ' LblKayitTarih
        ' 
        LblKayitTarih.AutoSize = True
        LblKayitTarih.BackColor = Color.Transparent
        LblKayitTarih.ForeColor = Color.DarkRed
        LblKayitTarih.Location = New Point(10, 230)
        LblKayitTarih.Margin = New Padding(4, 0, 4, 0)
        LblKayitTarih.Name = "LblKayitTarih"
        LblKayitTarih.Size = New Size(56, 17)
        LblKayitTarih.TabIndex = 13
        LblKayitTarih.Text = "Kayıt:"
        ' 
        ' LblYetki
        ' 
        LblYetki.AutoSize = True
        LblYetki.BackColor = Color.Transparent
        LblYetki.ForeColor = Color.DarkRed
        LblYetki.Location = New Point(10, 170)
        LblYetki.Margin = New Padding(4, 0, 4, 0)
        LblYetki.Name = "LblYetki"
        LblYetki.Size = New Size(56, 17)
        LblYetki.TabIndex = 9
        LblYetki.Text = "Yetki:"
        ' 
        ' LblSoyad
        ' 
        LblSoyad.AutoSize = True
        LblSoyad.BackColor = Color.Transparent
        LblSoyad.ForeColor = Color.DarkRed
        LblSoyad.Location = New Point(10, 140)
        LblSoyad.Margin = New Padding(4, 0, 4, 0)
        LblSoyad.Name = "LblSoyad"
        LblSoyad.Size = New Size(56, 17)
        LblSoyad.TabIndex = 7
        LblSoyad.Text = "Soyad:"
        ' 
        ' LblAd
        ' 
        LblAd.AutoSize = True
        LblAd.BackColor = Color.Transparent
        LblAd.ForeColor = Color.DarkRed
        LblAd.Location = New Point(10, 110)
        LblAd.Margin = New Padding(4, 0, 4, 0)
        LblAd.Name = "LblAd"
        LblAd.Size = New Size(32, 17)
        LblAd.TabIndex = 5
        LblAd.Text = "Ad:"
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.BackColor = Color.Transparent
        LblUsername.ForeColor = Color.DarkRed
        LblUsername.Location = New Point(10, 50)
        LblUsername.Margin = New Padding(4, 0, 4, 0)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(56, 17)
        LblUsername.TabIndex = 1
        LblUsername.Text = "Hesap:"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.BackColor = Color.Transparent
        LblEmail.ForeColor = Color.DarkRed
        LblEmail.Location = New Point(10, 80)
        LblEmail.Margin = New Padding(4, 0, 4, 0)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(56, 17)
        LblEmail.TabIndex = 3
        LblEmail.Text = "Email:"
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTitle.ForeColor = Color.Navy
        LblTitle.Location = New Point(10, 10)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(181, 21)
        LblTitle.TabIndex = 19
        LblTitle.Text = "KULLANICI BİLGİLERİ"
        ' 
        ' UserView
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(215, 361)
        Controls.Add(LblTitle)
        Controls.Add(CmbUser)
        Controls.Add(TxtId)
        Controls.Add(TxtGuncellemeTarih)
        Controls.Add(TxtKayitTarih)
        Controls.Add(TxtEmail)
        Controls.Add(TxtYetki)
        Controls.Add(TxtSoyad)
        Controls.Add(TxtAd)
        Controls.Add(LinkUsername)
        Controls.Add(LblId)
        Controls.Add(BtnDelete)
        Controls.Add(BtnEdit)
        Controls.Add(LblGuncellemeTarih)
        Controls.Add(LblKayitTarih)
        Controls.Add(LblYetki)
        Controls.Add(LblSoyad)
        Controls.Add(LblAd)
        Controls.Add(LblUsername)
        Controls.Add(LblEmail)
        Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = car1
        Name = "UserView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KULLANICI"
        CType(UserBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmbUser As ComboBox
    Friend WithEvents TxtId As Label
    Friend WithEvents TxtGuncellemeTarih As Label
    Friend WithEvents TxtKayitTarih As Label
    Friend WithEvents TxtEmail As Label
    Friend WithEvents TxtYetki As Label
    Friend WithEvents TxtSoyad As Label
    Friend WithEvents TxtAd As Label
    Friend WithEvents LinkUsername As LinkLabel
    Friend WithEvents LblId As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents LblGuncellemeTarih As Label
    Friend WithEvents LblKayitTarih As Label
    Friend WithEvents LblYetki As Label
    Friend WithEvents LblSoyad As Label
    Friend WithEvents LblAd As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents LblTitle As Label
End Class
