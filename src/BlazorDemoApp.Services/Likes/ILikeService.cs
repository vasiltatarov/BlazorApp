namespace BlazorDemoApp.Services.Likes
{
    using System.Threading.Tasks;

    public interface ILikeService
    {
        Task Like(int imageId, string userId);
    }
}
