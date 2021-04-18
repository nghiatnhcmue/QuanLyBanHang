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
            cmd.CommandText = "select MaKH, TenKH, GioiTinh,NamSinh,DiaChi,SDT,Email,Diem from tb_KhachHang";
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
            int count;
            cmd.CommandText = @"select count (*) from tb_KhachHang where MaKH != ''";
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
            return "KH" + ma;
        }

        public bool AddData(KhachHangObj khObj)
        {
            cmd.CommandText = "Insert into tb_KhachHang values ('" 
                            + khObj.MaKhachHang + "',N'" + khObj.TenKhachHang + "',N'" + khObj.GioiTinh + "',CONVERT(DATE,'" 
                            + khObj.NamSinh + "',103),N'" + khObj.DienThoai 
                            + "',N'" + khObj.DiaChi + "',0,'"+ khObj.Email + "')";
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
                            +khObj.Email +"',Diem = '" +khObj.Diem +"' Where MaKH = '" 
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

        public bool UpdDiem(KhachHangObj khObj)
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
        }

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
