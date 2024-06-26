Imports System.Configuration
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SiparisForm
    Dim connectionString As String = "Data Source=DESKTOP-59UNT62\SQLEXPRESS;Initial Catalog=db_Restaurant;Integrated Security=True"
    Dim connection As SqlConnection
    Private databasebaglanti As DatabaseBaglanti
    Public Property Username As String
    Private Sub SiparisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databasebaglanti = New DatabaseBaglanti(connectionString)
        connection = New SqlConnection(connectionString)
        LoadRadioButtonsFromDatabase()
        YemekTuru()
        siparisler()
        ' GroupBox1 içindeki radio butonlarına olay işleyicisini bağla
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(ctrl, RadioButton)
                AddHandler radioButton.CheckedChanged, AddressOf RadioButton_CheckedChanged
            End If
        Next

        ' GroupBox2 içindeki radio butonlarına olay işleyicisini bağla
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(ctrl, RadioButton)
                AddHandler radioButton.CheckedChanged, AddressOf RadioButton_CheckedChanged
            End If
        Next
    End Sub
    Public masano As Integer
    Public masarenk As String
    Public Sub LoadRadioButtonsFromDatabase()
        Try
            connection.Open()
            Dim query As String = "SELECT MasaButon, MasaDurum FROM Masa"
            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim radioButtonName As String = reader("MasaButon").ToString()
                Dim isFilledText As String = reader("MasaDurum").ToString()

                Dim radioButton As RadioButton = Me.Controls.Find(radioButtonName, True).FirstOrDefault()

                If radioButton IsNot Nothing Then
                    If isFilledText.ToLower() = "dolu" Then
                        radioButton.BackColor = Color.Red
                    ElseIf isFilledText.ToLower() = "bos" Then
                        radioButton.BackColor = Color.Green
                    Else
                        ' Durum belirtilmemişse, varsayılan olarak yeşil yapabilirsiniz veya istediğiniz herhangi bir renk.
                        radioButton.BackColor = Color.Green
                    End If
                End If
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error while loading radio buttons from database: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Dim selectedRadioButtonName As String = ""

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs)
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)

        If radioButton.Checked Then
            ' Seçilen radio butonun adını al
            selectedRadioButtonName = radioButton.Name
            masano = radioButton.Text
            masarenk = radioButton.BackColor.ToString()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Güncel tarih ve saat bilgisini al
        Dim currentDateAndTime As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

        ' Label kontrolüne yazdır
        Label1.Text = currentDateAndTime
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim selectedRowIndex As Integer = e.RowIndex
        Dim value As String = dtgvuturu.Rows(selectedRowIndex).Cells(0).Value.ToString()




        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT DISTINCT(UrunAd), UrunFiyat FROM Urunler WHERE UrunTuru = @Urunturu"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            command.Parameters.AddWithValue("@Urunturu", value)
            adapter.Fill(dataTable)
        End Using

        dtgvuadfiyat.DataSource = dataTable
    End Sub

    Private Sub YemekTuru()
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT DISTINCT(UrunTuru) FROM Urunler"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using

        dtgvuturu.DataSource = dataTable
    End Sub

    Private Sub btnSiparis_Click(sender As Object, e As EventArgs)
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        If masarenk = "Color [Green]" Then
            MessageBox.Show("Önce oturum başlatın")
        ElseIf masarenk = "Color [Red]" Then
            Dim valueuturu As String = dtgvuturu.SelectedCells(0).Value.ToString()
            Dim selectedRow As DataGridViewRow = dtgvuadfiyat.SelectedRows(0)
            Dim valueuad As String = selectedRow.Cells(0).Value.ToString()
            Dim valueufiyat As Double = Convert.ToDouble(selectedRow.Cells(1).Value)
            Dim valueuadet As Integer = nudadet.Value

            Dim query As String = "INSERT INTO Siparis (SiparisTarih, Personelid,urunid, urunturu, urunad, urunfiyat, urunadet, masano, siparisdurum) VALUES (GETDATE(), @personelno, @urunid,@uturu,@uad,@ufiyat,@uadet,@masano, 'aktif')"
            Dim queryuid As String = "Select UrunID Urunler WHERE UrunAd = @uad"
            Dim urunid As Integer
            Integer.TryParse(queryuid.ToString(), urunid)

            ' SqlCommand oluşturun
            Dim command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@personelno", Username)
            command.Parameters.AddWithValue("@urunid", urunid)
            command.Parameters.AddWithValue("@uturu", valueuturu)
            command.Parameters.AddWithValue("@uad", valueuad)
            command.Parameters.AddWithValue("@ufiyat", valueufiyat)
            command.Parameters.AddWithValue("@uadet", valueuadet)
            command.Parameters.AddWithValue("@masano", masano)

            ' Sorguyu çalıştırın
            command.ExecuteNonQuery()

            ' Kaynakları temizleyin
            command.Dispose()
            databasebaglanti.CloseConnection()
            siparisler()
            MessageBox.Show("Veriler başarıyla eklendi.")
        End If
    End Sub

    Private Sub RadioButton_Click(sender As Object, e As EventArgs)
        ' Tıklanan RadioButton kontrolünün Text özelliğini Label5'e yazdırın
        Dim clickedRadioButton As RadioButton = DirectCast(sender, RadioButton)
        masarenk = clickedRadioButton.BackColor.ToString()
    End Sub

    Public Sub siparisler()
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT urunturu, urunad,urunfiyat,urunadet,masano FROM Siparis where siparisdurum = 'aktif'"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub btnSiparis_Click_1(sender As Object, e As EventArgs) Handles btnSiparis.Click
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        If masarenk = "Color [Green]" Then
            MessageBox.Show("Önce oturum başlatın")
        ElseIf masarenk = "Color [Red]" Then
            Dim valueuturu As String = dtgvuturu.SelectedCells(0).Value.ToString()
            Dim selectedRow As DataGridViewRow = dtgvuadfiyat.SelectedRows(0)
            Dim valueuad As String = selectedRow.Cells(0).Value.ToString()
            Dim valueufiyat As Double = Convert.ToDouble(selectedRow.Cells(1).Value)
            Dim valueuadet As Integer = nudadet.Value

            Dim query As String = "INSERT INTO Siparis (SiparisTarih, Personelid,urunid, urunturu, urunad, urunfiyat, urunadet, masano, siparisdurum) VALUES (GETDATE(), @personelno, @urunid,@uturu,@uad,@ufiyat,@uadet,@masano, 'aktif')"
            Dim queryuid As String = "Select UrunID Urunler WHERE UrunAd = @uad"
            Dim urunid As Integer
            Integer.TryParse(queryuid.ToString(), urunid)

            ' SqlCommand oluşturun
            Dim command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@personelno", Username)
            command.Parameters.AddWithValue("@urunid", urunid)
            command.Parameters.AddWithValue("@uturu", valueuturu)
            command.Parameters.AddWithValue("@uad", valueuad)
            command.Parameters.AddWithValue("@ufiyat", valueufiyat)
            command.Parameters.AddWithValue("@uadet", valueuadet)
            command.Parameters.AddWithValue("@masano", masano)

            ' Sorguyu çalıştırın
            command.ExecuteNonQuery()

            ' Kaynakları temizleyin
            command.Dispose()
            databasebaglanti.CloseConnection()
            siparisler()
            MessageBox.Show("Veriler başarıyla eklendi.")
        End If
    End Sub

    Private Sub dtgvuturu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvuturu.CellClick
        Dim selectedRowIndex As Integer = e.RowIndex
        Dim value As String = dtgvuturu.Rows(selectedRowIndex).Cells(0).Value.ToString()




        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT DISTINCT(UrunAd), UrunFiyat FROM Urunler WHERE UrunTuru = @Urunturu"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            command.Parameters.AddWithValue("@Urunturu", value)
            adapter.Fill(dataTable)
        End Using

        dtgvuadfiyat.DataSource = dataTable
    End Sub

    Private Sub btnarttir_Click(sender As Object, e As EventArgs) Handles btnarttir.Click
        If nudadet.Value >= 1 AndAlso nudadet.Value < 15 Then
            nudadet.Value += 1
        Else
            Return
        End If
    End Sub

    Private Sub btneksilt_Click(sender As Object, e As EventArgs) Handles btneksilt.Click
        If nudadet.Value > 1 AndAlso nudadet.Value <= 15 Then
            nudadet.Value -= 1
        Else
            Return
        End If
    End Sub

    Private Sub btnDurdur_Click_1(sender As Object, e As EventArgs) Handles btnDurdur.Click
        Dim odemefrm As New OdemeForm()
        odemefrm.masanumara = masano
        odemefrm.perno = Username
        odemefrm.Show()

    End Sub

    Private Sub btnBaslat_Click(sender As Object, e As EventArgs) Handles btnBaslat.Click
        If String.IsNullOrEmpty(selectedRadioButtonName) Then
            MessageBox.Show("Lütfen bir radio buton seçin.")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Masa SET MasaDurum = 'dolu', MasaBasTarih = GETDATE() WHERE MasaButon = @RadioButtonName"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@RadioButtonName", selectedRadioButtonName)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Masa durumu başarıyla güncellendi.")
                    Else
                        MessageBox.Show("Masa durumu güncellenirken bir hata oluştu.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error executing SQL query: " & ex.Message)
        End Try
        LoadRadioButtonsFromDatabase()
    End Sub
End Class