Imports System.Data.SqlClient
Imports System.IO

Public Class CHITIETHOADON
    Private Sub CHITIETHOADON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHoaDon()
        TinhTongDoanhThu()
    End Sub

    Private Sub LoadHoaDon()
        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT h.MaHD, h.NgayTao, h.TenKH, n.TenNV, h.TongTien 
                                   FROM HOADON h 
                                   INNER JOIN NHANVIEN n ON h.MaNV = n.MaNV 
                                   ORDER BY h.NgayTao DESC"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub TinhTongDoanhThu()
        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT ISNULL(SUM(TongTien), 0) FROM HOADON"
            Dim cmd As New SqlCommand(query, conn)
            Dim tongTien As Decimal = Decimal.Parse(cmd.ExecuteScalar().ToString())
            TXTDOANHTHU.Text = tongTien.ToString("N0") & " VNĐ"
        End Using
    End Sub

    Private Sub btnXuatDoanhThu_Click(sender As Object, e As EventArgs) Handles BTNXUAT.Click
        ' Xuất file TEXT đơn giản
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Text Files (*.txt)|*.txt"
        saveDialog.Title = "Xuất báo cáo doanh thu"
        saveDialog.FileName = "BaoCaoDoanhThu_" & DateTime.Now.ToString("ddMMyyyy") & ".txt"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(saveDialog.FileName, False, System.Text.Encoding.UTF8)
                    ' Viết tiêu đề
                    writer.WriteLine("BÁO CÁO DOANH THU")
                    writer.WriteLine("Cửa hàng: QUẢN LÝ BÁN HÀNG")
                    writer.WriteLine("Ngày xuất: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                    writer.WriteLine("=" & New String("=", 50))
                    writer.WriteLine()

                    ' Tổng doanh thu
                    writer.WriteLine("TỔNG DOANH THU: " & TXTDOANHTHU.Text)
                    writer.WriteLine()

                    ' Danh sách hóa đơn
                    writer.WriteLine("DANH SÁCH HÓA ĐƠN")
                    writer.WriteLine("=" & New String("=", 50))
                    writer.WriteLine("{0,-8} {1,-12} {2,-20} {3,-15} {4,-15}",
                                    "Mã HD", "Ngày", "Khách hàng", "Nhân viên", "Tổng tiền")

                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If Not row.IsNewRow Then
                            Dim ngayTao As DateTime = DateTime.Parse(row.Cells("NgayTao").Value.ToString())
                            writer.WriteLine("{0,-8} {1,-12} {2,-20} {3,-15} {4,-15:N0} VNĐ",
                                          row.Cells("MaHD").Value,
                                          ngayTao.ToString("dd/MM/yyyy"),
                                          row.Cells("TenKH").Value,
                                          row.Cells("TenNV").Value,
                                          row.Cells("TongTien").Value)
                        End If
                    Next

                    writer.WriteLine()
                    writer.WriteLine("Tổng số hóa đơn: " & (DataGridView1.Rows.Count - 1))
                End Using

                MessageBox.Show("Xuất báo cáo thành công!" & vbCrLf & "File: " & saveDialog.FileName, "Thông báo")

            Catch ex As Exception
                MessageBox.Show("Lỗi khi xuất file: " & ex.Message, "Lỗi")
            End Try
        End If
    End Sub

    ' Hiển thị hóa đơn chi tiết khi click
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count - 1 Then
            Dim maHD As Integer = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells("MaHD").Value)
            HienThiChiTietHoaDon(maHD)
        End If
    End Sub

    Private Sub HienThiChiTietHoaDon(maHD As Integer)
        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT sp.TenSP, ct.SoLuong, ct.DonGia, ct.ThanhTien 
                                   FROM CHITIETHD ct 
                                   INNER JOIN SANPHAM sp ON ct.MaSP = sp.MaSP 
                                   WHERE ct.MaHD = @MaHD"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@MaHD", maHD)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim chiTiet As String = "CHI TIẾT HÓA ĐƠN #" & maHD & vbCrLf & vbCrLf
            While reader.Read()
                chiTiet &= String.Format("{0} x {1:N0} = {2:N0} VNĐ",
                                       reader("TenSP"),
                                       reader("SoLuong"),
                                       reader("ThanhTien")) & vbCrLf
            End While
            reader.Close()

            MessageBox.Show(chiTiet, "Chi tiết hóa đơn")
        End Using
    End Sub
End Class