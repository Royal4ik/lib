using System;
using System.Collections.Generic;

namespace ds.test.impl
{
    /// <summary>
    /// Static class containing all available plugins
    /// </summary>
    public static class Plugins
    {
        private static readonly Dictionary<string, IPlugin> AllPlugins = new Dictionary<string, IPlugin>();
        /// <summary>
        /// Returns the total number of plugins
        /// </summary>
        public static int PluginsCount { get; }
        /// <summary>
        /// Returns an array containing the names of all plugins
        /// </summary>
        public static string[] GetPluginsNames { get; }

        static Plugins()
        {
            var plugins = new IPlugin[]
            {
                new PluginSubtraction("This plugin is designed to get the difference between two numbers"),
                new PluginSum("This plugin is designed to get the sum of two numbers"),
                new PluginMultiplication("This plugin is designed to get the product of two numbers"),
                new PluginDivision("This plugin is designed to get the quotient of two numbers"),
                new PluginModule(
                    "This plugin is designed to get the remainder of the division of the first number by the second"),
                new PluginDegree("This plugin is designed to get the first number raised to the power of the second")
            };

            GetPluginsNames = new string[plugins.Length];

            for (var i = 0; i < plugins.Length; i++)
            {
                AllPlugins.Add(plugins[i].PluginName, plugins[i]);
                GetPluginsNames[i] = plugins[i].PluginName;
            }

            PluginsCount = AllPlugins.Count;
        }

        /// <summary>
        /// Returns a plugin by its name
        /// </summary>
        /// <param name="pluginName">Plugin name</param>
        /// <returns>The plugin with interface IPlugin</returns>
        /// <exception cref="Exception"> Thrown when there is no plugin corresponding to the plugin name entered</exception>
        public static IPlugin GetPlugin(string pluginName)
        {
            try
            {
                return AllPlugins[pluginName];
            }
            catch (KeyNotFoundException)
            {
                throw new Exception("Plugin with specified name does not exist");
            }
        }
    }
}
