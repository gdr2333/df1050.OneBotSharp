namespace df1050.OneBotSharp.OneBotv11.Messages;

public class ImageData
{
    [JsonInclude, JsonPropertyName("file")]
    public string? File { get; set; }
    [JsonInclude, JsonPropertyName("type")]
    public string? Type { [Obsolete("建议使用ImageData.IsFlashImage", false)] get; set; }
    [JsonIgnore]
#pragma warning disable CS0618
    public bool IsFlashImage { get => Type?.Equals("flash") ?? false; set => Type = value ? "flash" : null; }
#pragma warning restore CS0618
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonInclude, JsonPropertyName("url")]
    public Uri? Uri { get; [Obsolete("OneBot v11 不支持在上报消息段中使用url属性，set访问器是为（可能出现的）JSON反序列化预留的，请使用ImageData.File来更改上传内容。", false)] set; }
    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault), JsonInclude, JsonPropertyName("")]
}