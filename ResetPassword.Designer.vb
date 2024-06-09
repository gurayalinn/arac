Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResetPassword
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
        TxtPassword = New TextBox()
        LblMail = New Label()
        LblPassword = New Label()
        BtnSifirla = New Button()
        txtEmail = New TextBox()
        LblKod = New Label()
        BtnKod = New Button()
        TxtKod = New MaskedTextBox()
        PicPay = New PictureBox()
        BtnKodDogrula = New Button()
        CType(PicPay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(10, 170)
        TxtPassword.Margin = New Padding(5, 3, 5, 3)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.PlaceholderText = "******"
        TxtPassword.Size = New Size(190, 23)
        TxtPassword.TabIndex = 7
        ' 
        ' LblMail
        ' 
        LblMail.AutoSize = True
        LblMail.BackColor = Color.Transparent
        LblMail.Location = New Point(10, 10)
        LblMail.Margin = New Padding(5, 0, 5, 0)
        LblMail.Name = "LblMail"
        LblMail.Size = New Size(64, 17)
        LblMail.TabIndex = 0
        LblMail.Text = "E-Posta"
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.BackColor = Color.Transparent
        LblPassword.Location = New Point(10, 150)
        LblPassword.Margin = New Padding(5, 0, 5, 0)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(48, 17)
        LblPassword.TabIndex = 6
        LblPassword.Text = "Şifre"
        ' 
        ' BtnSifirla
        ' 
        BtnSifirla.BackColor = Color.RoyalBlue
        BtnSifirla.ForeColor = SystemColors.Control
        BtnSifirla.Location = New Point(10, 200)
        BtnSifirla.Margin = New Padding(5, 3, 5, 3)
        BtnSifirla.Name = "BtnSifirla"
        BtnSifirla.Size = New Size(280, 45)
        BtnSifirla.TabIndex = 8
        BtnSifirla.Text = "ŞİFRE SIFIRLA"
        BtnSifirla.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(10, 30)
        txtEmail.Margin = New Padding(5, 3, 5, 3)
        txtEmail.MaxLength = 254
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "ornek@gmail.com"
        txtEmail.Size = New Size(190, 23)
        txtEmail.TabIndex = 1
        ' 
        ' LblKod
        ' 
        LblKod.AutoSize = True
        LblKod.BackColor = Color.Transparent
        LblKod.Location = New Point(10, 80)
        LblKod.Margin = New Padding(5, 0, 5, 0)
        LblKod.Name = "LblKod"
        LblKod.Size = New Size(120, 17)
        LblKod.TabIndex = 3
        LblKod.Text = "Doğrulama Kodu"
        ' 
        ' BtnKod
        ' 
        BtnKod.BackColor = Color.RoyalBlue
        BtnKod.Font = New Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnKod.ForeColor = SystemColors.Control
        BtnKod.Location = New Point(200, 30)
        BtnKod.Margin = New Padding(5, 3, 5, 3)
        BtnKod.Name = "BtnKod"
        BtnKod.Size = New Size(90, 25)
        BtnKod.TabIndex = 2
        BtnKod.Text = "KOD GÖNDER"
        BtnKod.UseVisualStyleBackColor = False
        ' 
        ' TxtKod
        ' 
        TxtKod.Location = New Point(10, 100)
        TxtKod.Mask = "0000"
        TxtKod.Name = "TxtKod"
        TxtKod.Size = New Size(190, 23)
        TxtKod.TabIndex = 4
        ' 
        ' PicPay
        ' 
        PicPay.Image = Resources.lock
        PicPay.Location = New Point(205, 130)
        PicPay.Margin = New Padding(3, 2, 3, 2)
        PicPay.Name = "PicPay"
        PicPay.Size = New Size(85, 65)
        PicPay.SizeMode = PictureBoxSizeMode.Zoom
        PicPay.TabIndex = 42
        PicPay.TabStop = False
        ' 
        ' BtnKodDogrula
        ' 
        BtnKodDogrula.BackColor = Color.DarkGreen
        BtnKodDogrula.Font = New Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnKodDogrula.ForeColor = SystemColors.Control
        BtnKodDogrula.Location = New Point(200, 100)
        BtnKodDogrula.Margin = New Padding(5, 3, 5, 3)
        BtnKodDogrula.Name = "BtnKodDogrula"
        BtnKodDogrula.Size = New Size(90, 25)
        BtnKodDogrula.TabIndex = 5
        BtnKodDogrula.Text = "KOD DOĞRULA"
        BtnKodDogrula.UseVisualStyleBackColor = False
        ' 
        ' ResetPassword
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(299, 255)
        Controls.Add(BtnKodDogrula)
        Controls.Add(PicPay)
        Controls.Add(TxtKod)
        Controls.Add(BtnKod)
        Controls.Add(LblKod)
        Controls.Add(TxtPassword)
        Controls.Add(LblMail)
        Controls.Add(LblPassword)
        Controls.Add(BtnSifirla)
        Controls.Add(txtEmail)
        Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = car1
        Name = "ResetPassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ŞİFRE SIFIRLA"
        CType(PicPay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblMail As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents BtnSifirla As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents LblKod As Label
    Friend WithEvents BtnKod As Button
    Friend WithEvents TxtKod As MaskedTextBox
    Friend WithEvents PicPay As PictureBox
    Friend WithEvents BtnKodDogrula As Button
End Class
