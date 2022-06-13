using Microsoft.Extensions.Configuration;

namespace OnDarkModeChange
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            // Build a config object, using env vars and JSON providers.
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            Settings settings = config.GetRequiredSection("Settings").Get<Settings>();

            Application.Run(new MainForm(settings));
        }
    }

    public class Settings
    {
        public ExeWithArgs[] OnDarkMode { get; set; }
        public ExeWithArgs[] OnLightMode { get; set; }

        public class ExeWithArgs
        {
            public string CommandFileName { get; set; }
            public string Args { get; set; }
        }
    }
}