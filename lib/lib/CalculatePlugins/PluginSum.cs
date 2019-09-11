using System.Drawing;

namespace ds.test.impl
{
    internal class PluginSum : IPlugin
    {
        public string PluginName { get; }
        public string Version { get; }
        public Image Image { get; }
        public string Description { get; }

        public PluginSum(string description)
        {
            PluginName = "Plugin Sum";
            Version = "2.0.0";
            Description = description;
            Image = lib.Properties.Resources.PluginSum;
        }

        public int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}