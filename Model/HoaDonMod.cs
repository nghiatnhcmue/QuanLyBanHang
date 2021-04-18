using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class HoaDonMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select hd.MaHD, hd.NgayLap, nv.TenNV, kh.TenKH from tb_HoaDon hd, tb_KhachHang kh, tb_NhanVien nv where kh.MaKH = hd.KhachHang and nv.MaNV = hd.NguoiLap";
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
        public int CountData()
        {
            int count;
            cmd.CommandText = @"select count (*) from tb_HoaDon where MaHD != ''";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                count = (int)cmd.ExecuteScalar();
                return count;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
                return 0;
            }
        }
        public DataTable GetData(string dieukien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = dieukien;
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
        public int CountData(string dieukien)
        {
            int count;
            cmd.CommandText = dieukien;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                count = (int)cmd.ExecuteScalar();
                return count;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
                return 0;
            }
        }
        public int SumDoanhThu(HoaDonObj hdObj)
        {
            int sum;
            cmd.CommandText = @"select sum (ThanhTien) from tb_CTHD as ct, tb_HoaDon as hd where  hd.MaHD = ct.MaHD and hd.NgayLap = CONVERT(DATE, '" + hdObj.NgayLap + "', 103)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                sum = (int)cmd.ExecuteScalar();
                return sum;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
                return 0;
            }
        }
        public string MaHoaDon()
        {
            int count;
            cmd.CommandText = @"select count (*) from tb_HoaDon where MaHD != ''";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                count = (int)cmd.ExecuteScalar() + 1;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
                return "";
            }
            string x = "" + count;
            string ma = "";
            for (int i = 0; i < 3 - x.Length; i++)
            {
                ma += "0";
            }
            ma += x;
            return "HD" + ma;
        }

        public bool AddData(HoaDonObj hdObj)
        {
            cmd.CommandText = "insert into tb_HoaDon values ('" + hdObj.MaHoaDon + "', CONVERT (date,'" + hdObj.NgayLap + "',103),'" + hdObj.NguoiLap + "','" + hdObj .KhachHang+ "')";
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

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete tb_HoaDon Where MaHD = '" + ma + "'";
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
    }
}
