Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OperationsView
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
        TabPayment = New TabPage()
        PaySplashTitle = New Label()
        PayLblSelected = New Label()
        PayListView = New ListView()
        PayPicSearch = New PictureBox()
        PayBtnEdit = New Button()
        PayBtnRefresh = New Button()
        PayBtnDelete = New Button()
        PayTxtSearch = New TextBox()
        PayBtnAdd = New Button()
        TabRent = New TabPage()
        RentSplashTitle = New Label()
        RentLblSelected = New Label()
        RentListView = New ListView()
        RentPicSearch = New PictureBox()
        RentBtnEdit = New Button()
        RentBtnRefresh = New Button()
        RentBtnDelete = New Button()
        RentTxtSearch = New TextBox()
        RentBtnAdd = New Button()
        TabSale = New TabPage()
        SaleSplashTitle = New Label()
        SaleLblSelected = New Label()
        SaleListView = New ListView()
        SalePicSearch = New PictureBox()
        SaleBtnEdit = New Button()
        SaleBtnRefresh = New Button()
        SaleBtnDelete = New Button()
        SaleTxtSearch = New TextBox()
        SaleBtnAdd = New Button()
        TabControl = New TabControl()
        TabPayment.SuspendLayout()
        CType(PayPicSearch, ComponentModel.ISupportInitialize).BeginInit()
        TabRent.SuspendLayout()
        CType(RentPicSearch, ComponentModel.ISupportInitialize).BeginInit()
        TabSale.SuspendLayout()
        CType(SalePicSearch, ComponentModel.ISupportInitialize).BeginInit()
        TabControl.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabPayment
        ' 
        TabPayment.Controls.Add(PaySplashTitle)
        TabPayment.Controls.Add(PayLblSelected)
        TabPayment.Controls.Add(PayListView)
        TabPayment.Controls.Add(PayPicSearch)
        TabPayment.Controls.Add(PayBtnEdit)
        TabPayment.Controls.Add(PayBtnRefresh)
        TabPayment.Controls.Add(PayBtnDelete)
        TabPayment.Controls.Add(PayTxtSearch)
        TabPayment.Controls.Add(PayBtnAdd)
        TabPayment.Location = New Point(4, 24)
        TabPayment.Margin = New Padding(3, 2, 3, 2)
        TabPayment.Name = "TabPayment"
        TabPayment.Padding = New Padding(3, 2, 3, 2)
        TabPayment.Size = New Size(572, 333)
        TabPayment.TabIndex = 2
        TabPayment.Text = "ÖDEMELER"
        TabPayment.UseVisualStyleBackColor = True
        ' 
        ' PaySplashTitle
        ' 
        PaySplashTitle.AutoSize = True
        PaySplashTitle.BackColor = Color.Transparent
        PaySplashTitle.Font = New Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PaySplashTitle.ForeColor = SystemColors.Highlight
        PaySplashTitle.Location = New Point(196, 373)
        PaySplashTitle.Name = "PaySplashTitle"
        PaySplashTitle.Size = New Size(171, 43)
        PaySplashTitle.TabIndex = 38
        PaySplashTitle.Text = "PAYMENTS"
        PaySplashTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PayLblSelected
        ' 
        PayLblSelected.AutoSize = True
        PayLblSelected.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PayLblSelected.Location = New Point(268, 16)
        PayLblSelected.Name = "PayLblSelected"
        PayLblSelected.Size = New Size(14, 16)
        PayLblSelected.TabIndex = 35
        PayLblSelected.Text = " "
        ' 
        ' PayListView
        ' 
        PayListView.Location = New Point(5, 39)
        PayListView.Margin = New Padding(3, 2, 3, 2)
        PayListView.Name = "PayListView"
        PayListView.Size = New Size(578, 330)
        PayListView.TabIndex = 28
        PayListView.UseCompatibleStateImageBehavior = False
        PayListView.View = View.List
        ' 
        ' PayPicSearch
        ' 
        PayPicSearch.Image = My.Resources.search
        PayPicSearch.Location = New Point(5, 4)
        PayPicSearch.Margin = New Padding(3, 2, 3, 2)
        PayPicSearch.Name = "PayPicSearch"
        PayPicSearch.Size = New Size(42, 30)
        PayPicSearch.SizeMode = PictureBoxSizeMode.Zoom
        PayPicSearch.TabIndex = 34
        PayPicSearch.TabStop = False
        ' 
        ' PayBtnEdit
        ' 
        PayBtnEdit.BackgroundImage = My.Resources.edit
        PayBtnEdit.BackgroundImageLayout = ImageLayout.Zoom
        PayBtnEdit.Location = New Point(71, 373)
        PayBtnEdit.Margin = New Padding(3, 2, 3, 2)
        PayBtnEdit.Name = "PayBtnEdit"
        PayBtnEdit.Size = New Size(60, 44)
        PayBtnEdit.TabIndex = 31
        PayBtnEdit.UseVisualStyleBackColor = True
        ' 
        ' PayBtnRefresh
        ' 
        PayBtnRefresh.BackgroundImage = My.Resources.refresh
        PayBtnRefresh.BackgroundImageLayout = ImageLayout.Zoom
        PayBtnRefresh.Location = New Point(522, 373)
        PayBtnRefresh.Margin = New Padding(3, 2, 3, 2)
        PayBtnRefresh.Name = "PayBtnRefresh"
        PayBtnRefresh.Size = New Size(60, 44)
        PayBtnRefresh.TabIndex = 33
        PayBtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' PayBtnDelete
        ' 
        PayBtnDelete.BackgroundImage = My.Resources.delete1
        PayBtnDelete.BackgroundImageLayout = ImageLayout.Zoom
        PayBtnDelete.Location = New Point(457, 373)
        PayBtnDelete.Margin = New Padding(3, 2, 3, 2)
        PayBtnDelete.Name = "PayBtnDelete"
        PayBtnDelete.Size = New Size(60, 44)
        PayBtnDelete.TabIndex = 32
        PayBtnDelete.UseVisualStyleBackColor = True
        ' 
        ' PayTxtSearch
        ' 
        PayTxtSearch.Location = New Point(52, 14)
        PayTxtSearch.Margin = New Padding(3, 2, 3, 2)
        PayTxtSearch.Name = "PayTxtSearch"
        PayTxtSearch.Size = New Size(210, 23)
        PayTxtSearch.TabIndex = 29
        ' 
        ' PayBtnAdd
        ' 
        PayBtnAdd.BackgroundImage = My.Resources.add
        PayBtnAdd.BackgroundImageLayout = ImageLayout.Zoom
        PayBtnAdd.Location = New Point(5, 373)
        PayBtnAdd.Margin = New Padding(3, 2, 3, 2)
        PayBtnAdd.Name = "PayBtnAdd"
        PayBtnAdd.Size = New Size(60, 44)
        PayBtnAdd.TabIndex = 30
        PayBtnAdd.UseVisualStyleBackColor = True
        ' 
        ' TabRent
        ' 
        TabRent.Controls.Add(RentSplashTitle)
        TabRent.Controls.Add(RentLblSelected)
        TabRent.Controls.Add(RentListView)
        TabRent.Controls.Add(RentPicSearch)
        TabRent.Controls.Add(RentBtnEdit)
        TabRent.Controls.Add(RentBtnRefresh)
        TabRent.Controls.Add(RentBtnDelete)
        TabRent.Controls.Add(RentTxtSearch)
        TabRent.Controls.Add(RentBtnAdd)
        TabRent.Location = New Point(4, 24)
        TabRent.Margin = New Padding(3, 2, 3, 2)
        TabRent.Name = "TabRent"
        TabRent.Padding = New Padding(3, 2, 3, 2)
        TabRent.Size = New Size(572, 333)
        TabRent.TabIndex = 1
        TabRent.Text = "KİRALAMA"
        TabRent.UseVisualStyleBackColor = True
        ' 
        ' RentSplashTitle
        ' 
        RentSplashTitle.AutoSize = True
        RentSplashTitle.BackColor = Color.Transparent
        RentSplashTitle.Font = New Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RentSplashTitle.ForeColor = SystemColors.Highlight
        RentSplashTitle.Location = New Point(242, 289)
        RentSplashTitle.Name = "RentSplashTitle"
        RentSplashTitle.Size = New Size(171, 43)
        RentSplashTitle.TabIndex = 37
        RentSplashTitle.Text = "KİRALAMA"
        RentSplashTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RentLblSelected
        ' 
        RentLblSelected.AutoSize = True
        RentLblSelected.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RentLblSelected.Location = New Point(268, 16)
        RentLblSelected.Name = "RentLblSelected"
        RentLblSelected.Size = New Size(14, 16)
        RentLblSelected.TabIndex = 35
        RentLblSelected.Text = " "
        ' 
        ' RentListView
        ' 
        RentListView.Location = New Point(5, 39)
        RentListView.Margin = New Padding(3, 2, 3, 2)
        RentListView.Name = "RentListView"
        RentListView.Size = New Size(564, 248)
        RentListView.TabIndex = 28
        RentListView.UseCompatibleStateImageBehavior = False
        RentListView.View = View.List
        ' 
        ' RentPicSearch
        ' 
        RentPicSearch.Image = My.Resources.search
        RentPicSearch.Location = New Point(5, 4)
        RentPicSearch.Margin = New Padding(3, 2, 3, 2)
        RentPicSearch.Name = "RentPicSearch"
        RentPicSearch.Size = New Size(42, 30)
        RentPicSearch.SizeMode = PictureBoxSizeMode.Zoom
        RentPicSearch.TabIndex = 34
        RentPicSearch.TabStop = False
        ' 
        ' RentBtnEdit
        ' 
        RentBtnEdit.BackgroundImage = My.Resources.edit
        RentBtnEdit.BackgroundImageLayout = ImageLayout.Zoom
        RentBtnEdit.Location = New Point(71, 290)
        RentBtnEdit.Margin = New Padding(3, 2, 3, 2)
        RentBtnEdit.Name = "RentBtnEdit"
        RentBtnEdit.Size = New Size(60, 44)
        RentBtnEdit.TabIndex = 31
        RentBtnEdit.UseVisualStyleBackColor = True
        ' 
        ' RentBtnRefresh
        ' 
        RentBtnRefresh.BackgroundImage = My.Resources.refresh
        RentBtnRefresh.BackgroundImageLayout = ImageLayout.Zoom
        RentBtnRefresh.Location = New Point(508, 290)
        RentBtnRefresh.Margin = New Padding(3, 2, 3, 2)
        RentBtnRefresh.Name = "RentBtnRefresh"
        RentBtnRefresh.Size = New Size(60, 44)
        RentBtnRefresh.TabIndex = 33
        RentBtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' RentBtnDelete
        ' 
        RentBtnDelete.BackgroundImage = My.Resources.delete1
        RentBtnDelete.BackgroundImageLayout = ImageLayout.Zoom
        RentBtnDelete.Location = New Point(443, 290)
        RentBtnDelete.Margin = New Padding(3, 2, 3, 2)
        RentBtnDelete.Name = "RentBtnDelete"
        RentBtnDelete.Size = New Size(60, 44)
        RentBtnDelete.TabIndex = 32
        RentBtnDelete.UseVisualStyleBackColor = True
        ' 
        ' RentTxtSearch
        ' 
        RentTxtSearch.Location = New Point(52, 14)
        RentTxtSearch.Margin = New Padding(3, 2, 3, 2)
        RentTxtSearch.Name = "RentTxtSearch"
        RentTxtSearch.Size = New Size(210, 23)
        RentTxtSearch.TabIndex = 29
        ' 
        ' RentBtnAdd
        ' 
        RentBtnAdd.BackgroundImage = My.Resources.add
        RentBtnAdd.BackgroundImageLayout = ImageLayout.Zoom
        RentBtnAdd.Location = New Point(5, 290)
        RentBtnAdd.Margin = New Padding(3, 2, 3, 2)
        RentBtnAdd.Name = "RentBtnAdd"
        RentBtnAdd.Size = New Size(60, 44)
        RentBtnAdd.TabIndex = 30
        RentBtnAdd.UseVisualStyleBackColor = True
        ' 
        ' TabSale
        ' 
        TabSale.Controls.Add(SaleSplashTitle)
        TabSale.Controls.Add(SaleLblSelected)
        TabSale.Controls.Add(SaleListView)
        TabSale.Controls.Add(SalePicSearch)
        TabSale.Controls.Add(SaleBtnEdit)
        TabSale.Controls.Add(SaleBtnRefresh)
        TabSale.Controls.Add(SaleBtnDelete)
        TabSale.Controls.Add(SaleTxtSearch)
        TabSale.Controls.Add(SaleBtnAdd)
        TabSale.Location = New Point(4, 24)
        TabSale.Margin = New Padding(3, 2, 3, 2)
        TabSale.Name = "TabSale"
        TabSale.Padding = New Padding(3, 2, 3, 2)
        TabSale.Size = New Size(572, 333)
        TabSale.TabIndex = 0
        TabSale.Text = "SATIŞ"
        TabSale.UseVisualStyleBackColor = True
        ' 
        ' SaleSplashTitle
        ' 
        SaleSplashTitle.AutoSize = True
        SaleSplashTitle.BackColor = Color.Transparent
        SaleSplashTitle.Font = New Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaleSplashTitle.ForeColor = SystemColors.Highlight
        SaleSplashTitle.Location = New Point(239, 288)
        SaleSplashTitle.Name = "SaleSplashTitle"
        SaleSplashTitle.Size = New Size(114, 43)
        SaleSplashTitle.TabIndex = 36
        SaleSplashTitle.Text = "SATIŞ"
        SaleSplashTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SaleLblSelected
        ' 
        SaleLblSelected.AutoSize = True
        SaleLblSelected.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SaleLblSelected.Location = New Point(268, 16)
        SaleLblSelected.Name = "SaleLblSelected"
        SaleLblSelected.Size = New Size(14, 16)
        SaleLblSelected.TabIndex = 35
        SaleLblSelected.Text = " "
        ' 
        ' SaleListView
        ' 
        SaleListView.Location = New Point(5, 39)
        SaleListView.Margin = New Padding(3, 2, 3, 2)
        SaleListView.Name = "SaleListView"
        SaleListView.Size = New Size(566, 246)
        SaleListView.TabIndex = 28
        SaleListView.UseCompatibleStateImageBehavior = False
        SaleListView.View = View.List
        ' 
        ' SalePicSearch
        ' 
        SalePicSearch.Image = My.Resources.search
        SalePicSearch.Location = New Point(5, 4)
        SalePicSearch.Margin = New Padding(3, 2, 3, 2)
        SalePicSearch.Name = "SalePicSearch"
        SalePicSearch.Size = New Size(42, 30)
        SalePicSearch.SizeMode = PictureBoxSizeMode.Zoom
        SalePicSearch.TabIndex = 34
        SalePicSearch.TabStop = False
        ' 
        ' SaleBtnEdit
        ' 
        SaleBtnEdit.BackgroundImage = My.Resources.edit
        SaleBtnEdit.BackgroundImageLayout = ImageLayout.Zoom
        SaleBtnEdit.Location = New Point(71, 288)
        SaleBtnEdit.Margin = New Padding(3, 2, 3, 2)
        SaleBtnEdit.Name = "SaleBtnEdit"
        SaleBtnEdit.Size = New Size(60, 44)
        SaleBtnEdit.TabIndex = 31
        SaleBtnEdit.UseVisualStyleBackColor = True
        ' 
        ' SaleBtnRefresh
        ' 
        SaleBtnRefresh.BackgroundImage = My.Resources.refresh
        SaleBtnRefresh.BackgroundImageLayout = ImageLayout.Zoom
        SaleBtnRefresh.Location = New Point(510, 288)
        SaleBtnRefresh.Margin = New Padding(3, 2, 3, 2)
        SaleBtnRefresh.Name = "SaleBtnRefresh"
        SaleBtnRefresh.Size = New Size(60, 44)
        SaleBtnRefresh.TabIndex = 33
        SaleBtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' SaleBtnDelete
        ' 
        SaleBtnDelete.BackgroundImage = My.Resources.delete1
        SaleBtnDelete.BackgroundImageLayout = ImageLayout.Zoom
        SaleBtnDelete.Location = New Point(444, 288)
        SaleBtnDelete.Margin = New Padding(3, 2, 3, 2)
        SaleBtnDelete.Name = "SaleBtnDelete"
        SaleBtnDelete.Size = New Size(60, 44)
        SaleBtnDelete.TabIndex = 32
        SaleBtnDelete.UseVisualStyleBackColor = True
        ' 
        ' SaleTxtSearch
        ' 
        SaleTxtSearch.Location = New Point(52, 14)
        SaleTxtSearch.Margin = New Padding(3, 2, 3, 2)
        SaleTxtSearch.Name = "SaleTxtSearch"
        SaleTxtSearch.Size = New Size(210, 23)
        SaleTxtSearch.TabIndex = 29
        ' 
        ' SaleBtnAdd
        ' 
        SaleBtnAdd.BackgroundImage = My.Resources.add
        SaleBtnAdd.BackgroundImageLayout = ImageLayout.Zoom
        SaleBtnAdd.Location = New Point(5, 288)
        SaleBtnAdd.Margin = New Padding(3, 2, 3, 2)
        SaleBtnAdd.Name = "SaleBtnAdd"
        SaleBtnAdd.Size = New Size(60, 44)
        SaleBtnAdd.TabIndex = 30
        SaleBtnAdd.UseVisualStyleBackColor = True
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabSale)
        TabControl.Controls.Add(TabRent)
        TabControl.Controls.Add(TabPayment)
        TabControl.Location = New Point(10, 9)
        TabControl.Margin = New Padding(3, 2, 3, 2)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(580, 361)
        TabControl.TabIndex = 26
        ' 
        ' OperationsView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(590, 370)
        Controls.Add(TabControl)
        Icon = My.Resources.car1
        Margin = New Padding(3, 2, 3, 2)
        Name = "OperationsView"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        TabPayment.ResumeLayout(False)
        TabPayment.PerformLayout()
        CType(PayPicSearch, ComponentModel.ISupportInitialize).EndInit()
        TabRent.ResumeLayout(False)
        TabRent.PerformLayout()
        CType(RentPicSearch, ComponentModel.ISupportInitialize).EndInit()
        TabSale.ResumeLayout(False)
        TabSale.PerformLayout()
        CType(SalePicSearch, ComponentModel.ISupportInitialize).EndInit()
        TabControl.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabPayment As TabPage
    Friend WithEvents PayLblSelected As Label
    Friend WithEvents PayListView As ListView
    Friend WithEvents PayPicSearch As PictureBox
    Friend WithEvents PayBtnEdit As Button
    Friend WithEvents PayBtnRefresh As Button
    Friend WithEvents PayBtnDelete As Button
    Friend WithEvents PayTxtSearch As TextBox
    Friend WithEvents PayBtnAdd As Button
    Friend WithEvents TabRent As TabPage
    Friend WithEvents RentLblSelected As Label
    Friend WithEvents RentListView As ListView
    Friend WithEvents RentPicSearch As PictureBox
    Friend WithEvents RentBtnEdit As Button
    Friend WithEvents RentBtnRefresh As Button
    Friend WithEvents RentBtnDelete As Button
    Friend WithEvents RentTxtSearch As TextBox
    Friend WithEvents RentBtnAdd As Button
    Friend WithEvents TabSale As TabPage
    Friend WithEvents SaleLblSelected As Label
    Friend WithEvents SaleListView As ListView
    Friend WithEvents SalePicSearch As PictureBox
    Friend WithEvents SaleBtnEdit As Button
    Friend WithEvents SaleBtnRefresh As Button
    Friend WithEvents SaleBtnDelete As Button
    Friend WithEvents SaleTxtSearch As TextBox
    Friend WithEvents SaleBtnAdd As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents RentSplashTitle As Label
    Friend WithEvents SaleSplashTitle As Label
    Friend WithEvents PaySplashTitle As Label
End Class
