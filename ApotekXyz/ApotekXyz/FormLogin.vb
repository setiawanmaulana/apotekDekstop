Imports System.Data.SqlClient
Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub
    Sub kondisiawal()
        txtPassword.Text = ""
        txtUsername.Text = ""
        CheckBox1.Checked = False
        txtPassword.PasswordChar = "*"
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call kondisiawal()
    End Sub
    Public Property UserLogin As String
    Public Property IdUserLogin As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" OrElse txtPassword.Text = "" Then
            MessageBox.Show("Username dan Password Wajib di Isi!", "Peringatan")
        Else
            Dim username As String
            Dim idUser As Integer

            Call Koneksi()
            Cmd = New SqlCommand("Select * From TblUser where Username = '" & txtUsername.Text & "'", Conn)
            Rd = Cmd.ExecuteReader

            If Rd.Read() Then
                username = Rd!Username
                idUser = Rd!IdUser

                If txtPassword.Text = Rd!Password.ToString.Trim Then
                    If Rd!TipeUser.ToString = "admin" Then
                        insertLog(idUser, username, "Login")
                        Me.Hide()
                        FormAdmin.Show()
                    ElseIf Rd!TipeUser.ToString = "apoteker" Then
                        insertLog(idUser, username, "Login")
                        Me.Hide()
                        FormApoteker.Show()
                    ElseIf Rd!TipeUser.ToString = "kasir" Then
                        insertLog(idUser, username, "Login")
                        Me.Hide()
                        FormKasir.Show()
                        FormKasir.namaKasir.Text = username
                    End If
                    UserLogin = username
                    IdUserLogin = idUser
                Else
                    MessageBox.Show("Password Salah")
                End If
            Else
                MessageBox.Show("Username salah atau tidak Ada!")
            End If
        End If
    End Sub

    Public Sub insertLog(ByVal idUser As Integer, ByVal username As String, ByVal aktivitas As String)
        Call Koneksi()
        Dim timeNow As String = DateTime.Now.ToString("yyyy-MM-dd h:mm")
        Cmd = New SqlCommand($"INSERT INTO LogActivity (Waktu,IdUser,Username,Aktivitas) VALUES ('{timeNow}', {idUser}, '{username}', '{aktivitas}')", Conn)
        Cmd.ExecuteNonQuery()
    End Sub
End Class
