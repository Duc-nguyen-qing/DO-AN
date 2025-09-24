Imports System.Data.SqlClient

Public Class NHANVIEN
    Private Sub NHANVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT * FROM NHANVIEN"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles BTNTHEM.Click
        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "INSERT INTO NHANVIEN (TenNV, SoDienThoai, ChucVu, NgaySinh, CCCD, Luong, DiaChi, GioiTinh) 
                                   VALUES (@TenNV, @SDT, @ChucVu, @NgaySinh, @CCCD, @Luong, @DiaChi, @GioiTinh)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@TenNV", TXTTENNHANVIEN.Text)
            cmd.Parameters.AddWithValue("@SDT", TXTSDT.Text)
            cmd.Parameters.AddWithValue("@ChucVu", TXTCHUCVU.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", DTP.Value)
            cmd.Parameters.AddWithValue("@CCCD", TXTCCCD.Text)
            cmd.Parameters.AddWithValue("@Luong", Decimal.Parse(TXTLUONG.Text))
            cmd.Parameters.AddWithValue("@DiaChi", TXTDIACHI.Text)
            cmd.Parameters.AddWithValue("@GioiTinh", CMBGIOITINH.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm nhân viên thành công!")
            LoadData()
        End Using
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles BTNSUA.Click
        If DataGridView1.CurrentRow Is Nothing Then Return

        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "UPDATE NHANVIEN SET TenNV=@TenNV, SoDienThoai=@SDT, ChucVu=@ChucVu, 
                                   NgaySinh=@NgaySinh, CCCD=@CCCD, Luong=@Luong, DiaChi=@DiaChi, GioiTinh=@GioiTinh 
                                   WHERE MaNV=@MaNV"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@MaNV", DataGridView1.CurrentRow.Cells("MaNV").Value)
            cmd.Parameters.AddWithValue("@TenNV", TXTTENNHANVIEN.Text)
            cmd.Parameters.AddWithValue("@SDT", TXTSDT.Text)
            cmd.Parameters.AddWithValue("@ChucVu", TXTCHUCVU.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", DTP.Value)
            cmd.Parameters.AddWithValue("@CCCD", TXTCCCD.Text)
            cmd.Parameters.AddWithValue("@Luong", Decimal.Parse(TXTLUONG.Text))
            cmd.Parameters.AddWithValue("@DiaChi", TXTDIACHI.Text)
            cmd.Parameters.AddWithValue("@GioiTinh", CMBGIOITINH.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Sửa nhân viên thành công!")
            LoadData()
        End Using
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles BTNXOA.Click
        If DataGridView1.CurrentRow Is Nothing Then Return
        If MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As SqlConnection = Connection.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM NHANVIEN WHERE MaNV=@MaNV"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MaNV", DataGridView1.CurrentRow.Cells("MaNV").Value)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Xóa nhân viên thành công!")
                LoadData()
            End Using
        End If
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles BTNLAMMOI.Click
        For Each txt In {TXTTENNHANVIEN, TXTSDT, TXTCHUCVU, TXTCCCD, TXTLUONG, TXTDIACHI}
            txt.Text = ""
        Next
        CMBGIOITINH.Text = ""
        DTP.Value = DateTime.Now
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim row = DataGridView1.CurrentRow
        TXTTENNHANVIEN.Text = row.Cells("TenNV").Value.ToString()
        TXTSDT.Text = row.Cells("SoDienThoai").Value.ToString()
        TXTCHUCVU.Text = row.Cells("ChucVu").Value.ToString()
        TXTCCCD.Text = row.Cells("CCCD").Value.ToString()
        TXTLUONG.Text = row.Cells("Luong").Value.ToString()
        TXTDIACHI.Text = row.Cells("DiaChi").Value.ToString()
        CMBGIOITINH.Text = row.Cells("GioiTinh").Value.ToString()
        DTP.Value = DateTime.Parse(row.Cells("NgaySinh").Value.ToString())
    End Sub
End Class