Public Class OperationsView
    Private operationController As OperationController
    Private sales As List(Of Sale)
    Private rents As List(Of Rent)
    Private payments As List(Of Payment)

    Public Sub New()
        InitializeComponent()
        operationController = New OperationController((""))
    End Sub

    Private Sub OperationsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sales = operationController.GetSales()
        LoadSales()
        SaleCustomView()

        rents = operationController.GetRents()
        LoadRents()
        RentCustomView()

    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged

        Select Case TabControl.SelectedIndex
            Case 0
                SaleReloadForm()
            Case 1
                RentReloadForm()
            Case 2
                MessageBox.Show("Ödemeler Aktif olacak")
        End Select

    End Sub

    Private Sub LoadSales()
        For Each sale As Sale In sales
            Dim row As String() = New String() {sale.Id.ToString(), sale.CustomerId.ToString(), sale.VehicleId.ToString(), sale.SaleDate.ToString(), sale.Price.ToString(), sale.PaymentType}
            Dim listViewItem As New ListViewItem(row)
            SaleListView.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub LoadRents()
        For Each rent As Rent In rents
            Dim row As String() = New String() {rent.Id.ToString(), rent.CustomerId.ToString(), rent.VehicleId.ToString(), rent.RentDate.ToString(), rent.ReturnDate.ToString(), rent.Price.ToString(), rent.PaymentType}
            Dim listViewItem As New ListViewItem(row)
            RentListView.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub SaleReloadForm()
        SaleListView.Items.Clear()
        sales = operationController.GetSales()
        LoadSales()
    End Sub

    Private Sub RentReloadForm()
        RentListView.Items.Clear()
        rents = operationController.GetRents()
        LoadRents()
    End Sub

    Private Sub SaleBtnAdd_Click(sender As Object, e As EventArgs) Handles SaleBtnAdd.Click
        SaleOpenAddForm()
    End Sub

    Private Sub RentBtnAdd_Click(sender As Object, e As EventArgs) Handles RentBtnAdd.Click
        RentOpenAddForm()
    End Sub

    Private Sub SaleBtnEdit_Click(sender As Object, e As EventArgs) Handles SaleBtnEdit.Click
        If SaleListView.SelectedItems.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id = Integer.Parse(SaleListView.SelectedItems(0).SubItems(0).Text)
        SaleOpenEditForm(id)
    End Sub

    Private Sub RentBtnEdit_Click(sender As Object, e As EventArgs) Handles RentBtnEdit.Click
        If RentListView.SelectedItems.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id = Integer.Parse(RentListView.SelectedItems(0).SubItems(0).Text)
        RentOpenEditForm(id)
    End Sub

    Private Sub SaleBtnDelete_Click(sender As Object, e As EventArgs) Handles SaleBtnDelete.Click
        If SaleListView.SelectedItems.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Kayıt silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If

        Dim id As Integer = Integer.Parse(SaleListView.SelectedItems(0).SubItems(0).Text)
        operationController.DeleteSale(id)
        SaleReloadForm()
    End Sub

    Private Sub RentBtnDelete_Click(sender As Object, e As EventArgs) Handles RentBtnDelete.Click
        If RentListView.SelectedItems.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Kayıt silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If

        Dim id As Integer = Integer.Parse(RentListView.SelectedItems(0).SubItems(0).Text)
        operationController.DeleteRent(id)
        RentReloadForm()
    End Sub

    Private Sub SaleBtnRefresh_Click(sender As Object, e As EventArgs) Handles SaleBtnRefresh.Click
        SaleReloadForm()
    End Sub


    Private Sub RentBtnRefresh_Click(sender As Object, e As EventArgs) Handles RentBtnRefresh.Click
        RentReloadForm()
    End Sub

    Private Sub SaleTxtSearch_TextChanged()
        Dim search As String = SaleTxtSearch.Text
        Dim filteredSales As List(Of Sale) = sales.Where(Function(s) s.CustomerId.ToString().Contains(search) Or s.VehicleId.ToString().Contains(search) Or s.SaleDate.ToString().Contains(search) Or s.Price.ToString().Contains(search) Or s.PaymentType.Contains(search)).ToList()
        SaleListView.Items.Clear()
        For Each sale As Sale In filteredSales
            Dim row As String() = New String() {sale.Id.ToString(), sale.CustomerId.ToString(), sale.VehicleId.ToString(), sale.SaleDate.ToString(), sale.Price.ToString(), sale.PaymentType}
            Dim listViewItem As New ListViewItem(row)
            SaleListView.Items.Add(listViewItem)
        Next

    End Sub

    Private Sub RentTxtSearch_TextChanged()
        Dim search As String = RentTxtSearch.Text
        Dim filteredRents As List(Of Rent) = rents.Where(Function(r) r.CustomerId.ToString().Contains(search) Or r.VehicleId.ToString().Contains(search) Or r.RentDate.ToString().Contains(search) Or r.ReturnDate.ToString().Contains(search) Or r.Price.ToString().Contains(search) Or r.PaymentType.Contains(search)).ToList()
        RentListView.Items.Clear()
        For Each rent As Rent In filteredRents
            Dim row As String() = New String() {rent.Id.ToString(), rent.CustomerId.ToString(), rent.VehicleId.ToString(), rent.RentDate.ToString(), rent.ReturnDate.ToString(), rent.Price.ToString(), rent.PaymentType}
            Dim listViewItem As New ListViewItem(row)
            RentListView.Items.Add(listViewItem)
        Next
    End Sub


    Private Sub SaleCustomView()

        SaleListView.View = View.Details
        SaleListView.GridLines = True
        SaleListView.FullRowSelect = True
        SaleListView.HideSelection = False
        SaleListView.MultiSelect = False
        SaleListView.AutoArrange = True
        SaleListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        SaleListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        SaleListView.Columns.Add("ID", 50)
        SaleListView.Columns.Add("Müşteri ID", 100)
        SaleListView.Columns.Add("Araç ID", 100)
        SaleListView.Columns.Add("Satış Tarihi", 100)
        SaleListView.Columns.Add("Fiyat", 100)
        SaleListView.Columns.Add("Ödeme Türü", 100)


        AddHandler SaleListView.ColumnClick, Sub(sender As Object, e As ColumnClickEventArgs)
                                                 Dim sorter As New ListViewColumnSorter()
                                                 SaleListView.ListViewItemSorter = sorter
                                                 If sorter.Order = SortOrder.Ascending Then
                                                     sorter.Order = SortOrder.Descending
                                                 Else
                                                     sorter.Order = SortOrder.Ascending
                                                 End If
                                                 sorter.SortColumn = e.Column
                                                 SaleListView.Sort()
                                             End Sub


        AddHandler SaleListView.SelectedIndexChanged, Sub()
                                                          If SaleListView.SelectedItems.Count = 0 Then
                                                              SaleLblSelected.Text = ""
                                                              Return
                                                          End If
                                                          Dim id As Integer = Integer.Parse(SaleListView.SelectedItems(0).SubItems(0).Text)
                                                          Dim sale As Sale = operationController.GetSale(id)
                                                          Dim selected As String = sale.PaymentType + " - " + sale.Price.ToString() + " TL"
                                                          SaleLblSelected.ForeColor = Color.Blue
                                                          SaleLblSelected.Text = selected.ToString()
                                                      End Sub

        AddHandler SaleListView.DoubleClick, Sub()
                                                 If SaleListView.SelectedItems.Count = 0 Then
                                                     Return
                                                 End If
                                                 Dim id As Integer = Integer.Parse(SaleListView.SelectedItems(0).SubItems(0).Text)
                                                 SaleOpenEditForm(id)
                                             End Sub


    End Sub

    Private Sub RentCustomView()

        RentListView.View = View.Details
        RentListView.GridLines = True
        RentListView.FullRowSelect = True
        RentListView.HideSelection = False
        RentListView.MultiSelect = False
        RentListView.AutoArrange = True
        RentListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        RentListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        RentListView.Columns.Add("ID", 50)
        RentListView.Columns.Add("Müşteri ID", 100)
        RentListView.Columns.Add("Araç ID", 100)
        RentListView.Columns.Add("Kiralama Tarihi", 100)
        RentListView.Columns.Add("Teslim Tarihi", 100)
        RentListView.Columns.Add("Fiyat", 100)
        RentListView.Columns.Add("Ödeme Türü", 100)

        AddHandler RentListView.ColumnClick, Sub(sender As Object, e As ColumnClickEventArgs)
                                                 Dim sorter As New ListViewColumnSorter()
                                                 RentListView.ListViewItemSorter = sorter
                                                 If sorter.Order = SortOrder.Ascending Then
                                                     sorter.Order = SortOrder.Descending
                                                 Else
                                                     sorter.Order = SortOrder.Ascending
                                                 End If
                                                 sorter.SortColumn = e.Column
                                                 RentListView.Sort()
                                             End Sub

        AddHandler RentListView.SelectedIndexChanged, Sub()
                                                          If RentListView.SelectedItems.Count = 0 Then
                                                              RentLblSelected.Text = ""
                                                              Return
                                                          End If
                                                          Dim id As Integer = Integer.Parse(RentListView.SelectedItems(0).SubItems(0).Text)
                                                          Dim rent As Rent = operationController.GetRent(id)
                                                          Dim selected As String = rent.PaymentType + " - " + rent.Price.ToString() + " TL"
                                                          RentLblSelected.ForeColor = Color.Blue
                                                          RentLblSelected.Text = selected.ToString()
                                                      End Sub

        AddHandler RentListView.DoubleClick, Sub()
                                                 If RentListView.SelectedItems.Count = 0 Then
                                                     Return
                                                 End If
                                                 Dim id As Integer = Integer.Parse(RentListView.SelectedItems(0).SubItems(0).Text)
                                                 RentOpenEditForm(id)
                                             End Sub

    End Sub


    Private Sub SaleOpenEditForm(id As Integer)
        MessageBox.Show("Edit form açılacak")
    End Sub

    Private Sub RentOpenEditForm(id As Integer)
        MessageBox.Show("Edit form açılacak")
    End Sub

    Private Sub SaleOpenAddForm()
        MessageBox.Show("Ekle form açılacak")
    End Sub

    Private Sub RentOpenAddForm()
        MessageBox.Show("Ekle form açılacak")
    End Sub


End Class


Public Class ListViewColumnSorter

    Implements IComparer

    Public Property SortColumn As Integer
    Public Property Order As SortOrder

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Dim itemX As ListViewItem = DirectCast(x, ListViewItem)
        Dim itemY As ListViewItem = DirectCast(y, ListViewItem)
        Dim compareResult As Integer = String.Compare(itemX.SubItems(SortColumn).Text, itemY.SubItems(SortColumn).Text)
        If Order = SortOrder.Ascending Then
            Return compareResult
        ElseIf Order = SortOrder.Descending Then
            Return -compareResult
        Else
            Return 0
        End If
    End Function

End Class
