Imports System.Data.SqlClient

Public Class FormKelolaLaporan
    Private Sub FormKelolaLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub

    Private Sub kondisiawal()
        Call munculgrid()
        Chart1.Series("Omset").Points.Clear()
    End Sub

    Private Sub munculgrid()
        Call koneksi()
        Da = New SqlDataAdapter("select NoTransaksi,TglTransaksi,TotalBayar from TblTransaksi", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TblTransaksi")
        dgv.DataSource = Ds.Tables("TblTransaksi")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim startDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        Call koneksi()
        Da = New SqlDataAdapter("select NoTransaksi,TglTransaksi,TotalBayar from TblTransaksi where TglTransaksi between '" & startDate & "' and '" & endDate & "' order by TglTransaksi", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TblTransaksi")
        dgv.DataSource = Ds.Tables("TblTransaksi")
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim startDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        Call koneksi()
        Cmd = New SqlCommand("select NoTransaksi,TglTransaksi,TotalBayar from TblTransaksi where TglTransaksi between '" & startDate & "' and '" & endDate & "' order by TglTransaksi", Conn)
        Rd = Cmd.ExecuteReader
        Chart1.Series("Omset").Points.Clear()
        While Rd.Read
            Chart1.Series("Omset").Points.AddXY(Format(Rd!TglTransaksi, "yyyy-MM-dd").ToString, Rd!TotalBayar)
        End While
        Rd.Close()
    End Sub
    Private Sub kelolaUser_Click(sender As Object, e As EventArgs) Handles kelolaUser.Click
        Me.Close()
        FormKelolaUser.Show()
    End Sub

    Private Sub kelolaObat_Click(sender As Object, e As EventArgs) Handles kelolaObat.Click
        Me.Close()
        FormKelolaObat.Show()
    End Sub

    Private Sub kelolaLaporan_Click(sender As Object, e As EventArgs) Handles kelolaLaporan.Click
        MessageBox.Show("Kamu sudah di menu Kelola Laporan!", "Pemberitahuan")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim pesan As String = MessageBox.Show("Yakin ingin Logout?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pesan = vbYes Then
            Me.Close()
            munculgrid()
            FormLogin.Show()
            FormLogin.kondisiawal()
            FormLogin.insertLog(FormLogin.IdUserLogin, FormLogin.UserLogin, "Logout")
        End If
    End Sub
End Class