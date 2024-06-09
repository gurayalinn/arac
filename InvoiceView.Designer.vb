Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceView
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
        TxtOdemeNo = New TextBox()
        LblOdeme = New Label()
        PicPrint = New PictureBox()
        BtnPrint = New Button()
        CType(PicPrint, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtOdemeNo
        ' 
        TxtOdemeNo.ForeColor = Color.DarkGreen
        TxtOdemeNo.Location = New Point(10, 30)
        TxtOdemeNo.Name = "TxtOdemeNo"
        TxtOdemeNo.ReadOnly = True
        TxtOdemeNo.Size = New Size(300, 23)
        TxtOdemeNo.TabIndex = 16
        ' 
        ' LblOdeme
        ' 
        LblOdeme.AutoSize = True
        LblOdeme.Location = New Point(10, 10)
        LblOdeme.Name = "LblOdeme"
        LblOdeme.Size = New Size(80, 17)
        LblOdeme.TabIndex = 15
        LblOdeme.Text = "Ödeme No:"
        ' 
        ' PicPrint
        ' 
        PicPrint.BackColor = Color.Transparent
        PicPrint.Image = Resources.print
        PicPrint.Location = New Point(245, 85)
        PicPrint.Margin = New Padding(3, 2, 3, 2)
        PicPrint.Name = "PicPrint"
        PicPrint.Size = New Size(60, 40)
        PicPrint.SizeMode = PictureBoxSizeMode.Zoom
        PicPrint.TabIndex = 43
        PicPrint.TabStop = False
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = SystemColors.Control
        BtnPrint.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPrint.ForeColor = Color.DarkGreen
        BtnPrint.ImageAlign = ContentAlignment.MiddleRight
        BtnPrint.Location = New Point(180, 80)
        BtnPrint.Margin = New Padding(5, 3, 5, 3)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(130, 50)
        BtnPrint.TabIndex = 44
        BtnPrint.Text = "YAZDIR"
        BtnPrint.TextAlign = ContentAlignment.MiddleLeft
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' InvoiceView
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(328, 150)
        Controls.Add(PicPrint)
        Controls.Add(LblOdeme)
        Controls.Add(TxtOdemeNo)
        Controls.Add(BtnPrint)
        Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = car1
        Name = "InvoiceView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FATURA"
        CType(PicPrint, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtOdemeNo As TextBox
    Friend WithEvents LblOdeme As Label
    Friend WithEvents PicPrint As PictureBox
    Friend WithEvents BtnPrint As Button
End Class
