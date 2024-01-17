namespace WebApplication1.Models;
// namespace oznacava grupu klasa 
public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
