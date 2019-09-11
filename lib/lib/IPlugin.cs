namespace ds.test.impl
{
    /// <summary>
    /// The main interface for accessing plugins.
    /// Contains all properties and methods for working with the plugins
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        ///  Returns the plugin name
        /// </summary>
        string PluginName { get; }
        /// <summary>
        /// Returns the plugin version
        /// </summary>
        string Version { get; }
        /// <summary>
        /// Returns the plugin icon
        /// </summary>
        System.Drawing.Image Image { get; }
        /// <summary>
        /// Returns the plugin description
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Performs an operation on two integers, depending on the plugin type
        /// </summary>
        /// <param name="input1">Integer</param>
        /// <param name="input2">Integer</param>
        /// <returns>Result of processing two numbers</returns>
        int Run(int input1, int input2);
    }

}