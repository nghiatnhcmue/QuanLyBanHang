using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;

namespace QL_BanHang.Control
{
    class HoaDonCtr
    {
        HoaDonMod hdMod = new HoaDonMod();
        public DataTable GetData()
        {
            return hdMod.GetData();
        }
        public int CountData()
        {
            return hdMod.CountData();
        }
        public DataTable GetData(string dk)
        {
            return hdMod.GetData(dk);
        }
        public int CountData(string dk)
        {
            return hdMod.CountData(dk);
        }
        public int SumDoanhThu(HoaDonObj hdObj)
        {
            return hdMod.SumDoanhThu(hdObj);
        }
        public string MaHoaDon()
        {
            return hdMod.MaHoaDon();
        }
        public bool AddData(HoaDonObj hdObj)
        {
            return hdMod.AddData(hdObj);
        }
        public bool DelData(string ma)
        {
            return hdMod.DelData(ma);
        }
    }
}
