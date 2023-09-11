using PersonApi.Services;

namespace TestProject
{
    public class StringManipulationServiceTest
    {
        //Arrange
        private readonly StringManipulationService _sut = new StringManipulationService();

        [Theory]
        [InlineData("Duublicateed", "Dublicate")]
        public void RemoveDuplicateChars_ReturnRemovedDublicate(string str, string expected)
        {
            //Act
            var result = _sut.RemoveDuplicateChars(str);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        //[InlineData("Duublicateed")]
        public void RemoveDuplicateCharReturnArray_ReturnRemovedDublicate()
        {
            //Act
            var result = _sut.RemoveDuplicateCharReturnArray("Duublicateed");

            //Assert
            Assert.Equal("\"Duublicateed\"", result.ToString());
        }

        [Theory]
        [InlineData("Aram", "rama", true)]
        public void CheckAnagram_ReturnsComparison(string strA, string strB, bool expected)
        {
            //Act(call the service)
            var result = _sut.CheckAnagram(strA, strB);

            //Assert
            Assert.True(result);
        }


    }
}
