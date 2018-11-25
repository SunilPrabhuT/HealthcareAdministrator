namespace Healthcare.Administrator.DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SmartChefDbContext : DbContext
    {
        public SmartChefDbContext()
            : base("name=SmartChefDbContext")
        {
        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<HealthcareAdministrator_Address> HealthcareAdministrator_Address { get; set; }
        public virtual DbSet<HealthcareAdministrator_PhyscianNurse> HealthcareAdministrator_PhyscianNurse { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Master_Diseases> Master_Diseases { get; set; }
        public virtual DbSet<Master_Patient> Master_Patient { get; set; }
        public virtual DbSet<Master_Rule> Master_Rule { get; set; }
        public virtual DbSet<PatientPopulationData> PatientPopulationData { get; set; }
        public virtual DbSet<SmsLog> SmsLog { get; set; }
        public virtual DbSet<Master_Patient_Rule> Master_Patient_Rule { get; set; }
        public virtual DbSet<Master_PCP> Master_PCP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<HealthcareAdministrator_Address>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_Address>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_Address>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_Address>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_Address>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_Address>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_Address>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_Address>()
                .HasMany(e => e.Master_Patient)
                .WithRequired(e => e.HealthcareAdministrator_Address)
                .HasForeignKey(e => e.AddressId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HealthcareAdministrator_Address>()
                .HasMany(e => e.HealthcareAdministrator_PhyscianNurse)
                .WithOptional(e => e.HealthcareAdministrator_Address)
                .HasForeignKey(e => e.AddressId);

            modelBuilder.Entity<HealthcareAdministrator_PhyscianNurse>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_PhyscianNurse>()
                .Property(e => e.RoleId)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_PhyscianNurse>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_PhyscianNurse>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_PhyscianNurse>()
                .Property(e => e.AddressId)
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_PhyscianNurse>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HealthcareAdministrator_PhyscianNurse>()
                .Property(e => e.PCPId)
                .IsUnicode(false);

            modelBuilder.Entity<Master_Diseases>()
                .HasMany(e => e.Master_Rule)
                .WithOptional(e => e.Master_Diseases)
                .HasForeignKey(e => e.DiseaseId);

            modelBuilder.Entity<Master_Patient>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Master_Patient>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Master_Patient>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Master_Patient>()
                .Property(e => e.AddressId)
                .IsUnicode(false);

            modelBuilder.Entity<Master_Patient_Rule>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Master_PCP>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Master_PCP>()
                .Property(e => e.AddressId)
                .IsUnicode(false);

            modelBuilder.Entity<Master_PCP>()
                .Property(e => e.PCPName)
                .IsUnicode(false);
        }
    }
}
