Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Panel1 = New Panel()
        SplashTitle = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(SplashTitle)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' SplashTitle
        ' 
        SplashTitle.AutoSize = True
        SplashTitle.BackColor = Color.Transparent
        SplashTitle.Font = New Font("Cascadia Mono", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SplashTitle.ForeColor = SystemColors.Highlight
        SplashTitle.Location = New Point(111, 73)
        SplashTitle.Name = "SplashTitle"
        SplashTitle.Size = New Size(559, 189)
        SplashTitle.TabIndex = 1
        SplashTitle.Text = "ARAÇ SATIŞ KİRALAMA" & vbCrLf & vbCrLf & "OTOMASYONU"
        SplashTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.bridge1
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Splash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Araç Satış Kiralama"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SplashTitle As Label

End Class
