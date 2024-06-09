Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        txtName = New TextBox()
        txtEmailLabel = New Label()
        txtSurname = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtUsernameLabel = New Label()
        txtNameLabel = New Label()
        txtPasswordLabel = New Label()
        txtUsername = New TextBox()
        btnRegister = New Button()
        txtSurnameLabel = New Label()
        PictureBox1 = New PictureBox()
        SplashTitle = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(215, 159)
        txtName.Name = "txtName"
        txtName.Size = New Size(183, 23)
        txtName.TabIndex = 2
        ' 
        ' txtEmailLabel
        ' 
        txtEmailLabel.AutoSize = True
        txtEmailLabel.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmailLabel.ForeColor = SystemColors.ControlLightLight
        txtEmailLabel.Location = New Point(215, 192)
        txtEmailLabel.Name = "txtEmailLabel"
        txtEmailLabel.Size = New Size(55, 21)
        txtEmailLabel.TabIndex = 1
        txtEmailLabel.Text = "Email"
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(404, 159)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(183, 23)
        txtSurname.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(215, 216)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(372, 23)
        txtEmail.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(215, 274)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(372, 23)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsernameLabel
        ' 
        txtUsernameLabel.AutoSize = True
        txtUsernameLabel.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsernameLabel.ForeColor = SystemColors.ControlLightLight
        txtUsernameLabel.Location = New Point(215, 82)
        txtUsernameLabel.Name = "txtUsernameLabel"
        txtUsernameLabel.Size = New Size(127, 21)
        txtUsernameLabel.TabIndex = 7
        txtUsernameLabel.Text = "Kullanıcı Adı"
        ' 
        ' txtNameLabel
        ' 
        txtNameLabel.AutoSize = True
        txtNameLabel.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNameLabel.ForeColor = SystemColors.ControlLightLight
        txtNameLabel.Location = New Point(215, 136)
        txtNameLabel.Name = "txtNameLabel"
        txtNameLabel.Size = New Size(28, 21)
        txtNameLabel.TabIndex = 8
        txtNameLabel.Text = "Ad"
        ' 
        ' txtPasswordLabel
        ' 
        txtPasswordLabel.AutoSize = True
        txtPasswordLabel.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPasswordLabel.ForeColor = SystemColors.ControlLightLight
        txtPasswordLabel.Location = New Point(215, 250)
        txtPasswordLabel.Name = "txtPasswordLabel"
        txtPasswordLabel.Size = New Size(55, 21)
        txtPasswordLabel.TabIndex = 9
        txtPasswordLabel.Text = "Şifre"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(215, 106)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(183, 23)
        txtUsername.TabIndex = 1
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = SystemColors.Highlight
        btnRegister.Location = New Point(215, 320)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(372, 39)
        btnRegister.TabIndex = 6
        btnRegister.Text = "KAYIT OL"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' txtSurnameLabel
        ' 
        txtSurnameLabel.AutoSize = True
        txtSurnameLabel.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSurnameLabel.ForeColor = SystemColors.ControlLightLight
        txtSurnameLabel.Location = New Point(404, 136)
        txtSurnameLabel.Name = "txtSurnameLabel"
        txtSurnameLabel.Size = New Size(55, 21)
        txtSurnameLabel.TabIndex = 12
        txtSurnameLabel.Text = "Soyad"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.bridge1
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' SplashTitle
        ' 
        SplashTitle.AutoSize = True
        SplashTitle.BackColor = Color.Transparent
        SplashTitle.Font = New Font("Cascadia Mono", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SplashTitle.ForeColor = SystemColors.Highlight
        SplashTitle.Location = New Point(322, 9)
        SplashTitle.Name = "SplashTitle"
        SplashTitle.Size = New Size(167, 63)
        SplashTitle.TabIndex = 14
        SplashTitle.Text = "KAYIT"
        SplashTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplashTitle)
        Controls.Add(txtSurnameLabel)
        Controls.Add(btnRegister)
        Controls.Add(txtUsername)
        Controls.Add(txtPasswordLabel)
        Controls.Add(txtNameLabel)
        Controls.Add(txtUsernameLabel)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtSurname)
        Controls.Add(txtEmailLabel)
        Controls.Add(txtName)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register - Araç Satış Kiralama"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmailLabel As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsernameLabel As Label
    Friend WithEvents txtNameLabel As Label
    Friend WithEvents txtPasswordLabel As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtSurnameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SplashTitle As Label
End Class
