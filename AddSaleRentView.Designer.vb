Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddSaleRentView
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        SaleBindingSource = New BindingSource(components)
        ButtonSaveSale = New Button()
        SaleRentControl = New TabControl()
        TabPageSale = New TabPage()
        ComboBoxPaymentTypeSale = New ComboBox()
        TextBoxPriceSale = New TextBox()
        LabelSale = New Label()
        ButtonAddVehicleSale = New Button()
        LabelVehicleSale = New Label()
        ComboBoxVehicleSale = New ComboBox()
        LabelPaymentSale = New Label()
        ButtonAddOwnerSale = New Button()
        LabelOwnerSale = New Label()
        ComboBoxOwnerSale = New ComboBox()
        PictureBoxSale = New PictureBox()
        LabelDateSale = New Label()
        DateTimePickerSale = New DateTimePicker()
        TabPageRent = New TabPage()
        ComboBoxPaymentTypeRent = New ComboBox()
        TextBoxPriceRent = New TextBox()
        BtnClearTarih = New Button()
        BtnSaveTarih = New Button()
        LblTarihSec = New Label()
        CmbTarih = New ComboBox()
        CmbSayi = New ComboBox()
        LabelRent = New Label()
        ButtonAddVehicleRent = New Button()
        LabelVehicleRent = New Label()
        ComboBoxVehicleRent = New ComboBox()
        LabelPaymentRent = New Label()
        ButtonAddOwnerRent = New Button()
        LabelOwnerRent = New Label()
        ComboBoxOwnerRent = New ComboBox()
        PictureBoxRent = New PictureBox()
        LabelDateRent = New Label()
        ButtonSaveRent = New Button()
        DateTimePickerRent = New DateTimePicker()
        CType(SaleBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SaleRentControl.SuspendLayout()
        TabPageSale.SuspendLayout()
        CType(PictureBoxSale, ComponentModel.ISupportInitialize).BeginInit()
        TabPageRent.SuspendLayout()
        CType(PictureBoxRent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonSaveSale
        ' 
        ButtonSaveSale.BackColor = Color.DarkGreen
        ButtonSaveSale.ForeColor = SystemColors.Control
        ButtonSaveSale.Location = New Point(5, 210)
        ButtonSaveSale.Margin = New Padding(4, 3, 4, 3)
        ButtonSaveSale.Name = "ButtonSaveSale"
        ButtonSaveSale.Size = New Size(380, 50)
        ButtonSaveSale.TabIndex = 16
        ButtonSaveSale.Text = "KAYDET"
        ButtonSaveSale.UseVisualStyleBackColor = False
        ' 
        ' SaleRentControl
        ' 
        SaleRentControl.Controls.Add(TabPageSale)
        SaleRentControl.Controls.Add(TabPageRent)
        SaleRentControl.Location = New Point(10, 10)
        SaleRentControl.Name = "SaleRentControl"
        SaleRentControl.SelectedIndex = 0
        SaleRentControl.Size = New Size(600, 300)
        SaleRentControl.TabIndex = 0
        ' 
        ' TabPageSale
        ' 
        TabPageSale.BackColor = Color.Silver
        TabPageSale.Controls.Add(ComboBoxPaymentTypeSale)
        TabPageSale.Controls.Add(TextBoxPriceSale)
        TabPageSale.Controls.Add(LabelSale)
        TabPageSale.Controls.Add(ButtonAddVehicleSale)
        TabPageSale.Controls.Add(LabelVehicleSale)
        TabPageSale.Controls.Add(ComboBoxVehicleSale)
        TabPageSale.Controls.Add(LabelPaymentSale)
        TabPageSale.Controls.Add(ButtonAddOwnerSale)
        TabPageSale.Controls.Add(LabelOwnerSale)
        TabPageSale.Controls.Add(ComboBoxOwnerSale)
        TabPageSale.Controls.Add(PictureBoxSale)
        TabPageSale.Controls.Add(LabelDateSale)
        TabPageSale.Controls.Add(ButtonSaveSale)
        TabPageSale.Controls.Add(DateTimePickerSale)
        TabPageSale.Location = New Point(4, 25)
        TabPageSale.Name = "TabPageSale"
        TabPageSale.Padding = New Padding(3)
        TabPageSale.Size = New Size(592, 271)
        TabPageSale.TabIndex = 0
        TabPageSale.Text = "SAT"
        ' 
        ' ComboBoxPaymentTypeSale
        ' 
        ComboBoxPaymentTypeSale.ForeColor = Color.Tomato
        ComboBoxPaymentTypeSale.FormattingEnabled = True
        ComboBoxPaymentTypeSale.Items.AddRange(New Object() {"-", "NAKİT", "KREDİ", "HAVALE", "ÇEK", "DİĞER"})
        ComboBoxPaymentTypeSale.Location = New Point(80, 140)
        ComboBoxPaymentTypeSale.Name = "ComboBoxPaymentTypeSale"
        ComboBoxPaymentTypeSale.Size = New Size(130, 24)
        ComboBoxPaymentTypeSale.TabIndex = 75
        ' 
        ' TextBoxPriceSale
        ' 
        TextBoxPriceSale.BackColor = Color.LightGreen
        TextBoxPriceSale.ForeColor = Color.Black
        TextBoxPriceSale.Location = New Point(230, 140)
        TextBoxPriceSale.Name = "TextBoxPriceSale"
        TextBoxPriceSale.PlaceholderText = "0 ₺"
        TextBoxPriceSale.Size = New Size(150, 21)
        TextBoxPriceSale.TabIndex = 15
        ' 
        ' LabelSale
        ' 
        LabelSale.AutoSize = True
        LabelSale.Font = New Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSale.ForeColor = Color.RoyalBlue
        LabelSale.Location = New Point(400, 210)
        LabelSale.Name = "LabelSale"
        LabelSale.Size = New Size(114, 43)
        LabelSale.TabIndex = 17
        LabelSale.Text = "SATIŞ"
        ' 
        ' ButtonAddVehicleSale
        ' 
        ButtonAddVehicleSale.Location = New Point(258, 5)
        ButtonAddVehicleSale.Name = "ButtonAddVehicleSale"
        ButtonAddVehicleSale.Size = New Size(125, 28)
        ButtonAddVehicleSale.TabIndex = 3
        ButtonAddVehicleSale.Text = "Araç Ekle"
        ButtonAddVehicleSale.UseVisualStyleBackColor = True
        ' 
        ' LabelVehicleSale
        ' 
        LabelVehicleSale.AutoSize = True
        LabelVehicleSale.Location = New Point(5, 5)
        LabelVehicleSale.Name = "LabelVehicleSale"
        LabelVehicleSale.Size = New Size(35, 16)
        LabelVehicleSale.TabIndex = 1
        LabelVehicleSale.Text = "Araç"
        ' 
        ' ComboBoxVehicleSale
        ' 
        ComboBoxVehicleSale.FormattingEnabled = True
        ComboBoxVehicleSale.Items.AddRange(New Object() {"-"})
        ComboBoxVehicleSale.Location = New Point(80, 5)
        ComboBoxVehicleSale.Name = "ComboBoxVehicleSale"
        ComboBoxVehicleSale.Size = New Size(150, 24)
        ComboBoxVehicleSale.TabIndex = 2
        ' 
        ' LabelPaymentSale
        ' 
        LabelPaymentSale.AutoSize = True
        LabelPaymentSale.Location = New Point(5, 140)
        LabelPaymentSale.Name = "LabelPaymentSale"
        LabelPaymentSale.Size = New Size(42, 16)
        LabelPaymentSale.TabIndex = 9
        LabelPaymentSale.Text = "Ödeme"
        ' 
        ' ButtonAddOwnerSale
        ' 
        ButtonAddOwnerSale.ForeColor = SystemColors.ControlText
        ButtonAddOwnerSale.Location = New Point(258, 55)
        ButtonAddOwnerSale.Name = "ButtonAddOwnerSale"
        ButtonAddOwnerSale.Size = New Size(125, 28)
        ButtonAddOwnerSale.TabIndex = 6
        ButtonAddOwnerSale.Text = "Müşteri Ekle"
        ButtonAddOwnerSale.UseVisualStyleBackColor = True
        ' 
        ' LabelOwnerSale
        ' 
        LabelOwnerSale.AutoSize = True
        LabelOwnerSale.BackColor = Color.Transparent
        LabelOwnerSale.Location = New Point(5, 55)
        LabelOwnerSale.Margin = New Padding(4, 0, 4, 0)
        LabelOwnerSale.Name = "LabelOwnerSale"
        LabelOwnerSale.Size = New Size(56, 16)
        LabelOwnerSale.TabIndex = 4
        LabelOwnerSale.Text = "Müşteri"
        ' 
        ' ComboBoxOwnerSale
        ' 
        ComboBoxOwnerSale.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxOwnerSale.FormattingEnabled = True
        ComboBoxOwnerSale.Items.AddRange(New Object() {"-"})
        ComboBoxOwnerSale.Location = New Point(80, 55)
        ComboBoxOwnerSale.Margin = New Padding(4, 3, 4, 3)
        ComboBoxOwnerSale.Name = "ComboBoxOwnerSale"
        ComboBoxOwnerSale.Size = New Size(150, 24)
        ComboBoxOwnerSale.TabIndex = 5
        ' 
        ' PictureBoxSale
        ' 
        PictureBoxSale.BorderStyle = BorderStyle.FixedSingle
        PictureBoxSale.Image = cars
        PictureBoxSale.InitialImage = cars
        PictureBoxSale.Location = New Point(400, 5)
        PictureBoxSale.Name = "PictureBoxSale"
        PictureBoxSale.Size = New Size(180, 200)
        PictureBoxSale.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxSale.TabIndex = 56
        PictureBoxSale.TabStop = False
        ' 
        ' LabelDateSale
        ' 
        LabelDateSale.AutoSize = True
        LabelDateSale.Location = New Point(5, 100)
        LabelDateSale.Name = "LabelDateSale"
        LabelDateSale.Size = New Size(42, 16)
        LabelDateSale.TabIndex = 7
        LabelDateSale.Text = "Tarih"
        ' 
        ' DateTimePickerSale
        ' 
        DateTimePickerSale.Location = New Point(80, 100)
        DateTimePickerSale.MaxDate = New Date(2026, 4, 4, 0, 0, 0, 0)
        DateTimePickerSale.MinDate = New Date(2024, 6, 4, 0, 0, 0, 0)
        DateTimePickerSale.Name = "DateTimePickerSale"
        DateTimePickerSale.Size = New Size(300, 21)
        DateTimePickerSale.TabIndex = 8
        DateTimePickerSale.Value = New Date(2024, 6, 4, 0, 0, 0, 0)
        ' 
        ' TabPageRent
        ' 
        TabPageRent.BackColor = Color.Silver
        TabPageRent.Controls.Add(ComboBoxPaymentTypeRent)
        TabPageRent.Controls.Add(TextBoxPriceRent)
        TabPageRent.Controls.Add(BtnClearTarih)
        TabPageRent.Controls.Add(BtnSaveTarih)
        TabPageRent.Controls.Add(LblTarihSec)
        TabPageRent.Controls.Add(CmbTarih)
        TabPageRent.Controls.Add(CmbSayi)
        TabPageRent.Controls.Add(LabelRent)
        TabPageRent.Controls.Add(ButtonAddVehicleRent)
        TabPageRent.Controls.Add(LabelVehicleRent)
        TabPageRent.Controls.Add(ComboBoxVehicleRent)
        TabPageRent.Controls.Add(LabelPaymentRent)
        TabPageRent.Controls.Add(ButtonAddOwnerRent)
        TabPageRent.Controls.Add(LabelOwnerRent)
        TabPageRent.Controls.Add(ComboBoxOwnerRent)
        TabPageRent.Controls.Add(PictureBoxRent)
        TabPageRent.Controls.Add(LabelDateRent)
        TabPageRent.Controls.Add(ButtonSaveRent)
        TabPageRent.Controls.Add(DateTimePickerRent)
        TabPageRent.Location = New Point(4, 25)
        TabPageRent.Name = "TabPageRent"
        TabPageRent.Padding = New Padding(3)
        TabPageRent.Size = New Size(592, 271)
        TabPageRent.TabIndex = 1
        TabPageRent.Text = "KİRALA"
        ' 
        ' ComboBoxPaymentTypeRent
        ' 
        ComboBoxPaymentTypeRent.ForeColor = Color.Tomato
        ComboBoxPaymentTypeRent.FormattingEnabled = True
        ComboBoxPaymentTypeRent.Items.AddRange(New Object() {"-", "NAKİT", "KREDİ", "HAVALE", "ÇEK", "DİĞER"})
        ComboBoxPaymentTypeRent.Location = New Point(80, 180)
        ComboBoxPaymentTypeRent.Name = "ComboBoxPaymentTypeRent"
        ComboBoxPaymentTypeRent.Size = New Size(130, 24)
        ComboBoxPaymentTypeRent.TabIndex = 74
        ' 
        ' TextBoxPriceRent
        ' 
        TextBoxPriceRent.BackColor = Color.LightGreen
        TextBoxPriceRent.ForeColor = Color.Black
        TextBoxPriceRent.Location = New Point(230, 180)
        TextBoxPriceRent.Name = "TextBoxPriceRent"
        TextBoxPriceRent.PlaceholderText = "0 ₺"
        TextBoxPriceRent.Size = New Size(150, 21)
        TextBoxPriceRent.TabIndex = 20
        ' 
        ' BtnClearTarih
        ' 
        BtnClearTarih.ForeColor = Color.Tomato
        BtnClearTarih.Location = New Point(309, 140)
        BtnClearTarih.Name = "BtnClearTarih"
        BtnClearTarih.Size = New Size(74, 23)
        BtnClearTarih.TabIndex = 13
        BtnClearTarih.Text = "Temizle"
        BtnClearTarih.UseVisualStyleBackColor = True
        ' 
        ' BtnSaveTarih
        ' 
        BtnSaveTarih.ForeColor = Color.LimeGreen
        BtnSaveTarih.Location = New Point(230, 140)
        BtnSaveTarih.Name = "BtnSaveTarih"
        BtnSaveTarih.Size = New Size(67, 23)
        BtnSaveTarih.TabIndex = 12
        BtnSaveTarih.Text = "Uygula"
        BtnSaveTarih.UseVisualStyleBackColor = True
        ' 
        ' LblTarihSec
        ' 
        LblTarihSec.AutoSize = True
        LblTarihSec.Location = New Point(5, 140)
        LblTarihSec.Name = "LblTarihSec"
        LblTarihSec.Size = New Size(70, 16)
        LblTarihSec.TabIndex = 9
        LblTarihSec.Text = "Tarih Seç"
        ' 
        ' CmbTarih
        ' 
        CmbTarih.ForeColor = Color.Tomato
        CmbTarih.FormattingEnabled = True
        CmbTarih.Items.AddRange(New Object() {"-", "GÜN", "HAFTA", "AY", "YIL"})
        CmbTarih.Location = New Point(150, 140)
        CmbTarih.Name = "CmbTarih"
        CmbTarih.Size = New Size(60, 24)
        CmbTarih.TabIndex = 11
        ' 
        ' CmbSayi
        ' 
        CmbSayi.ForeColor = Color.Tomato
        CmbSayi.FormattingEnabled = True
        CmbSayi.Items.AddRange(New Object() {"-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        CmbSayi.Location = New Point(80, 140)
        CmbSayi.Name = "CmbSayi"
        CmbSayi.Size = New Size(60, 24)
        CmbSayi.TabIndex = 10
        ' 
        ' LabelRent
        ' 
        LabelRent.AutoSize = True
        LabelRent.Font = New Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRent.ForeColor = Color.Orange
        LabelRent.Location = New Point(400, 210)
        LabelRent.Name = "LabelRent"
        LabelRent.Size = New Size(133, 43)
        LabelRent.TabIndex = 22
        LabelRent.Text = "KİRALA"
        ' 
        ' ButtonAddVehicleRent
        ' 
        ButtonAddVehicleRent.Location = New Point(258, 5)
        ButtonAddVehicleRent.Name = "ButtonAddVehicleRent"
        ButtonAddVehicleRent.Size = New Size(125, 28)
        ButtonAddVehicleRent.TabIndex = 3
        ButtonAddVehicleRent.Text = "Araç Ekle"
        ButtonAddVehicleRent.UseVisualStyleBackColor = True
        ' 
        ' LabelVehicleRent
        ' 
        LabelVehicleRent.AutoSize = True
        LabelVehicleRent.Location = New Point(5, 5)
        LabelVehicleRent.Name = "LabelVehicleRent"
        LabelVehicleRent.Size = New Size(35, 16)
        LabelVehicleRent.TabIndex = 1
        LabelVehicleRent.Text = "Araç"
        ' 
        ' ComboBoxVehicleRent
        ' 
        ComboBoxVehicleRent.FormattingEnabled = True
        ComboBoxVehicleRent.Items.AddRange(New Object() {"-"})
        ComboBoxVehicleRent.Location = New Point(80, 5)
        ComboBoxVehicleRent.Name = "ComboBoxVehicleRent"
        ComboBoxVehicleRent.Size = New Size(150, 24)
        ComboBoxVehicleRent.TabIndex = 2
        ' 
        ' LabelPaymentRent
        ' 
        LabelPaymentRent.AutoSize = True
        LabelPaymentRent.Location = New Point(5, 180)
        LabelPaymentRent.Name = "LabelPaymentRent"
        LabelPaymentRent.Size = New Size(42, 16)
        LabelPaymentRent.TabIndex = 14
        LabelPaymentRent.Text = "Ödeme"
        ' 
        ' ButtonAddOwnerRent
        ' 
        ButtonAddOwnerRent.Location = New Point(258, 55)
        ButtonAddOwnerRent.Name = "ButtonAddOwnerRent"
        ButtonAddOwnerRent.Size = New Size(125, 28)
        ButtonAddOwnerRent.TabIndex = 6
        ButtonAddOwnerRent.Text = "Müşteri Ekle"
        ButtonAddOwnerRent.UseVisualStyleBackColor = True
        ' 
        ' LabelOwnerRent
        ' 
        LabelOwnerRent.AutoSize = True
        LabelOwnerRent.BackColor = Color.Transparent
        LabelOwnerRent.Location = New Point(5, 55)
        LabelOwnerRent.Margin = New Padding(4, 0, 4, 0)
        LabelOwnerRent.Name = "LabelOwnerRent"
        LabelOwnerRent.Size = New Size(56, 16)
        LabelOwnerRent.TabIndex = 4
        LabelOwnerRent.Text = "Müşteri"
        ' 
        ' ComboBoxOwnerRent
        ' 
        ComboBoxOwnerRent.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxOwnerRent.FormattingEnabled = True
        ComboBoxOwnerRent.Items.AddRange(New Object() {"-"})
        ComboBoxOwnerRent.Location = New Point(80, 55)
        ComboBoxOwnerRent.Margin = New Padding(4, 3, 4, 3)
        ComboBoxOwnerRent.Name = "ComboBoxOwnerRent"
        ComboBoxOwnerRent.Size = New Size(150, 24)
        ComboBoxOwnerRent.TabIndex = 5
        ' 
        ' PictureBoxRent
        ' 
        PictureBoxRent.BorderStyle = BorderStyle.FixedSingle
        PictureBoxRent.Image = cars
        PictureBoxRent.InitialImage = cars
        PictureBoxRent.Location = New Point(400, 5)
        PictureBoxRent.Name = "PictureBoxRent"
        PictureBoxRent.Size = New Size(180, 200)
        PictureBoxRent.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxRent.TabIndex = 73
        PictureBoxRent.TabStop = False
        ' 
        ' LabelDateRent
        ' 
        LabelDateRent.AutoSize = True
        LabelDateRent.Location = New Point(5, 100)
        LabelDateRent.Name = "LabelDateRent"
        LabelDateRent.Size = New Size(70, 16)
        LabelDateRent.TabIndex = 7
        LabelDateRent.Text = "Iade Tar."
        ' 
        ' ButtonSaveRent
        ' 
        ButtonSaveRent.BackColor = Color.DarkGreen
        ButtonSaveRent.ForeColor = SystemColors.Control
        ButtonSaveRent.Location = New Point(5, 210)
        ButtonSaveRent.Margin = New Padding(4, 3, 4, 3)
        ButtonSaveRent.Name = "ButtonSaveRent"
        ButtonSaveRent.Size = New Size(380, 50)
        ButtonSaveRent.TabIndex = 21
        ButtonSaveRent.Text = "KAYDET"
        ButtonSaveRent.UseVisualStyleBackColor = False
        ' 
        ' DateTimePickerRent
        ' 
        DateTimePickerRent.Location = New Point(80, 100)
        DateTimePickerRent.MaxDate = New Date(2026, 6, 4, 0, 0, 0, 0)
        DateTimePickerRent.MinDate = New Date(2024, 6, 4, 0, 0, 0, 0)
        DateTimePickerRent.Name = "DateTimePickerRent"
        DateTimePickerRent.Size = New Size(300, 21)
        DateTimePickerRent.TabIndex = 8
        DateTimePickerRent.Value = New Date(2024, 6, 4, 0, 0, 0, 0)
        ' 
        ' AddSaleRentView
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(624, 321)
        Controls.Add(SaleRentControl)
        Font = New Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = car1
        Margin = New Padding(4, 3, 4, 3)
        Name = "AddSaleRentView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SÖZLEŞME"
        CType(SaleBindingSource, ComponentModel.ISupportInitialize).EndInit()
        SaleRentControl.ResumeLayout(False)
        TabPageSale.ResumeLayout(False)
        TabPageSale.PerformLayout()
        CType(PictureBoxSale, ComponentModel.ISupportInitialize).EndInit()
        TabPageRent.ResumeLayout(False)
        TabPageRent.PerformLayout()
        CType(PictureBoxRent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents SaleBindingSource As BindingSource
    Friend WithEvents ButtonSaveSale As Button
    Friend WithEvents SaleRentControl As TabControl
    Friend WithEvents TabPageSale As TabPage
    Friend WithEvents LabelDateSale As Label
    Friend WithEvents DateTimePickerSale As DateTimePicker
    Friend WithEvents TabPageRent As TabPage
    Friend WithEvents PictureBoxSale As PictureBox
    Friend WithEvents LabelOwnerSale As Label
    Friend WithEvents ComboBoxOwnerSale As ComboBox
    Friend WithEvents ButtonAddOwnerSale As Button
    Friend WithEvents LabelPaymentSale As Label
    Friend WithEvents ComboBoxVehicleSale As ComboBox
    Friend WithEvents ButtonAddVehicleSale As Button
    Friend WithEvents LabelVehicleSale As Label
    Friend WithEvents ButtonAddVehicleRent As Button
    Friend WithEvents LabelVehicleRent As Label
    Friend WithEvents ComboBoxVehicleRent As ComboBox
    Friend WithEvents LabelPaymentRent As Label
    Friend WithEvents ButtonAddOwnerRent As Button
    Friend WithEvents LabelOwnerRent As Label
    Friend WithEvents ComboBoxOwnerRent As ComboBox
    Friend WithEvents PictureBoxRent As PictureBox
    Friend WithEvents LabelDateRent As Label
    Friend WithEvents ButtonSaveRent As Button
    Friend WithEvents DateTimePickerRent As DateTimePicker
    Friend WithEvents LabelSale As Label
    Friend WithEvents LabelRent As Label
    Friend WithEvents BtnClearTarih As Button
    Friend WithEvents BtnSaveTarih As Button
    Friend WithEvents LblTarihSec As Label
    Friend WithEvents CmbTarih As ComboBox
    Friend WithEvents CmbSayi As ComboBox
    Friend WithEvents TextBoxPriceRent As TextBox
    Friend WithEvents TextBoxPriceSale As TextBox
    Friend WithEvents ComboBoxPaymentTypeRent As ComboBox
    Friend WithEvents ComboBoxPaymentTypeSale As ComboBox
End Class
