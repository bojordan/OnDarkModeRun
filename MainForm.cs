using System.Diagnostics;

namespace OnDarkModeRun
{
    public partial class MainForm : Form
    {
        private readonly Settings _settings;

        public MainForm(Settings settings)
        {
            _settings = settings;
            InitializeComponent();
        }

        private bool WasDarkMode { get; set; }

        private void StateCheckTimer_Tick(object sender, EventArgs e)
        {
            if (Interop.ShouldSystemUseDarkMode())
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
            if (_settings.OnDarkModeCommands != null)
            {
                foreach (var command in _settings.OnDarkModeCommands)
                {
                    if (command.CommandFileName != null && command.Args != null)
                    {
                        using var _ = Process.Start(command.CommandFileName, command.Args);
                    }
                }
            }
        }
        private void DoStuffLight()
        {
            if (_settings.OnLightModeCommands != null)
            {
                foreach (var command in _settings.OnLightModeCommands)
                {
                    if (command.CommandFileName != null && command.Args != null)
                    {
                        using var _ = Process.Start(command.CommandFileName, command.Args);
                    }
                }
            }
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}