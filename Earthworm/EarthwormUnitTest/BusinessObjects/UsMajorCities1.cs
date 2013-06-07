using System;
using Earthworm;

public class UsMajorCities1 : MappableFeature
{
    [MappedField("NAME", 40)]
    public virtual string NAME { get; set; }

    [MappedField("ST", 2)]
    public virtual string ST { get; set; }

    [MappedField("ZIP", 5)]
    public virtual string ZIP { get; set; }

    [MappedField("RuleID")]
    public virtual int? RuleID { get; set; }

    [MappedField("Override")]
    public virtual byte[] Override { get; set; }
}