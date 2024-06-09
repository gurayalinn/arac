Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Panel1 = New Panel()
        PanelContainerWrap = New Panel()
        PicPay = New PictureBox()
        BtnPay = New Button()
        PicUser = New PictureBox()
        BtnUser = New Button()
        PicPayments = New PictureBox()
        BtnPayments = New Button()
        PicSales = New PictureBox()
        BtnSales = New Button()
        PicRents = New PictureBox()
        BtnRents = New Button()
        PicSaleRent = New PictureBox()
        BtnSaleRent = New Button()
        lblUsername = New Label()
        PicLogout = New PictureBox()
        BtnLogout = New Button()
        PanelContainer = New Panel()
        PicCustomers = New PictureBox()
        BtnCustomers = New Button()
        PicCars = New PictureBox()
        BtnCars = New Button()
        SplashTitle = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        PanelContainerWrap.SuspendLayout()
        CType(PicPay, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicPayments, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSales, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicRents, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSaleRent, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicLogout, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicCustomers, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicCars, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PanelContainerWrap)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' PanelContainerWrap
        ' 
        PanelContainerWrap.BackColor = Color.Transparent
        PanelContainerWrap.Controls.Add(PicPay)
        PanelContainerWrap.Controls.Add(BtnPay)
        PanelContainerWrap.Controls.Add(PicUser)
        PanelContainerWrap.Controls.Add(BtnUser)
        PanelContainerWrap.Controls.Add(PicPayments)
        PanelContainerWrap.Controls.Add(BtnPayments)
        PanelContainerWrap.Controls.Add(PicSales)
        PanelContainerWrap.Controls.Add(BtnSales)
        PanelContainerWrap.Controls.Add(PicRents)
        PanelContainerWrap.Controls.Add(BtnRents)
        PanelContainerWrap.Controls.Add(PicSaleRent)
        PanelContainerWrap.Controls.Add(BtnSaleRent)
        PanelContainerWrap.Controls.Add(lblUsername)
        PanelContainerWrap.Controls.Add(PicLogout)
        PanelContainerWrap.Controls.Add(BtnLogout)
        PanelContainerWrap.Controls.Add(PanelContainer)
        PanelContainerWrap.Controls.Add(PicCustomers)
        PanelContainerWrap.Controls.Add(BtnCustomers)
        PanelContainerWrap.Controls.Add(PicCars)
        PanelContainerWrap.Controls.Add(BtnCars)
        PanelContainerWrap.Controls.Add(SplashTitle)
        PanelContainerWrap.Controls.Add(PictureBox1)
        PanelContainerWrap.Location = New Point(0, 0)
        PanelContainerWrap.Name = "PanelContainerWrap"
        PanelContainerWrap.Size = New Size(800, 450)
        PanelContainerWrap.TabIndex = 1
        ' 
        ' PicPay
        ' 
        PicPay.Image = add
        PicPay.Location = New Point(147, 320)
        PicPay.Margin = New Padding(3, 2, 3, 2)
        PicPay.Name = "PicPay"
        PicPay.Size = New Size(29, 32)
        PicPay.SizeMode = PictureBoxSizeMode.Zoom
        PicPay.TabIndex = 53
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
        BtnPay.Location = New Point(10, 320)
        BtnPay.Margin = New Padding(3, 2, 3, 2)
        BtnPay.Name = "BtnPay"
        BtnPay.Size = New Size(165, 32)
        BtnPay.TabIndex = 52
        BtnPay.Text = "ÖDEME YAP"
        BtnPay.TextAlign = ContentAlignment.MiddleLeft
        BtnPay.UseVisualStyleBackColor = False
        ' 
        ' PicUser
        ' 
        PicUser.Image = admin
        PicUser.Location = New Point(147, 409)
        PicUser.Margin = New Padding(3, 2, 3, 2)
        PicUser.Name = "PicUser"
        PicUser.Size = New Size(29, 32)
        PicUser.SizeMode = PictureBoxSizeMode.Zoom
        PicUser.TabIndex = 51
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
        BtnUser.Location = New Point(10, 409)
        BtnUser.Margin = New Padding(3, 2, 3, 2)
        BtnUser.Name = "BtnUser"
        BtnUser.Size = New Size(165, 32)
        BtnUser.TabIndex = 50
        BtnUser.Text = "KULLANICI"
        BtnUser.TextAlign = ContentAlignment.MiddleLeft
        BtnUser.UseVisualStyleBackColor = False
        ' 
        ' PicPayments
        ' 
        PicPayments.Image = operations
        PicPayments.Location = New Point(147, 248)
        PicPayments.Margin = New Padding(3, 2, 3, 2)
        PicPayments.Name = "PicPayments"
        PicPayments.Size = New Size(29, 32)
        PicPayments.SizeMode = PictureBoxSizeMode.Zoom
        PicPayments.TabIndex = 49
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
        BtnPayments.Location = New Point(10, 248)
        BtnPayments.Margin = New Padding(3, 2, 3, 2)
        BtnPayments.Name = "BtnPayments"
        BtnPayments.Size = New Size(165, 32)
        BtnPayments.TabIndex = 48
        BtnPayments.Text = "ÖDEMELER"
        BtnPayments.TextAlign = ContentAlignment.MiddleLeft
        BtnPayments.UseVisualStyleBackColor = False
        ' 
        ' PicSales
        ' 
        PicSales.Image = cars
        PicSales.Location = New Point(147, 176)
        PicSales.Margin = New Padding(3, 2, 3, 2)
        PicSales.Name = "PicSales"
        PicSales.Size = New Size(29, 32)
        PicSales.SizeMode = PictureBoxSizeMode.Zoom
        PicSales.TabIndex = 47
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
        BtnSales.Location = New Point(10, 176)
        BtnSales.Margin = New Padding(3, 2, 3, 2)
        BtnSales.Name = "BtnSales"
        BtnSales.Size = New Size(165, 32)
        BtnSales.TabIndex = 46
        BtnSales.Text = "SATIŞLAR"
        BtnSales.TextAlign = ContentAlignment.MiddleLeft
        BtnSales.UseVisualStyleBackColor = False
        ' 
        ' PicRents
        ' 
        PicRents.Image = cars
        PicRents.Location = New Point(147, 212)
        PicRents.Margin = New Padding(3, 2, 3, 2)
        PicRents.Name = "PicRents"
        PicRents.Size = New Size(29, 32)
        PicRents.SizeMode = PictureBoxSizeMode.Zoom
        PicRents.TabIndex = 45
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
        BtnRents.Location = New Point(10, 212)
        BtnRents.Margin = New Padding(3, 2, 3, 2)
        BtnRents.Name = "BtnRents"
        BtnRents.Size = New Size(165, 32)
        BtnRents.TabIndex = 44
        BtnRents.Text = "KİRALAMALAR"
        BtnRents.TextAlign = ContentAlignment.MiddleLeft
        BtnRents.UseVisualStyleBackColor = False
        ' 
        ' PicSaleRent
        ' 
        PicSaleRent.Image = add
        PicSaleRent.Location = New Point(147, 284)
        PicSaleRent.Margin = New Padding(3, 2, 3, 2)
        PicSaleRent.Name = "PicSaleRent"
        PicSaleRent.Size = New Size(29, 32)
        PicSaleRent.SizeMode = PictureBoxSizeMode.Zoom
        PicSaleRent.TabIndex = 43
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
        BtnSaleRent.Location = New Point(10, 284)
        BtnSaleRent.Margin = New Padding(3, 2, 3, 2)
        BtnSaleRent.Name = "BtnSaleRent"
        BtnSaleRent.Size = New Size(165, 32)
        BtnSaleRent.TabIndex = 42
        BtnSaleRent.Text = "SAT/KİRALA"
        BtnSaleRent.TextAlign = ContentAlignment.MiddleLeft
        BtnSaleRent.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold)
        lblUsername.ForeColor = Color.Teal
        lblUsername.Location = New Point(10, 386)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(46, 21)
        lblUsername.TabIndex = 40
        lblUsername.Text = "USER"
        lblUsername.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicLogout
        ' 
        PicLogout.BackColor = Color.Transparent
        PicLogout.Image = logout
        PicLogout.Location = New Point(741, 30)
        PicLogout.Margin = New Padding(3, 2, 3, 2)
        PicLogout.Name = "PicLogout"
        PicLogout.Size = New Size(43, 35)
        PicLogout.SizeMode = PictureBoxSizeMode.Zoom
        PicLogout.TabIndex = 39
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
        BtnLogout.Location = New Point(674, 30)
        BtnLogout.Margin = New Padding(3, 2, 3, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(110, 35)
        BtnLogout.TabIndex = 38
        BtnLogout.Text = "ÇIKIŞ"
        BtnLogout.TextAlign = ContentAlignment.MiddleLeft
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' PanelContainer
        ' 
        PanelContainer.BackColor = Color.Transparent
        PanelContainer.Location = New Point(187, 70)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(597, 371)
        PanelContainer.TabIndex = 35
        ' 
        ' PicCustomers
        ' 
        PicCustomers.Image = customers
        PicCustomers.Location = New Point(147, 70)
        PicCustomers.Margin = New Padding(3, 2, 3, 2)
        PicCustomers.Name = "PicCustomers"
        PicCustomers.Size = New Size(29, 32)
        PicCustomers.SizeMode = PictureBoxSizeMode.Zoom
        PicCustomers.TabIndex = 32
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
        BtnCustomers.Location = New Point(10, 70)
        BtnCustomers.Margin = New Padding(3, 2, 3, 2)
        BtnCustomers.Name = "BtnCustomers"
        BtnCustomers.Size = New Size(165, 32)
        BtnCustomers.TabIndex = 31
        BtnCustomers.Text = "MÜŞTERİLER"
        BtnCustomers.TextAlign = ContentAlignment.MiddleLeft
        BtnCustomers.UseVisualStyleBackColor = False
        ' 
        ' PicCars
        ' 
        PicCars.Image = cars
        PicCars.Location = New Point(147, 107)
        PicCars.Margin = New Padding(3, 2, 3, 2)
        PicCars.Name = "PicCars"
        PicCars.Size = New Size(29, 32)
        PicCars.SizeMode = PictureBoxSizeMode.Zoom
        PicCars.TabIndex = 30
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
        BtnCars.Location = New Point(10, 107)
        BtnCars.Margin = New Padding(3, 2, 3, 2)
        BtnCars.Name = "BtnCars"
        BtnCars.Size = New Size(165, 32)
        BtnCars.TabIndex = 29
        BtnCars.Text = "ARAÇLAR"
        BtnCars.TextAlign = ContentAlignment.MiddleLeft
        BtnCars.UseVisualStyleBackColor = False
        ' 
        ' SplashTitle
        ' 
        SplashTitle.AutoSize = True
        SplashTitle.BackColor = Color.Transparent
        SplashTitle.Font = New Font("Cascadia Mono", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SplashTitle.ForeColor = SystemColors.Highlight
        SplashTitle.Location = New Point(187, 8)
        SplashTitle.Name = "SplashTitle"
        SplashTitle.Size = New Size(335, 63)
        SplashTitle.TabIndex = 28
        SplashTitle.Text = "HOŞGELDİNİZ"
        SplashTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = bridge1
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Icon = car1
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Araç Satış Kiralama"
        Panel1.ResumeLayout(False)
        PanelContainerWrap.ResumeLayout(False)
        PanelContainerWrap.PerformLayout()
        CType(PicPay, ComponentModel.ISupportInitialize).EndInit()
        CType(PicUser, ComponentModel.ISupportInitialize).EndInit()
        CType(PicPayments, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSales, ComponentModel.ISupportInitialize).EndInit()
        CType(PicRents, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSaleRent, ComponentModel.ISupportInitialize).EndInit()
        CType(PicLogout, ComponentModel.ISupportInitialize).EndInit()
        CType(PicCustomers, ComponentModel.ISupportInitialize).EndInit()
        CType(PicCars, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelContainerWrap As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PicCustomers As PictureBox
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents PicCars As PictureBox
    Friend WithEvents BtnCars As Button
    Friend WithEvents SplashTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PicLogout As PictureBox
    Friend WithEvents BtnLogout As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents PicUser As PictureBox
    Friend WithEvents BtnUser As Button
    Friend WithEvents PicPayments As PictureBox
    Friend WithEvents BtnPayments As Button
    Friend WithEvents PicSales As PictureBox
    Friend WithEvents BtnSales As Button
    Friend WithEvents PicRents As PictureBox
    Friend WithEvents BtnRents As Button
    Friend WithEvents PicSaleRent As PictureBox
    Friend WithEvents BtnSaleRent As Button
    Friend WithEvents PicPay As PictureBox
    Friend WithEvents BtnPay As Button
End Class
