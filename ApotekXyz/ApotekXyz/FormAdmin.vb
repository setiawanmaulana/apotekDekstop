Imports System.Data.SqlClient

Public Class FormAdmin
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call munculgrid()
    End Sub

    Sub munculgrid()
        Call koneksi()
        Da = New SqlDataAdapter("Select IdLog,Username,Waktu,Aktivitas from LogActivity", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "LogActivity")
        dgv.DataSource = Ds.Tables("LogActivity")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim formatTanggal As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        Call koneksi()
        Da = New SqlDataAdapter("Select IdLog,Username,Waktu,Aktivitas from LogActivity where convert(date,Waktu) = '" & formatTanggal & "' ", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "LogActivity")
        dgv.DataSource = Ds.Tables("LogActivity")
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
        Me.Close()
        FormKelolaLaporan.Show()
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