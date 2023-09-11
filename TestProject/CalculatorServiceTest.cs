using PersonApi.Services;

namespace TestProject
{
    public class CalculatorServiceTest
    {
        private readonly CalculatorService _sut = new CalculatorService();

        [Theory]
        [InlineData(2.2, 3.1, 5.3)]
        [InlineData(4, 5.8, 9.8)]
        [InlineData(-3, -3.2, -6.2)]
        public void AddAsync_ReturnSum(double x, double y, double expected)
        {
            //Arrange
            //var _sut = new CalculatorService();

            //Act
            var result = _sut.AddAsync(x, y);

            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(5.30, 2.20, 3.10)]
        //[InlineData(9.8, 4, 5.8)]
        //[InlineData(-7.20, -3, -3.20, -1)]
        public void AddParamsAsync_ReturnSumOfParams(double expected, params double[] nums)
        {
            //Arrange
            //var _sut = new CalculatorService();

            //Act
            var result = _sut.AddParamsAsync(nums);

            //Assert
            Assert.Equal(expected, result);

        }


    }
}
