using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorArtisan.Services;
using Microsoft.Extensions.Logging;

namespace BlazorArtisan.Net5.Pages
{
    
    public partial class Index
    {
        //@inject
        [Inject]
        LoggerService logs { get; set; }
        void DeleteItem(LogItem item)
        {
            logs.LogItems.Remove(item);
        }

       string CssMap(LogItem item) =>
          item.Level switch
          {
              LogLevel.Warning => "alert-warning",
              LogLevel.Critical => "alert-danger",
              LogLevel.Error => "alert-danger",
              _ => "alert-info"
          };
    }
}
