using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        string manv, ten, gioitinh, email, phone, diachi;
        public string MaNV { get => manv; set => manv = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioitinh; set => gioitinh = value; }    
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string DiaChi { get => diachi; set => diachi = value; }


        public DTO_Staff() { }
        public DTO_Staff(string manv, string ten, string gioitinh, string email, string phone, string diachi)
        {
            MaNV = manv;
            Ten = ten;
            GioiTinh = gioitinh;
            Email = email;
            Phone = phone;
            DiaChi = diachi;   
        }
    }
}
