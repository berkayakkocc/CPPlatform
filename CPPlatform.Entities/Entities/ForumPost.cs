using CPPlatform.Core.Base;

namespace CPPlatform.Entities.Entities
{
    /// <summary>
    /// Forum alanında kullanıcıların oluşturduğu mesajları temsil eder
    /// </summary>
    public class ForumPost : BaseEntity
    {
        public string UserId { get; set; } // Gönderiyi oluşturan kullanıcının ID'si

        public string Category { get; set; } // Forum kategorisi (örneğin: Destek, Tavsiye, Sorun)

        public string Title { get; set; } // Başlık

        public string Content { get; set; } // Mesaj içeriği

        public DateTime PostedDate { get; set; } = DateTime.UtcNow; // Yayınlanma tarihi

        // Navigation Properties
        public ApplicationUser User { get; set; } // Kullanıcı ilişkisi
    }
}
