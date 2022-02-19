using System;
using Xunit;

namespace XUnitTestProject_15._02._2022
{
    namespace TestProject1
    {       
        public class UnitTest1
        {
            [Theory]
            [InlineData(0, 1, 9, 1)]
            [InlineData(0, 0, 0, 0)]
            [InlineData(-1, 0, 1, 4)]
            [InlineData(10, 55, 99, -935)]
            [InlineData(1.2345678, 1234567.8, 0.000012345678, 1524157652796.84)]
            [InlineData(0, 0.1, 0.001, 0.010000000000000002)]
            [InlineData(0, 0.010000000000000002, 1, 0.00010000000000000005)]
            [InlineData(0.1, 0.001, 0.0001, -3.9000000000000006E-05)]
            [InlineData(2.2250738585072014, 2.2250738585, 1.7976931348623158, -11.049046324219919)]
            [InlineData(1.7, 1.79, 1.797, -9.0155)]
            [InlineData(1.7976, 1.79769, 1.797693, -9.6944424111)]
            [InlineData(1.7976931, 1.79769313, 1.797693134, -9.695101581987505)]
            [InlineData(1.7976931348, 1.79769313486, 1.797693134862, -9.695101820951258)]
            [InlineData(1.7976931348623, 1.797693134862329, 1.7976931348623299, -9.69510182139324)]
            [InlineData(-1, -0.1, 1.79769313486232, 7.20077253944928)]
            [InlineData(-1.7, -1.79, -1.797, -9.0155)]
            [InlineData(-1.7976, -1.79769, -1.797693, -9.6944424111)]
            [InlineData(-1.7976931, -1.79769313, -1.797693134, -9.695101581987505)]
            [InlineData(-1.7976931348, -1.79769313486, -1.797693134862, -9.695101820951258)]
            [InlineData(-1.7976931348623, -1.797693134862329, -1.7976931348623299, -9.69510182139324)]                      

            public void Test1(double item1, double item2, double item3, double expected)
            {
                double actual = Class1.ForTest(item1, item2, item3);
                Assert.Equal(expected, actual);
            }
        }
    }
}
