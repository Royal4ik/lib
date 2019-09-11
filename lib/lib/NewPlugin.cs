using System.Drawing;

namespace ds.test.impl
{
    internal abstract class NewPlugin : IPlugin
    {
        protected NewPlugin()
        {
            Version = "1.0.0";
            Image = lib.Properties.Resources.NewPlugin;
        }

        public abstract string PluginName { get; }
        public string Version { get; }
        public Image Image { get; }
        public abstract string Description { get; }
        public abstract int Run(int input1, int input2);
    }
}

