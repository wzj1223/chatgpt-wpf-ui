
namespace OpenAI;

public class ChatServiceSettings
{
    public string? Model { get; set; }
    public ChatMessage[]? Messages { get; set; }
    public string? Suffix { get; set; }
    public decimal Temperature { get; set; }
    public int MaxTokens { get; set; }
    public decimal TopP { get; set; }
    public string? Stop { get; set; }

    public string? ApiKey { get; set; }
}
