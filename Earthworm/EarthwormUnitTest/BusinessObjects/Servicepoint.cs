using System;
using Earthworm;

public class Servicepoint : MappableFeature
{
    [MappedField("FACILITYID", 20)]
    public virtual string FACILITYID { get; set; }

    [MappedField("ANCILLARYROLE")]
    public virtual short? ANCILLARYROLE { get; set; }

    [MappedField("ROTATION")]
    public virtual double? ROTATION { get; set; }

    [MappedField("ENABLED")]
    public virtual short? ENABLED { get; set; }

    [MappedField("NETWORKID", 30)]
    public virtual string NETWORKID { get; set; }

    [MappedField("PHASECODE")]
    public virtual int? PHASECODE { get; set; }

    [MappedField("STATIONID", 40)]
    public virtual string STATIONID { get; set; }

    [MappedField("COMMENTS", 255)]
    public virtual string COMMENTS { get; set; }

    [MappedField("UID", 40)]
    public virtual string UID { get; set; }

    [MappedField("SESSIONID", 40)]
    public virtual string SESSIONID { get; set; }

    [MappedField("X")]
    public virtual double? X { get; set; }

    [MappedField("Y")]
    public virtual double? Y { get; set; }

    [MappedField("Z")]
    public virtual double? Z { get; set; }
}
