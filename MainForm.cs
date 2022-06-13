using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OnDarkModeChange
{
    public partial class MainForm : Form
    {
        private readonly Settings _settings;

        public MainForm(Settings settings)
        {
            _settings = settings;
            InitializeComponent();
        }

        // https://docs.microsoft.com/en-us/answers/questions/715081/how-to-detect-windows-dark-mode.html
        [DllImport("UXTheme.dll", SetLastError = true, EntryPoint = "#138")]
        public static extern bool ShouldSystemUseDarkMode();

        private bool WasDarkMode { get; set; }

        private void stateCheckTimer_Tick(object sender, EventArgs e)
        {
            if (ShouldSystemUseDarkMode())
            {
                currentStateMenuItem.Text = "Currently in Dark Mode";
                currentStateLabel.Text = "DARK MODE!";
                if (!WasDarkMode)
                {
                    DoStuffDark();
                }
                WasDarkMode = true;
            }
            else
            {
                currentStateMenuItem.Text = "Currently in Light Mode";
                currentStateLabel.Text = "LIGHT MODE!";
                if (WasDarkMode)
                {
                    DoStuffLight();
                }
                WasDarkMode = false;
            }
        }

        private void DoStuffDark()
        {
            //using var _ = Process.Start(@"C:\Program Files\Rainmeter\Rainmeter.exe", "!LoadLayout \"CPU RAM clocks big monitor\"");
            foreach (var command in _settings.OnDarkMode)
            {
                using var _ = Process.Start(command.CommandFileName, command.Args);
            }
        }
        private void DoStuffLight()
        {
            foreach (var command in _settings.OnLightMode)
            {
                using var _ = Process.Start(command.CommandFileName, command.Args);
            }
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}