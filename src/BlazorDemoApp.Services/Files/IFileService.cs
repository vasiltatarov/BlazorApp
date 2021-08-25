namespace BlazorDemoApp.Services.Files
{
    using System.Threading.Tasks;

    public interface IFileService
    {
        Task Create(string name, string userId);
    }
}
