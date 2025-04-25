using QMS.core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QMS.core.Repositories.VendorRepository
{
    public interface IVendorRepository
    {
        Task<List<VendorMasterViewModel>> GetVendorsListAsync();
        Task<VendorMasterViewModel?> GetVendorByIdAsync(int vendorId);
        Task<OperationResult> CreateVendorAsync(VendorMasterViewModel vendorViewModel, bool returnCreatedRecord = false);
        Task<OperationResult> UpdateVendorAsync(VendorMasterViewModel vendorViewModel, bool returnUpdatedRecord = false);
        Task<OperationResult> DeleteVendorAsync(int vendorId);
    }
}
