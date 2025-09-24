<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SANPHAM
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTNHACUNGCAP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNXOA = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSUA = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNTHEM = New Guna.UI2.WinForms.Guna2Button()
        Me.TXTGIABAN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTGIANHAP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTSL = New System.Windows.Forms.TextBox()
        Me.TXTTENSP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXTNHACUNGCAP)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BTNXOA)
        Me.GroupBox2.Controls.Add(Me.BTNSUA)
        Me.GroupBox2.Controls.Add(Me.BTNTHEM)
        Me.GroupBox2.Controls.Add(Me.TXTGIABAN)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TXTGIANHAP)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TXTSL)
        Me.GroupBox2.Controls.Add(Me.TXTTENSP)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 491)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thêm Sản Phẩm"
        '
        'TXTNHACUNGCAP
        '
        Me.TXTNHACUNGCAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNHACUNGCAP.Location = New System.Drawing.Point(21, 427)
        Me.TXTNHACUNGCAP.Name = "TXTNHACUNGCAP"
        Me.TXTNHACUNGCAP.Size = New System.Drawing.Size(239, 28)
        Me.TXTNHACUNGCAP.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nhà cung câp :"
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
        Me.BTNXOA.Location = New System.Drawing.Point(315, 363)
        Me.BTNXOA.Name = "BTNXOA"
        Me.BTNXOA.Size = New System.Drawing.Size(189, 92)
        Me.BTNXOA.TabIndex = 18
        Me.BTNXOA.Text = "Xóa Sản Phẩm"
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
        Me.BTNSUA.Location = New System.Drawing.Point(315, 216)
        Me.BTNSUA.Name = "BTNSUA"
        Me.BTNSUA.Size = New System.Drawing.Size(189, 82)
        Me.BTNSUA.TabIndex = 17
        Me.BTNSUA.Text = "Sửa Sản Phẩm"
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
        Me.BTNTHEM.Location = New System.Drawing.Point(315, 63)
        Me.BTNTHEM.Name = "BTNTHEM"
        Me.BTNTHEM.Size = New System.Drawing.Size(189, 79)
        Me.BTNTHEM.TabIndex = 16
        Me.BTNTHEM.Text = "Thêm Sản Phẩm"
        '
        'TXTGIABAN
        '
        Me.TXTGIABAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGIABAN.Location = New System.Drawing.Point(21, 331)
        Me.TXTGIABAN.Name = "TXTGIABAN"
        Me.TXTGIABAN.Size = New System.Drawing.Size(239, 28)
        Me.TXTGIABAN.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Giá Bán :"
        '
        'TXTGIANHAP
        '
        Me.TXTGIANHAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGIANHAP.Location = New System.Drawing.Point(21, 239)
        Me.TXTGIANHAP.Name = "TXTGIANHAP"
        Me.TXTGIANHAP.Size = New System.Drawing.Size(239, 28)
        Me.TXTGIANHAP.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Giá Nhập :"
        '
        'TXTSL
        '
        Me.TXTSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSL.Location = New System.Drawing.Point(21, 148)
        Me.TXTSL.Name = "TXTSL"
        Me.TXTSL.Size = New System.Drawing.Size(239, 28)
        Me.TXTSL.TabIndex = 11
        '
        'TXTTENSP
        '
        Me.TXTTENSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTENSP.Location = New System.Drawing.Point(21, 63)
        Me.TXTTENSP.Name = "TXTTENSP"
        Me.TXTTENSP.Size = New System.Drawing.Size(239, 28)
        Me.TXTTENSP.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Số Lượng :"
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
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(557, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(943, 976)
        Me.DataGridView1.TabIndex = 7
        '
        'SANPHAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1520, 1000)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SANPHAM"
        Me.Text = "SANPHAM"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXTNHACUNGCAP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNXOA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSUA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNTHEM As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXTGIABAN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTGIANHAP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTSL As TextBox
    Friend WithEvents TXTTENSP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
