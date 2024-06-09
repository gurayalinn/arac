Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnLogin = New Button()
        TxtUsername = New TextBox()
        TxtPassword = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        btnRegister = New Button()
        PictureBox1 = New PictureBox()
        SplashTitle = New Label()
        BtnAdmin = New Button()
        AppNotifyIcon = New NotifyIcon(components)
        AppMenu = New ContextMenuStrip(components)
        AppMenuItemCikis = New ToolStripMenuItem()
        BtnSifre = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        AppMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.Green
        btnLogin.Location = New Point(280, 220)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(120, 40)
        btnLogin.TabIndex = 6
        btnLogin.Text = "GİRİŞ"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' TxtUsername
        ' 
        TxtUsername.BackColor = SystemColors.Window
        TxtUsername.Location = New Point(280, 120)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(300, 23)
        TxtUsername.TabIndex = 3
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(280, 170)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(300, 23)
        TxtPassword.TabIndex = 5
        TxtPassword.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(280, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 21)
        Label2.TabIndex = 2
        Label2.Text = "Kullanıcı Adı"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(280, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 21)
        Label3.TabIndex = 4
        Label3.Text = "Şifre"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Transparent
        btnRegister.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = SystemColors.Highlight
        btnRegister.Location = New Point(460, 220)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(120, 40)
        btnRegister.TabIndex = 7
        btnRegister.Text = "KAYIT OL"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = Resources.bridge1
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' SplashTitle
        ' 
        SplashTitle.AutoSize = True
        SplashTitle.BackColor = Color.Transparent
        SplashTitle.Font = New Font("Cascadia Mono", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SplashTitle.ForeColor = SystemColors.Highlight
        SplashTitle.Location = New Point(350, 10)
        SplashTitle.Name = "SplashTitle"
        SplashTitle.Size = New Size(167, 63)
        SplashTitle.TabIndex = 1
        SplashTitle.Text = "GİRİŞ"
        SplashTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnAdmin
        ' 
        BtnAdmin.BackColor = Color.Transparent
        BtnAdmin.FlatAppearance.BorderSize = 0
        BtnAdmin.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnAdmin.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnAdmin.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAdmin.ForeColor = Color.Red
        BtnAdmin.Location = New Point(718, 9)
        BtnAdmin.Name = "BtnAdmin"
        BtnAdmin.Size = New Size(70, 30)
        BtnAdmin.TabIndex = 0
        BtnAdmin.Text = "ADMIN"
        BtnAdmin.UseVisualStyleBackColor = False
        ' 
        ' AppNotifyIcon
        ' 
        AppNotifyIcon.Icon = My.Resources.car1
        AppNotifyIcon.Text = "Araç"
        AppNotifyIcon.Visible = True
        ' 
        ' AppMenu
        ' 
        AppMenu.BackColor = Color.Silver
        AppMenu.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AppMenu.Items.AddRange(New ToolStripItem() {AppMenuItemCikis})
        AppMenu.Name = "ContextMenuStrip1"
        AppMenu.RenderMode = ToolStripRenderMode.System
        AppMenu.Size = New Size(117, 26)
        AppMenu.Text = "Araç"
        ' 
        ' AppMenuItemCikis
        ' 
        AppMenuItemCikis.BackColor = Color.Transparent
        AppMenuItemCikis.Font = New Font("Cascadia Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AppMenuItemCikis.ForeColor = Color.DarkRed
        AppMenuItemCikis.Name = "AppMenuItemCikis"
        AppMenuItemCikis.Size = New Size(116, 22)
        AppMenuItemCikis.Text = "Çıkış"
        ' 
        ' BtnSifre
        ' 
        BtnSifre.BackColor = Color.Transparent
        BtnSifre.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSifre.ForeColor = Color.Tomato
        BtnSifre.Location = New Point(280, 280)
        BtnSifre.Name = "BtnSifre"
        BtnSifre.Size = New Size(300, 28)
        BtnSifre.TabIndex = 8
        BtnSifre.Text = "Şifremi Unuttum?"
        BtnSifre.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnSifre)
        Controls.Add(BtnAdmin)
        Controls.Add(SplashTitle)
        Controls.Add(btnRegister)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Controls.Add(btnLogin)
        Controls.Add(PictureBox1)
        Icon = My.Resources.car1
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - Araç Satış Kiralama"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        AppMenu.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogin As Button
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SplashTitle As Label
    Friend WithEvents BtnAdmin As Button
    Friend WithEvents AppNotifyIcon As NotifyIcon
    Friend WithEvents AppMenu As ContextMenuStrip
    Friend WithEvents AppMenuItemCikis As ToolStripMenuItem
    Friend WithEvents BtnSifre As Button
End Class
