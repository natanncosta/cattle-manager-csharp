namespace CattleManager.Domain.Models;

public class ServiceResponse<T>
{
    public T? Data { get; set; }
    public bool Success { get; set; } = true;
    public string Message { get; set; } = string.Empty;

    public ServiceResponse(T data)
    {
        Data = data;
    }

    public ServiceResponse(bool success, string message)
    {
        Success = success;
        Message = message;
    }

    public ServiceResponse() { }
}
