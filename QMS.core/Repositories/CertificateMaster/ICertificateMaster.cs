using QMS.core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QMS.core.Repositories.CertificateMaster
{
    public interface ICertificateMasterRepository
    {
        Task<List<CertificateMasterViewModel>> GetCertificatesAsync();
        Task<CertificateMasterViewModel?> GetCertificateByIdAsync(int certificateId);
        Task<OperationResult> CreateCertificateAsync(CertificateMasterViewModel model);
        Task<OperationResult> UpdateCertificateAsync(CertificateMasterViewModel model);
        Task<OperationResult> DeleteCertificateAsync(int certificateId);
    }
}
