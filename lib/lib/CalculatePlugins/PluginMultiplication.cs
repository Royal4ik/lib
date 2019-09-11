using System.Drawing;

namespace ds.test.impl
{
    internal class PluginMultiplication : IPlugin
    {
        public string PluginName { get; }
        public string Version { get; }
        public Image Image { get; }
        public string Description { get; }

        public PluginMultiplication(string description)
        {
            PluginName = "Plugin Multiplication";
            Version = "2.0.0";
            Description = description;
            Image = lib.Properties.Resources.PluginMultiplication;
        }

        public int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}