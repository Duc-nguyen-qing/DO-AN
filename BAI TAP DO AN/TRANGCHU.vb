Imports FontAwesome.Sharp
Public Class TrangChu
    Private currentbtn As IconButton
    Private leftborderbtn As Panel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftborderbtn = New Panel()
        leftborderbtn.Size = New Size(7, 67)
        Panel1.Controls.Add(leftborderbtn)
    End Sub
    Private Sub Activatebutton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            Disablebutton()
            currentbtn = CType(senderBtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(37, 36, 81)
            currentbtn.ForeColor = customcolor
            currentbtn.IconColor = customcolor
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.ImageAlign = ContentAlignment.MiddleRight
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftborderbtn.BackColor = customcolor
            leftborderbtn.Location = New Point(0, currentbtn.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()
        End If
    End Sub
    Private Sub Disablebutton()
        If currentbtn IsNot Nothing Then
            currentbtn.BackColor = Color.FromArgb(0, 206, 209)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.IconColor = Color.Gainsboro
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub BTNBANHANG_Click(sender As Object, e As EventArgs) Handles BTNBANHANG.Click
        Activatebutton(sender, RGBcolors.color1)
        Dim form1 As New BANHANG()
        form1.TopLevel = False
        form1.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(form1)
        form1.Show()
    End Sub

    Private Sub BTNSANPHAM_Click(sender As Object, e As EventArgs) Handles BTNSANPHAM.Click
        Activatebutton(sender, RGBcolors.color2)
        Dim form2 As New SANPHAM()
        form2.TopLevel = False
        form2.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(form2)
        form2.Show()
    End Sub

    Private Sub BTNCHITIET_Click(sender As Object, e As EventArgs) Handles BTNCHITIET.Click
        Activatebutton(sender, RGBcolors.color3)
        Dim form3 As New CHITIETHOADON()
        form3.TopLevel = False
        form3.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(form3)
        form3.Show()
    End Sub

    Private Sub BTNNHANVIEN_Click(sender As Object, e As EventArgs) Handles BTNNHANVIEN.Click
        Activatebutton(sender, RGBcolors.color5)
        Dim form4 As New NHANVIEN()
        form4.TopLevel = False
        form4.Dock = DockStyle.Fill
        Panel1.Controls.Clear()
        Panel1.Controls.Add(form4)
        form4.Show()
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        Application.Exit()
    End Sub
End Class