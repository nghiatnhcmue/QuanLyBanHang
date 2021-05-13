using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class ChiTietMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select ct.MaHD, hh.TenHang HangHoa, ct.SoLuong, ct.DonGia, ct.SoLuong*ct.DonGia ThanhTien from tb_CTHD ct, tb_HangHoa hh where ct.MaHH = hh.MaHang and MaHD = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(DataTable dt)
        {
            
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd.CommandText = "insert into tb_CTHD values ('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "'," + dt.Rows[i][2].ToString() + "," + dt.Rows[i][3].ToString() + "," + dt.Rows[i][4].ToString() + ")";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Connection;
                    con.OpenConn();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete tb_CTHD Where MaHD = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
        public DataTable ThongKeHangHoa(string thang, string nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select  hh.TenHang, sum(ct.SoLuong) as 'SoHangHoa'
                                from tb_CTHD as ct, tb_HoaDon as hd, tb_HangHoa as hh
                                where month(hd.NgayLap)='"+ thang +@"' and YEAR(hd.NgayLap)='" + nam +@"' and hd.MaHD=ct.MaHD and ct.MaHH=hh.MaHang
                                group by hh.TenHang
                                order by SoHangHoa desc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public DataTable ThongKeNhanVien(string thang, string nam)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select nv.TenNV, sum(ct.SoLuong) as 'SoHangHoa'
                                from tb_HoaDon as hd, tb_CTHD as ct, tb_NhanVien as nv
                                where month(hd.NgayLap)='" + thang +@"' and YEAR(hd.NgayLap)='" + nam + @"' and hd.MaHD=ct.MaHD and nv.MaNV=hd.NguoiLap
                                group by nv.TenNV
                                order by SoHangHoa desc";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
    }
}
