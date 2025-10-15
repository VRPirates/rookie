namespace AndroidSideloader
{
    public sealed class StartupOptions
    {
        public bool OfflineMode { get; set; } = false;

        public bool RcloneUpdatesDisabled { get; set; }

        public bool NoAppCheck { get; set; } = false;
    }
}
