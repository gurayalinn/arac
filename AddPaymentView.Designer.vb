Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPaymentView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPaymentView))
        RdSat = New RadioButton()
        RdKira = New RadioButton()
        CmbSat = New ComboBox()
        CmbKira = New ComboBox()
        DtpPaymentDate = New DateTimePicker()
        TxtAciklama = New TextBox()
        TxtOdemeNo = New TextBox()
        LblOdeme = New Label()
        LblAciklama = New Label()
        BtnPay = New Button()
        BtnCancel = New Button()
        CheckDurum = New CheckBox()
        LblIslem = New Label()
        LinkIslem = New LinkLabel()
        SuspendLayout()
        ' 
        ' RdSat
        ' 
        RdSat.AutoSize = True
        RdSat.Location = New Point(10, 54)
        RdSat.Name = "RdSat"
        RdSat.Size = New Size(66, 21)
        RdSat.TabIndex = 2
        RdSat.TabStop = True
        RdSat.Text = "SATIŞ"
        RdSat.UseVisualStyleBackColor = True
        ' 
        ' RdKira
        ' 
        RdKira.AutoSize = True
        RdKira.Location = New Point(190, 54)
        RdKira.Name = "RdKira"
        RdKira.Size = New Size(90, 21)
        RdKira.TabIndex = 3
        RdKira.TabStop = True
        RdKira.Text = "KİRALAMA"
        RdKira.UseVisualStyleBackColor = True
        ' 
        ' CmbSat
        ' 
        CmbSat.FormattingEnabled = True
        CmbSat.Location = New Point(10, 84)
        CmbSat.Name = "CmbSat"
        CmbSat.Size = New Size(120, 25)
        CmbSat.TabIndex = 4
        ' 
        ' CmbKira
        ' 
        CmbKira.FormattingEnabled = True
        CmbKira.Location = New Point(190, 84)
        CmbKira.Name = "CmbKira"
        CmbKira.Size = New Size(120, 25)
        CmbKira.TabIndex = 5
        ' 
        ' DtpPaymentDate
        ' 
        DtpPaymentDate.Location = New Point(10, 150)
        DtpPaymentDate.MaxDate = New Date(2026, 12, 31, 0, 0, 0, 0)
        DtpPaymentDate.MinDate = New Date(2024, 6, 5, 0, 0, 0, 0)
        DtpPaymentDate.Name = "DtpPaymentDate"
        DtpPaymentDate.Size = New Size(300, 23)
        DtpPaymentDate.TabIndex = 6
        ' 
        ' TxtAciklama
        ' 
        TxtAciklama.Location = New Point(10, 200)
        TxtAciklama.Multiline = True
        TxtAciklama.Name = "TxtAciklama"
        TxtAciklama.Size = New Size(300, 67)
        TxtAciklama.TabIndex = 8
        ' 
        ' TxtOdemeNo
        ' 
        TxtOdemeNo.ForeColor = Color.DarkGreen
        TxtOdemeNo.Location = New Point(10, 30)
        TxtOdemeNo.Name = "TxtOdemeNo"
        TxtOdemeNo.ReadOnly = True
        TxtOdemeNo.Size = New Size(300, 23)
        TxtOdemeNo.TabIndex = 1
        ' 
        ' LblOdeme
        ' 
        LblOdeme.AutoSize = True
        LblOdeme.Location = New Point(10, 10)
        LblOdeme.Name = "LblOdeme"
        LblOdeme.Size = New Size(80, 17)
        LblOdeme.TabIndex = 0
        LblOdeme.Text = "Ödeme No:"
        ' 
        ' LblAciklama
        ' 
        LblAciklama.AutoSize = True
        LblAciklama.Location = New Point(10, 180)
        LblAciklama.Name = "LblAciklama"
        LblAciklama.Size = New Size(80, 17)
        LblAciklama.TabIndex = 7
        LblAciklama.Text = "Açıklama:"
        ' 
        ' BtnPay
        ' 
        BtnPay.BackColor = Color.Green
        BtnPay.ForeColor = Color.White
        BtnPay.Location = New Point(10, 300)
        BtnPay.Name = "BtnPay"
        BtnPay.Size = New Size(300, 50)
        BtnPay.TabIndex = 10
        BtnPay.Text = "ÖDEME YAP"
        BtnPay.UseVisualStyleBackColor = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.Tomato
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(210, 0)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(100, 24)
        BtnCancel.TabIndex = 11
        BtnCancel.Text = "TEMIZLE"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' CheckDurum
        ' 
        CheckDurum.AutoSize = True
        CheckDurum.CheckAlign = ContentAlignment.MiddleRight
        CheckDurum.ForeColor = Color.Green
        CheckDurum.Location = New Point(10, 275)
        CheckDurum.Name = "CheckDurum"
        CheckDurum.Size = New Size(75, 21)
        CheckDurum.TabIndex = 9
        CheckDurum.Text = "Ödendi"
        CheckDurum.UseVisualStyleBackColor = True
        ' 
        ' LblIslem
        ' 
        LblIslem.AutoSize = True
        LblIslem.ForeColor = Color.Green
        LblIslem.Location = New Point(12, 121)
        LblIslem.Name = "LblIslem"
        LblIslem.Size = New Size(56, 17)
        LblIslem.TabIndex = 12
        LblIslem.Text = "İşlem:"
        ' 
        ' LinkIslem
        ' 
        LinkIslem.AutoSize = True
        LinkIslem.Location = New Point(74, 121)
        LinkIslem.Name = "LinkIslem"
        LinkIslem.Size = New Size(16, 17)
        LinkIslem.TabIndex = 14
        LinkIslem.TabStop = True
        LinkIslem.Text = "-"
        ' 
        ' AddPaymentView
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(323, 361)
        Controls.Add(LinkIslem)
        Controls.Add(LblIslem)
        Controls.Add(CheckDurum)
        Controls.Add(BtnCancel)
        Controls.Add(BtnPay)
        Controls.Add(LblAciklama)
        Controls.Add(LblOdeme)
        Controls.Add(TxtOdemeNo)
        Controls.Add(TxtAciklama)
        Controls.Add(DtpPaymentDate)
        Controls.Add(CmbKira)
        Controls.Add(CmbSat)
        Controls.Add(RdKira)
        Controls.Add(RdSat)
        Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AddPaymentView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ÖDEME YAP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RdSat As RadioButton
    Friend WithEvents RdKira As RadioButton
    Friend WithEvents CmbSat As ComboBox
    Friend WithEvents CmbKira As ComboBox
    Friend WithEvents DtpPaymentDate As DateTimePicker
    Friend WithEvents LblOdeme As Label
    Friend WithEvents TxtOdemeNo As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnPay As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents CheckDurum As CheckBox
    Friend WithEvents LblAciklama As Label
    Friend WithEvents TxtAciklama As TextBox
    Friend WithEvents LblIslem As Label
    Friend WithEvents LinkIslem As LinkLabel
End Class
