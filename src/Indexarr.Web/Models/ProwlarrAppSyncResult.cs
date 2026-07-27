namespace Indexarr.Web.Models;

public sealed class ProwlarrAppSyncResult
{
    public bool Success { get; init; }

    public bool DryRun { get; init; }

    public int QueuedCount { get; init; }

    public int FailedCount { get; init; }

    public string Message { get; init; } = string.Empty;
}
