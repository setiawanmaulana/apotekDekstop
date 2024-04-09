<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.kelolaLaporan = New System.Windows.Forms.Button()
        Me.kelolaObat = New System.Windows.Forms.Button()
        Me.kelolaUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(12, 388)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(172, 50)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'kelolaLaporan
        '
        Me.kelolaLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaLaporan.Location = New System.Drawing.Point(12, 331)
        Me.kelolaLaporan.Name = "kelolaLaporan"
        Me.kelolaLaporan.Size = New System.Drawing.Size(172, 51)
        Me.kelolaLaporan.TabIndex = 1
        Me.kelolaLaporan.Text = "Kelola Laporan"
        Me.kelolaLaporan.UseVisualStyleBackColor = True
        '
        'kelolaObat
        '
        Me.kelolaObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaObat.Location = New System.Drawing.Point(12, 277)
        Me.kelolaObat.Name = "kelolaObat"
        Me.kelolaObat.Size = New System.Drawing.Size(172, 48)
        Me.kelolaObat.TabIndex = 1
        Me.kelolaObat.Text = "Kelola Obat"
        Me.kelolaObat.UseVisualStyleBackColor = True
        '
        'kelolaUser
        '
        Me.kelolaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kelolaUser.Location = New System.Drawing.Point(12, 220)
        Me.kelolaUser.Name = "kelolaUser"
        Me.kelolaUser.Size = New System.Drawing.Size(172, 51)
        Me.kelolaUser.TabIndex = 1
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(449, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Log Activity"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(242, 69)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(515, 313)
        Me.dgv.TabIndex = 19
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLoad.FlatAppearance.BorderSize = 0
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(647, 399)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 27)
        Me.btnLoad.TabIndex = 21
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Tampilkan Per."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DateTimePicker1.CustomFormat = "dddd, dd MMMM yyyy"
        Me.DateTimePicker1.Location = New System.Drawing.Point(365, 402)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdmin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents kelolaLaporan As Button
    Friend WithEvents kelolaObat As Button
    Friend WithEvents kelolaUser As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
