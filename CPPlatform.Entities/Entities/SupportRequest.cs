using CPPlatform.Core.Base;
using System;

namespace CPPlatform.Entities.Entities
{
    /// <summary>
    /// Kullanıcının destek talebi gönderdiği veriyi temsil eder
    /// </summary>
    public class SupportRequest : BaseEntity
    {
        public string UserId { get; set; } // Talebi gönderen kullanıcının ID'si

        public string Message { get; set; } // Kullanıcının mesajı

        public bool IsResolved { get; set; } = false; // Talep çözüldü mü?

        public DateTime CreatedAtLocal => CreatedAt.ToLocalTime(); // Yerel saatle oluşturulma zamanı

        // Navigation Properties
        public ApplicationUser User { get; set; } // Kullanıcı ilişkisi
    }
}
