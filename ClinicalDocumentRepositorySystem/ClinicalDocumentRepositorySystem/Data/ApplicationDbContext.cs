using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClinicalDocumentRepositorySystem.Models;

namespace ClinicalDocumentRepositorySystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ClinicalDocumentRepositorySystem.Models.Clinic> Clinic { get; set; } = default!;
        public DbSet<ClinicalDocumentRepositorySystem.Models.ClinicalRecord> ClinicalRecord { get; set; } = default!;
        public DbSet<ClinicalDocumentRepositorySystem.Models.Patient> Patient { get; set; } = default!;
    }
}
