namespace OnDarkModeChange
{
    public class Settings
    {
        public ExeWithArgs[]? OnDarkModeCommands { get; set; }
        public ExeWithArgs[]? OnLightModeCommands { get; set; }

        public class ExeWithArgs
        {
            public string? CommandFileName { get; set; }
            public string? Args { get; set; }
        }
    }
}