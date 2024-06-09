Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
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
        SplashTitle = New Label()
        PictureBox1 = New PictureBox()
        UserControllerBindingSource = New BindingSource(components)
        BtnUsers = New Button()
        PicUsers = New PictureBox()
        PicCars = New PictureBox()
        BtnCars = New Button()
        PicCustomers = New PictureBox()
        BtnCustomers = New Button()
        PanelContainer = New Panel()
        PicLogout = New PictureBox()
        BtnLogout = New Button()
        lblUsername = New Label()
        PicSaleRent = New PictureBox()
        BtnSaleRent = New Button()
        PicRents = New PictureBox()
        BtnRents = New Button()
        PicSales = New PictureBox()
        BtnSales = New Button()
        PicPayments = New PictureBox()
        BtnPayments = New Button()
        PicUser = New PictureBox()
        BtnUser = New Button()
        PicPay = New PictureBox()
        BtnPay = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserControllerBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicUsers, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicCars, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicCustomers, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicLogout, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSaleRent, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicRents, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSales, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicPayments, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicPay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplashTitle
        ' 
        SplashTitle.AutoSize = True
        SplashTitle.BackColor = Color.Transparent
        SplashTitle.Font = New Font("Cascadia Mono", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SplashTitle.ForeColor = SystemColors.Highlight
        SplashTitle.Location = New Point(181, 7)
        SplashTitle.Name = "SplashTitle"
        SplashTitle.Size = New Size(167, 63)
        SplashTitle.TabIndex = 17
        SplashTitle.Text = "ADMIN"
        SplashTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = bridge1
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' BtnUsers
        ' 
        BtnUsers.BackColor = Color.Transparent
        BtnUsers.BackgroundImageLayout = ImageLayout.None
        BtnUsers.FlatAppearance.BorderSize = 0
        BtnUsers.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnUsers.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnUsers.FlatStyle = FlatStyle.Flat
        BtnUsers.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnUsers.Location = New Point(10, 69)
        BtnUsers.Margin = New Padding(3, 2, 3, 2)
        BtnUsers.Name = "BtnUsers"
        BtnUsers.Size = New Size(165, 32)
        BtnUsers.TabIndex = 18
        BtnUsers.Text = "KULLANICILAR"
        BtnUsers.TextAlign = ContentAlignment.MiddleLeft
        BtnUsers.UseVisualStyleBackColor = False
        ' 
        ' PicUsers
        ' 
        PicUsers.Image = users
        PicUsers.Location = New Point(147, 69)
        PicUsers.Margin = New Padding(3, 2, 3, 2)
        PicUsers.Name = "PicUsers"
        PicUsers.Size = New Size(29, 32)
        PicUsers.SizeMode = PictureBoxSizeMode.Zoom
        PicUsers.TabIndex = 19
        PicUsers.TabStop = False
        ' 
        ' PicCars
        ' 
        PicCars.Image = cars
        PicCars.Location = New Point(147, 142)
        PicCars.Margin = New Padding(3, 2, 3, 2)
        PicCars.Name = "PicCars"
        PicCars.Size = New Size(29, 32)
        PicCars.SizeMode = PictureBoxSizeMode.Zoom
        PicCars.TabIndex = 21
        PicCars.TabStop = False
        ' 
        ' BtnCars
        ' 
        BtnCars.BackColor = Color.Transparent
        BtnCars.BackgroundImageLayout = ImageLayout.None
        BtnCars.FlatAppearance.BorderSize = 0
        BtnCars.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnCars.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnCars.FlatStyle = FlatStyle.Flat
        BtnCars.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCars.Location = New Point(10, 142)
        BtnCars.Margin = New Padding(3, 2, 3, 2)
        BtnCars.Name = "BtnCars"
        BtnCars.Size = New Size(165, 32)
        BtnCars.TabIndex = 20
        BtnCars.Text = "ARAÇLAR"
        BtnCars.TextAlign = ContentAlignment.MiddleLeft
        BtnCars.UseVisualStyleBackColor = False
        ' 
        ' PicCustomers
        ' 
        PicCustomers.Image = customers
        PicCustomers.Location = New Point(147, 106)
        PicCustomers.Margin = New Padding(3, 2, 3, 2)
        PicCustomers.Name = "PicCustomers"
        PicCustomers.Size = New Size(29, 32)
        PicCustomers.SizeMode = PictureBoxSizeMode.Zoom
        PicCustomers.TabIndex = 23
        PicCustomers.TabStop = False
        ' 
        ' BtnCustomers
        ' 
        BtnCustomers.BackColor = Color.Transparent
        BtnCustomers.BackgroundImageLayout = ImageLayout.None
        BtnCustomers.FlatAppearance.BorderSize = 0
        BtnCustomers.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnCustomers.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnCustomers.FlatStyle = FlatStyle.Flat
        BtnCustomers.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCustomers.Location = New Point(10, 106)
        BtnCustomers.Margin = New Padding(3, 2, 3, 2)
        BtnCustomers.Name = "BtnCustomers"
        BtnCustomers.Size = New Size(165, 32)
        BtnCustomers.TabIndex = 22
        BtnCustomers.Text = "MÜŞTERİLER"
        BtnCustomers.TextAlign = ContentAlignment.MiddleLeft
        BtnCustomers.UseVisualStyleBackColor = False
        ' 
        ' PanelContainer
        ' 
        PanelContainer.BackColor = Color.Transparent
        PanelContainer.Location = New Point(181, 69)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(597, 371)
        PanelContainer.TabIndex = 26
        ' 
        ' PicLogout
        ' 
        PicLogout.BackColor = Color.Transparent
        PicLogout.Image = logout
        PicLogout.Location = New Point(735, 29)
        PicLogout.Margin = New Padding(3, 2, 3, 2)
        PicLogout.Name = "PicLogout"
        PicLogout.Size = New Size(43, 35)
        PicLogout.SizeMode = PictureBoxSizeMode.Zoom
        PicLogout.TabIndex = 28
        PicLogout.TabStop = False
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = Color.WhiteSmoke
        BtnLogout.BackgroundImageLayout = ImageLayout.None
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnLogout.FlatAppearance.MouseOverBackColor = Color.Red
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogout.Location = New Point(668, 29)
        BtnLogout.Margin = New Padding(3, 2, 3, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(110, 35)
        BtnLogout.TabIndex = 27
        BtnLogout.Text = "ÇIKIŞ"
        BtnLogout.TextAlign = ContentAlignment.MiddleLeft
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        lblUsername.ForeColor = Color.Teal
        lblUsername.Location = New Point(10, 385)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(55, 21)
        lblUsername.TabIndex = 29
        lblUsername.Text = "ADMIN"
        lblUsername.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicSaleRent
        ' 
        PicSaleRent.Image = add
        PicSaleRent.Location = New Point(147, 250)
        PicSaleRent.Margin = New Padding(3, 2, 3, 2)
        PicSaleRent.Name = "PicSaleRent"
        PicSaleRent.Size = New Size(29, 32)
        PicSaleRent.SizeMode = PictureBoxSizeMode.Zoom
        PicSaleRent.TabIndex = 31
        PicSaleRent.TabStop = False
        ' 
        ' BtnSaleRent
        ' 
        BtnSaleRent.BackColor = Color.Transparent
        BtnSaleRent.BackgroundImageLayout = ImageLayout.None
        BtnSaleRent.FlatAppearance.BorderSize = 0
        BtnSaleRent.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnSaleRent.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnSaleRent.FlatStyle = FlatStyle.Flat
        BtnSaleRent.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSaleRent.Location = New Point(10, 250)
        BtnSaleRent.Margin = New Padding(3, 2, 3, 2)
        BtnSaleRent.Name = "BtnSaleRent"
        BtnSaleRent.Size = New Size(165, 32)
        BtnSaleRent.TabIndex = 30
        BtnSaleRent.Text = "SAT/KİRALA"
        BtnSaleRent.TextAlign = ContentAlignment.MiddleLeft
        BtnSaleRent.UseVisualStyleBackColor = False
        ' 
        ' PicRents
        ' 
        PicRents.Image = cars
        PicRents.Location = New Point(147, 214)
        PicRents.Margin = New Padding(3, 2, 3, 2)
        PicRents.Name = "PicRents"
        PicRents.Size = New Size(29, 32)
        PicRents.SizeMode = PictureBoxSizeMode.Zoom
        PicRents.TabIndex = 33
        PicRents.TabStop = False
        ' 
        ' BtnRents
        ' 
        BtnRents.BackColor = Color.Transparent
        BtnRents.BackgroundImageLayout = ImageLayout.None
        BtnRents.FlatAppearance.BorderSize = 0
        BtnRents.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnRents.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnRents.FlatStyle = FlatStyle.Flat
        BtnRents.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRents.Location = New Point(10, 214)
        BtnRents.Margin = New Padding(3, 2, 3, 2)
        BtnRents.Name = "BtnRents"
        BtnRents.Size = New Size(165, 32)
        BtnRents.TabIndex = 32
        BtnRents.Text = "KİRALAMALAR"
        BtnRents.TextAlign = ContentAlignment.MiddleLeft
        BtnRents.UseVisualStyleBackColor = False
        ' 
        ' PicSales
        ' 
        PicSales.Image = cars
        PicSales.Location = New Point(147, 178)
        PicSales.Margin = New Padding(3, 2, 3, 2)
        PicSales.Name = "PicSales"
        PicSales.Size = New Size(29, 32)
        PicSales.SizeMode = PictureBoxSizeMode.Zoom
        PicSales.TabIndex = 35
        PicSales.TabStop = False
        ' 
        ' BtnSales
        ' 
        BtnSales.BackColor = Color.Transparent
        BtnSales.BackgroundImageLayout = ImageLayout.None
        BtnSales.FlatAppearance.BorderSize = 0
        BtnSales.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnSales.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnSales.FlatStyle = FlatStyle.Flat
        BtnSales.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSales.Location = New Point(10, 178)
        BtnSales.Margin = New Padding(3, 2, 3, 2)
        BtnSales.Name = "BtnSales"
        BtnSales.Size = New Size(165, 32)
        BtnSales.TabIndex = 34
        BtnSales.Text = "SATIŞLAR"
        BtnSales.TextAlign = ContentAlignment.MiddleLeft
        BtnSales.UseVisualStyleBackColor = False
        ' 
        ' PicPayments
        ' 
        PicPayments.Image = operations
        PicPayments.Location = New Point(147, 286)
        PicPayments.Margin = New Padding(3, 2, 3, 2)
        PicPayments.Name = "PicPayments"
        PicPayments.Size = New Size(29, 32)
        PicPayments.SizeMode = PictureBoxSizeMode.Zoom
        PicPayments.TabIndex = 37
        PicPayments.TabStop = False
        ' 
        ' BtnPayments
        ' 
        BtnPayments.BackColor = Color.Transparent
        BtnPayments.BackgroundImageLayout = ImageLayout.None
        BtnPayments.FlatAppearance.BorderSize = 0
        BtnPayments.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnPayments.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnPayments.FlatStyle = FlatStyle.Flat
        BtnPayments.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPayments.Location = New Point(10, 286)
        BtnPayments.Margin = New Padding(3, 2, 3, 2)
        BtnPayments.Name = "BtnPayments"
        BtnPayments.Size = New Size(165, 32)
        BtnPayments.TabIndex = 36
        BtnPayments.Text = "ÖDEMELER"
        BtnPayments.TextAlign = ContentAlignment.MiddleLeft
        BtnPayments.UseVisualStyleBackColor = False
        ' 
        ' PicUser
        ' 
        PicUser.Image = admin
        PicUser.Location = New Point(147, 408)
        PicUser.Margin = New Padding(3, 2, 3, 2)
        PicUser.Name = "PicUser"
        PicUser.Size = New Size(29, 32)
        PicUser.SizeMode = PictureBoxSizeMode.Zoom
        PicUser.TabIndex = 39
        PicUser.TabStop = False
        ' 
        ' BtnUser
        ' 
        BtnUser.BackColor = Color.Transparent
        BtnUser.BackgroundImageLayout = ImageLayout.None
        BtnUser.FlatAppearance.BorderSize = 0
        BtnUser.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnUser.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnUser.FlatStyle = FlatStyle.Flat
        BtnUser.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnUser.Location = New Point(10, 408)
        BtnUser.Margin = New Padding(3, 2, 3, 2)
        BtnUser.Name = "BtnUser"
        BtnUser.Size = New Size(165, 32)
        BtnUser.TabIndex = 38
        BtnUser.Text = "KULLANICI"
        BtnUser.TextAlign = ContentAlignment.MiddleLeft
        BtnUser.UseVisualStyleBackColor = False
        ' 
        ' PicPay
        ' 
        PicPay.Image = add
        PicPay.Location = New Point(147, 322)
        PicPay.Margin = New Padding(3, 2, 3, 2)
        PicPay.Name = "PicPay"
        PicPay.Size = New Size(29, 32)
        PicPay.SizeMode = PictureBoxSizeMode.Zoom
        PicPay.TabIndex = 41
        PicPay.TabStop = False
        ' 
        ' BtnPay
        ' 
        BtnPay.BackColor = Color.Transparent
        BtnPay.BackgroundImageLayout = ImageLayout.None
        BtnPay.FlatAppearance.BorderSize = 0
        BtnPay.FlatAppearance.MouseDownBackColor = Color.Transparent
        BtnPay.FlatAppearance.MouseOverBackColor = Color.Transparent
        BtnPay.FlatStyle = FlatStyle.Flat
        BtnPay.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPay.Location = New Point(10, 322)
        BtnPay.Margin = New Padding(3, 2, 3, 2)
        BtnPay.Name = "BtnPay"
        BtnPay.Size = New Size(165, 32)
        BtnPay.TabIndex = 40
        BtnPay.Text = "ÖDEME YAP"
        BtnPay.TextAlign = ContentAlignment.MiddleLeft
        BtnPay.UseVisualStyleBackColor = False
        ' 
        ' AdminHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PicPay)
        Controls.Add(BtnPay)
        Controls.Add(PicUser)
        Controls.Add(BtnUser)
        Controls.Add(PicPayments)
        Controls.Add(BtnPayments)
        Controls.Add(PicSales)
        Controls.Add(BtnSales)
        Controls.Add(PicRents)
        Controls.Add(BtnRents)
        Controls.Add(PicSaleRent)
        Controls.Add(BtnSaleRent)
        Controls.Add(lblUsername)
        Controls.Add(PicLogout)
        Controls.Add(BtnLogout)
        Controls.Add(PanelContainer)
        Controls.Add(PicCustomers)
        Controls.Add(BtnCustomers)
        Controls.Add(PicCars)
        Controls.Add(BtnCars)
        Controls.Add(PicUsers)
        Controls.Add(BtnUsers)
        Controls.Add(SplashTitle)
        Controls.Add(PictureBox1)
        Icon = car1
        Margin = New Padding(3, 2, 3, 2)
        Name = "AdminHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin - Araç Satış Kiralama"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(UserControllerBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(PicUsers, ComponentModel.ISupportInitialize).EndInit()
        CType(PicCars, ComponentModel.ISupportInitialize).EndInit()
        CType(PicCustomers, ComponentModel.ISupportInitialize).EndInit()
        CType(PicLogout, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSaleRent, ComponentModel.ISupportInitialize).EndInit()
        CType(PicRents, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSales, ComponentModel.ISupportInitialize).EndInit()
        CType(PicPayments, ComponentModel.ISupportInitialize).EndInit()
        CType(PicUser, ComponentModel.ISupportInitialize).EndInit()
        CType(PicPay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SplashTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UserControllerBindingSource As BindingSource
    Friend WithEvents BtnUsers As Button
    Friend WithEvents PicUsers As PictureBox
    Friend WithEvents PicCars As PictureBox
    Friend WithEvents BtnCars As Button
    Friend WithEvents PicCustomers As PictureBox
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PicLogout As PictureBox
    Friend WithEvents BtnLogout As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents PicSaleRent As PictureBox
    Friend WithEvents BtnSaleRent As Button
    Friend WithEvents PicRents As PictureBox
    Friend WithEvents BtnRents As Button
    Friend WithEvents PicSales As PictureBox
    Friend WithEvents BtnSales As Button
    Friend WithEvents PicPayments As PictureBox
    Friend WithEvents BtnPayments As Button
    Friend WithEvents PicUser As PictureBox
    Friend WithEvents BtnUser As Button
    Friend WithEvents PicPay As PictureBox
    Friend WithEvents BtnPay As Button
End Class
