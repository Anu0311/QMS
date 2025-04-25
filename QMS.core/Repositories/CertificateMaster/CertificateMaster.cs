using QMS.core.DatabaseContext;
using QMS.core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QMS.core.Repositories.CertificateMaster
{
    public class CertificateMasterRepository : ICertificateMasterRepository
    {
        private readonly QMSDbContext _context;

        public CertificateMasterRepository(QMSDbContext context)
        {
            _context = context;
        }

        public async Task<List<CertificateMasterViewModel>> GetCertificatesAsync()
        {
            return await _context.CertificateMasters
                .Select(c => new CertificateMasterViewModel
                {
                    CertificateID = c.CertificateID,
                    CertificateName = c.CertificateName,
                    IssueDate = c.IssueDate,
                    ExpiryDate = c.ExpiryDate,
                    FileUploadPath = c.FileUploadPath,
                    CreatedDate = c.CreatedDate,
                    VendorID = c.VendorID,
                    Vendor = c.Vendor
                }).ToListAsync();
        }

        public async Task<CertificateMasterViewModel?> GetCertificateByIdAsync(int certificateId)
        {
            return await _context.CertificateMasters
                .Where(c => c.CertificateID == certificateId)
                .Select(c => new CertificateMasterViewModel
                {
                    CertificateID = c.CertificateID,
                    CertificateName = c.CertificateName,
                    IssueDate = c.IssueDate,
                    ExpiryDate = c.ExpiryDate,
                    FileUploadPath = c.FileUploadPath,
                    CreatedDate = c.CreatedDate,
                    VendorID = c.VendorID,
                    Vendor = c.Vendor
                }).FirstOrDefaultAsync();
        }

        public async Task<OperationResult> CreateCertificateAsync(CertificateMasterViewModel model)
        {
            try
            {
                var certificate = new CertificateMaster
                {
                    CertificateName = model.CertificateName,
                    IssueDate = model.IssueDate,
                    ExpiryDate = model.ExpiryDate,
                    FileUploadPath = model.FileUploadPath,
                    CreatedDate = DateTime.UtcNow,
                    VendorID = model.VendorID
                };

                _context.CertificateMasters.Add(certificate);
                await _context.SaveChangesAsync();

                return new OperationResult { Success = true, Message = "Certificate created successfully." };
            }
            catch (Exception ex)
            {
                return new OperationResult { Success = false, Message = ex.Message };
            }
        }

        public async Task<OperationResult> UpdateCertificateAsync(CertificateMasterViewModel model)
        {
            try
            {
                var certificate = await _context.CertificateMasters
                    .FirstOrDefaultAsync(c => c.CertificateID == model.CertificateID);

                if (certificate == null)
                    return new OperationResult { Success = false, Message = "Certificate not found." };

                certificate.CertificateName = model.CertificateName;
                certificate.IssueDate = model.IssueDate;
                certificate.ExpiryDate = model.ExpiryDate;
                certificate.FileUploadPath = model.FileUploadPath;
                certificate.CreatedDate = model.CreatedDate;
