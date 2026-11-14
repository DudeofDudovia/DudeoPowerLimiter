namespace DudeoPowerLimiter
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
            Application.Run(new Form1());
            Application.EnableVisualStyles();
            //Application.Run(new TrayApplicationContext());
            //Application.SetCompatibleTextRenderingDefault(false);

        }
    }
    internal class TrayApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        public TrayApplicationContext()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Open Settings", null, OpenSettings);
            contextMenu.Items.Add("Enforce Limit", null, EnforceLimit);
            contextMenu.Items.Add("Remove Limit", null, RemoveLimit);
            contextMenu.Items.Add("Exit", null, Exit);

           /* trayIcon = new NotifyIcon()
            {
                Icon = Form1.CobaltBattery,
                ContextMenuStrip = contextMenu,
                Text = "Dudeo Power Limiter",
                Visible = true
            };*/
            //trayIcon.DoubleClick += OpenSettings;
        }
        private void OpenSettings(object sender, EventArgs e)
        {
            Form1 settingsForm = new Form1();
            settingsForm.Show();
        }
        private void Exit(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            Application.Exit();
        }
        private void RemoveLimit(object sender, EventArgs e)
        {

        }
        private void EnforceLimit(object sender, EventArgs e)
        {

        }
    }
}