Imports System.Data.SqlClient

Public Class SANPHAM
    Private Sub SANPHAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT * FROM SANPHAM"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles BTNTHEM.Click
        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "INSERT INTO SANPHAM (TenSP, SoLuong, GiaNhap, GiaBan, NhaCungCap) 
                                   VALUES (@TenSP, @SoLuong, @GiaNhap, @GiaBan, @NCC)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@TenSP", TXTTENSP.Text)
            cmd.Parameters.AddWithValue("@SoLuong", Integer.Parse(TXTSL.Text))
            cmd.Parameters.AddWithValue("@GiaNhap", Decimal.Parse(TXTGIANHAP.Text))
            cmd.Parameters.AddWithValue("@GiaBan", Decimal.Parse(TXTGIABAN.Text))
            cmd.Parameters.AddWithValue("@NCC", TXTNHACUNGCAP.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm sản phẩm thành công!")
            LoadData()
        End Using
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles BTNSUA.Click
        If DataGridView1.CurrentRow Is Nothing Then Return

        Using conn As SqlConnection = Connection.GetConnection()
            conn.Open()
            Dim query As String = "UPDATE SANPHAM SET TenSP=@TenSP, SoLuong=@SoLuong, GiaNhap=@GiaNhap, 
                                   GiaBan=@GiaBan, NhaCungCap=@NCC WHERE MaSP=@MaSP"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@MaSP", DataGridView1.CurrentRow.Cells("MaSP").Value)
            cmd.Parameters.AddWithValue("@TenSP", TXTTENSP.Text)
            cmd.Parameters.AddWithValue("@SoLuong", Integer.Parse(TXTSL.Text))
            cmd.Parameters.AddWithValue("@GiaNhap", Decimal.Parse(TXTGIANHAP.Text))
            cmd.Parameters.AddWithValue("@GiaBan", Decimal.Parse(TXTGIABAN.Text))
            cmd.Parameters.AddWithValue("@NCC", TXTNHACUNGCAP.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Sửa sản phẩm thành công!")
            LoadData()
        End Using
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles BTNXOA.Click
        If DataGridView1.CurrentRow Is Nothing Then Return
        If MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As SqlConnection = Connection.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM SANPHAM WHERE MaSP=@MaSP"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MaSP", DataGridView1.CurrentRow.Cells("MaSP").Value)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Xóa sản phẩm thành công!")
                LoadData()
            End Using
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow Is Nothing Then Return
        Dim row = DataGridView1.CurrentRow
        TXTTENSP.Text = row.Cells("TenSP").Value.ToString()
        TXTSL.Text = row.Cells("SoLuong").Value.ToString()
        TXTGIANHAP.Text = row.Cells("GiaNhap").Value.ToString()
        TXTGIABAN.Text = row.Cells("GiaBan").Value.ToString()
        TXTNHACUNGCAP.Text = row.Cells("NhaCungCap").Value.ToString()
    End Sub
End Class