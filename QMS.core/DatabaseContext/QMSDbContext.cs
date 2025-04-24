using Microsoft.EntityFrameworkCore;
using QMS.core.DatabaseContext;

namespace QMS.core.Data
{
    public class QMSDbContext : DbContext
    {
        public DbSet<AuditScoreMaster> AuditScoreMasters { get; set; }
        public DbSet<CertificateMaster> CertificateMasters { get; set; }
        public DbSet<ComplaintMaster> ComplaintMasters { get; set; }
        public DbSet<PDIMaster> PDIMasters { get; set; }
        public DbSet<ProductMaster> ProductMasters { get; set; }
        public DbSet<SPMParameterMaster> SPMParameterMasters { get; set; }
        public DbSet<SPMScores> SPMScores { get; set; }
        public DbSet<ThirdPartyTestReports> ThirdPartyTestReports { get; set; }
        public DbSet<VendorType> Types { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<VendorContactMaster> VendorContactMasters { get; set; }
        public DbSet<VendorDesignation> VendorDesignations { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public QMSDbContext(DbContextOptions<QMSDbContext> options)
        : base(options)
        {
        }
    }
}