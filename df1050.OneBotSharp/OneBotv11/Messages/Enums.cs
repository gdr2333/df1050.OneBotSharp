namespace df1050.OneBotSharp.OneBotv11.Messages;

[JsonConverter(typeof(JsonStringEnumConverter<MessageType>))]
public enum MessageType
{
    [JsonPropertyName("text")]
    Text,
    [JsonPropertyName("face")]
    Face,
    [JsonPropertyName("image")]
    Image,
    [JsonPropertyName("record")]
    Record,
    [JsonPropertyName("video")]
    Video,
    [JsonPropertyName("at")]
    At,
    [JsonPropertyName("rps")]
    Rps,
    [JsonPropertyName("dice")]
    Dice,
    [JsonPropertyName("shake")]
    Shake,
    [JsonPropertyName("poke")]
    Poke,
    [JsonPropertyName("anonymous")]
    Anonymous,
    [JsonPropertyName("share")]
    Share,
    [JsonPropertyName("contact")]
    Contact,
    [JsonPropertyName("location")]
    Location,
    [JsonPropertyName("music")]
    Music,
    [JsonPropertyName("reply")]
    Reply,
    [JsonPropertyName("forward")]
    Forward,
    [JsonPropertyName("node")]
    Node,
    [JsonPropertyName("xml")]
    Xml,
    [JsonPropertyName("json")]
    Json
}
