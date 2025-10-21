using System.Windows.Forms;

namespace TaskTimer.Services
{
    static class NotificationService
    {
        private static NotifyIcon? notifyIcon;

        public static void Init()
        {
            notifyIcon = new NotifyIcon
            {
                Visible = true,
                Icon = SystemIcons.Information
            };
        }
        public static void Show(string title, string message)
        {
            notifyIcon?.ShowBalloonTip(4000, title, message, ToolTipIcon.Info);
        }
    }
}
