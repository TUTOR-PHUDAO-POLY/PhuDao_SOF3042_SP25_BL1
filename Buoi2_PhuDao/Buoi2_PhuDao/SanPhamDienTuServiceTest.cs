using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_PhuDao
{
    [TestFixture]
    public class SanPhamDienTuServiceTest
    {
        private SanPhamDienTuService _service;

        [SetUp]
        public void Setup()
        {
            _service = new SanPhamDienTuService();
        }

        // case 1: test thanh cong them 1 san pham
        [Test]
        public void TestFunctionAddSanPhamSuccessWithOneSanPham()
        {
            SanPhamDienTu sp = new SanPhamDienTu("SP01","San pham 1",10.5F,1,10,"Thuong hieu 1");
            _service.AddSanPham(sp);
            // kiem tra
            var lists = _service.getList();
            // kiem tra size da duoc tang 
            Assert.That(lists.Count, Is.EqualTo(1));
            // Kiem tra tt cua doi tuong add la dung thuc su ton tai trong list 
            Assert.That(lists[0].MaSP, Is.EqualTo("SP01"));
            Assert.That(lists[0].TenSP, Is.EqualTo("San pham 1"));
            // kiem tra cac truong con lai
        }

        // case 2: test thanh cong voi 2 san pham 
        // case 3: test thanh cong voi 2 san pham chung ten 
        // case 4: Test faile => Check trong => Ma trong 
        [TestCase("")]
        [TestCase("     ")]
        public void TestFunctionAddFailWithMaEmpty(String ma)
        {
            SanPhamDienTu sp = new SanPhamDienTu(ma, "San pham 1", 10.5F, 1, 10, "Thuong hieu 1");
            var ex = Assert.Throws<ArgumentException>(() => _service.AddSanPham(sp));
            Assert.That(ex.Message, Is.EqualTo("Khong duoc de trong"));
        }

        // case 5: Ten trong, thuong hieu trong 
        // tuong tu case 4 
        // case 6: Gia <0 | So luong < 0 | Bao hang < 0 => Tuong tu vs case 4 
        
        [Test]
        public void TestFunctionAddFaileWithNull()
        {
            var ex = Assert.Throws<ArgumentException>(() => _service.AddSanPham(null));
            Assert.That(ex.Message, Is.EqualTo("San pham dang bi null"));
        }

        [TearDown]
        public void Teardown()
        {
            _service = null;
        }

    }
}
