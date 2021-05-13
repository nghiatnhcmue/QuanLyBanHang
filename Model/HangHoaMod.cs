using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Obiect;

namespace QL_BanHang.Model
{
    class HangHoaMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_HangHoa";
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
        public string MaHangHoa()
        {
            string tam;
            cmd.CommandText = @"SELECT TOP 1 MaHang FROM tb_HangHoa ORDER BY MaHang DESC;";
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
            string kq = "HH";
            stt += 1;
            string tmp = stt.ToString();
            // Lắp các số 0 còn thiếu
            for (int i = 0; i < (3 - tmp.Length); i++)
                kq += "0";
            kq += stt.ToString();
            return kq;
        }

        public DataTable GetData(string dieukien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_HangHoa " + dieukien;
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

        public bool AddData(HangHoaObj hhObj)
        {
            cmd.CommandText = "Insert into tb_HangHoa values ('" 
                            + hhObj.MaHangHoa + "', N'" 
                            + hhObj.TenHangHoa + "'," 
                            + hhObj.DonGia + "," 
                            + hhObj.SoLuong + ",'" 
                            + hhObj.Anh + "')";
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

        public bool UpdData(string ma, string ten, string sl, string dongia, string anh)
        {
            cmd.CommandText = @"update tb_HangHoa set TenHang='"+ten.ToString()+"' ,SoLuong="+sl.ToString()+", DonGia = "+dongia.ToString()+", Anh='"+anh.ToString()+"' where MaHang='"+ma.ToString()+"'";
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

        public bool UpdSLH(string mahh, int SL)
        {
            cmd.CommandText = "Update tb_HangHoa set  SoLuong = " 
                                + SL + " Where MaHang = '" 
                                + mahh + "'";
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
        public bool UpdSL(DataTable dt)
        {
            DataTable dthh = new DataTable();
            dthh = GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dthh.Rows.Count; j++)
                {
                    if (dt.Rows[i][1].ToString() == dthh.Rows[j][0].ToString())
                    {
                        int SLcu = int.Parse(dthh.Rows[j][3].ToString());
                        int SLmoi = int.Parse(dthh.Rows[j][3].ToString()) - int.Parse(dt.Rows[i][3].ToString());
                        if (!UpdSLH(dthh.Rows[j][0].ToString(), SLmoi))
                            return false;
                        break;
                    }
                }

            }
            return true;
        }
        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete tb_HangHoa Where MaHang = '" + ma + "'";
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
