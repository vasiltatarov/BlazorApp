namespace BlazorDemoApp.Services.FileUploads
{
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Hosting;
    using BlazorInputFile;

    public class FileUploadService : IFileUploadService
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public FileUploadService(IHostingEnvironment hostBuilder)
            => _hostingEnvironment = hostBuilder;

        public async Task UploadFile(IFileListEntry fileEntry)
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath, fileEntry.Name);

            var memoryStream = new MemoryStream();

            await fileEntry.Data.CopyToAsync(memoryStream);

            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}
