Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VehiclesView
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
        PicSearch = New PictureBox()
        LblSelected = New Label()
        BtnRefresh = New Button()
        txtSearch = New TextBox()
        BtnAdd = New Button()
        BtnDelete = New Button()
        BtnEdit = New Button()
        ListView = New ListView()
        BtnSale = New Button()
        BtnRent = New Button()
        DataGridViewVehicle = New DataGridView()
        VehicleBindingSource = New BindingSource(components)
        IdDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        SahibiDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        DurumDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        SinifDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        MarkaDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ModelDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        RenkDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        YilDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        KmDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        PlakaDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        SasiDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        KiralamaUcretiDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        SatisUcretiDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        KiralayanDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        AciklamaDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        GorselDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CreatedAtDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        UpdatedAtDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CType(PicSearch, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewVehicle, ComponentModel.ISupportInitialize).BeginInit()
        CType(VehicleBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicSearch
        ' 
        PicSearch.Image = search
        PicSearch.Location = New Point(10, 5)
        PicSearch.Margin = New Padding(3, 2, 3, 2)
        PicSearch.Name = "PicSearch"
        PicSearch.Size = New Size(42, 30)
        PicSearch.SizeMode = PictureBoxSizeMode.Zoom
        PicSearch.TabIndex = 18
        PicSearch.TabStop = False
        ' 
        ' LblSelected
        ' 
        LblSelected.AutoSize = True
        LblSelected.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSelected.Location = New Point(273, 14)
        LblSelected.Name = "LblSelected"
        LblSelected.Size = New Size(14, 16)
        LblSelected.TabIndex = 17
        LblSelected.Text = " "
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.BackgroundImage = Resources.refresh
        BtnRefresh.BackgroundImageLayout = ImageLayout.Zoom
        BtnRefresh.Location = New Point(522, 306)
        BtnRefresh.Margin = New Padding(3, 2, 3, 2)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(60, 44)
        BtnRefresh.TabIndex = 16
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(58, 11)
        txtSearch.Margin = New Padding(3, 2, 3, 2)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(210, 23)
        txtSearch.TabIndex = 12
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackgroundImage = add
        BtnAdd.BackgroundImageLayout = ImageLayout.Zoom
        BtnAdd.Location = New Point(10, 306)
        BtnAdd.Margin = New Padding(3, 2, 3, 2)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(60, 44)
        BtnAdd.TabIndex = 13
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackgroundImage = delete1
        BtnDelete.BackgroundImageLayout = ImageLayout.Zoom
        BtnDelete.Location = New Point(457, 306)
        BtnDelete.Margin = New Padding(3, 2, 3, 2)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(60, 44)
        BtnDelete.TabIndex = 15
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackgroundImage = edit
        BtnEdit.BackgroundImageLayout = ImageLayout.Zoom
        BtnEdit.Location = New Point(76, 306)
        BtnEdit.Margin = New Padding(3, 2, 3, 2)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(60, 44)
        BtnEdit.TabIndex = 14
        BtnEdit.UseVisualStyleBackColor = True
        ' 
        ' ListView
        ' 
        ListView.Location = New Point(10, 40)
        ListView.Margin = New Padding(3, 2, 3, 2)
        ListView.Name = "ListView"
        ListView.Size = New Size(562, 244)
        ListView.TabIndex = 11
        ListView.UseCompatibleStateImageBehavior = False
        ListView.View = View.List
        ' 
        ' BtnSale
        ' 
        BtnSale.BackColor = SystemColors.HotTrack
        BtnSale.FlatStyle = FlatStyle.Flat
        BtnSale.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSale.ForeColor = SystemColors.ControlLight
        BtnSale.Location = New Point(142, 306)
        BtnSale.Margin = New Padding(3, 2, 3, 2)
        BtnSale.Name = "BtnSale"
        BtnSale.Size = New Size(80, 44)
        BtnSale.TabIndex = 19
        BtnSale.Text = "SAT"
        BtnSale.UseVisualStyleBackColor = False
        ' 
        ' BtnRent
        ' 
        BtnRent.BackColor = Color.Tomato
        BtnRent.FlatStyle = FlatStyle.Flat
        BtnRent.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRent.ForeColor = SystemColors.ControlLight
        BtnRent.Location = New Point(228, 306)
        BtnRent.Margin = New Padding(3, 2, 3, 2)
        BtnRent.Name = "BtnRent"
        BtnRent.Size = New Size(80, 44)
        BtnRent.TabIndex = 20
        BtnRent.Text = "KİRALA"
        BtnRent.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewVehicle
        ' 
        DataGridViewVehicle.AllowUserToOrderColumns = True
        DataGridViewVehicle.AutoGenerateColumns = False
        DataGridViewVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewVehicle.Columns.AddRange(New DataGridViewColumn() {IdDataGridViewTextBoxColumn, SahibiDataGridViewTextBoxColumn, DurumDataGridViewTextBoxColumn, SinifDataGridViewTextBoxColumn, MarkaDataGridViewTextBoxColumn, ModelDataGridViewTextBoxColumn, RenkDataGridViewTextBoxColumn, YilDataGridViewTextBoxColumn, KmDataGridViewTextBoxColumn, PlakaDataGridViewTextBoxColumn, SasiDataGridViewTextBoxColumn, KiralamaUcretiDataGridViewTextBoxColumn, SatisUcretiDataGridViewTextBoxColumn, KiralayanDataGridViewTextBoxColumn, AciklamaDataGridViewTextBoxColumn, GorselDataGridViewTextBoxColumn, CreatedAtDataGridViewTextBoxColumn, UpdatedAtDataGridViewTextBoxColumn})
        DataGridViewVehicle.DataSource = VehicleBindingSource
        DataGridViewVehicle.Location = New Point(10, 40)
        DataGridViewVehicle.Name = "DataGridViewVehicle"
        DataGridViewVehicle.Size = New Size(562, 242)
        DataGridViewVehicle.TabIndex = 21
        ' 
        ' VehicleBindingSource
        ' 
        VehicleBindingSource.DataSource = GetType(Vehicle)
        ' 
        ' IdDataGridViewTextBoxColumn
        ' 
        IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        IdDataGridViewTextBoxColumn.HeaderText = "Id"
        IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        ' 
        ' SahibiDataGridViewTextBoxColumn
        ' 
        SahibiDataGridViewTextBoxColumn.DataPropertyName = "Sahibi"
        SahibiDataGridViewTextBoxColumn.HeaderText = "Sahibi"
        SahibiDataGridViewTextBoxColumn.Name = "SahibiDataGridViewTextBoxColumn"
        ' 
        ' DurumDataGridViewTextBoxColumn
        ' 
        DurumDataGridViewTextBoxColumn.DataPropertyName = "Durum"
        DurumDataGridViewTextBoxColumn.HeaderText = "Durum"
        DurumDataGridViewTextBoxColumn.Name = "DurumDataGridViewTextBoxColumn"
        ' 
        ' SinifDataGridViewTextBoxColumn
        ' 
        SinifDataGridViewTextBoxColumn.DataPropertyName = "Sinif"
        SinifDataGridViewTextBoxColumn.HeaderText = "Sinif"
        SinifDataGridViewTextBoxColumn.Name = "SinifDataGridViewTextBoxColumn"
        ' 
        ' MarkaDataGridViewTextBoxColumn
        ' 
        MarkaDataGridViewTextBoxColumn.DataPropertyName = "Marka"
        MarkaDataGridViewTextBoxColumn.HeaderText = "Marka"
        MarkaDataGridViewTextBoxColumn.Name = "MarkaDataGridViewTextBoxColumn"
        ' 
        ' ModelDataGridViewTextBoxColumn
        ' 
        ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        ' 
        ' RenkDataGridViewTextBoxColumn
        ' 
        RenkDataGridViewTextBoxColumn.DataPropertyName = "Renk"
        RenkDataGridViewTextBoxColumn.HeaderText = "Renk"
        RenkDataGridViewTextBoxColumn.Name = "RenkDataGridViewTextBoxColumn"
        ' 
        ' YilDataGridViewTextBoxColumn
        ' 
        YilDataGridViewTextBoxColumn.DataPropertyName = "Yil"
        YilDataGridViewTextBoxColumn.HeaderText = "Yil"
        YilDataGridViewTextBoxColumn.Name = "YilDataGridViewTextBoxColumn"
        ' 
        ' KmDataGridViewTextBoxColumn
        ' 
        KmDataGridViewTextBoxColumn.DataPropertyName = "Km"
        KmDataGridViewTextBoxColumn.HeaderText = "Km"
        KmDataGridViewTextBoxColumn.Name = "KmDataGridViewTextBoxColumn"
        ' 
        ' PlakaDataGridViewTextBoxColumn
        ' 
        PlakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka"
        PlakaDataGridViewTextBoxColumn.HeaderText = "Plaka"
        PlakaDataGridViewTextBoxColumn.Name = "PlakaDataGridViewTextBoxColumn"
        ' 
        ' SasiDataGridViewTextBoxColumn
        ' 
        SasiDataGridViewTextBoxColumn.DataPropertyName = "Sasi"
        SasiDataGridViewTextBoxColumn.HeaderText = "Sasi"
        SasiDataGridViewTextBoxColumn.Name = "SasiDataGridViewTextBoxColumn"
        ' 
        ' KiralamaUcretiDataGridViewTextBoxColumn
        ' 
        KiralamaUcretiDataGridViewTextBoxColumn.DataPropertyName = "KiralamaUcreti"
        KiralamaUcretiDataGridViewTextBoxColumn.HeaderText = "KiralamaUcreti"
        KiralamaUcretiDataGridViewTextBoxColumn.Name = "KiralamaUcretiDataGridViewTextBoxColumn"
        ' 
        ' SatisUcretiDataGridViewTextBoxColumn
        ' 
        SatisUcretiDataGridViewTextBoxColumn.DataPropertyName = "SatisUcreti"
        SatisUcretiDataGridViewTextBoxColumn.HeaderText = "SatisUcreti"
        SatisUcretiDataGridViewTextBoxColumn.Name = "SatisUcretiDataGridViewTextBoxColumn"
        ' 
        ' KiralayanDataGridViewTextBoxColumn
        ' 
        KiralayanDataGridViewTextBoxColumn.DataPropertyName = "Kiralayan"
        KiralayanDataGridViewTextBoxColumn.HeaderText = "Kiralayan"
        KiralayanDataGridViewTextBoxColumn.Name = "KiralayanDataGridViewTextBoxColumn"
        ' 
        ' AciklamaDataGridViewTextBoxColumn
        ' 
        AciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama"
        AciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama"
        AciklamaDataGridViewTextBoxColumn.Name = "AciklamaDataGridViewTextBoxColumn"
        ' 
        ' GorselDataGridViewTextBoxColumn
        ' 
        GorselDataGridViewTextBoxColumn.DataPropertyName = "Gorsel"
        GorselDataGridViewTextBoxColumn.HeaderText = "Gorsel"
        GorselDataGridViewTextBoxColumn.Name = "GorselDataGridViewTextBoxColumn"
        ' 
        ' CreatedAtDataGridViewTextBoxColumn
        ' 
        CreatedAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt"
        CreatedAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt"
        CreatedAtDataGridViewTextBoxColumn.Name = "CreatedAtDataGridViewTextBoxColumn"
        ' 
        ' UpdatedAtDataGridViewTextBoxColumn
        ' 
        UpdatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt"
        UpdatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt"
        UpdatedAtDataGridViewTextBoxColumn.Name = "UpdatedAtDataGridViewTextBoxColumn"
        ' 
        ' VehiclesView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(DataGridViewVehicle)
        Controls.Add(BtnRent)
        Controls.Add(BtnSale)
        Controls.Add(PicSearch)
        Controls.Add(LblSelected)
        Controls.Add(BtnRefresh)
        Controls.Add(txtSearch)
        Controls.Add(BtnAdd)
        Controls.Add(BtnDelete)
        Controls.Add(BtnEdit)
        Controls.Add(ListView)
        Icon = car1
        Margin = New Padding(3, 2, 3, 2)
        Name = "VehiclesView"
        Text = "ARAÇLAR"
        CType(PicSearch, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewVehicle, ComponentModel.ISupportInitialize).EndInit()
        CType(VehicleBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicSearch As PictureBox
    Friend WithEvents LblSelected As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents BtnSale As Button
    Friend WithEvents BtnRent As Button
    Friend WithEvents DataGridViewVehicle As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SahibiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DurumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SinifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarkaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RenkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlakaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KiralamaUcretiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SatisUcretiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KiralayanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AciklamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GorselDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleBindingSource As BindingSource
End Class
