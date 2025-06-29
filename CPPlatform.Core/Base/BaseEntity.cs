namespace CPPlatform.Core.Base
{
    /// <summary>
    /// Tüm veri varlıkları (entity) için temel sınıf
    /// Ortak alanlar burada tanımlanır
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; } // Birincil anahtar (Primary Key)

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Oluşturulma tarihi

        public DateTime? UpdatedAt { get; set; } // Güncellenme tarihi

        public bool IsActive { get; set; } = true; // Aktiflik durumu (Soft delete için kullanılabilir)
    }
}
