using QMS.core.Models;
using System;
using QMS.core.DatabaseContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QMS.core.Models
{
    public class PDIMasterViewModel
    {
    [Key]
    public int PDI_ID { get; set; }

    [ForeignKey("VendorMaster")]
    public int? VendorID { get; set; }

    [StringLength(50)]
    public string? LotNumber { get; set; }

    [StringLength(150)]
    // Consider VARCHAR(500) for Remarks
    public string? Remarks { get; set; }

    [StringLength(50)]
    // Consider VARCHAR(255) for ReportUploadPath
    public string? ReportUploadPath { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual VendorMaster? Vendor { get; set; }
}}