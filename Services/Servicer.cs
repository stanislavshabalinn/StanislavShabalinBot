using StanislavSabalinBot;


namespace StanislavShabalinBot.Services
{
    public interface IFileHandler
    {
        Task Download(string fileId, CancellationToken ct);
        string Process(string param);
    }
}
