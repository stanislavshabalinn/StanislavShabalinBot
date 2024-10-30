using StanislavShabalinBot.Models;
using StanislavShabalinBot.Models;

namespace StanislavShabalinBot.Services
{
    public interface IStorage
    {
        /// <summary>
        /// Получение сессии пользователя по идентификатору
        /// </summary>
        Session GetSession(long chatId);
    }
}