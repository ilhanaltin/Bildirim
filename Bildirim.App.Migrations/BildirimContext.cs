using Bildirim.Domain.Entity.Entities.Authorization;
using Bildirim.Domain.Entity.Entities.Notify;
using Bildirim.Domain.Entity.Entities.Shared;
using Bildirim.Domain.Entity.Entities.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Bildirim.App.Migrations
{
    public class BildirimContext : DbContext
    {
        #region Dbsets

        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserVerification> UserVerification { get; set; }

        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<NotificationVote> NotificationVote { get; set; }
        public virtual DbSet<UserFavoriteNotifications> UserFavoriteNotifications { get; set; }
        
        public virtual DbSet<NotificationType> NotificationType { get; set; }
        public virtual DbSet<UserLoginType> UserLoginType { get; set; }
        public virtual DbSet<RoleType> RoleType { get; set; }
        public virtual DbSet<UserStatusType> UserStatusType { get; set; }


        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<County> County { get; set; }

        public virtual DbSet<Company> Company { get; set; }


        #endregion

        public BildirimContext(DbContextOptions<BildirimContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblies)
            {
                var typesToRegister = assembly.GetTypes()
                    .Where(t => t.GetInterfaces().Any(gi => gi.IsGenericType && gi.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))).ToList();

                foreach (var type in typesToRegister)
                {
                    dynamic configurationInstance = Activator.CreateInstance(type);
                    modelBuilder.ApplyConfiguration(configurationInstance);
                }
            }

            //modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<T> _Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
