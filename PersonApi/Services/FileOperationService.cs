namespace PersonApi.Services
{
    public class FileOperationService
    {
        public async Task CreateWriteFile(string path, string content)
        {
            await File.WriteAllTextAsync(path, content);
        }

        public void CopyFile(string path, string target)
        {
            var sourcePath = Path.GetFullPath(path);

            var targetPath = Path.GetFullPath(target);

            FileInfo fileInfo = new FileInfo(sourcePath);

            fileInfo.CopyTo(targetPath);
        }


    }
}
