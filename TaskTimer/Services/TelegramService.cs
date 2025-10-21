using Telegram.Bot;

namespace TaskTimer.Services
{
    public static class TelegramService
    {
        private static TelegramBotClient? bot;
        private static long chatId; 

        public static void Init(string token, long userId)
        {
            bot = new TelegramBotClient(token);
            chatId = userId;
        }
        public static async Task SendMessage(string message)
        {
            if (bot == null) return;
            await bot.SendMessage(chatId, message);
        }
    }
}
