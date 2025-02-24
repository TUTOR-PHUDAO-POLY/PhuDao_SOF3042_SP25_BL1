using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_PhuDao
{
    public class SanPhamDienTu
    {
        // maSP - String, tenSP - String, gia - float,
        //baoHanh - int, soLuong - int, thuongHieu - String.
        private String maSP;
        private String tenSP;
        private float gia;
        private int baoHanh;
        private int soLuong;
        private String thuongHieu;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public float Gia { get => gia; set => gia = value; }
        public int BaoHanh { get => baoHanh; set => baoHanh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string ThuongHieu { get => thuongHieu; set => thuongHieu = value; }

        public SanPhamDienTu(string maSP, string tenSP, float gia, int baoHanh, int soLuong, string thuongHieu)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.Gia = gia;
            this.BaoHanh = baoHanh;
            this.SoLuong = soLuong;
            this.ThuongHieu = thuongHieu;
        }

        public SanPhamDienTu()
        {
        }
    }
}
