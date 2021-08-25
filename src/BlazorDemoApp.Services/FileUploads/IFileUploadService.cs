namespace BlazorDemoApp.Services.FileUploads
{
    using System.Threading.Tasks;
    using BlazorInputFile;

    public interface IFileUploadService
    {
        Task UploadFile(IFileListEntry file);
    }
}
