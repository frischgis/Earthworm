using System;
using Earthworm;

public class County : MappableFeature
{
    [MappedField("NAME")]
    public virtual string NAME { get; set; }

    [MappedField("STATE_NAME")]
    public virtual string STATE_NAME { get; set; }

    [MappedField("AREA")]
    public virtual double? AREA { get; set; }

    [MappedField("POP2000")]
    public virtual int? POP2000 { get; set; }

    [MappedField("POP00_SQMI")]
    public virtual double? POP00_SQMI { get; set; }
}
