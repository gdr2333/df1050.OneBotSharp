namespace df1050.OneBotSharp.OneBotv11.Events.Enums;

/// <summary>
/// <para>上报类型枚举</para>
/// <para><see href="https://github.com/botuniverse/onebot-11/tree/master/event#%E5%86%85%E5%AE%B9%E5%AD%97%E6%AE%B5"/> </para>
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<PostType>))]
public enum PostType
{
    /// <summary>
    /// 消息事件
    /// </summary>
    [JsonPropertyName("message")]
    Message,
    /// <summary>
    /// 通知事件
    /// </summary>
    [JsonPropertyName("notice")]
    Notice,
    /// <summary>
    /// 请求事件
    /// </summary>
    [JsonPropertyName("request")]
    Request,
    /// <summary>
    /// 元事件
    /// </summary>
    [JsonPropertyName("meta_event")]
    MetaEvent
}