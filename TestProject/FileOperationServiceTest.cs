using PersonApi.Services;

namespace TestProject
{
    public class FileOperationServiceTest
    {
        //Arrange
        private readonly FileOperationService _sut = new FileOperationService();

        [Theory]
        [InlineData(@"C:\Users\n-abb\OneDrive\Documents\FileCreateWrite\FileCreateWrite.txt", "FileCreateWrite")]
        public async Task CreateWriteFile_CreateWriteFile(string filePath, string content)
        {
            //Act
            await _sut.CreateWriteFile(filePath, content);

            var result = File.ReadAllText(filePath);

            //Assert
            Assert.Equal(content, result);

        }

        [Theory]
        [InlineData(@"C:\Users\n-abb\OneDrive\Documents\FileCreateWrite\FileCreateWrite.txt", @"C:\Users\n-abb\OneDrive\Documents\FileCreateWrite\FileCreateWriteCopied.txt")]
        public void CopyFile_ReturnCreateACopy(string filePath, string destination)
        {
            _sut.CopyFile(filePath, destination);
        }

    }
}
