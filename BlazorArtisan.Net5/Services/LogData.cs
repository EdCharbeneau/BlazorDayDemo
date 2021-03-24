using Microsoft.Extensions.Logging;

namespace BlazorArtisan
{
    public class LogItem
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public LogLevel Level { get; set; }
    }
}
