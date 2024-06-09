Imports Font = System.Drawing.Font

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersView))
        UserControllerBindingSource = New BindingSource(components)
        ListViewUsers = New ListView()
        BtnEditUser = New Button()
        BtnDeleteUser = New Button()
        BtnAddUser = New Button()
        txtSearch = New TextBox()
        BtnRefresh = New Button()
        LblSelectedUser = New Label()
        PicSearch = New PictureBox()
        CType(UserControllerBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicSearch, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UserControllerBindingSource
        ' 
        UserControllerBindingSource.DataSource = GetType(UserController)
        ' 
        ' ListViewUsers
        ' 
        ListViewUsers.Location = New Point(12, 50)
        ListViewUsers.Name = "ListViewUsers"
        ListViewUsers.Size = New Size(654, 324)
        ListViewUsers.TabIndex = 0
        ListViewUsers.UseCompatibleStateImageBehavior = False
        ListViewUsers.View = View.List
        ' 
        ' BtnEditUser
        ' 
        BtnEditUser.BackgroundImage = My.Resources.Resources.edit
        BtnEditUser.BackgroundImageLayout = ImageLayout.Zoom
        BtnEditUser.Location = New Point(87, 380)
        BtnEditUser.Name = "BtnEditUser"
        BtnEditUser.Size = New Size(69, 58)
        BtnEditUser.TabIndex = 3
        BtnEditUser.UseVisualStyleBackColor = True
        ' 
        ' BtnDeleteUser
        ' 
        BtnDeleteUser.BackgroundImage = My.Resources.Resources.delete1
        BtnDeleteUser.BackgroundImageLayout = ImageLayout.Zoom
        BtnDeleteUser.Location = New Point(522, 380)
        BtnDeleteUser.Name = "BtnDeleteUser"
        BtnDeleteUser.Size = New Size(69, 58)
        BtnDeleteUser.TabIndex = 4
        BtnDeleteUser.UseVisualStyleBackColor = True
        ' 
        ' BtnAddUser
        ' 
        BtnAddUser.BackgroundImage = My.Resources.Resources.add
        BtnAddUser.BackgroundImageLayout = ImageLayout.Zoom
        BtnAddUser.Location = New Point(12, 380)
        BtnAddUser.Name = "BtnAddUser"
        BtnAddUser.Size = New Size(69, 58)
        BtnAddUser.TabIndex = 2
        BtnAddUser.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(66, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(240, 27)
        txtSearch.TabIndex = 1
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.BackgroundImage = My.Resources.Resources.refresh
        BtnRefresh.BackgroundImageLayout = ImageLayout.Zoom
        BtnRefresh.Location = New Point(597, 380)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.Size = New Size(69, 58)
        BtnRefresh.TabIndex = 5
        BtnRefresh.UseVisualStyleBackColor = True
        ' 
        ' LblSelectedUser
        ' 
        LblSelectedUser.AutoSize = True
        LblSelectedUser.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSelectedUser.Location = New Point(312, 15)
        LblSelectedUser.Name = "LblSelectedUser"
        LblSelectedUser.Size = New Size(18, 20)
        LblSelectedUser.TabIndex = 8
        LblSelectedUser.Text = " "
        ' 
        ' PicSearch
        ' 
        PicSearch.Image = My.Resources.Resources.search
        PicSearch.Location = New Point(12, 4)
        PicSearch.Name = "PicSearch"
        PicSearch.Size = New Size(48, 40)
        PicSearch.SizeMode = PictureBoxSizeMode.Zoom
        PicSearch.TabIndex = 10
        PicSearch.TabStop = False
        ' 
        ' UsersView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 450)
        Controls.Add(PicSearch)
        Controls.Add(LblSelectedUser)
        Controls.Add(BtnRefresh)
        Controls.Add(txtSearch)
        Controls.Add(BtnAddUser)
        Controls.Add(BtnDeleteUser)
        Controls.Add(BtnEditUser)
        Controls.Add(ListViewUsers)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "UsersView"
        RightToLeft = RightToLeft.No
        Text = "USERS"
        CType(UserControllerBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(PicSearch, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UserControllerBindingSource As BindingSource
    Friend WithEvents ListViewUsers As ListView
    Friend WithEvents BtnEditUser As Button
    Friend WithEvents BtnDeleteUser As Button
    Friend WithEvents BtnAddUser As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents LblSelectedUser As Label
    Friend WithEvents PicSearch As PictureBox
End Class
