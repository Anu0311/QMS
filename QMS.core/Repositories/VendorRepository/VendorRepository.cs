using Microsoft.EntityFrameworkCore;
using QMS.core.DatabaseContext;
using QMS.core.Models;
using QMS.core.Repositories.VendorRepository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QMS.core.Repositories.VendorRepository
{
    public class VendorRepository : IVendorRepository
    {
        private readonly QMSDbContext _context;

        public VendorRepository(QMSDbContext context)
        {
            _context = context;
        }

        public async Task<List<VendorMasterViewModel>> GetVendorsListAsync()
        {
            return await _context.VendorMasters
                .Where(v => !v.IsDeleted)
                .Select(v => new VendorMasterViewModel
                {
                    VendorID = v.VendorID,
                    VendorName = v.VendorName,
                    Address = v.Address,
                    Email = v.Email,
                    MobileNumber = v.MobileNumber,
                    GSTNumber = v.GSTNumber,
                    CreatedDate = v.CreatedDate,
                    UpdatedDate = v.UpdatedDate,
                    CreatedBy = v.CreatedBy,
                    IsDeleted = v.IsDeleted,
                    IsActive = v.IsActive
                })
                .ToListAsync();
        }

        public async Task<VendorMasterViewModel?> GetVendorByIdAsync(int vendorId)
        {
            var vendor = await _context.VendorMasters.FindAsync(vendorId);
            if (vendor == null || vendor.IsDeleted) return null;

            return new VendorMasterViewModel
            {
                VendorID = vendor.VendorID,
                VendorName = vendor.VendorName,
                Address = vendor.Address,
                Email = vendor.Email,
                MobileNumber = vendor.MobileNumber,
                GSTNumber = vendor.GSTNumber,
                CreatedDate = vendor.CreatedDate,
                UpdatedDate = vendor.UpdatedDate,
                CreatedBy = vendor.CreatedBy,
                IsDeleted = vendor.IsDeleted,
                IsActive = vendor.IsActive
            };
        }

        public async Task<OperationResult> CreateVendorAsync(VendorMasterViewModel vendorViewModel, bool returnCreatedRecord = false)
        {
            var vendor = new VendorMaster
            {
                VendorName = vendorViewModel.VendorName,
                Address = vendorViewModel.Address,
                Email = vendorViewModel.Email,
                MobileNumber = vendorViewModel.MobileNumber,
                GSTNumber = vendorViewModel.GSTNumber,
                CreatedDate = vendorViewModel.CreatedDate ?? DateTime.Now,
                CreatedBy = vendorViewModel.CreatedBy,
                IsActive = vendorViewModel.IsActive,
                IsDeleted = false
            };

            _context.VendorMasters.Add(vendor);
            await _context.SaveChangesAsync();

            if (returnCreatedRecord)
            {
                vendorViewModel.VendorID = vendor.VendorID;
            }

            return new OperationResult { Success = true, Message = "Vendor created successfully", Data = returnCreatedRecord ? vendorViewModel : null };
        }

        public async Task<OperationResult> UpdateVendorAsync(VendorMasterViewModel vendorViewModel, bool returnUpdatedRecord = false)
        {
            var vendor = await _context.VendorMasters.FindAsync(vendorViewModel.VendorID);
            if (vendor == null || vendor.IsDeleted)
                return new OperationResult { Success = false, Message = "Vendor not found" };

            vendor.VendorName = vendorViewModel.VendorName;
            vendor.Address = vendorViewModel.Address;
            vendor.Email = vendorViewModel.Email;
            vendor.MobileNumber = vendorViewModel.MobileNumber;
            vendor.GSTNumber = vendorViewModel.GSTNumber;
            vendor.UpdatedDate = DateTime.Now;
            vendor.IsActive = vendorViewModel.IsActive;

            await _context.SaveChangesAsync();

            return new OperationResult { Success = true, Message = "Vendor updated successfully", Data = returnUpdatedRecord ? vendorViewModel : null };
        }

        public async Task<OperationResult> DeleteVendorAsync(int vendorId)
        {
            var vendor = await _context.VendorMasters.FindAsync(vendorId);
            if (vendor == null || vendor.IsDeleted)
                return new OperationResult { Success = false, Message = "Vendor not found" };

            vendor.IsDeleted = true;
            await _context.SaveChangesAsync();

            return new OperationResult { Success = true, Message = "Vendor deleted successfully" };
        }
    }
}
