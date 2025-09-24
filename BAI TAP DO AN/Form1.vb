Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BTNDANGNHAP_Click(sender As Object, e As EventArgs) Handles BTNDANGNHAP.Click
        Dim taikhoan As String = TXTTK.Text.Trim()
        Dim matkhau As String = TXTMK.Text.Trim()

        ' Kiểm tra tài khoản và mật khẩu (ví dụ đơn giản)
        If taikhoan = "" Or matkhau = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Kiểm tra tài khoản và mật khẩu (có thể thay bằng database sau)
            If taikhoan = "admin" And matkhau = "123456" Then
                TRANGCHU.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BTNTHOAT_Click(sender As Object, e As EventArgs) Handles BTNTHOAT.Click
        Application.Exit()
    End Sub
End Class