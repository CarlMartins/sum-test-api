using System.Net;

namespace Sum.Models;

public record Response
{
    public string Message { get; set; } = "Success";
    public HttpStatusCode Code { get; set; }
    public object? Value { get; set; }
}