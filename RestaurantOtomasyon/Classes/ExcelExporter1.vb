Imports Microsoft.Office.Interop
Public Class ExcelExporter1
    Public Sub ExportDataGridViewToExcel(ByVal dgv As DataGridView, ByVal filePath As String)
        ' Excel uygulamasını başlat
        Dim excelApp As New Excel.Application
        excelApp.Visible = False
        excelApp.DisplayAlerts = False

        ' Yeni bir çalışma kitabı oluştur
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add(Type.Missing)
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            worksheet = CType(workbook.Sheets("Sheet1"), Excel.Worksheet)
            worksheet.Name = "DataGridView Export"

            ' Sütun başlıklarını yaz
            For i As Integer = 1 To dgv.Columns.Count
                worksheet.Cells(1, i) = dgv.Columns(i - 1).HeaderText
            Next

            ' DataGridView'deki verileri yaz
            For i As Integer = 0 To dgv.Rows.Count - 1
                For j As Integer = 0 To dgv.Columns.Count - 1
                    worksheet.Cells(i + 2, j + 1) = dgv.Rows(i).Cells(j).Value.ToString()
                Next
            Next

            ' Dosyayı kaydet
            workbook.SaveAs(filePath)
        Catch ex As Exception
            Throw New Exception("DataGridView verileri Excel'e aktarılırken bir hata oluştu: " & ex.Message)
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
