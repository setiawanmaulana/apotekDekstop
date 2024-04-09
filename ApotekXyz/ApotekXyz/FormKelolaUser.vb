Imports System.Data.SqlClient

Public Class FormKelolaUser
    Private Sub FormKelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
        tipeUser.Items.AddRange({"admin", "apoteker", "kasir"})
    End Sub

    Sub kondisiawal()
        Call munculGrid()
        tipeUser.Text = ""
        nama.Text = ""
        telpon.Text = ""
        alamat.Text = ""
        username.Text = ""
        password.Text = ""
        pencarian.Text = ""
    End Sub

    Private Sub munculGrid()
        Call koneksi()
        Da = New SqlDataAdapter("select * from TblUser", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TblUser")
        dgv.DataSource = Ds.Tables("TblUser")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tipeUser.Text = "" Or nama.Text = "" Or telpon.Text = "" Or alamat.Text = "" Or username.Text = "" Or password.Text = "" Then
            MessageBox.Show("Semua data dibutuhkan,Tolong isi terlebih dahulu.", "Pemberitahuan", MessageBoxButtons.OK)
        Else
            Call koneksi()
            Cmd = New SqlCommand("insert into TblUser values ('" & tipeUser.Text & "','" & nama.Text & "','" & alamat.Text & "','" & telpon.Text & "','" & username.Text & "','" & password.Text & "')", Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan", "Pemberitahuan", MessageBoxButtons.OK)
            Call kondisiawal()
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer = dgv.CurrentRow.Index
        Call koneksi()
        Cmd = New SqlCommand("select * from TblUser where IdUser = '" & dgv.Item(0, i).Value & "'", Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read Then
            tipeUser.Text = Rd!TipeUser
            nama.Text = Rd!NamaUser
            telpon.Text = Rd!Telpon
            alamat.Text = Rd!Alamat
            username.Text = Rd!Username
            password.Text = Rd!Password
            On Error Resume Next
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If tipeUser.Text = "" Or nama.Text = "" Or telpon.Text = "" Or alamat.Text = "" Or username.Text = "" Or password.Text = "" Then
            MessageBox.Show("Mohon pilih data yang ingin diedit terlebih dahulu.", "Pemberitahuan", MessageBoxButtons.OK)
        Else
            Dim i As Integer = dgv.CurrentRow.Index
            Call koneksi()
            Cmd = New SqlCommand("update TblUser set TipeUser= '" & tipeUser.Text & "',NamaUser= '" & nama.Text & "',Telpon= '" & telpon.Text & "',Alamat= '" & alamat.Text & "',Username= '" & username.Text & "',Password= '" & password.Text & "' where IdUser = '" & dgv.Item(0, i).Value & "'", Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diedit", "Pemberitahuan", MessageBoxButtons.OK)
            Call kondisiawal()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If tipeUser.Text = "" Or nama.Text = "" Or telpon.Text = "" Or alamat.Text = "" Or username.Text = "" Or password.Text = "" Then
            MessageBox.Show("Mohon pilih data yang ingin dihapus terlebih dahulu.", "Pemberitahuan", MessageBoxButtons.OK)
        Else
            Dim pesan As String = MessageBox.Show("Yakin ingin Menghapus?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Dim i As Integer = dgv.CurrentRow.Index
                Call koneksi()
                Cmd = New SqlCommand("delete from TblUser where IdUser = '" & dgv.Item(0, i).Value & "'", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus", "Pemberitahuan", MessageBoxButtons.OK)
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub pencarian_TextChanged(sender As Object, e As EventArgs) Handles pencarian.TextChanged
        Try
            Call koneksi()
            Da = New SqlDataAdapter("select * from TblUser where NamaUser like '%" & pencarian.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "TblUser")
            dgv.DataSource = Ds.Tables("TblUser")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub kelolaUser_Click(sender As Object, e As EventArgs) Handles kelolaUser.Click
        MessageBox.Show("Kamu sudah di menu Kelola User!", "Pemberitahuan")
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
            munculGrid()
            FormLogin.Show()
            FormLogin.kondisiawal()
            FormLogin.insertLog(FormLogin.IdUserLogin, FormLogin.UserLogin, "Logout")
        End If
    End Sub

    Public Sub formatNumeric(ByVal e As Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            MessageBox.Show("Field ini hanya menerima angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub telpon_KeyPress(sender As Object, e As EventArgs) Handles telpon.KeyPress
        formatNumeric(e)
    End Sub
End Class