Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class Form1
    Dim no_transaksi As Integer
    Dim no_parkir As String
    Dim PlatPolisi As String
    Dim jam_masuk As DateTime
    Dim jam_keluar As DateTime
    Dim tgl_keluar As Date = Date.Now
    Dim biaya_Parkir As Integer
    Dim Deposito As Integer
    Dim Total As Integer
    Sub modestandby()
        Txt_Biaya.Enabled = False
        Txt_JamMasuk.Enabled = False
        Txt_No_Transaksi.Enabled = False
        Txt_No_Parkir.Enabled = True
        Btn_Proses.Enabled = True
        Btn_Save.Enabled = False
        Btn_Clear.Enabled = False
    End Sub

    Sub modeEdit()
        Txt_Biaya.Enabled = True
        Txt_JamMasuk.Enabled = True
        Txt_No_Transaksi.Enabled = False
        Txt_No_Parkir.Enabled = True
        Txt_JamMasuk.Enabled = True
        Btn_Clear.Enabled = True
        Btn_Save.Enabled = True
        Btn_Proses.Enabled = False
    End Sub

    Private Sub Btn_Proses_Click(sender As Object, e As EventArgs) Handles Btn_Proses.Click
        'Proses pengambilan data dari database
        If Txt_No_Parkir.Text = "" Then
            MessageBox.Show("tolong di isi No parkirnya")
        Else
            For x = 0 To no_parkir.Count - 1
                If Txt_No_Parkir.Text = no_parkir Then
                    modeEdit()
                    no_transaksi += 1
                    no_parkir = Txt_No_Parkir.Text
                    Txt_No_Transaksi.Text = no_transaksi
                    'Mendapatkan selisih waktu
                    Dim ts As TimeSpan =
                        (Convert.ToDateTime(Txt_JamKeluar.Text).Subtract(Convert.ToDateTime(Txt_JamMasuk.Text))).Duration()
                    Dim Lama_Parkir As String = [String].Format("{0}", ts.Hours)

                    'Pengecekakn Jenis kendaraan
                    'T = Motor
                    'B = Mobil
                    If no_parkir.Substring(0, 1) = "T" Then
                        If Lama_Parkir > 2 Then
                            biaya_Parkir = (Lama_Parkir - 2) * 500 + 2000
                        Else
                            biaya_Parkir = 2000
                        End If
                    ElseIf no_parkir.Substring(0, 1) = "B" Then
                        If Lama_Parkir > 2 Then
                            biaya_Parkir = (Lama_Parkir - 2) * 1000 + 5000
                        Else
                            biaya_Parkir = 5000
                        End If
                    End If

                    'Pengecekan jenis pelanggan
                    'L = Langganan
                    'U= Umum
                    'K=Karyawan
                    If no_parkir.Substring(1, 1) = "L" Then
                        If Deposito >= 50000 Then
                            biaya_Parkir /= 2
                            Deposito -= biaya_Parkir
                            MessageBox.Show("sisa saldo = " & Deposito)
                        End If
                    ElseIf no_parkir.Substring(1, 1) = "K" Then
                        biaya_Parkir = 0
                        Exit For
                    End If
                    Txt_Biaya.Text = Format(biaya_Parkir, "##,###")
                    Exit For
                Else
                    MessageBox.Show("Maaf Data tidak ditemukkan")
                    Txt_No_Parkir.Clear()
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        'proses pembayaran dan penyimpanan data..ketika tombol ini di klik
        'Dim JnsPelanggan As String
        'Dim JnsKendaraan As String
        'If no_parkir.Substring(1, 1) = "L" Then
        '    JnsPelanggan = "Langganan"
        'ElseIf no_parkir.Substring(1, 1) = "K" Then
        '    JnsPelanggan = "Karyawan"
        'Else
        '    JnsPelanggan = "Umum"
        'End If
        'If no_parkir.Substring(0, 1) = "B" Then
        '    JnsKendaraan = "Mobil"
        'ElseIf no_parkir.Substring(0, 1) = "T" Then
        '    JnsKendaraan = "Motor"
        'End If
        'MessageBox.Show("No Transaksi : " & no_transaksi &
        '            " No Parkir : " & no_parkir &
        '            " Jenis Pelanggan : " & JnsPelanggan &
        '            " Jenis Kendaraan : " & JnsKendaraan &
        '            " Jam Masuk : " & Txt_JamMasuk.Text &
        '            " Jam_Keluar : " & Txt_JamKeluar.Text)
        'anggap saja palang parkir terbuka
        Dim strSql As String
        strSql = "UPDATE Parkir SET No_parkir='{0}', Jam_keluar='{1}', Tgl_keluar='{2}' WHERE No_parkir='{3}'"
        strSql = String.Format(strSql, no_parkir, jam_keluar)
        Me.Parkir.executeSQL(strSql)


        Dim strCon As String = "Data Source = .\ SQLEXPRESS;Initial Catalog=IdamanParkirDb2;Integrated Security=True"
        Dim con As New SqlConnection(strCon)
        Dim comm As New SqlCommand
        con.Open()
        comm.CommandText = "SELECT Deposit FROM Pelanggan WHERE Kd_pelanggan='" & TxtKdPel.Text & "'"
        comm.Connection = con
        Dim UangDeposit As Object = comm.ExecuteScalar()
        TxtUangDeposit.Text = UangDeposit
        modestandby()
        Txt_Biaya.Clear()
        Txt_JamMasuk.Clear()
        Txt_No_Transaksi.Clear()
        Txt_No_Parkir.Clear()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Txt_Biaya.Clear()
        Txt_JamMasuk.Clear()
        Txt_No_Transaksi.Clear()
        Txt_No_Parkir.Clear()
        If no_transaksi = 0 Then
            MessageBox.Show("tidak ada transaksi")
        Else
            no_transaksi -= 1
        End If
        modestandby()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Txt_JamKeluar.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Txt_JamMasuk.Text = Format("00:00:00")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_Tanggal_Keluar.Text = tgl_keluar.ToString("yyyy-MM-dd")
    End Sub
End Class
