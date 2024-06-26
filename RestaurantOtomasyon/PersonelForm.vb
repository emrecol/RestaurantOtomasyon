Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PersonelForm
    Private databasebaglanti As DatabaseBaglanti

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=DESKTOP-59UNT62\SQLEXPRESS;Initial Catalog=db_Restaurant;Integrated Security=True"
        databasebaglanti = New DatabaseBaglanti(connectionString)
        VerileriAl()
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        ' Kullanıcıdan alınan verileri textbox'lardan okuyun

        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox2.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox3.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox4.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox5.Text) AndAlso
       ComboBox1.SelectedItem IsNot Nothing Then

            Dim userType As String = ""
            If ComboBox1.SelectedItem IsNot Nothing Then
                If ComboBox1.SelectedItem.ToString() = "ADMİN" Then
                    userType = "AD"
                ElseIf ComboBox1.SelectedItem.ToString() = "PERSONEL" Then
                    userType = "PR"
                End If
            End If

            Dim value1 As String = TextBox1.Text
            Dim value2 As String = TextBox2.Text
            Dim value3 As String = TextBox3.Text
            Dim value4 As String = TextBox4.Text
            Dim value5 As String = TextBox5.Text

            ' Veri ekleme sorgusunu oluşturun
            Dim query As String = "INSERT INTO Personel (per_ad, per_soyad, per_username, per_password, per_email, per_yetki) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)"

            ' SqlCommand oluşturun
            Dim command As New SqlCommand(query, connection)

            ' Parametreleri ekleyin
            command.Parameters.AddWithValue("@Value1", value1)
            command.Parameters.AddWithValue("@Value2", value2)
            command.Parameters.AddWithValue("@Value3", value3)
            command.Parameters.AddWithValue("@Value4", value4)
            command.Parameters.AddWithValue("@Value5", value5)
            command.Parameters.AddWithValue("@Value6", userType)

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

    Private Sub VerileriAl()
        Dim dataTable As New DataTable()
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        Dim query As String = "SELECT per_ad, per_soyad, per_username, per_password, per_yetki, per_email FROM Personel"
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using


        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        ' Kullanıcıdan alınan verileri textbox'lardan okuyun

        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox2.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox3.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox4.Text) AndAlso
       Not String.IsNullOrWhiteSpace(TextBox5.Text) AndAlso
       ComboBox1.SelectedItem IsNot Nothing Then

            Dim userType As String = ""
            If ComboBox1.SelectedItem IsNot Nothing Then
                If ComboBox1.SelectedItem.ToString() = "ADMİN" Then
                    userType = "AD"
                ElseIf ComboBox1.SelectedItem.ToString() = "PERSONEL" Then
                    userType = "PR"
                End If
            End If

            Dim value1 As String = TextBox1.Text
            Dim value2 As String = TextBox2.Text
            Dim value3 As String = TextBox3.Text
            Dim value4 As String = TextBox4.Text
            Dim value5 As String = TextBox5.Text

            ' Veri ekleme sorgusunu oluşturun
            Dim query As String = "UPDATE Personel SET per_ad = @Value1, per_soyad = @Value2, per_username = @Value3, per_password = @Value4, per_email = @Value5 ,per_yetki = @Value6 WHERE per_username = @Value3"
            ' SqlCommand oluşturun
            Dim command As New SqlCommand(query, connection)

            ' Parametreleri ekleyin
            command.Parameters.AddWithValue("@Value1", value1)
            command.Parameters.AddWithValue("@Value2", value2)
            command.Parameters.AddWithValue("@Value3", value3)
            command.Parameters.AddWithValue("@Value4", value4)
            command.Parameters.AddWithValue("@Value5", value5)
            command.Parameters.AddWithValue("@Value6", userType)

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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim selectedRowIndex As Integer = e.RowIndex

        ' Seçili satırın geçerli olduğundan emin olun
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < DataGridView1.Rows.Count Then
            ' Seçili satırdaki hücrelerden değerleri alın
            Dim value1 As String = DataGridView1.Rows(selectedRowIndex).Cells(0).Value.ToString()
            Dim value2 As String = DataGridView1.Rows(selectedRowIndex).Cells(1).Value.ToString()
            Dim value3 As String = DataGridView1.Rows(selectedRowIndex).Cells(2).Value.ToString()
            Dim value4 As String = DataGridView1.Rows(selectedRowIndex).Cells(3).Value.ToString()
            Dim value5 As String = DataGridView1.Rows(selectedRowIndex).Cells(5).Value.ToString()
            Dim userType As String = DataGridView1.Rows(selectedRowIndex).Cells(4).Value.ToString()



            ' TextBox'lara ve ComboBox'a değerleri yerleştirin
            TextBox1.Text = value1
            TextBox2.Text = value2
            TextBox3.Text = value3
            TextBox4.Text = value4
            TextBox5.Text = value5

            If userType = "PR" Then
                ComboBox1.SelectedItem = "PERSONEL"
            ElseIf userType = "AD" Then
                ComboBox1.SelectedItem = "ADMİN"
            End If
        End If
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        ' Veritabanı bağlantısını açın
        Dim connection As SqlConnection = databasebaglanti.OpenConnection()

        ' Kullanıcıdan alınan verileri kontrol edin
        If Not String.IsNullOrWhiteSpace(TextBox3.Text) Then
            ' Silinecek kaydın kullanıcı adını alın
            Dim kullaniciAdi As String = TextBox3.Text

            ' Silme sorgusunu oluşturun
            Dim query As String = "DELETE FROM Personel WHERE per_username = @KullaniciAdi"

            ' SqlCommand'u oluşturun
            Dim command As New SqlCommand(query, connection)

            ' Parametreyi ekleyin
            command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi)

            ' Sorguyu çalıştırın
            Dim affectedRows As Integer = command.ExecuteNonQuery()

            ' Kayıt silindi mi kontrol edin
            If affectedRows > 0 Then
                MessageBox.Show("Kayıt başarıyla silindi.")
            Else
                MessageBox.Show("Silinecek kayıt bulunamadı veya silme işlemi gerçekleşmedi.")
            End If

            ' Kaynakları temizleyin
            command.Dispose()
        Else
            ' Eğer kullanıcı adı boşsa, kullanıcıya bir uyarı gösterin
            MessageBox.Show("Lütfen bir kullanıcı adı girin!")
        End If

        ' Veritabanı bağlantısını kapatın
        databasebaglanti.CloseConnection()

        ' Verileri yeniden yükleme işlemi
        VerileriAl()
    End Sub
End Class
