using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_PhuDao
{
    [TestFixture] // Danh dau 1 class la class test trong C# 
    public class CalculatorTest
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            // setup cac gia tri ban dau => chi can khoi tao 1 lan 
            _calculator = new Calculator();
        }

        // viet unit test cho cac testcase cua cac ham ben class Calculator 
        // test 
        // Cu phap 1 cua 1 function test 
        //[Test]
        //public void TestChucNang1()
        //{
        //    int.m
        //    // lam gi thi lam => so sanh ket qua ....
        //}
        // tinh tong : min cua kieu du lieu int, max kieu du lieu int 

        // Case 1: Bien: Gia tri trong khoang hop le 
        //[Test]
        //public void TestChucNangTinhTongVoiGiaTriHopLe()
        //{
        //    //Calculator calculator = new Calculator();
        //    var ketQuaThucTe = _calculator.TinhTong(3, 2);
        //    // ss 2 gia tri voi: 1 ket qua thuc te (ket qua tu function), 1 ket qua mong muon 
        //    // AreEqual(ket qua mong muon, ket qua thuc te)
        //    //Assert.AreEqual(5, ketQuaThucTe);
        //    // That: thuc te, mong muon
        //    Assert.That(ketQuaThucTe, Is.EqualTo(5));
        //}
        //[Test]
        //public void TestChucNangTinhTongVoiGiaTriHopLe1()
        //{
        //    //Calculator calculator = new Calculator();
        //    var ketQuaThucTe = _calculator.TinhTong(4, 2);
        //    // ss 2 gia tri voi: 1 ket qua thuc te (ket qua tu function), 1 ket qua mong muon 
        //    // AreEqual(ket qua mong muon, ket qua thuc te)
        //    //Assert.AreEqual(5, ketQuaThucTe);
        //    // That: thuc te, mong muon
        //    Assert.That(ketQuaThucTe, Is.EqualTo(6));
        //}

        //// Bien: int.MinValue : Tai Bien duoi
        //[Test]
        //public void TestChucNangTinhTongVoiGiaTriHopLeTaiBienDuoi()
        //{
        //    //Calculator calculator = new Calculator();
        //    int soThuNhat = int.MinValue + 1;
        //    int soThuHai = -1;
        //    var ketQuaThucTe = _calculator.TinhTong(soThuNhat,soThuHai);
        //    Assert.That(ketQuaThucTe, Is.EqualTo(int.MinValue));
        //}

        //// Bien: int.MaxValue : Tai Bien tren
        //[Test]
        //public void TestChucNangTinhTongVoiGiaTriHopLeTaiBienTren()
        //{
        //    //Calculator calculator = new Calculator();
        //    int soThuNhat = int.MaxValue - 1;
        //    int soThuHai = 1;
        //    var ketQuaThucTe = _calculator.TinhTong(soThuNhat, soThuHai);
        //    Assert.That(ketQuaThucTe, Is.EqualTo(int.MaxValue));
        //}

        //[Test]
        //public void TestChucNangTinhTongVoiGiaTriHopLeCuaSoKhongVoi1SoDuong()
        //{
        //    //Calculator calculator = new Calculator();
        //    int soThuNhat = 0;
        //    int soThuHai = 1;
        //    var ketQuaThucTe = _calculator.TinhTong(soThuNhat, soThuHai);
        //    Assert.That(ketQuaThucTe, Is.EqualTo(1));
        //}
        //// cac case khac nua

        // C2: Su dung bo data : Testcase

        [TestCase(3,2,5)] // trong khoang dieu kien => phan vung tuong duong
        [TestCase(4,2,6)] // gia tri hop le => bien
        [TestCase(int.MinValue +1 , -1, int.MinValue)] // tai bien duoi
        [TestCase(int.MaxValue -1 ,1,int.MaxValue)] // tai bien tren 
        public void TestChucNangTinhTongVoiGiaTriHopLe(int a, int b, int ketQuaMongMuon)
        {
            int ketQuaThucTe = _calculator.TinhTong(a, b);
            Assert.That(ketQuaThucTe,Is.EqualTo(ketQuaMongMuon));
        }

        // Viet testcase cho function tinh can bac hai 
        // 0 -> max value
        [TestCase(0,0)] // tai bien duoi 
        [TestCase(1,1)] // bien nho nhat 
        [TestCase(9,3)] // gia tri hop le => phan vung tuong duong
        [TestCase(int.MaxValue,46340.95)] // tai bien tren 
        [TestCase(100,10)] // gia tri lon 
        [TestCase(13,3.6055)] // gia tri le => so khong chinh phuong
        public void TestSuccessFunctionTinhCanBacHai(int number, double ketQuaMongMuon)
        {
            var ketQuaThucTe = _calculator.TinhCanBacHai(number);
            Assert.That(ketQuaThucTe, Is.EqualTo(ketQuaMongMuon).Within(0.0001));
        }

        // Fail => Ngoai le throw 
        // C1: Su dung Assert.throws
        // C2: tr...catch 
        // C1: 
        public void TestFunctionTinhCanBacHaiCuaSoNguyenFail()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), 
                () => _calculator.TinhCanBacHai(-3));
        }
        // C2: try...catch => Assert.Fail
        public void TestFunctionTinhCanBacHaiCuaSoNguyenFail1()
        {
            try
            {
                _calculator.TinhCanBacHai(-1);
                Assert.Fail("Hi vong co exception");
            }
            catch (ArgumentOutOfRangeException e)
            {
                // SS ngoai le mong muon vs ngoai le ma chuong trinh tra ra la 1 khong
                Assert.That(typeof(ArgumentOutOfRangeException),Is.EqualTo(e.GetType()));
            }
        }

        [TearDown]
        public void TearDown()
        {
            // don dep tai nguyen sau khi thuc hien function test 
            _calculator = null;
        }
    }
}
