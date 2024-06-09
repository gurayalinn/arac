Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesView
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
        dgvSales = New DataGridView()
        LblSelected = New Label()
        BtnRefresh = New Button()
        txtSearch = New TextBox()
        BtnDelete = New Button()
        ListView = New ListView()
        PicSearch = New PictureBox()
        BtnPay = New Button()
        LabelSales = New Label()
        SaleBindingSource = New BindingSource(components)
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSearch, ComponentModel.ISupportInitialize).BeginInit()
        CType(SaleBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvSales
        ' 
        dgvSales.AllowUserToOrderColumns = True
        dgvSales.AutoGenerateColumns = False
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSales.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6})
        dgvSales.DataSource = SaleBindingSource
        dgvSales.Location = New Point(6, 43)
        dgvSales.Name = "dgvSales"
        dgvSales.Size = New Size(562, 242)
        dgvSales.TabIndex = 28
        ' 
        ' LblSelected
        ' 
        LblSelected.AutoSize = True
        LblSelected.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSelected.Location = New Point(269, 17)
        LblSelected.Name = "LblSelected"
        LblSelected.Size = New Size(14, 16)
        LblSelected.TabIndex = 26
        LblSelected.Text = " "
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.BackgroundImage = Resources.refresh
        BtnRefresh.BackgroundImageLayout = ImageLayout.Zoom
        BtnRefresh.Location = New Point(518, 309)
        BtnRefresh.Margin = New Padding(3, 2, 3, 2)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(60, 44)
        BtnRefresh.TabIndex = 25
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(54, 14)
        txtSearch.Margin = New Padding(3, 2, 3, 2)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(210, 23)
        txtSearch.TabIndex = 23
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackgroundImage = delete1
        BtnDelete.BackgroundImageLayout = ImageLayout.Zoom
        BtnDelete.Location = New Point(453, 309)
        BtnDelete.Margin = New Padding(3, 2, 3, 2)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(60, 44)
        BtnDelete.TabIndex = 24
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' ListView
        ' 
        ListView.Location = New Point(6, 43)
        ListView.Margin = New Padding(3, 2, 3, 2)
        ListView.Name = "ListView"
        ListView.Size = New Size(562, 244)
        ListView.TabIndex = 22
        ListView.UseCompatibleStateImageBehavior = False
        ListView.View = View.List
        ' 
        ' PicSearch
        ' 
        PicSearch.Image = search
        PicSearch.Location = New Point(6, 8)
        PicSearch.Margin = New Padding(3, 2, 3, 2)
        PicSearch.Name = "PicSearch"
        PicSearch.Size = New Size(42, 30)
        PicSearch.SizeMode = PictureBoxSizeMode.Zoom
        PicSearch.TabIndex = 27
        PicSearch.TabStop = False
        ' 
        ' BtnPay
        ' 
        BtnPay.BackColor = Color.Green
        BtnPay.FlatStyle = FlatStyle.Flat
        BtnPay.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPay.ForeColor = SystemColors.ControlLight
        BtnPay.Location = New Point(298, 309)
        BtnPay.Margin = New Padding(3, 2, 3, 2)
        BtnPay.Name = "BtnPay"
        BtnPay.Size = New Size(149, 44)
        BtnPay.TabIndex = 30
        BtnPay.Text = "ÖDEME YAP"
        BtnPay.UseVisualStyleBackColor = False
        ' 
        ' LabelSales
        ' 
        LabelSales.AutoSize = True
        LabelSales.Font = New Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSales.ForeColor = Color.RoyalBlue
        LabelSales.Location = New Point(6, 310)
        LabelSales.Name = "LabelSales"
        LabelSales.Size = New Size(171, 43)
        LabelSales.TabIndex = 31
        LabelSales.Text = "SATIŞLAR"
        ' 
        ' SaleBindingSource
        ' 
        SaleBindingSource.DataSource = GetType(Sale)
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        DataGridViewTextBoxColumn1.HeaderText = "Id"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.DataPropertyName = "CustomerId"
        DataGridViewTextBoxColumn2.HeaderText = "CustomerId"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.DataPropertyName = "VehicleId"
        DataGridViewTextBoxColumn3.HeaderText = "VehicleId"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.DataPropertyName = "SaleDate"
        DataGridViewTextBoxColumn4.HeaderText = "SaleDate"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.DataPropertyName = "Price"
        DataGridViewTextBoxColumn5.HeaderText = "Price"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.DataPropertyName = "PaymentType"
        DataGridViewTextBoxColumn6.HeaderText = "PaymentType"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        ' 
        ' SalesView
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(LabelSales)
        Controls.Add(BtnPay)
        Controls.Add(dgvSales)
        Controls.Add(LblSelected)
        Controls.Add(BtnRefresh)
        Controls.Add(txtSearch)
        Controls.Add(BtnDelete)
        Controls.Add(ListView)
        Controls.Add(PicSearch)
        Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = car1
        Name = "SalesView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SATIŞLAR"
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSearch, ComponentModel.ISupportInitialize).EndInit()
        CType(SaleBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents LblSelected As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents PicSearch As PictureBox
    Friend WithEvents BtnPay As Button
    Friend WithEvents LabelSales As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents SaleBindingSource As BindingSource
End Class
