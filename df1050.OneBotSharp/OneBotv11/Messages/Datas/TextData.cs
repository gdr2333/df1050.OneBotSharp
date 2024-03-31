namespace df1050.OneBotSharp.OneBotv11.Messages;

public class TextData
{
    [JsonInclude, JsonPropertyName("text")]
    public string Text { get; set; }

    public TextData(string text)
    {
        Text = text;
    }

    public TextData()
    {
        Text = string.Empty;
    }
}