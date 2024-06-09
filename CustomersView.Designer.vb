Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomersView
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
        components = New ComponentModel.Container()
        UserControllerBindingSource = New BindingSource(components)
        ListViewCustomers = New ListView()
        BtnEditCustomer = New Button()
        BtnDeleteCustomer = New Button()
        BtnAddCustomer = New Button()
        txtSearch = New TextBox()
        BtnRefresh = New Button()
        LblSelected = New Label()
        PicSearch = New PictureBox()
        CType(UserControllerBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSearch, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListViewCustomers
        ' 
        ListViewCustomers.Location = New Point(10, 38)
        ListViewCustomers.Margin = New Padding(3, 2, 3, 2)
        ListViewCustomers.Name = "ListViewCustomers"
        ListViewCustomers.Size = New Size(573, 244)
        ListViewCustomers.TabIndex = 0
        ListViewCustomers.UseCompatibleStateImageBehavior = False
        ListViewCustomers.View = View.List
        ' 
        ' BtnEditCustomer
        ' 
        BtnEditCustomer.BackgroundImage = My.Resources.edit
        BtnEditCustomer.BackgroundImageLayout = ImageLayout.Zoom
        BtnEditCustomer.Location = New Point(76, 285)
        BtnEditCustomer.Margin = New Padding(3, 2, 3, 2)
        BtnEditCustomer.Name = "BtnEditCustomer"
        BtnEditCustomer.Size = New Size(60, 44)
        BtnEditCustomer.TabIndex = 3
        BtnEditCustomer.UseVisualStyleBackColor = True
        ' 
        ' BtnDeleteCustomer
        ' 
        BtnDeleteCustomer.BackgroundImage = Resources.delete1
        BtnDeleteCustomer.BackgroundImageLayout = ImageLayout.Zoom
        BtnDeleteCustomer.Location = New Point(457, 285)
        BtnDeleteCustomer.Margin = New Padding(3, 2, 3, 2)
        BtnDeleteCustomer.Name = "BtnDeleteCustomer"
        BtnDeleteCustomer.Size = New Size(60, 44)
        BtnDeleteCustomer.TabIndex = 4
        BtnDeleteCustomer.UseVisualStyleBackColor = True
        ' 
        ' BtnAddCustomer
        ' 
        BtnAddCustomer.BackgroundImage = Resources.add
        BtnAddCustomer.BackgroundImageLayout = ImageLayout.Zoom
        BtnAddCustomer.Location = New Point(10, 285)
        BtnAddCustomer.Margin = New Padding(3, 2, 3, 2)
        BtnAddCustomer.Name = "BtnAddCustomer"
        BtnAddCustomer.Size = New Size(60, 44)
        BtnAddCustomer.TabIndex = 2
        BtnAddCustomer.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(58, 9)
        txtSearch.Margin = New Padding(3, 2, 3, 2)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(210, 23)
        txtSearch.TabIndex = 1
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.BackgroundImage = Resources.refresh
        BtnRefresh.BackgroundImageLayout = ImageLayout.Zoom
        BtnRefresh.Location = New Point(522, 285)
        BtnRefresh.Margin = New Padding(3, 2, 3, 2)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(60, 44)
        BtnRefresh.TabIndex = 5
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' LblSelected
        ' 
        LblSelected.AutoSize = True
        LblSelected.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSelected.Location = New Point(273, 11)
        LblSelected.Name = "LblSelected"
        LblSelected.Size = New Size(14, 16)
        LblSelected.TabIndex = 8
        LblSelected.Text = " "
        ' 
        ' PicSearch
        ' 
        PicSearch.Image = Resources.search
        PicSearch.Location = New Point(10, 3)
        PicSearch.Margin = New Padding(3, 2, 3, 2)
        PicSearch.Name = "PicSearch"
        PicSearch.Size = New Size(42, 30)
        PicSearch.SizeMode = PictureBoxSizeMode.Zoom
        PicSearch.TabIndex = 10
        PicSearch.TabStop = False
        ' 
        ' CustomersView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(598, 338)
        Controls.Add(PicSearch)
        Controls.Add(LblSelected)
        Controls.Add(BtnRefresh)
        Controls.Add(txtSearch)
        Controls.Add(BtnAddCustomer)
        Controls.Add(BtnDeleteCustomer)
        Controls.Add(BtnEditCustomer)
        Controls.Add(ListViewCustomers)
        Icon = My.Resources.car1
        Margin = New Padding(3, 2, 3, 2)
        Name = "CustomersView"
        RightToLeft = RightToLeft.No
        Text = "USERS"
        CType(UserControllerBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSearch, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UserControllerBindingSource As BindingSource
    Friend WithEvents ListViewCustomers As ListView
    Friend WithEvents BtnEditCustomer As Button
    Friend WithEvents BtnDeleteCustomer As Button
    Friend WithEvents BtnAddCustomer As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents LblSelected As Label
    Friend WithEvents PicSearch As PictureBox
End Class
