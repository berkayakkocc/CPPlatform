using CPPlatform.Core.Base;
using System;

namespace CPPlatform.Entities.Entities
{
    /// <summary>
    /// Kullanıcının aldığı randevuları temsil eder
    /// </summary>
    public class Appointment : BaseEntity
    {
        public string UserId { get; set; } // ASP.NET Identity kullanıcısının ID'si

        public DateTime AppointmentDate { get; set; } // Randevu tarihi

        public string Title { get; set; } // Randevu başlığı

        public string? Description { get; set; } // Açıklama (isteğe bağlı)

        public bool IsReminderEnabled { get; set; } = true; // Hatırlatma açık mı?

        // Navigation Properties
        public ApplicationUser User { get; set; } // Kullanıcı ilişkisi
    }
}
