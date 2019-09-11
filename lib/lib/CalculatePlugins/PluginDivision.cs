using System;

namespace ds.test.impl
{
    internal class PluginDivision : NewPlugin
    {
        public override string PluginName { get; }
        public override string Description { get; }

        public PluginDivision(string description)
        {
            PluginName = "Plugin Division";
            Description = description;
        }

        public override int Run(int input1, int input2)
        {
            if (input2 == 0) throw new DivideByZeroException("The second parameter must not be zero.");
            return input1 / input2;
        }
    }
}