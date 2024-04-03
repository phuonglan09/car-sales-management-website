using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        string manv, tendn, pass, quyen;
        public string TenDN { get => tendn; set => tendn = value; }

        public string Pass { get => pass; set => pass = value; }

        public string MaNV { get => manv; set => manv = value; }
        public string Quyen { get => quyen; set => quyen = value; }

        public DTO_Account() { }
        public DTO_Account(string manv, string tendn, string pass, string quyen)
        {
            MaNV = manv;
            TenDN = tendn;
            Pass = pass;
            Quyen = quyen;
        }
    }
}
