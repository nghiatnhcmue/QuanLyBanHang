using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public bool Login(string username, string password)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM tb_NhanVien WHERE MaNV = " + "\'" + username + "\'"
                + "AND MatKhau = " + "\'" + password + "\'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
                return false;
            }
        }
        public DataTable GetPass(string username)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM tb_NhanVien WHERE MaNV = " + "\'" + username + "\'";
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
        public bool DoiPass(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update tb_NhanVien set MatKhau =  N'"
                            + nvObj.MatKhau + "' Where MaNV = '"
                            + nvObj.MaNhanVien + "'";
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
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaNV, TenNV, GioiTinh, NamSinh, DiaChi, SDT  from tb_NhanVien";
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
        public string MaNhanVien()
        {
            string tam;
            cmd.CommandText = @"SELECT TOP 1 MaNV FROM tb_NhanVien ORDER BY MaNV DESC;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                tam = (string)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
                return "";
            }
            string Max = tam.ToString().Substring(2);
            int stt = int.Parse(Max);
            string kq = "NV";
            stt += 1;
            string tmp = stt.ToString();
            // Lắp các số 0 còn thiếu
            for (int i = 0; i < (3 - tmp.Length); i++)
                kq += "0";
            kq += stt.ToString();
            return kq;
        }

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Insert into tb_NhanVien values ('" + nvObj.MaNhanVien 
                + "',N'" + nvObj.TenNhanVien + "',N'" + nvObj.GioiTinh 
                + "',CONVERT(DATE,'" + nvObj.NamSinh + "',103),N'" 
                + nvObj.DiaChi + "','" + nvObj.DienThoai + "','" 
                +nvObj.MatKhau+ "')";
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

        public bool UpdData(NhanVienObj nvObj)
        {
            cmd.CommandText = @"Update tb_NhanVien set TenNV =  N'" 
                        + nvObj.TenNhanVien + "', GioiTinh = N'" + nvObj.GioiTinh 
                        + "', NamSinh = CONVERT(DATE,'" + nvObj.NamSinh + "',103), DiaChi = N'" 
                        + nvObj.DiaChi + "', SDT = '" + nvObj.DienThoai + "' Where MaNV = '" 
                        + nvObj.MaNhanVien +"'";
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
            cmd.CommandText =  "Delete tb_NhanVien Where MaNV = '" + ma + "'";
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
