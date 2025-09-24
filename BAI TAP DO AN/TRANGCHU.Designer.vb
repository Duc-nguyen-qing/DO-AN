<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrangChu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.BTNNHANVIEN = New FontAwesome.Sharp.IconButton()
        Me.BTNCHITIET = New FontAwesome.Sharp.IconButton()
        Me.BTNSANPHAM = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNBANHANG = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.DarkTurquoise
        Me.PanelMenu.Controls.Add(Me.IconButton6)
        Me.PanelMenu.Controls.Add(Me.BTNNHANVIEN)
        Me.PanelMenu.Controls.Add(Me.BTNCHITIET)
        Me.PanelMenu.Controls.Add(Me.BTNSANPHAM)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.BTNBANHANG)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(280, 1000)
        Me.PanelMenu.TabIndex = 4
        '
        'IconButton6
        '
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton6.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket
        Me.IconButton6.IconColor = System.Drawing.Color.White
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 32
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(3, 919)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton6.Size = New System.Drawing.Size(274, 69)
        Me.IconButton6.TabIndex = 6
        Me.IconButton6.Text = "Thoát"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'BTNNHANVIEN
        '
        Me.BTNNHANVIEN.FlatAppearance.BorderSize = 0
        Me.BTNNHANVIEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNNHANVIEN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNHANVIEN.ForeColor = System.Drawing.Color.GhostWhite
        Me.BTNNHANVIEN.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        Me.BTNNHANVIEN.IconColor = System.Drawing.Color.MistyRose
        Me.BTNNHANVIEN.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTNNHANVIEN.IconSize = 32
        Me.BTNNHANVIEN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNHANVIEN.Location = New System.Drawing.Point(-3, 692)
        Me.BTNNHANVIEN.Name = "BTNNHANVIEN"
        Me.BTNNHANVIEN.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BTNNHANVIEN.Size = New System.Drawing.Size(280, 85)
        Me.BTNNHANVIEN.TabIndex = 5
        Me.BTNNHANVIEN.Text = "Nhân Viên"
        Me.BTNNHANVIEN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNHANVIEN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNNHANVIEN.UseVisualStyleBackColor = True
        '
        'BTNCHITIET
        '
        Me.BTNCHITIET.FlatAppearance.BorderSize = 0
        Me.BTNCHITIET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCHITIET.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCHITIET.ForeColor = System.Drawing.Color.GhostWhite
        Me.BTNCHITIET.IconChar = FontAwesome.Sharp.IconChar.ChartSimple
        Me.BTNCHITIET.IconColor = System.Drawing.Color.MistyRose
        Me.BTNCHITIET.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTNCHITIET.IconSize = 32
        Me.BTNCHITIET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCHITIET.Location = New System.Drawing.Point(0, 575)
        Me.BTNCHITIET.Name = "BTNCHITIET"
        Me.BTNCHITIET.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BTNCHITIET.Size = New System.Drawing.Size(280, 85)
        Me.BTNCHITIET.TabIndex = 3
        Me.BTNCHITIET.Text = "Chi Tiết Hóa Đơn"
        Me.BTNCHITIET.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCHITIET.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNCHITIET.UseVisualStyleBackColor = True
        '
        'BTNSANPHAM
        '
        Me.BTNSANPHAM.FlatAppearance.BorderSize = 0
        Me.BTNSANPHAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSANPHAM.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSANPHAM.ForeColor = System.Drawing.Color.GhostWhite
        Me.BTNSANPHAM.IconChar = FontAwesome.Sharp.IconChar.MobileAlt
        Me.BTNSANPHAM.IconColor = System.Drawing.Color.MistyRose
        Me.BTNSANPHAM.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTNSANPHAM.IconSize = 32
        Me.BTNSANPHAM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSANPHAM.Location = New System.Drawing.Point(0, 460)
        Me.BTNSANPHAM.Name = "BTNSANPHAM"
        Me.BTNSANPHAM.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BTNSANPHAM.Size = New System.Drawing.Size(280, 85)
        Me.BTNSANPHAM.TabIndex = 2
        Me.BTNSANPHAM.Text = "Sản Phẩm"
        Me.BTNSANPHAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSANPHAM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNSANPHAM.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.BAI_TAP_DO_AN.My.Resources.Resources.Gemini_Generated_Image_87uaq287uaq287ua_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BTNBANHANG
        '
        Me.BTNBANHANG.FlatAppearance.BorderSize = 0
        Me.BTNBANHANG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNBANHANG.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBANHANG.ForeColor = System.Drawing.Color.GhostWhite
        Me.BTNBANHANG.IconChar = FontAwesome.Sharp.IconChar.CartShopping
        Me.BTNBANHANG.IconColor = System.Drawing.Color.MistyRose
        Me.BTNBANHANG.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTNBANHANG.IconSize = 32
        Me.BTNBANHANG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNBANHANG.Location = New System.Drawing.Point(0, 347)
        Me.BTNBANHANG.Name = "BTNBANHANG"
        Me.BTNBANHANG.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BTNBANHANG.Size = New System.Drawing.Size(280, 85)
        Me.BTNBANHANG.TabIndex = 0
        Me.BTNBANHANG.Text = "Mua Hàng"
        Me.BTNBANHANG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNBANHANG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNBANHANG.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.Location = New System.Drawing.Point(280, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1520, 1000)
        Me.Panel1.TabIndex = 5
        '
        'TrangChu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1800, 1000)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TrangChu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANGCHU"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents BTNNHANVIEN As FontAwesome.Sharp.IconButton
    Friend WithEvents BTNCHITIET As FontAwesome.Sharp.IconButton
    Friend WithEvents BTNSANPHAM As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNBANHANG As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
End Class
