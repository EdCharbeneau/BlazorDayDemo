﻿using GenFu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDay.Services
{
    public class LoggerService
    {
        
        public LoggerService()
        {

            // Generate random data
            var i = 0;
            A.Configure<LogItem>()
                .Fill(li => li.Id, () => { return i++; })
                .Fill(li => li.Message).AsLoremIpsumSentences(1);

            LogItems = A.ListOf<LogItem>();
        }

        public List<LogItem> LogItems { get; }
    }
}
