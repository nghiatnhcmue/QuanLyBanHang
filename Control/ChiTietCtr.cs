using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Obiect;


namespace QL_BanHang.Control
{
    class ChiTietCtr
    {
        ChiTietMod ctMod = new ChiTietMod();
        public DataTable GetData(string ma)
        {
            return ctMod.GetData(ma);
        }
        public bool AddData(DataTable dt)
        {
            return ctMod.AddData(dt);
        }
        public bool DelData(string ma)
        {
            return ctMod.DelData(ma);
        }
        public DataTable ThongKeHangHoa(string thang, string nam)
        {
            return ctMod.ThongKeHangHoa(thang, nam);
        }
        public DataTable ThongKeNhanVien(string thang, string nam)
        {
            return ctMod.ThongKeNhanVien(thang, nam);
        }
    }
}
