using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDay
{
    public class LogItem
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public LogLevel Level { get; set; }
    }
}
