namespace df1050.OneBotSharp.OneBotv11.Messages;

public class FaseData
{
    [JsonInclude, JsonPropertyName("id")]
    public int Id { get; set; }
    public FaseData(int Id) => this.Id = Id;
    public FaseData() => Id = 0;
}