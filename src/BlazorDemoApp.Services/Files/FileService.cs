namespace BlazorDemoApp.Services.Files
{
    using System.Threading.Tasks;
    using Data;
    using Data.Models;

    public class FileService : IFileService
    {
        private readonly ApplicationDbContext _data;

        public FileService(ApplicationDbContext data) 
            => _data = data;

        public async Task Create(string name, string userId)
        {
            await _data.Images.AddAsync(new Image
            {
                Name = name,
                UserId = userId,
            });

            await _data.SaveChangesAsync();
        }
    }
}
