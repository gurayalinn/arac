Public Class CustomersView
    Private customerController As CustomerController
    Private customers As List(Of Customer)

    Public Sub New()
        InitializeComponent()
        customerController = New CustomerController((""))
    End Sub

    Private Sub CustomersView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customers = customerController.GetAllCustomers()

        LoadCustomers()
        CustomView()
    End Sub

    Private Sub LoadCustomers()
        For Each customer As Customer In customers
            Dim row As String() = New String() {customer.Id, customer.Ad, customer.Soyad, customer.Tckn, customer.Cinsiyet, customer.Dogum.ToString("dd/MM/yyyy"), customer.Telefon, customer.Adres, customer.Email}
            Dim listViewItem As New ListViewItem(row)
            ListViewCustomers.Items.Add(listViewItem)

        Next
    End Sub

    Private Sub ReloadForm()
        ListViewCustomers.Items.Clear()
        customers = customerController.GetAllCustomers()
        LoadCustomers()

    End Sub


    Private Sub CustomView()

        ListViewCustomers.View = View.Details
        ListViewCustomers.GridLines = True
        ListViewCustomers.FullRowSelect = True
        ListViewCustomers.HideSelection = False
        ListViewCustomers.MultiSelect = False
        ListViewCustomers.AutoArrange = True
        ListViewCustomers.Columns.Add("#", 50)
        ListViewCustomers.Columns.Add("Ad", 150)
        ListViewCustomers.Columns.Add("Soyad", 150)
        ListViewCustomers.Columns.Add("TCKN", 150)
        ListViewCustomers.Columns.Add("Cinsiyet", 150)
        ListViewCustomers.Columns.Add("Doğum", 150)
        ListViewCustomers.Columns.Add("Telefon", 150)
        ListViewCustomers.Columns.Add("Adres", 150)
        ListViewCustomers.Columns.Add("Email", 150)


        ListViewCustomers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListViewCustomers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        AddHandler ListViewCustomers.ColumnClick, Sub(sender As Object, e As ColumnClickEventArgs)
                                                      Dim sorter As New ListViewColumnSorter()
                                                      sorter.SortColumn = e.Column
                                                      sorter.Order = If(sorter.Order = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
                                                      If sorter.Order = SortOrder.Ascending Then
                                                          ListViewCustomers.Sorting = SortOrder.Ascending
                                                      Else
                                                          ListViewCustomers.Sorting = SortOrder.Descending
                                                      End If
                                                      ListViewCustomers.ListViewItemSorter = sorter
                                                      ListViewCustomers.Sort()
                                                  End Sub

        AddHandler ListViewCustomers.SelectedIndexChanged, Sub()
                                                               If ListViewCustomers.SelectedItems.Count = 0 Then
                                                                   LblSelected.Text = ""
                                                                   Return
                                                               End If
                                                               Dim id As Integer = Integer.Parse(ListViewCustomers.SelectedItems(0).SubItems(0).Text)
                                                               Dim customer As Customer = customerController.GetCustomerById(id)
                                                               Dim name As String = customer.Ad + " " + customer.Soyad
                                                               LblSelected.ForeColor = Color.Blue
                                                               LblSelected.Text = name.ToString()
                                                           End Sub

        AddHandler ListViewCustomers.DoubleClick, Sub()
                                                      If ListViewCustomers.SelectedItems.Count = 0 Then
                                                          Return
                                                      End If

                                                      Dim id = Integer.Parse(ListViewCustomers.SelectedItems(0).SubItems(0).Text)

                                                      Dim data As New AddCustomerView(id)
                                                      data.ShowDialog()
                                                  End Sub


    End Sub

    Private Sub BtnEditCustomer_Click(sender As Object, e As EventArgs) Handles BtnEditCustomer.Click
        If ListViewCustomers.SelectedItems.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim id = Integer.Parse(ListViewCustomers.SelectedItems(0).SubItems(0).Text)
        Dim data As New AddCustomerView(id)
        data.ShowDialog()
        ReloadForm()
    End Sub


    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        Dim data As New AddCustomerView()
        data.ShowDialog()
        ReloadForm()
    End Sub


    Private Sub BtnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles BtnDeleteCustomer.Click
        If ListViewCustomers.SelectedItems.Count = 0 Then
            MessageBox.Show("Lütfen bir kayıt seçin.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Kayıt silmek istediğinize emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return
        End If

        Dim id As Integer = Integer.Parse(ListViewCustomers.SelectedItems(0).SubItems(0).Text)
        customerController.DeleteCustomer(id)
        ReloadForm()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim search As String = txtSearch.Text
        Dim filteredCustomers As List(Of Customer) = customers.FindAll(Function(customer) customer.Ad.Contains(search, StringComparison.CurrentCultureIgnoreCase) Or customer.Soyad.Contains(search, StringComparison.CurrentCultureIgnoreCase) Or customer.Tckn.Contains(search, StringComparison.CurrentCultureIgnoreCase) Or customer.Cinsiyet.Contains(search, StringComparison.CurrentCultureIgnoreCase) Or customer.Dogum.ToString().Contains(search, StringComparison.CurrentCultureIgnoreCase) Or customer.Telefon.Contains(search, StringComparison.CurrentCultureIgnoreCase) Or customer.Adres.Contains(search, StringComparison.CurrentCultureIgnoreCase) Or customer.Email.Contains(search, StringComparison.CurrentCultureIgnoreCase))
        ListViewCustomers.Items.Clear()
        For Each customer As Customer In filteredCustomers
            Dim row As String() = New String() {customer.Id, customer.Ad, customer.Soyad, customer.Tckn, customer.Cinsiyet, customer.Dogum.ToString("dd/MM/yyyy"), customer.Telefon, customer.Adres, customer.Email}
            Dim listViewItem As New ListViewItem(row)
            ListViewCustomers.Items.Add(listViewItem)
        Next
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        ReloadForm()
    End Sub




    Private Class ListViewColumnSorter
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
End Class


