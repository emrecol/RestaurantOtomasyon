Imports System.Dynamic

Public Class RaporForm
    Dim connectionString As String = "Data Source=DESKTOP-59UNT62\SQLEXPRESS;Initial Catalog=db_Restaurant;Integrated Security=True"
    Dim connection As SqlConnection
    Private databasebaglanti As DatabaseBaglanti

    Private Sub RaporForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim autoCompleteData1 As AutoCompleteStringCollection = GetAutoCompleteData1()
        SetUpAutoCompleteTextBox(txtPersonel, autoCompleteData1)

        Dim autoCompleteData2 As AutoCompleteStringCollection = GetAutoCompleteData2()
        SetUpAutoCompleteTextBox(txtMusteri, autoCompleteData2)
        ComboBox1.SelectedIndex = 0
        cbMasano.SelectedIndex = 0
        DataGridView1.ScrollBars = ScrollBars.Vertical

    End Sub

    Private Function GetAutoCompleteData1() As AutoCompleteStringCollection
        Dim query As String = "SELECT perid FROM Odeme"
        Dim autoCompleteCollection As New AutoCompleteStringCollection()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            autoCompleteCollection.Add(reader("perid").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Veri çekilirken hata oluştu: " & ex.Message)
        End Try

        Return autoCompleteCollection
    End Function

    Private Function GetAutoCompleteData2() As AutoCompleteStringCollection
        Dim query As String = "SELECT musteriadsoyad FROM Odeme"
        Dim autoCompleteCollection As New AutoCompleteStringCollection()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            autoCompleteCollection.Add(reader("musteriadsoyad").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Veri çekilirken hata oluştu: " & ex.Message)
        End Try

        Return autoCompleteCollection
    End Function

    Private Sub FetchData(paymentType As String)
        Dim query As String
        If paymentType = "" Then
            query = "SELECT * FROM Odeme"
        Else
            query = "SELECT * FROM Odeme WHERE OdemeTuru = @odemeturu"
        End If
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@odemeturu", paymentType)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Veri çekilirken hata oluştu: " & ex.Message)
        End Try
    End Sub


    Private Sub SetUpAutoCompleteTextBox(textBox As TextBox, autoCompleteData As AutoCompleteStringCollection)
        textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        textBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        textBox.AutoCompleteCustomSource = autoCompleteData
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtMusteri.TextChanged

    End Sub

    Private Sub btnFiltrele_Click(sender As Object, e As EventArgs) Handles btnFiltrele.Click

        SearchDatabase(txtPersonel.Text, txtMusteri.Text, Convert.ToInt32(cbMasano.SelectedIndex), dtpStartDate.Value, dtpEndDate.Value, ComboBox1.SelectedItem.ToString())
    End Sub

    Private Sub SearchDatabase(searchTerm1 As String, searchTerm2 As String, searchTerm3 As Integer, startDate As DateTime, endDate As DateTime, paymentType As String)
        Using conn As New SqlConnection(connectionString)
            Try
                ' Bağlantıyı aç
                conn.Open()

                ' SQL sorgusunu dinamik olarak oluştur
                Dim query As String = "SELECT * FROM Odeme WHERE 1=1"

                ' Parametre listesi
                Dim parameters As New List(Of SqlParameter)

                ' İlk TextBox değeri
                If Not String.IsNullOrEmpty(searchTerm1) Then
                    query &= " AND perid LIKE @perno"
                    parameters.Add(New SqlParameter("@perno", "%" & searchTerm1 & "%"))
                End If

                ' İkinci TextBox değeri
                If Not String.IsNullOrEmpty(searchTerm2) Then
                    query &= " AND musteriadsoyad LIKE @musadsoyad"
                    parameters.Add(New SqlParameter("@musadsoyad", "%" & searchTerm2 & "%"))
                End If

                'Üçüncü TextBox değeri
                If cbMasano.SelectedItem = "TÜMÜ" Then
                    query &= ""
                    'ElseIf Not String.IsNullOrEmpty(searchTerm3) Then
                Else
                    query &= " AND masaNo = @searchTerm3"
                    parameters.Add(New SqlParameter("@searchTerm3", searchTerm3))
                End If

                ' Tarih aralığı
                query &= " AND OdemeTarih BETWEEN @startDate AND @endDate"
                parameters.Add(New SqlParameter("@startDate", startDate))
                parameters.Add(New SqlParameter("@endDate", endDate))

                ' Ödeme türü
                If ComboBox1.SelectedItem = "TÜMÜ" Then
                    query &= ""
                Else
                    query &= " AND OdemeTuru = @paymentType"
                    parameters.Add(New SqlParameter("@paymentType", paymentType))
                End If

                ' Komutu oluştur
                Using cmd As New SqlCommand(query, conn)
                    ' Parametreleri komuta ekle
                    cmd.Parameters.AddRange(parameters.ToArray())

                    ' DataAdapter ve DataTable kullanarak sonuçları al
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Sonuçları DataGridView'e bağla
                    DataGridView1.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Veritabanı hatası: " & ex.Message)
            Finally
                ' Bağlantıyı kapat
                conn.Close()
            End Try
        End Using
    End Sub

    Dim odemeid As Integer

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        odemeid = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim query As String = "SELECT * FROM Siparis WHERE OdemeID = @odemeid"
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@odemeid", odemeid)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        dtgvodemesiparisleri.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Veri çekilirken hata oluştu: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        'üstteki tablo seçili ise tabloyu excel olarak kaydeder
        If rbtnust.Checked Then
            Dim exporter As New ExcelExporter1()
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files|*.xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    exporter.ExportDataGridViewToExcel(DataGridView1, saveFileDialog.FileName)
                    MessageBox.Show("Veriler başarıyla Excel'e aktarıldı.")
                Catch ex As Exception
                    MessageBox.Show("Bir hata oluştu: " & ex.Message)
                End Try
            End If
            'alttaki tablo seçili ise üstteki tablodan seçi olan satırı ve alttaki tabloyu excel olarak kaydeder
        ElseIf rbtnalt.Checked Then
            Dim exporter As New ExcelExporter()
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files|*.xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ' DataGridView1'de seçili olan satırın indeksini alın
                    Dim selectedRowIndex As Integer = -1
                    If DataGridView1.SelectedRows.Count > 0 Then
                        selectedRowIndex = DataGridView1.SelectedRows(0).Index
                    End If

                    exporter.ExportDataGridViewsToExcel(DataGridView1, dtgvodemesiparisleri, selectedRowIndex, saveFileDialog.FileName)
                    MessageBox.Show("Veriler başarıyla Excel'e aktarıldı.")
                Catch ex As Exception
                    MessageBox.Show("Bir hata oluştu: " & ex.Message)
                End Try
            End If

        End If
    End Sub
End Class