namespace df1050.OneBotSharp.OneBotv11.Messages;

public class Fase : MessageBase<FaseData>
{
    [JsonInclude, JsonPropertyName("data")]
    public override FaseData Data { get; set; }
    public Fase()
    {
        Type = MessageType.Face;
        Data = new();
    }
    public Fase(int Id)
    {
        Type = MessageType.Face;
        Data = new(Id);
    }
}