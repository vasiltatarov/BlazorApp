namespace BlazorDemoApp.Data.Models
{
    public class Like
    {
        public int ImageId { get; set; }

        public Image Image { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public bool IsActive { get; set; }
    }
}
