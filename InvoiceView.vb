Imports System.IO
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports System.Windows.Forms
Imports iText.Kernel
Imports iText.IO


Public Class InvoiceView
    Inherits Form
    Private operationController As OperationController
    Private customerController As CustomerController
    Private vehicleController As VehicleController
    Private sales As List(Of Sale)
    Private sale As Sale
    Private SaleId As Integer
    Private rents As List(Of Rent)
    Private rent As Rent
    Private RentId As Integer
    Private customer As Customer
    Private vehicle As Vehicle
    Private PaymentId As Integer
    Private payment As Payment
    Private payments As List(Of Payment)
    Private TransactionNo As String

    Public Sub New()
        InitializeComponent()
        operationController = New OperationController((""))
        customerController = New CustomerController((""))
        vehicleController = New VehicleController((""))
    End Sub

    Public Sub New(id As Integer)
        InitializeComponent()
        PaymentId = id
        operationController = New OperationController((""))
        customerController = New CustomerController((""))
        vehicleController = New VehicleController((""))
    End Sub

    Private Sub InvoiceView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtOdemeNo.Enabled = False

        Dim payment As Payment = operationController.GetPayment(PaymentId)
        If payment Is Nothing Then
            Return
        End If
        TransactionNo = payment.TransactionNo

        RentId = payment.RentId
        SaleId = payment.SaleId

        If RentId > 0 Then
            rent = operationController.GetRent(RentId)
            If rent Is Nothing Then
                Return
            End If
            customer = customerController.GetCustomer(rent.CustomerId)
            vehicle = vehicleController.GetVehicle(rent.VehicleId)
        End If

        If SaleId > 0 Then
            sale = operationController.GetSale(SaleId)
            If sale Is Nothing Then
                Return
            End If
            customer = customerController.GetCustomer(sale.CustomerId)
            vehicle = vehicleController.GetVehicle(sale.VehicleId)
        End If

        TxtOdemeNo.Text = TransactionNo
    End Sub



    Private Sub PicPrint_Click(sender As Object, e As EventArgs) Handles PicPrint.Click
        BtnPrint.PerformClick()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        TransactionNo = TxtOdemeNo.Text
        ExportInvoiceToPDF()

    End Sub



    Private Sub ExportInvoiceToPDF()

        Dim pdfFileName As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), TransactionNo & ".pdf")


        Try
            Using writer As New PdfWriter(pdfFileName)
                Using pdf As New PdfDocument(writer)
                    Using document As New Document(pdf)
                        Dim info As PdfDocumentInfo = pdf.GetDocumentInfo()
                        If Not File.Exists(pdfFileName) Then
                            MessageBox.Show("PDF dosyası oluşturulamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                        info.SetTitle("Fatura")
                        info.SetAuthor("Araç Satış Kiralama Otomasyonu")
                        info.SetSubject("Satış - Kiralama Faturası")
                        info.SetKeywords("Fatura, Araç, Satış, Kiralama")
                        info.SetCreator("Araç Satış Kiralama Otomasyonu")
                        info.SetMoreInfo("Araç Satış Kiralama Otomasyonu", "Araç Satış Kiralama Otomasyonu")


                        document.SetMargins(20, 20, 20, 20)
                        Dim Font As iText.Kernel.Font.PdfFont = iText.Kernel.Font.PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFontFamilies.HELVETICA)

                        Dim title As New Paragraph("FATURA")
                        title.SetTextAlignment(TextAlignment.CENTER)
                        title.SetFont(Font)
                        title.SetBold()
                        title.SetFontSize(20)
                        document.Add(title)

                        Dim InvoiceInfo As New Paragraph()
                        InvoiceInfo.Add("Tarih: " & DateTime.Now.ToString("dd/MM/yyyy") & vbLf)
                        InvoiceInfo.Add("Fatura No: " & TransactionNo & vbLf)
                        document.Add(InvoiceInfo)

                        document.Close()
                        writer.Close()
                    End Using
                End Using
            End Using

            Dim result As DialogResult = MessageBox.Show($"Fatura başarıyla PDF olarak kaydedildi: {pdfFileName}. Faturayı açmak için Tamam'a tıklayın.", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            If result = DialogResult.OK Then
                Dim processInfo As New ProcessStartInfo()
                processInfo.UseShellExecute = True
                processInfo.FileName = pdfFileName
                Process.Start(processInfo)
            End If

        Catch ex As FileNotFoundException
            MessageBox.Show($"Dosya bulunamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As NotSupportedException
            MessageBox.Show($"Desteklenmeyen işlem: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As iText.Kernel.Exceptions.PdfException
            MessageBox.Show($"PDF hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"PDF oluşturulurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Close()
        End Try
    End Sub
End Class
