using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Model
{
    class NhanVienObj
    {
        string ma, ten, gioiTinh, diaChi, sdt, matKhau;
        DateTime namSinh;

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public DateTime NamSinh
        {
            get
            {
                return namSinh;
            }

            set
            {
                namSinh = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public NhanVienObj() { }
        public NhanVienObj(string ma, string ten, string gioiTinh, DateTime namSinh, string diaChi, string sdt, string matKhau)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.matKhau = matKhau;
        }
    }
}
