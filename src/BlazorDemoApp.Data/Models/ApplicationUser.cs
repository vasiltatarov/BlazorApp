namespace BlazorDemoApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public IEnumerable<Image> Images { get; set; } = new HashSet<Image>();

        public IEnumerable<Like> Likes { get; set; } = new HashSet<Like>();
    }
}
