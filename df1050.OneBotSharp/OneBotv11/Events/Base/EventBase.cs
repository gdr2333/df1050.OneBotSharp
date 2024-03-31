using System.Text.Json.Serialization;
using df1050.OneBotSharp.OneBotv11.Events.Enums;

namespace df1050.OneBotSharp.OneBotv11.Events;

/// <summary>
/// <para>事件基类型</para>
/// <para><see href="https://github.com/botuniverse/onebot-11/tree/master/event#%E5%86%85%E5%AE%B9%E5%AD%97%E6%AE%B5"/></para>
/// </summary>
public abstract class EventBase
{
    /// <summary>
    /// 发生时间（Unix时间戳）
    /// </summary>
    [JsonInclude, JsonPropertyName("time")]
    public abstract long UnixTime { [Obsolete("建议使用DateTime EventBase.Time", false)] get; protected set; }
    /// <summary>
    /// 发生时间
    /// </summary>
    [JsonIgnore]
    public abstract DateTime Time { get; protected set; }
    /// <summary>
    /// 机器人QQ号
    /// </summary>
    [JsonInclude, JsonPropertyName("self_id")]
    public abstract long BotUid { get; protected set; }
    /// <summary>
    /// 上报类型
    /// </summary>
    [JsonInclude, JsonPropertyName("post_type")]
    public abstract PostType PostType { get; protected set; }
}