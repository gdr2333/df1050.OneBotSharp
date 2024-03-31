namespace df1050.OneBotSharp.OneBotv11.Messages;

public abstract class MessageBase
{
    [JsonInclude, JsonPropertyName("type")]
    public MessageType Type { get; protected set; }
}
public abstract class MessageBase<T> : MessageBase
{
    [JsonInclude, JsonPropertyName("data")]
    public abstract T Data { get; set; }
}