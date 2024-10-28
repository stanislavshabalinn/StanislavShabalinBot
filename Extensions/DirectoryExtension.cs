using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;
using StanislavShabalinBot.Controllers;
using StanislavShabalinBot.Services;
using StanislavShabalinBot.Configuration;

namespace StanislavSabalinBot.Extensions
{
    public static class DirectoryExtension
    {
        /// <summary>
        /// Получаем путь до каталога с .sln файлом 
        /// </summary>
        public static string GetSolutionRoot()
        {
            var dir = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            var fullname = Directory.GetParent(dir).FullName;
            var projectRoot = fullname.Substring(0, fullname.Length - 4);
            return Directory.GetParent(projectRoot)?.FullName;
        }
    }
}