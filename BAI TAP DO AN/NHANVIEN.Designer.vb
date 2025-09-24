<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NHANVIEN
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTCHUCVU = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTLUONG = New System.Windows.Forms.TextBox()
        Me.CMBGIOITINH = New System.Windows.Forms.ComboBox()
        Me.BTNTHEM = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTCCCD = New System.Windows.Forms.TextBox()
        Me.TXTDIACHI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTSDT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTTENNHANVIEN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNLAMMOI = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNXOA = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSUA = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTCHUCVU)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXTLUONG)
        Me.GroupBox1.Controls.Add(Me.CMBGIOITINH)
        Me.GroupBox1.Controls.Add(Me.BTNTHEM)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DTP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTCCCD)
        Me.GroupBox1.Controls.Add(Me.TXTDIACHI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTSDT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTTENNHANVIEN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 712)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thêm Nhân Viên :"
        '
        'TXTCHUCVU
        '
        Me.TXTCHUCVU.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCHUCVU.Location = New System.Drawing.Point(15, 216)
        Me.TXTCHUCVU.Name = "TXTCHUCVU"
        Me.TXTCHUCVU.Size = New System.Drawing.Size(221, 28)
        Me.TXTCHUCVU.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Lương :"
        '
        'TXTLUONG
        '
        Me.TXTLUONG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLUONG.Location = New System.Drawing.Point(15, 440)
        Me.TXTLUONG.Name = "TXTLUONG"
        Me.TXTLUONG.Size = New System.Drawing.Size(164, 28)
        Me.TXTLUONG.TabIndex = 17
        '
        'CMBGIOITINH
        '
        Me.CMBGIOITINH.FormattingEnabled = True
        Me.CMBGIOITINH.Location = New System.Drawing.Point(15, 570)
        Me.CMBGIOITINH.Name = "CMBGIOITINH"
        Me.CMBGIOITINH.Size = New System.Drawing.Size(151, 37)
        Me.CMBGIOITINH.TabIndex = 15
        '
        'BTNTHEM
        '
        Me.BTNTHEM.BorderRadius = 20
        Me.BTNTHEM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNTHEM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNTHEM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNTHEM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNTHEM.FillColor = System.Drawing.Color.AliceBlue
        Me.BTNTHEM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTHEM.ForeColor = System.Drawing.Color.Black
        Me.BTNTHEM.Location = New System.Drawing.Point(291, 455)
        Me.BTNTHEM.Name = "BTNTHEM"
        Me.BTNTHEM.Size = New System.Drawing.Size(195, 96)
        Me.BTNTHEM.TabIndex = 14
        Me.BTNTHEM.Text = "Thêm Nhân Viên"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Chức Vụ :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Giới Tính :"
        '
        'DTP
        '
        Me.DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Location = New System.Drawing.Point(15, 287)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(348, 28)
        Me.DTP.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CCCD :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ngày Sinh :"
        '
        'TXTCCCD
        '
        Me.TXTCCCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCCCD.Location = New System.Drawing.Point(15, 375)
        Me.TXTCCCD.Name = "TXTCCCD"
        Me.TXTCCCD.Size = New System.Drawing.Size(164, 28)
        Me.TXTCCCD.TabIndex = 6
        '
        'TXTDIACHI
        '
        Me.TXTDIACHI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDIACHI.Location = New System.Drawing.Point(15, 506)
        Me.TXTDIACHI.Name = "TXTDIACHI"
        Me.TXTDIACHI.Size = New System.Drawing.Size(164, 28)
        Me.TXTDIACHI.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 481)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Địa Chỉ :"
        '
        'TXTSDT
        '
        Me.TXTSDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSDT.Location = New System.Drawing.Point(15, 151)
        Me.TXTSDT.Name = "TXTSDT"
        Me.TXTSDT.Size = New System.Drawing.Size(221, 28)
        Me.TXTSDT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Số Điện Thoại :"
        '
        'TXTTENNHANVIEN
        '
        Me.TXTTENNHANVIEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTENNHANVIEN.Location = New System.Drawing.Point(10, 63)
        Me.TXTTENNHANVIEN.Name = "TXTTENNHANVIEN"
        Me.TXTTENNHANVIEN.Size = New System.Drawing.Size(303, 28)
        Me.TXTTENNHANVIEN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Nhân Viên :"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(523, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(985, 976)
        Me.DataGridView1.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNLAMMOI)
        Me.GroupBox2.Controls.Add(Me.BTNXOA)
        Me.GroupBox2.Controls.Add(Me.BTNSUA)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 730)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(505, 258)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tính Năng"
        '
        'BTNLAMMOI
        '
        Me.BTNLAMMOI.BorderRadius = 20
        Me.BTNLAMMOI.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNLAMMOI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNLAMMOI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNLAMMOI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLAMMOI.FillColor = System.Drawing.Color.AliceBlue
        Me.BTNLAMMOI.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLAMMOI.ForeColor = System.Drawing.Color.Black
        Me.BTNLAMMOI.Location = New System.Drawing.Point(150, 138)
        Me.BTNLAMMOI.Name = "BTNLAMMOI"
        Me.BTNLAMMOI.Size = New System.Drawing.Size(220, 99)
        Me.BTNLAMMOI.TabIndex = 14
        Me.BTNLAMMOI.Text = "Làm Mới"
        '
        'BTNXOA
        '
        Me.BTNXOA.BorderRadius = 20
        Me.BTNXOA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNXOA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNXOA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNXOA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNXOA.FillColor = System.Drawing.Color.AliceBlue
        Me.BTNXOA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNXOA.ForeColor = System.Drawing.Color.Black
        Me.BTNXOA.Location = New System.Drawing.Point(281, 33)
        Me.BTNXOA.Name = "BTNXOA"
        Me.BTNXOA.Size = New System.Drawing.Size(208, 99)
        Me.BTNXOA.TabIndex = 13
        Me.BTNXOA.Text = "Xóa Nhân Viên"
        '
        'BTNSUA
        '
        Me.BTNSUA.BorderRadius = 20
        Me.BTNSUA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNSUA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNSUA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNSUA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNSUA.FillColor = System.Drawing.Color.AliceBlue
        Me.BTNSUA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSUA.ForeColor = System.Drawing.Color.Black
        Me.BTNSUA.Location = New System.Drawing.Point(6, 33)
        Me.BTNSUA.Name = "BTNSUA"
        Me.BTNSUA.Size = New System.Drawing.Size(220, 99)
        Me.BTNSUA.TabIndex = 12
        Me.BTNSUA.Text = "Sửa Nhân Viên"
        '
        'NHANVIEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1520, 1000)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NHANVIEN"
        Me.Text = "NHANVIEN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTCHUCVU As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTLUONG As TextBox
    Friend WithEvents CMBGIOITINH As ComboBox
    Friend WithEvents BTNTHEM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTCCCD As TextBox
    Friend WithEvents TXTDIACHI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTSDT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTTENNHANVIEN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTNLAMMOI As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNXOA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSUA As Guna.UI2.WinForms.Guna2Button
End Class
