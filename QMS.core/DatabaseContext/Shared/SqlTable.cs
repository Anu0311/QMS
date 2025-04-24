using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QMS.core.DatabaseContext.Shared;

public class SqlTable
{
    [Key]
    public virtual int Id { get; set; }
    public virtual bool Deleted { get; set; }
}

public class SqlTableOverrideExample : SqlTable
{
    //-----------------------------------
    // SqlTable override
    //-----------------------------------
    [Key]
    [Column("ID")]
    public override int Id { get; set; }

    [Column("IsDeleted")]
    public override bool Deleted { get; set; }
    //------------ END overrides --------
}
