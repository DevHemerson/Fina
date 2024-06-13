using System.Text.Json.Serialization;

namespace Fina.Core.Responses;
public class Response<TData>
{
    private int _statusCode = Configurations.DefaultStatusCode;

    [JsonConstructor]
    public Response()
    {
        _statusCode = Configurations.DefaultStatusCode;
    }

    public Response(TData? data, int statusCode = Configurations.DefaultStatusCode, string? message = null)
    {
        _statusCode = statusCode;
        Message = message;
        Data = data;
    }

    public string? Message { get; set; }
    public TData? Data { get; set; }

    [JsonIgnore]
    public bool IsSuccess => _statusCode is >= 200 and <= 299;
}
