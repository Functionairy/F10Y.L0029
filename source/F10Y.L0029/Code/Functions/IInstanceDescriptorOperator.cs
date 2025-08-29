using System;
using System.Threading.Tasks;

using F10Y.T0002;


namespace F10Y.L0029
{
    [FunctionsMarker]
    public partial interface IInstanceDescriptorOperator
    {
        public Task<InstanceDescriptor[]> Load_Instances(
            string instances_JsonFilePath)
            => Instances.JsonOperator.Load_FromFile<InstanceDescriptor[]>(
                instances_JsonFilePath);
    }
}
