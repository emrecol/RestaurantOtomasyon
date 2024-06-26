Imports Microsoft.Office.Interop
Public Class ExcelExporter
    Public Sub ExportDataGridViewsToExcel(ByVal dgv1 As DataGridView, ByVal dgv2 As DataGridView, ByVal selectedRowIndex As Integer, ByVal filePath As String)
        ' Excel uygulamasını başlat
        Dim excelApp As New Excel.Application
        excelApp.Visible = False
        excelApp.DisplayAlerts = False

        ' Yeni bir çalışma kitabı oluştur
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add(Type.Missing)
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            ' DataGridView2'in tamamını yaz
            worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
            worksheet.Name = "DataGridView2 Export"

            ' DataGridView2 sütun başlıklarını yaz
            For i As Integer = 1 To dgv2.Columns.Count
                worksheet.Cells(1, i) = dgv2.Columns(i - 1).HeaderText
            Next

            ' DataGridView2 satır verilerini yaz
            For i As Integer = 0 To dgv2.Rows.Count - 1
                For j As Integer = 0 To dgv2.Columns.Count - 1
                    Dim cellValue As String = If(dgv2.Rows(i).Cells(j).Value IsNot Nothing, dgv2.Rows(i).Cells(j).Value.ToString(), String.Empty)
                    worksheet.Cells(i + 2, j + 1) = cellValue
                Next
            Next

            ' Yeni bir çalışma sayfası ekle ve DataGridView1'in seçili satırını yaz
            worksheet = CType(workbook.Sheets.Add(After:=workbook.Sheets(workbook.Sheets.Count)), Excel.Worksheet)
            worksheet.Name = "DataGridView1 Selected Row"

            ' DataGridView1 sütun başlıklarını yaz
            For i As Integer = 1 To dgv1.Columns.Count
                worksheet.Cells(1, i) = dgv1.Columns(i - 1).HeaderText
            Next

            ' DataGridView1 seçili satırın verilerini yaz
            If selectedRowIndex >= 0 AndAlso selectedRowIndex < dgv1.Rows.Count Then
                For j As Integer = 0 To dgv1.Columns.Count - 1
                    Dim cellValue As String = If(dgv1.Rows(selectedRowIndex).Cells(j).Value IsNot Nothing, dgv1.Rows(selectedRowIndex).Cells(j).Value.ToString(), String.Empty)
                    worksheet.Cells(2, j + 1) = cellValue
                Next
            End If

            ' Dosyayı kaydet
            workbook.SaveAs(filePath)
        Catch ex As Exception
            Throw New Exception("Veriler Excel'e aktarılırken bir hata oluştu: " & ex.Message)
        Finally
            ' Kaynakları serbest bırak
            workbook.Close()
            excelApp.Quit()

            ReleaseObject(worksheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
