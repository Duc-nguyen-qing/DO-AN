Imports System.Data.SqlClient

Public Class BANHANG
    Private dtGioHang As New DataTable()

    Private Sub BANHANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNhanVien()
        LoadSanPham()
        DTPTG.Value = DateTime.Now
        KhoiTaoGioHang()
    End Sub

    Private Sub LoadNhanVien()
        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT MaNV, TenNV FROM NHANVIEN"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            CBMNVXL.DataSource = table
            CBMNVXL.DisplayMember = "TenNV"
            CBMNVXL.ValueMember = "MaNV"
        End Using
    End Sub

    Private Sub LoadSanPham()
        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT MaSP, TenSP, SoLuong, GiaBan FROM SANPHAM WHERE SoLuong > 0"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            CBMSP.DataSource = table
            CBMSP.DisplayMember = "TenSP"
            CBMSP.ValueMember = "MaSP"
        End Using
    End Sub

    Private Sub KhoiTaoGioHang()
        dtGioHang.Columns.Add("MaSP", GetType(Integer))
        dtGioHang.Columns.Add("TenSP", GetType(String))
        dtGioHang.Columns.Add("SoLuongTon", GetType(Integer))
        dtGioHang.Columns.Add("SoLuongMua", GetType(Integer))
        dtGioHang.Columns.Add("DonGia", GetType(Decimal))
        dtGioHang.Columns.Add("ThanhTien", GetType(Decimal))

        DataGridView1.DataSource = dtGioHang
    End Sub

    ' NÚT THÊM SẢN PHẨM VÀO DATAGRIDVIEW
    Private Sub btnThemSP_Click(sender As Object, e As EventArgs) Handles BTNTHEMSANPHAM.Click
        If CBMSP.SelectedValue Is Nothing OrElse String.IsNullOrEmpty(TXTSL.Text) Then
            MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng!")
            Return
        End If

        ' Kiểm tra số lượng
        Dim soLuongMua As Integer
        If Not Integer.TryParse(TXTSL.Text, soLuongMua) Or soLuongMua <= 0 Then
            MessageBox.Show("Số lượng mua phải là số nguyên dương!")
            Return
        End If

        ' Kiểm tra số lượng tồn
        Dim selectedRow As DataRowView = CBMSP.SelectedItem
        Dim soLuongTon As Integer = Integer.Parse(selectedRow("SoLuong").ToString())

        If soLuongMua > soLuongTon Then
            MessageBox.Show("Số lượng mua vượt quá số lượng tồn! Chỉ còn " & soLuongTon & " sản phẩm")
            Return
        End If

        ' Kiểm tra sản phẩm đã có trong giỏ hàng chưa
        For Each row As DataRow In dtGioHang.Rows
            If row("MaSP") = selectedRow("MaSP") Then
                MessageBox.Show("Sản phẩm đã có trong giỏ hàng! Vui lòng xóa và thêm lại hoặc cập nhật số lượng.")
                Return
            End If
        Next

        ' Thêm sản phẩm vào DataGridView
        Dim newRow As DataRow = dtGioHang.NewRow()
        newRow("MaSP") = selectedRow("MaSP")
        newRow("TenSP") = selectedRow("TenSP")
        newRow("SoLuongTon") = soLuongTon
        newRow("SoLuongMua") = soLuongMua
        newRow("DonGia") = Decimal.Parse(selectedRow("GiaBan"))
        newRow("ThanhTien") = soLuongMua * newRow("DonGia")

        dtGioHang.Rows.Add(newRow)
        DataGridView1.DataSource = dtGioHang

        ' Làm mới ô nhập số lượng
        TXTSL.Text = ""
    End Sub

    ' NÚT XÓA SẢN PHẨM KHỎI DATAGRIDVIEW
    Private Sub btnXoaSP_Click(sender As Object, e As EventArgs) Handles BTNXOASANPHAM.Click
        If DataGridView1.CurrentRow Is Nothing OrElse DataGridView1.CurrentRow.IsNewRow Then
            MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này khỏi giỏ hàng?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            dtGioHang.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        End If
    End Sub

    ' NÚT TẠO HÓA ĐƠN (lưu tất cả sản phẩm trong DataGridView)
    Private Sub btnTaoDonHang_Click(sender As Object, e As EventArgs) Handles BTNTAODONHANG.Click
        If dtGioHang.Rows.Count = 0 Then
            MessageBox.Show("Vui lòng thêm sản phẩm vào giỏ hàng!")
            Return
        End If

        If String.IsNullOrEmpty(TXTTENKHACHHANG.Text) Then
            MessageBox.Show("Vui lòng nhập tên khách hàng!")
            Return
        End If

        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                ' 1. Thêm vào bảng HOADON
                Dim queryHD As String = "INSERT INTO HOADON (MaNV, TenKH, SoDienThoaiKH, DiaChiKH, NgayTao, TongTien) 
                                       OUTPUT INSERTED.MaHD 
                                       VALUES (@MaNV, @TenKH, @SDT, @DiaChi, @NgayTao, @TongTien)"
                Dim cmdHD As New SqlCommand(queryHD, conn, transaction)
                cmdHD.Parameters.AddWithValue("@MaNV", CBMNVXL.SelectedValue)
                cmdHD.Parameters.AddWithValue("@TenKH", TXTTENKHACHHANG.Text)
                cmdHD.Parameters.AddWithValue("@SDT", If(String.IsNullOrEmpty(TXTSDT.Text), DBNull.Value, TXTSDT.Text))
                cmdHD.Parameters.AddWithValue("@DiaChi", If(String.IsNullOrEmpty(TXTDIACHI.Text), DBNull.Value, TXTDIACHI.Text))
                cmdHD.Parameters.AddWithValue("@NgayTao", DTPTG.Value)

                ' Tính tổng tiền từ DataGridView
                Dim tongTien As Decimal = 0
                For Each row As DataRow In dtGioHang.Rows
                    tongTien += row("ThanhTien")
                Next
                cmdHD.Parameters.AddWithValue("@TongTien", tongTien)

                Dim maHD As Integer = cmdHD.ExecuteScalar()

                ' 2. Thêm vào bảng CHITIETHD (tất cả sản phẩm trong DataGridView)
                For Each row As DataRow In dtGioHang.Rows
                    Dim queryCT As String = "INSERT INTO CHITIETHD (MaHD, MaSP, SoLuong, DonGia, ThanhTien) 
                                           VALUES (@MaHD, @MaSP, @SoLuong, @DonGia, @ThanhTien)"
                    Dim cmdCT As New SqlCommand(queryCT, conn, transaction)
                    cmdCT.Parameters.AddWithValue("@MaHD", maHD)
                    cmdCT.Parameters.AddWithValue("@MaSP", row("MaSP"))
                    cmdCT.Parameters.AddWithValue("@SoLuong", row("SoLuongMua"))
                    cmdCT.Parameters.AddWithValue("@DonGia", row("DonGia"))
                    cmdCT.Parameters.AddWithValue("@ThanhTien", row("ThanhTien"))
                    cmdCT.ExecuteNonQuery()

                    ' 3. Cập nhật số lượng tồn kho
                    Dim queryUpdate As String = "UPDATE SANPHAM SET SoLuong = SoLuong - @SoLuongMua WHERE MaSP = @MaSP"
                    Dim cmdUpdate As New SqlCommand(queryUpdate, conn, transaction)
                    cmdUpdate.Parameters.AddWithValue("@SoLuongMua", row("SoLuongMua"))
                    cmdUpdate.Parameters.AddWithValue("@MaSP", row("MaSP"))
                    cmdUpdate.ExecuteNonQuery()
                Next

                transaction.Commit()
                MessageBox.Show("Tạo hóa đơn thành công! Mã HD: " & maHD)
                LamMoi()

            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Lỗi khi tạo hóa đơn: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnHuyDon_Click(sender As Object, e As EventArgs) Handles BTNHUYDONHANG.Click
        LamMoi()
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles BTNLAMMOI.Click
        LamMoi()
    End Sub

    Private Sub LamMoi()
        TXTTENKHACHHANG.Text = ""
        TXTSDT.Text = ""
        TXTDIACHI.Text = ""
        TXTSL.Text = ""
        DTPTG.Value = DateTime.Now
        dtGioHang.Rows.Clear()
        If CBMSP.Items.Count > 0 Then CBMSP.SelectedIndex = 0
        If CBMNVXL.Items.Count > 0 Then CBMNVXL.SelectedIndex = 0
    End Sub
End Class