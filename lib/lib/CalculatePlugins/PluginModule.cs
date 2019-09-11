using System;

namespace ds.test.impl
{
    internal class PluginModule : NewPlugin
    {
        public override string PluginName { get; }
        public override string Description { get; }

        public PluginModule(string description)
        {
            PluginName = "Plugin Module";
            Description = description;
        }

        public override int Run(int input1, int input2)
        {
            if (input2 == 0) throw new DivideByZeroException("The second parameter must not be zero.");
            return input1 % input2;
        }
    }
}

