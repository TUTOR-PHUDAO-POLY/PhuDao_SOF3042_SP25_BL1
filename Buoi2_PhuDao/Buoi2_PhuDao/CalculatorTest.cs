using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_PhuDao
{
    [TestFixture] 
    public class CalculatorTest
    {

        // Khoi tao gia tri mac dinh 
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // Test success
        [TestCase(1,1)] // tai bien nho nhat 
        [TestCase(int.MaxValue,int.MaxValue)] // tai bien lon nhat 
        [TestCase(100,100)] // Phan vung tai gia tri hop le 
        [TestCase(10,10)] // gia tri trung binh ( dk thoa man cua khoang bien)
        [TestCase(999,999)] // gia tri lon hon ( dk thoa man cua khoang bien)
        public void TestFunctionSuccessTinhGiaTriTuyetDoi(int number, int ketQuaMongMuon)
        {
            var ketQuaThucTe = _calculator.TinhTriTuyetDoi(number);
            Assert.That(ketQuaThucTe,Is.EqualTo(ketQuaMongMuon));   
        }
        // Test Fail 
        // 1 => doi vs cac so nguyen am: -1, -2... 
        // 0 
        [TestCase(-1)] 
        [TestCase(-10)] 
        [TestCase(-100)] 
        [TestCase(-999)] 
        [TestCase(int.MinValue)] 
       public void TestFunctionFailTinhGiaTriTuyetDoiVoiCacSoAm(int number)
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException),
                () => _calculator.TinhTriTuyetDoi(number));
        }

        [Test]
        public void TestFunctionFailTinhGiaTriTuyetDoiVoiSo0()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException),
                () => _calculator.TinhTriTuyetDoi(0));
        }

        // Don dep bo nho 
        [TearDown] public void TearDown()
        {
            _calculator = null;
        }
    }
}
