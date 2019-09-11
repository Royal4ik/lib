using System;

namespace ds.test.impl
{
    internal class PluginDegree : NewPlugin
    {
        public override string PluginName { get; }
        public override string Description { get; }

        public PluginDegree(string description)
        {
            PluginName = "Plugin Degree";
            Description = description;
        }

        public override int Run(int input1, int input2)
        {
            return (int)Math.Pow(input1, input2);
        }
    }
}