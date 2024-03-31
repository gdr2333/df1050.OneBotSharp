namespace df1050.OneBotSharp.OneBotv11.Messages;

public class Text : MessageBase<TextData>
{
    [JsonInclude, JsonPropertyName("data")]
    public override TextData Data { get; set; } = new();
}