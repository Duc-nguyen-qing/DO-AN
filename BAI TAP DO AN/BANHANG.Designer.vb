<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BANHANG
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
        Me.CBMNVXL = New System.Windows.Forms.ComboBox()
        Me.DTPTG = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTDIACHI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTSDT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTTENKHACHHANG = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNXOASANPHAM = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNTHEMSANPHAM = New Guna.UI2.WinForms.Guna2Button()
        Me.TXTSL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBMSP = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNLAMMOI = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNHUYDONHANG = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNTAODONHANG = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBMNVXL)
        Me.GroupBox1.Controls.Add(Me.DTPTG)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTDIACHI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTSDT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTTENKHACHHANG)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 282)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Khách Hàng"
        '
        'CBMNVXL
        '
        Me.CBMNVXL.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMNVXL.FormattingEnabled = True
        Me.CBMNVXL.Location = New System.Drawing.Point(368, 136)
        Me.CBMNVXL.Name = "CBMNVXL"
        Me.CBMNVXL.Size = New System.Drawing.Size(221, 27)
        Me.CBMNVXL.TabIndex = 10
        '
        'DTPTG
        '
        Me.DTPTG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTG.Location = New System.Drawing.Point(10, 207)
        Me.DTPTG.Name = "DTPTG"
        Me.DTPTG.Size = New System.Drawing.Size(463, 28)
        Me.DTPTG.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Thời Gian :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(364, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nhân Viên Xử Lý:"
        '
        'TXTDIACHI
        '
        Me.TXTDIACHI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDIACHI.Location = New System.Drawing.Point(10, 136)
        Me.TXTDIACHI.Name = "TXTDIACHI"
        Me.TXTDIACHI.Size = New System.Drawing.Size(164, 28)
        Me.TXTDIACHI.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Địa Chỉ :"
        '
        'TXTSDT
        '
        Me.TXTSDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSDT.Location = New System.Drawing.Point(368, 63)
        Me.TXTSDT.Name = "TXTSDT"
        Me.TXTSDT.Size = New System.Drawing.Size(221, 28)
        Me.TXTSDT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(364, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Số Điện Thoại :"
        '
        'TXTTENKHACHHANG
        '
        Me.TXTTENKHACHHANG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTENKHACHHANG.Location = New System.Drawing.Point(10, 63)
        Me.TXTTENKHACHHANG.Name = "TXTTENKHACHHANG"
        Me.TXTTENKHACHHANG.Size = New System.Drawing.Size(303, 28)
        Me.TXTTENKHACHHANG.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Khách Hàng :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNXOASANPHAM)
        Me.GroupBox2.Controls.Add(Me.BTNTHEMSANPHAM)
        Me.GroupBox2.Controls.Add(Me.TXTSL)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CBMSP)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 297)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sản Phẩm"
        '
        'BTNXOASANPHAM
        '
        Me.BTNXOASANPHAM.Animated = True
        Me.BTNXOASANPHAM.AutoRoundedCorners = True
        Me.BTNXOASANPHAM.BackColor = System.Drawing.Color.Transparent
        Me.BTNXOASANPHAM.BorderRadius = 36
        Me.BTNXOASANPHAM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNXOASANPHAM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNXOASANPHAM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNXOASANPHAM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNXOASANPHAM.FillColor = System.Drawing.Color.LightSkyBlue
        Me.BTNXOASANPHAM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNXOASANPHAM.ForeColor = System.Drawing.Color.Black
        Me.BTNXOASANPHAM.Location = New System.Drawing.Point(340, 188)
        Me.BTNXOASANPHAM.Name = "BTNXOASANPHAM"
        Me.BTNXOASANPHAM.Size = New System.Drawing.Size(237, 74)
        Me.BTNXOASANPHAM.TabIndex = 12
        Me.BTNXOASANPHAM.Text = "Xóa Sản Phẩm"
        Me.BTNXOASANPHAM.UseTransparentBackground = True
        '
        'BTNTHEMSANPHAM
        '
        Me.BTNTHEMSANPHAM.Animated = True
        Me.BTNTHEMSANPHAM.AutoRoundedCorners = True
        Me.BTNTHEMSANPHAM.BackColor = System.Drawing.Color.Transparent
        Me.BTNTHEMSANPHAM.BorderRadius = 36
        Me.BTNTHEMSANPHAM.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNTHEMSANPHAM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNTHEMSANPHAM.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNTHEMSANPHAM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNTHEMSANPHAM.FillColor = System.Drawing.Color.LightSkyBlue
        Me.BTNTHEMSANPHAM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTHEMSANPHAM.ForeColor = System.Drawing.Color.Black
        Me.BTNTHEMSANPHAM.Location = New System.Drawing.Point(40, 188)
        Me.BTNTHEMSANPHAM.Name = "BTNTHEMSANPHAM"
        Me.BTNTHEMSANPHAM.Size = New System.Drawing.Size(237, 74)
        Me.BTNTHEMSANPHAM.TabIndex = 11
        Me.BTNTHEMSANPHAM.Text = "Thêm Sản Phẩm"
        Me.BTNTHEMSANPHAM.UseTransparentBackground = True
        '
        'TXTSL
        '
        Me.TXTSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSL.Location = New System.Drawing.Point(21, 136)
        Me.TXTSL.Name = "TXTSL"
        Me.TXTSL.Size = New System.Drawing.Size(164, 28)
        Me.TXTSL.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Số Lượng Mua :"
        '
        'CBMSP
        '
        Me.CBMSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMSP.FormattingEnabled = True
        Me.CBMSP.Location = New System.Drawing.Point(21, 63)
        Me.CBMSP.Name = "CBMSP"
        Me.CBMSP.Size = New System.Drawing.Size(494, 28)
        Me.CBMSP.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tên Sản Phẩm :"
        '
        'BTNLAMMOI
        '
        Me.BTNLAMMOI.Animated = True
        Me.BTNLAMMOI.AutoRoundedCorners = True
        Me.BTNLAMMOI.BorderRadius = 29
        Me.BTNLAMMOI.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNLAMMOI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNLAMMOI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNLAMMOI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNLAMMOI.FillColor = System.Drawing.Color.AliceBlue
        Me.BTNLAMMOI.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNLAMMOI.ForeColor = System.Drawing.Color.Black
        Me.BTNLAMMOI.Location = New System.Drawing.Point(212, 788)
        Me.BTNLAMMOI.Name = "BTNLAMMOI"
        Me.BTNLAMMOI.Size = New System.Drawing.Size(224, 60)
        Me.BTNLAMMOI.TabIndex = 13
        Me.BTNLAMMOI.Text = "Làm Mới"
        '
        'BTNHUYDONHANG
        '
        Me.BTNHUYDONHANG.Animated = True
        Me.BTNHUYDONHANG.AutoRoundedCorners = True
        Me.BTNHUYDONHANG.BorderRadius = 36
        Me.BTNHUYDONHANG.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNHUYDONHANG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNHUYDONHANG.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNHUYDONHANG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNHUYDONHANG.FillColor = System.Drawing.Color.AliceBlue
        Me.BTNHUYDONHANG.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNHUYDONHANG.ForeColor = System.Drawing.Color.Black
        Me.BTNHUYDONHANG.Location = New System.Drawing.Point(362, 693)
        Me.BTNHUYDONHANG.Name = "BTNHUYDONHANG"
        Me.BTNHUYDONHANG.Size = New System.Drawing.Size(258, 74)
        Me.BTNHUYDONHANG.TabIndex = 12
        Me.BTNHUYDONHANG.Text = "Hủy Đơn Hàng"
        '
        'BTNTAODONHANG
        '
        Me.BTNTAODONHANG.Animated = True
        Me.BTNTAODONHANG.AutoRoundedCorners = True
        Me.BTNTAODONHANG.BackColor = System.Drawing.Color.Transparent
        Me.BTNTAODONHANG.BorderRadius = 36
        Me.BTNTAODONHANG.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNTAODONHANG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNTAODONHANG.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNTAODONHANG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNTAODONHANG.FillColor = System.Drawing.Color.AliceBlue
        Me.BTNTAODONHANG.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTAODONHANG.ForeColor = System.Drawing.Color.Black
        Me.BTNTAODONHANG.Location = New System.Drawing.Point(22, 693)
        Me.BTNTAODONHANG.Name = "BTNTAODONHANG"
        Me.BTNTAODONHANG.Size = New System.Drawing.Size(237, 74)
        Me.BTNTAODONHANG.TabIndex = 11
        Me.BTNTAODONHANG.Text = "Tạo Đơn Hàng"
        Me.BTNTAODONHANG.UseTransparentBackground = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(643, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(865, 976)
        Me.DataGridView1.TabIndex = 14
        '
        'BANHANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1520, 1000)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTNLAMMOI)
        Me.Controls.Add(Me.BTNHUYDONHANG)
        Me.Controls.Add(Me.BTNTAODONHANG)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BANHANG"
        Me.Text = "BANHANG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBMNVXL As ComboBox
    Friend WithEvents DTPTG As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTDIACHI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTSDT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTTENKHACHHANG As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTNXOASANPHAM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNTHEMSANPHAM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTSL As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CBMSP As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNLAMMOI As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNHUYDONHANG As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNTAODONHANG As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
