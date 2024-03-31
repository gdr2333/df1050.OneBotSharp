namespace df1050.OneBotSharp.OneBotv11.Messages;

public class Fase : MessageBase<FaseData>
{
    [JsonInclude, JsonPropertyName("data")]
    public override FaseData Data { get; set; } = new();
}