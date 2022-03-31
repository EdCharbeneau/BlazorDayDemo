using BlazorComponentArtisan.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorComponentArtisan.Pages;

public partial class Index
{
    //@inject
    [Inject]
    LoggerService Logs { get; set; } = default!;
    void DeleteItem(LogItem item) => Logs.LogItems.Remove(item);

    string CssMap(LogItem item) => item.Level switch
    {
        LogLevel.Warning => "alert-warning",
        LogLevel.Critical => "alert-danger",
        LogLevel.Error => "alert-danger",
        _ => "alert-info"
    };
}
