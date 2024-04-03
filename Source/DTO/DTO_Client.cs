using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Client
    {
        string makh, tenkh,mail, gt, sdt, dc, ngay;
        public string MaKH { get => makh; set => makh = value; }
        public string TenKH { get => tenkh; set => tenkh = value; }
        public string Mail { get => mail; set => mail = value; }
        public string GT { get => gt; set => gt = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string DC { get => dc; set => dc = value; }
        public string NgayThem { get => ngay; set => ngay = value; }


        public DTO_Client() { }
        public DTO_Client(string makh, string tenkh, string gt,string mail, string sdt, string dc, string ngay)
        {
            MaKH = makh;
            TenKH = tenkh;
            GT = gt;
            Mail = mail;
            SDT = sdt;
            DC = dc;
            NgayThem = ngay;
        }
    }
}
