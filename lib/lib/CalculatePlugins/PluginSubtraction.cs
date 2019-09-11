using System.Drawing;

namespace ds.test.impl
{
    internal class PluginSubtraction : IPlugin
    {
        public string PluginName { get; }
        public string Version { get; }
        public Image Image { get; }
        public string Description { get; }

        public PluginSubtraction(string description)
        {
            PluginName = "Plugin Subtraction";
            Version = "2.1.0";
            Description = description;
            Image = lib.Properties.Resources.PluginSubtraction;
        }

        public int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}