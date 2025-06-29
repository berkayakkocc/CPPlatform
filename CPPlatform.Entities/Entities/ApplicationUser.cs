using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CPPlatform.Entities.Entities
{
    /// <summary>
    /// Uygulamadaki kullanıcıyı temsil eden ASP.NET Identity sınıfı
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } // Kullanıcının tam adı

        public string? Biography { get; set; } // Kısa biyografi (isteğe bağlı)

        public string? ProfileImageUrl { get; set; } // Profil fotoğrafı (URL)

        // Navigation Properties

        public ICollection<Appointment> Appointments { get; set; }

        public ICollection<ForumPost> ForumPosts { get; set; }

        public ICollection<SupportRequest> SupportRequests { get; set; }
    }
}
