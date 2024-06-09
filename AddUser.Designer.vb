Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        LblSoyad = New Label()
        LblUsername = New Label()
        LblUser = New Label()
        LblMail = New Label()
        LblPassword = New Label()
        LblAd = New Label()
        CmbUser = New ComboBox()
        BtnKaydet = New Button()
        txtEmail = New TextBox()
        TxtSurname = New TextBox()
        txtName = New TextBox()
        TxtPassword = New TextBox()
        TxtUsername = New TextBox()
        RdUser = New RadioButton()
        RdAdmin = New RadioButton()
        SuspendLayout()
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
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.BackColor = Color.Transparent
        LblUsername.Location = New Point(10, 10)
        LblUsername.Margin = New Padding(5, 0, 5, 0)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(112, 17)
        LblUsername.TabIndex = 0
        LblUsername.Text = "Kullanıcı Adı"
        ' 
        ' LblUser
        ' 
        LblUser.AutoSize = True
        LblUser.BackColor = Color.Transparent
        LblUser.Location = New Point(220, 130)
        LblUser.Margin = New Padding(5, 0, 5, 0)
        LblUser.Name = "LblUser"
        LblUser.Size = New Size(80, 17)
        LblUser.TabIndex = 13
        LblUser.Text = "Kullanıcı"
        ' 
        ' LblMail
        ' 
        LblMail.AutoSize = True
        LblMail.BackColor = Color.Transparent
        LblMail.Location = New Point(220, 10)
        LblMail.Margin = New Padding(5, 0, 5, 0)
        LblMail.Name = "LblMail"
        LblMail.Size = New Size(64, 17)
        LblMail.TabIndex = 2
        LblMail.Text = "E-Posta"
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.BackColor = Color.Transparent
        LblPassword.Location = New Point(10, 130)
        LblPassword.Margin = New Padding(5, 0, 5, 0)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(48, 17)
        LblPassword.TabIndex = 8
        LblPassword.Text = "Şifre"
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
        ' CmbUser
        ' 
        CmbUser.DropDownStyle = ComboBoxStyle.DropDownList
        CmbUser.FormattingEnabled = True
        CmbUser.Location = New Point(220, 150)
        CmbUser.Margin = New Padding(5, 3, 5, 3)
        CmbUser.Name = "CmbUser"
        CmbUser.Size = New Size(190, 25)
        CmbUser.TabIndex = 14
        ' 
        ' BtnKaydet
        ' 
        BtnKaydet.BackColor = Color.DarkGreen
        BtnKaydet.ForeColor = SystemColors.Control
        BtnKaydet.Location = New Point(10, 250)
        BtnKaydet.Margin = New Padding(5, 3, 5, 3)
        BtnKaydet.Name = "BtnKaydet"
        BtnKaydet.Size = New Size(400, 45)
        BtnKaydet.TabIndex = 12
        BtnKaydet.Text = "KAYDET"
        BtnKaydet.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(220, 30)
        txtEmail.Margin = New Padding(5, 3, 5, 3)
        txtEmail.MaxLength = 254
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "ornek@gmail.com"
        txtEmail.Size = New Size(190, 23)
        txtEmail.TabIndex = 3
        ' 
        ' TxtSurname
        ' 
        TxtSurname.Location = New Point(220, 90)
        TxtSurname.Margin = New Padding(5, 3, 5, 3)
        TxtSurname.Name = "TxtSurname"
        TxtSurname.PlaceholderText = "Soyad"
        TxtSurname.Size = New Size(190, 23)
        TxtSurname.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(10, 90)
        txtName.Margin = New Padding(5, 3, 5, 3)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Ad"
        txtName.Size = New Size(190, 23)
        txtName.TabIndex = 5
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(10, 150)
        TxtPassword.Margin = New Padding(5, 3, 5, 3)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.PlaceholderText = "******"
        TxtPassword.Size = New Size(190, 23)
        TxtPassword.TabIndex = 9
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(10, 30)
        TxtUsername.Margin = New Padding(5, 3, 5, 3)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.PlaceholderText = "Kullanıcı Adı"
        TxtUsername.Size = New Size(190, 23)
        TxtUsername.TabIndex = 1
        ' 
        ' RdUser
        ' 
        RdUser.AutoSize = True
        RdUser.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RdUser.ForeColor = Color.DarkGreen
        RdUser.Location = New Point(140, 200)
        RdUser.Name = "RdUser"
        RdUser.Size = New Size(64, 25)
        RdUser.TabIndex = 10
        RdUser.TabStop = True
        RdUser.Text = "USER"
        RdUser.UseVisualStyleBackColor = True
        ' 
        ' RdAdmin
        ' 
        RdAdmin.AutoSize = True
        RdAdmin.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RdAdmin.ForeColor = Color.RoyalBlue
        RdAdmin.Location = New Point(220, 200)
        RdAdmin.Name = "RdAdmin"
        RdAdmin.Size = New Size(73, 25)
        RdAdmin.TabIndex = 11
        RdAdmin.TabStop = True
        RdAdmin.Text = "ADMIN"
        RdAdmin.UseVisualStyleBackColor = True
        ' 
        ' AddUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(424, 311)
        Controls.Add(RdAdmin)
        Controls.Add(RdUser)
        Controls.Add(TxtUsername)
        Controls.Add(TxtPassword)
        Controls.Add(LblSoyad)
        Controls.Add(LblUsername)
        Controls.Add(LblUser)
        Controls.Add(LblMail)
        Controls.Add(LblPassword)
        Controls.Add(LblAd)
        Controls.Add(CmbUser)
        Controls.Add(BtnKaydet)
        Controls.Add(txtEmail)
        Controls.Add(TxtSurname)
        Controls.Add(txtName)
        Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AddUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KULLANICI EKLE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblSoyad As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblAd As Label
    Friend WithEvents CmbUser As ComboBox
    Friend WithEvents BtnKaydet As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents TxtSurname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents RdUser As RadioButton
    Friend WithEvents RdAdmin As RadioButton
End Class
