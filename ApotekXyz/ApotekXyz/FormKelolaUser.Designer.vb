<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKelolaUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKelolaUser))
        Me.tipeUser = New System.Windows.Forms.ComboBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pencarian = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.telpon = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.kelolaLaporan = New System.Windows.Forms.Button()
        Me.kelolaObat = New System.Windows.Forms.Button()
        Me.kelolaUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tipeUser
        '
        Me.tipeUser.FormattingEnabled = True
        Me.tipeUser.Location = New System.Drawing.Point(243, 81)
        Me.tipeUser.Name = "tipeUser"
        Me.tipeUser.Size = New System.Drawing.Size(215, 21)
        Me.tipeUser.TabIndex = 1
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(398, 217)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(65, 26)
        Me.btnHapus.TabIndex = 9
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(327, 217)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(65, 26)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(246, 217)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 27)
        Me.btnTambah.TabIndex = 7
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(246, 268)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(517, 170)
        Me.dgv.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Telepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(494, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Cari User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(545, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(458, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Kelola User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(545, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tipe User"
        '
        'pencarian
        '
        Me.pencarian.Location = New System.Drawing.Point(550, 220)
        Me.pencarian.Name = "pencarian"
        Me.pencarian.Size = New System.Drawing.Size(210, 20)
        Me.pencarian.TabIndex = 11
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(548, 130)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(212, 20)
        Me.username.TabIndex = 5
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(548, 82)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(212, 20)
        Me.alamat.TabIndex = 4
        '
        'telpon
        '
        Me.telpon.Location = New System.Drawing.Point(243, 178)
        Me.telpon.Name = "telpon"
        Me.telpon.Size = New System.Drawing.Size(212, 20)
        Me.telpon.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Location = New System.Drawing.Point(497, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 142)
        Me.Panel2.TabIndex = 9
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(548, 178)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(212, 20)
        Me.password.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(545, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Password"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(243, 130)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(212, 20)
        Me.nama.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.kelolaLaporan)
        Me.Panel1.Controls.Add(Me.kelolaObat)
        Me.Panel1.Controls.Add(Me.kelolaUser)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 450)
        Me.Panel1.TabIndex = 27
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(12, 388)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(172, 50)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'kelolaLaporan
        '
        Me.kelolaLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaLaporan.Location = New System.Drawing.Point(12, 331)
        Me.kelolaLaporan.Name = "kelolaLaporan"
        Me.kelolaLaporan.Size = New System.Drawing.Size(172, 51)
        Me.kelolaLaporan.TabIndex = 15
        Me.kelolaLaporan.Text = "Kelola Laporan"
        Me.kelolaLaporan.UseVisualStyleBackColor = True
        '
        'kelolaObat
        '
        Me.kelolaObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaObat.Location = New System.Drawing.Point(12, 277)
        Me.kelolaObat.Name = "kelolaObat"
        Me.kelolaObat.Size = New System.Drawing.Size(172, 48)
        Me.kelolaObat.TabIndex = 14
        Me.kelolaObat.Text = "Kelola Obat"
        Me.kelolaObat.UseVisualStyleBackColor = True
        '
        'kelolaUser
        '
        Me.kelolaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaUser.Location = New System.Drawing.Point(12, 220)
        Me.kelolaUser.Name = "kelolaUser"
        Me.kelolaUser.Size = New System.Drawing.Size(172, 51)
        Me.kelolaUser.TabIndex = 13
        Me.kelolaUser.Text = "Kelola User"
        Me.kelolaUser.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormKelolaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tipeUser)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pencarian)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.telpon)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormKelolaUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKelolaUser"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tipeUser As ComboBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pencarian As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents alamat As TextBox
    Friend WithEvents telpon As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents password As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents kelolaLaporan As Button
    Friend WithEvents kelolaObat As Button
    Friend WithEvents kelolaUser As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
