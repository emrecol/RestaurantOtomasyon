Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class AdminForm

    Private databasebaglanti As DatabaseBaglanti

    ' Mevcut butonlarınızı buraya ekleyin
    Private buttons() As Windows.Forms.Button
    Private spacing As Integer = 15 ' Butonlar arasındaki boşluk
    Private sideSpacing As Integer = 20 ' Butonlar ile panelin kenarları arasındaki boşluk

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=DESKTOP-59UNT62\SQLEXPRESS;Initial Catalog=db_Restaurant;Integrated Security=True"
        databasebaglanti = New DatabaseBaglanti(connectionString)
        VerileriAl()

        ' Mevcut butonları diziye ekleyin
        buttons = New Windows.Forms.Button() {btnCorba, btnArasicak, btnAnayemek, btnTatli, btnİcecek}

        ' Panelin Resize olayını tanımla
        AddHandler Panel3.Resize, AddressOf Panel3_Resize

        ' Başlangıçta bir kez boyutlandırma işlemi yap
        ResizeButtons()

    End Sub

    Private Sub Panel3_Resize(sender As Object, e As EventArgs)
        ' Panel yeniden boyutlandırıldığında butonları yeniden boyutlandır
        ResizeButtons()
    End Sub

    Private Sub ResizeButtons()
        ' Panelin yeni genişliğini ve yüksekliğini al
        Dim panelWidth As Integer = Panel3.ClientSize.Width
        Dim panelHeight As Integer = Panel3.ClientSize.Height

        ' Her bir butonun genişliğini hesapla
        Dim totalSpacing As Integer = spacing * (buttons.Length - 1) + sideSpacing * 2
        Dim buttonWidth As Integer = (panelWidth - totalSpacing) \ buttons.Length
        Dim buttonHeight As Integer = panelHeight \ 2

        ' Butonların boyutunu ve konumunu ayarla
        For i As Integer = 0 To buttons.Length - 1
            buttons(i).Width = buttonWidth
            buttons(i).Height = buttonHeight
            buttons(i).Left = sideSpacing + i * (buttonWidth + spacing)

            ' Panelin yüksekliğine ortala
            buttons(i).Top = (panelHeight - buttonHeight) \ 2
        Next
    End Sub


    Private Sub VerileriAl()
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT UrunAd, UrunFiyat, UrunTuru  FROM Urunler"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using


        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim selectedRowIndex As Integer = e.RowIndex

        ' Seçili satırın geçerli olduğundan emin olun
        If selectedRowIndex >= 0 Then
            ' Seçili satırdaki hücrelerden değerleri alın
            Dim value1 As String = DataGridView1.Rows(selectedRowIndex).Cells(0).Value.ToString()
            Dim value2 As String = DataGridView1.Rows(selectedRowIndex).Cells(1).Value.ToString()
            Dim foodType As String = DataGridView1.Rows(selectedRowIndex).Cells(2).Value.ToString()

            ' TextBox'lara ve ComboBox'a değerleri yerleştirin
            TextBox1.Text = value1
            TextBox2.Text = value2

            If foodType = "corba" Then
                ComboBox1.SelectedIndex = 0
            ElseIf foodType = "anayemek" Then
                ComboBox1.SelectedIndex = 1
            ElseIf foodType = "arasicak" Then
                ComboBox1.SelectedIndex = 2
            ElseIf foodType = "tatli" Then
                ComboBox1.SelectedIndex = 3
            ElseIf foodType = "icecek" Then
                ComboBox1.SelectedIndex = 4
            End If
        End If
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        ' Kullanıcıdan alınan verileri textbox'lardan okuyun

        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox2.Text) AndAlso
       ComboBox1.SelectedItem IsNot Nothing Then

            Dim foodType As String = ""
            If ComboBox1.SelectedItem = "ÇORBA" Then
                foodType = "corba"
            ElseIf ComboBox1.SelectedItem = "ANA YEMEK" Then
                foodType = "anayemek"
            ElseIf ComboBox1.SelectedItem = "ARA SICAK" Then
                foodType = "arasicak"
            ElseIf ComboBox1.SelectedItem = "TATLI" Then
                foodType = "tatli"
            ElseIf ComboBox1.SelectedItem = "İÇECEK" Then
                foodType = "icecek"
            End If

            Dim value1 As String = TextBox1.Text
            Dim value2 As String = TextBox2.Text
            Dim value3 As String = ComboBox1.Text

            ' Veri ekleme sorgusunu oluşturun
            Dim query As String = "INSERT INTO Urunler (UrunAd, UrunFiyat, UrunTuru) VALUES (@Value1, @Value2, @Value3)"

            ' SqlCommand oluşturun
            Dim command As New SqlCommand(query, connection)

            ' Parametreleri ekleyin
            command.Parameters.AddWithValue("@Value1", value1)
            command.Parameters.AddWithValue("@Value2", value2)
            command.Parameters.AddWithValue("@Value3", foodType)

            ' Sorguyu çalıştırın
            command.ExecuteNonQuery()

            ' Kaynakları temizleyin
            command.Dispose()
            databasebaglanti.CloseConnection()

            MessageBox.Show("Veriler başarıyla eklendi.")

        Else
            MessageBox.Show("Lütfen tüm alanları doldurun!")

        End If
        VerileriAl()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        If TextBox1.Text = "" AndAlso
        TextBox2.Text = "" AndAlso
        ComboBox1.Text = "" Then

            MessageBox.Show("Lütfen tüm alanları doldurun!")
        Else

            Dim uturu As String = ""
            If ComboBox1.SelectedItem IsNot Nothing Then
                If ComboBox1.SelectedItem.ToString() = "ÇORBA" Then
                    uturu = "corba"
                ElseIf ComboBox1.SelectedItem.ToString() = "ANA YEMEK" Then
                    uturu = "anayemek"
                ElseIf ComboBox1.SelectedItem.ToString() = "ARA SICAK" Then
                    uturu = "arasicak"
                ElseIf ComboBox1.SelectedItem.ToString() = "TATLI" Then
                    uturu = "tatli"
                ElseIf ComboBox1.SelectedItem.ToString() = "İÇECEK" Then
                    uturu = "icecek"
                End If
            End If

            Dim uad As String = TextBox1.Text
            Dim ufiyat As Int32 = TextBox2.Text
            Dim urunturu As String = uturu
            'DELETE FROM Urunler WHERE UrunAd = @uad, UrunFiyat = @ufiyat, UrunTuru = @uturu
            Dim sorgu As String = "UPDATE Urunler SET UrunAd = @uad, UrunFiyat = @ufiyat, UrunTuru = @uturu WHERE UrunAd = @uad "

            Dim command As New SqlCommand(sorgu, connection)

            command.Parameters.AddWithValue("@uad", uad)
            command.Parameters.AddWithValue("@ufiyat", ufiyat)
            command.Parameters.AddWithValue("@uturu", urunturu)

            ' Sorguyu çalıştırın
            command.ExecuteNonQuery()

            ' Kaynakları temizleyin
            command.Dispose()
            databasebaglanti.CloseConnection()
            VerileriAl()

            MessageBox.Show("Kayıt başarıyla güncellendi.")

        End If
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        ' Kullanıcıdan alınan verileri textbox'lardan okuyun

        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox2.Text) AndAlso
       ComboBox1.SelectedItem IsNot Nothing Then

            Dim foodType As String = ""
            If ComboBox1.SelectedItem = "ÇORBA" Then
                foodType = "corba"
            ElseIf ComboBox1.SelectedItem = "ANA YEMEK" Then
                foodType = "anayemek"
            ElseIf ComboBox1.SelectedItem = "ARA SICAK" Then
                foodType = "arasicak"
            ElseIf ComboBox1.SelectedItem = "TATLI" Then
                foodType = "tatli"
            ElseIf ComboBox1.SelectedItem = "İÇECEK" Then
                foodType = "icecek"
            End If

            Dim value1 As String = TextBox1.Text
            Dim value2 As Double = TextBox2.Text
            Dim value3 As String = ComboBox1.Text

            ' Veri ekleme sorgusunu oluşturun
            Dim query As String = "DELETE FROM Urunler WHERE UrunAd = @Value1 AND UrunFiyat = @Value2 AND UrunTuru = @Value3"

            ' SqlCommand oluşturun
            Dim command As New SqlCommand(query, connection)

            ' Parametreleri ekleyin
            command.Parameters.AddWithValue("@Value1", value1)
            command.Parameters.AddWithValue("@Value2", value2)
            command.Parameters.AddWithValue("@Value3", foodType)

            ' Sorguyu çalıştırın
            command.ExecuteNonQuery()

            ' Kaynakları temizleyin
            command.Dispose()
            databasebaglanti.CloseConnection()

            MessageBox.Show("Veriler başarıyla eklendi.")

        Else
            MessageBox.Show("Lütfen tüm alanları doldurun!")

        End If
        VerileriAl()
    End Sub

    Private Sub btnCorba_Click(sender As Object, e As EventArgs) Handles btnCorba.Click
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT UrunAd, UrunFiyat, UrunTuru  FROM Urunler WHERE UrunTuru = 'corba'"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub btnArasicak_Click(sender As Object, e As EventArgs) Handles btnArasicak.Click
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT UrunAd, UrunFiyat, UrunTuru  FROM Urunler WHERE UrunTuru = 'arasicak'"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub btnAnayemek_Click(sender As Object, e As EventArgs) Handles btnAnayemek.Click
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT UrunAd, UrunFiyat, UrunTuru  FROM Urunler WHERE UrunTuru = 'anayemek'"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub btnTatli_Click(sender As Object, e As EventArgs) Handles btnTatli.Click
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT UrunAd, UrunFiyat, UrunTuru  FROM Urunler WHERE UrunTuru = 'tatli'"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub btnİcecek_Click(sender As Object, e As EventArgs) Handles btnİcecek.Click
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT UrunAd, UrunFiyat, UrunTuru  FROM Urunler WHERE UrunTuru = 'icecek'"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub btnZam_Click(sender As Object, e As EventArgs) Handles btnZam.Click

        Dim connection As SqlConnection = databasebaglanti.OpenConnection()
        ' TextBox'tan yüzde oranını al
        Dim percentage As Double
        If Double.TryParse(txtOran.Text, percentage) Then
            ' Yüzde oranını 0.10 şeklinde (yüzde 10) olarak dönüştür
            percentage = percentage / 100

            ' SQL sorgusunu oluştur
            Dim query As String = String.Empty
            If rbtnartizam.Checked Then
                ' RadioButton1 seçiliyse zam yap
                query = "UPDATE Urunler SET UrunFiyat = UrunFiyat * (1 + @PercentageChange)"
            ElseIf rbtneksizam.Checked Then
                ' RadioButton2 seçiliyse indirim yap
                query = "UPDATE Urunler SET UrunFiyat = UrunFiyat * (1 - @PercentageChange)"
            Else
                MessageBox.Show("Lütfen bir işlem seçin.")
                Exit Sub
            End If

            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@PercentageChange", percentage)

            ' Sorguyu çalıştırın
            command.ExecuteNonQuery()

            ' Kaynakları temizleyin
            command.Dispose()
            databasebaglanti.CloseConnection()
            VerileriAl()
            MessageBox.Show("Veriler başarıyla güncellendi.")
        Else
            MessageBox.Show("Lütfen geçerli bir yüzde oranı girin.")
        End If
    End Sub
End Class