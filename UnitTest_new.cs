using System;
using Xunit;

namespace SE2_Calculator_unit_tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturn0WhenEmptyString()
        {
            var calc = new StringCalculator();
            var result = calc.Add("");
            Assert.Equal(0, result);
            //Assert.False(result == 0 ? true : false, "The empty string should return 0");

        }

        [Fact]
        public void ShouldReturnNumberWhenOneNumber()
        {
            var calc = new StringCalculator();
            var result = calc.Add("128");
            Assert.Equal(128, result);
            //Assert.False(result == 0 ? true : false, "The empty string should return 0");

        }

    }
}
