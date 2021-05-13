using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class KhachHangMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaKH, TenKH, GioiTinh,NamSinh,DiaChi,SDT,Email from tb_KhachHang";
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
        public string MaKhachHang()
        {
            string tam;
            cmd.CommandText = @"SELECT TOP 1 MaKH FROM tb_KhachHang ORDER BY MaKH DESC;";
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
            string kq = "KH";
            stt += 1;
            string tmp = stt.ToString();
            // Lắp các số 0 còn thiếu
            for (int i = 0; i < (3 - tmp.Length); i++)
                kq += "0";
            kq += stt.ToString();
            return kq;
        }

        public bool AddData(KhachHangObj khObj)
        {
            cmd.CommandText = "Insert into tb_KhachHang values ('" 
                            + khObj.MaKhachHang + "',N'" + khObj.TenKhachHang + "',N'" + khObj.GioiTinh + "',CONVERT(DATE,'" 
                            + khObj.NamSinh + "',103),N'" + khObj.DienThoai 
                            + "',N'" + khObj.DiaChi + "','"+ khObj.Email + "')";
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

        public bool UpdData(KhachHangObj khObj)
        {
            cmd.CommandText = "Update tb_KhachHang set TenKH =  N'"
                            +khObj.TenKhachHang +"', GioiTinh = N'"
                            +khObj.GioiTinh +"', NamSinh = CONVERT(DATE,'"
                            +khObj.NamSinh +"',103), DiaChi = N'"
                            +khObj.DiaChi +"',SDT = '"
                            +khObj.DienThoai +"',Email = '"
                            +khObj.Email +"' Where MaKH = '" 
                            +khObj.MaKhachHang +"'";
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

        /*public bool UpdDiem(KhachHangObj khObj)
        {
            cmd.CommandText = "Update tb_KhachHang set Diem ='" + khObj.Diem + "' Where MaKH = '" + khObj.MaKhachHang + "'";
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
        }*/

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete tb_KhachHang Where MaKH = '" + ma + "'";
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
