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

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            Settings settings = config.GetRequiredSection("Settings").Get<Settings>();

            Application.Run(new MainForm(settings));
        }
    }
}