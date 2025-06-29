using CPPlatform.Core.Base;

namespace CPPlatform.Entities.Entities
{
    /// <summary>
    /// Kullanıcılar için sunulan eğitim içeriklerini temsil eder
    /// </summary>
    public class LearningContent : BaseEntity
    {
        public string Title { get; set; } // İçeriğin başlığı

        public string ContentType { get; set; } // İçerik tipi (örneğin: Video, Yazı, Ses)

        public string ContentUrl { get; set; } // İçeriğin bağlantı adresi

        public string? Description { get; set; } // Açıklama (isteğe bağlı)
    }
}
