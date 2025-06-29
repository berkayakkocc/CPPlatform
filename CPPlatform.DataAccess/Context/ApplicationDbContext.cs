using CPPlatform.Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CPPlatform.DataAccess.Context
{
    /// <summary>
    /// Uygulamanın veritabanı bağlamı. Identity ve domain entity'lerini içerir.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<ForumPost> ForumPosts { get; set; }

        public DbSet<LearningContent> LearningContents { get; set; }

        public DbSet<SupportRequest> SupportRequests { get; set; }

        // Fluent API konfigürasyonları gerekiyorsa buraya override edilebilir
    }
}
