using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_PhuDao
{
    public class SanPhamDienTuService
    {
        private List<SanPhamDienTu> lists = new List<SanPhamDienTu>();

        public void AddSanPham(SanPhamDienTu sp)
        {
            // check trong truoc khi add
            // check doi tuong null
            if(sp == null)
            {
                throw new ArgumentNullException("San pham dang bi null");
            }
            // check trong: "" , "     " => string.IsNullOrWriteSpace
            if(string.IsNullOrWhiteSpace(sp.MaSP) || string.IsNullOrWhiteSpace(sp.TenSP)
                || string.IsNullOrWhiteSpace(sp.ThuongHieu)
                )
            {
                throw new ArgumentException("Khong duoc de trong");
            }
            // GS: so la so nguyen duong
            if(sp.Gia <= 0)
            {
                throw new ArgumentException("Gia khong duoc phep nho hon 0 ");
            }
            if (sp.SoLuong <= 0)
            {
                throw new ArgumentException("So luong khong duoc phep nho hon 0 ");
            }
            if (sp.BaoHanh <= 0)
            {
                throw new ArgumentException("Bao hanh khong duoc phep nho hon 0 ");
            }
            // check moi thu xong moi add
            lists.Add(sp);
        }

        public List<SanPhamDienTu > getList()
        {
            return lists;
        }
    }
}
