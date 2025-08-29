using System;


namespace F10Y.L0029
{
    public class InstanceDescriptorOperator : IInstanceDescriptorOperator
    {
        #region Infrastructure

        public static IInstanceDescriptorOperator Instance { get; } = new InstanceDescriptorOperator();


        private InstanceDescriptorOperator()
        {
        }

        #endregion
    }
}
