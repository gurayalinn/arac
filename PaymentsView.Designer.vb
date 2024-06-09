Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentsView
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
        dgvPayments = New DataGridView()
        LabelSales = New Label()
        BtnInvoice = New Button()
        LblSelected = New Label()
        BtnRefresh = New Button()
        txtSearch = New TextBox()
        BtnDelete = New Button()
        ListView = New ListView()
        PicSearch = New PictureBox()
        PaymentBindingSource = New BindingSource(components)
        IdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        TransactionNoDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        RentIdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        SaleIdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        StatusDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        DescriptionDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        PaymentDateDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CType(dgvPayments, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSearch, ComponentModel.ISupportInitialize).BeginInit()
        CType(PaymentBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvPayments
        ' 
        dgvPayments.AllowUserToOrderColumns = True
        dgvPayments.AutoGenerateColumns = False
        dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPayments.Columns.AddRange(New DataGridViewColumn() {IdDataGridViewTextBoxColumn, TransactionNoDataGridViewTextBoxColumn, RentIdDataGridViewTextBoxColumn, SaleIdDataGridViewTextBoxColumn, StatusDataGridViewTextBoxColumn, DescriptionDataGridViewTextBoxColumn, PaymentDateDataGridViewTextBoxColumn})
        dgvPayments.DataSource = PaymentBindingSource
        dgvPayments.Location = New Point(6, 43)
        dgvPayments.Name = "dgvPayments"
        dgvPayments.Size = New Size(562, 242)
        dgvPayments.TabIndex = 38
        ' 
        ' LabelSales
        ' 
        LabelSales.AutoSize = True
        LabelSales.Font = New Font("Cascadia Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSales.ForeColor = Color.Green
        LabelSales.Location = New Point(6, 310)
        LabelSales.Name = "LabelSales"
        LabelSales.Size = New Size(171, 43)
        LabelSales.TabIndex = 40
        LabelSales.Text = "SATIŞLAR"
        ' 
        ' BtnInvoice
        ' 
        BtnInvoice.BackColor = Color.Green
        BtnInvoice.FlatStyle = FlatStyle.Flat
        BtnInvoice.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnInvoice.ForeColor = SystemColors.ControlLight
        BtnInvoice.Location = New Point(298, 309)
        BtnInvoice.Margin = New Padding(3, 2, 3, 2)
        BtnInvoice.Name = "BtnInvoice"
        BtnInvoice.Size = New Size(149, 44)
        BtnInvoice.TabIndex = 39
        BtnInvoice.Text = "FATURA"
        BtnInvoice.UseVisualStyleBackColor = False
        ' 
        ' LblSelected
        ' 
        LblSelected.AutoSize = True
        LblSelected.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSelected.Location = New Point(269, 17)
        LblSelected.Name = "LblSelected"
        LblSelected.Size = New Size(14, 16)
        LblSelected.TabIndex = 36
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
        BtnRefresh.TabIndex = 35
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(54, 14)
        txtSearch.Margin = New Padding(3, 2, 3, 2)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(210, 23)
        txtSearch.TabIndex = 33
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackgroundImage = delete1
        BtnDelete.BackgroundImageLayout = ImageLayout.Zoom
        BtnDelete.Location = New Point(453, 309)
        BtnDelete.Margin = New Padding(3, 2, 3, 2)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(60, 44)
        BtnDelete.TabIndex = 34
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' ListView
        ' 
        ListView.Location = New Point(6, 43)
        ListView.Margin = New Padding(3, 2, 3, 2)
        ListView.Name = "ListView"
        ListView.Size = New Size(562, 244)
        ListView.TabIndex = 32
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
        PicSearch.TabIndex = 37
        PicSearch.TabStop = False
        ' 
        ' PaymentBindingSource
        ' 
        PaymentBindingSource.DataSource = GetType(Payment)
        ' 
        ' IdDataGridViewTextBoxColumn
        ' 
        IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        IdDataGridViewTextBoxColumn.HeaderText = "Id"
        IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        ' 
        ' TransactionNoDataGridViewTextBoxColumn
        ' 
        TransactionNoDataGridViewTextBoxColumn.DataPropertyName = "TransactionNo"
        TransactionNoDataGridViewTextBoxColumn.HeaderText = "TransactionNo"
        TransactionNoDataGridViewTextBoxColumn.Name = "TransactionNoDataGridViewTextBoxColumn"
        ' 
        ' RentIdDataGridViewTextBoxColumn
        ' 
        RentIdDataGridViewTextBoxColumn.DataPropertyName = "RentId"
        RentIdDataGridViewTextBoxColumn.HeaderText = "RentId"
        RentIdDataGridViewTextBoxColumn.Name = "RentIdDataGridViewTextBoxColumn"
        ' 
        ' SaleIdDataGridViewTextBoxColumn
        ' 
        SaleIdDataGridViewTextBoxColumn.DataPropertyName = "SaleId"
        SaleIdDataGridViewTextBoxColumn.HeaderText = "SaleId"
        SaleIdDataGridViewTextBoxColumn.Name = "SaleIdDataGridViewTextBoxColumn"
        ' 
        ' StatusDataGridViewTextBoxColumn
        ' 
        StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        ' 
        ' DescriptionDataGridViewTextBoxColumn
        ' 
        DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        ' 
        ' PaymentDateDataGridViewTextBoxColumn
        ' 
        PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "paymentDate"
        PaymentDateDataGridViewTextBoxColumn.HeaderText = "paymentDate"
        PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        ' 
        ' PaymentsView
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(dgvPayments)
        Controls.Add(LabelSales)
        Controls.Add(BtnInvoice)
        Controls.Add(LblSelected)
        Controls.Add(BtnRefresh)
        Controls.Add(txtSearch)
        Controls.Add(BtnDelete)
        Controls.Add(ListView)
        Controls.Add(PicSearch)
        Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = car1
        Name = "PaymentsView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ÖDEMELER"
        CType(dgvPayments, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSearch, ComponentModel.ISupportInitialize).EndInit()
        CType(PaymentBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvPayments As DataGridView
    Friend WithEvents LabelSales As Label
    Friend WithEvents BtnInvoice As Button
    Friend WithEvents LblSelected As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents PicSearch As PictureBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactionNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentBindingSource As BindingSource
End Class
