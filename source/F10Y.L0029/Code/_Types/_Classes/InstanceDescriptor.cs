using System;

using F10Y.T0004;


namespace F10Y.L0029
{
    /// <summary>
    /// Instance descriptor data.
    /// </summary>
    // Prior work: D8S.L0014.T000.
    [DataTypeMarker]
    public class InstanceDescriptor :
        IWith_DocumentationXml
    {
        public string InstanceVariety { get; set; }
        public string IdentityString { get; set; }
        public string SignatureString { get; set; }
        public string ProjectFilePath { get; set; }
        public string DocumentationXml { get; set; }
        public DateTime LastModifiedTime { get; set; }

        public string SurveyAttributesList { get; set; }


        public override string ToString()
        {
            var output = $"{this.IdentityString}\n{this.InstanceVariety}\n{this.ProjectFilePath}";
            return output;
        }
    }
}
