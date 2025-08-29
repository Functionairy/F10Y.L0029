using System;

using F10Y.T0009;


namespace F10Y.L0029
{
    [WithXMarker]
    public interface IWith_DocumentationXml :
        IHas_DocumentationXml
    {
        new string DocumentationXml { get; set; }
    }
}
