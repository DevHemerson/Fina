namespace Fina.Core.Responses;
public class PagedResponse<TData>: Response<TData>
{
    
    public PagedResponse(TData? data, int totalCount, int currentPage = 1, int pageSize = Configurations.DefaultPageSize)
        : base(data)
    {
        Data = data;
        CurrentPage = currentPage;
        PageSize = pageSize;
        TotalCount = totalCount;
    }

    public PagedResponse(TData? data, int _statusCode = Configurations.DefaultStatusCode, string? message = null)
        :base(data, _statusCode, message)
    {
    }

    public int CurrentPage { get; set; }
    public int TotalPages => (int)Math.Ceiling(TotalPages / (double)PageSize);
    public int PageSize { get; set; } = Configurations.DefaultPageSize;
    public int TotalCount { get; set; }
}
