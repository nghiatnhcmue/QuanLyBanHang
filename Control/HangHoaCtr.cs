using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;

namespace QL_BanHang.Control
{
    class HangHoaCtr
    {
        HangHoaMod hhMod = new HangHoaMod();
        public DataTable GetData()
        {
            return hhMod.GetData();
        }
        public string MaHangHoa()
        {
            return hhMod.MaHangHoa();
        }
        public DataTable GetData(string dieukien)
        {
            return hhMod.GetData(dieukien);
        }
        public bool AddData(HangHoaObj hhObj)
        {
            return hhMod.AddData(hhObj);
        }
        public bool UpdData(string ma, string ten, string sl, string dongia, string anh)
        {
            return hhMod.UpdData(ma,ten,sl,dongia,anh);
        }
        public bool UpdSL(DataTable dt)
        {
            return hhMod.UpdSL(dt);
        }
        public bool UpdSLH(string mahh, int SL)
        {
            return hhMod.UpdSLH(mahh, SL);
        }
        public bool DelData(string ma)
        {
            return hhMod.DelData(ma);
        }
    }
}
