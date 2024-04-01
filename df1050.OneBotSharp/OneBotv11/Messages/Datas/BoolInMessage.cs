using System.Diagnostics.CodeAnalysis;

namespace df1050.OneBotSharp.OneBotv11.Messages;

[JsonConverter(typeof(BoolInMessageConverter))]
public readonly struct BoolInMessage : IComparable, IComparable<BoolInMessage>, IComparable<bool>, IConvertible, IEquatable<bool>, IEquatable<BoolInMessage>, IParsable<BoolInMessage>
{
    [JsonIgnore]
    private readonly bool _value;

    public BoolInMessage(bool val) => _value = val;
    public BoolInMessage(sbyte val)
    {
        switch (val)
        {
            case 0:
                _value = false;
                return;
            case 1:
                _value = true;
                return;
            default:
                throw new ArgumentOutOfRangeException(nameof(val), "参数值只能是0或1");
        }
    }
    public BoolInMessage(byte val)
    {
        switch (val)
        {
            case 0:
                _value = false;
                return;
            case 1:
                _value = true;
                return;
            default:
                throw new ArgumentOutOfRangeException(nameof(val), "参数值只能是0或1");
        }
    }
    public BoolInMessage(string val)
    {
        if (bool.TryParse(val, out var resb))
            _value = resb;
        else if (byte.TryParse(val, out var resi))
            switch (resi)
            {
                case 0:
                    _value = false;
                    return;
                case 1:
                    _value = true;
                    return;
                default:
                    throw new ArgumentOutOfRangeException(nameof(val), "参数值只能是true false 0 1或yes no");
            }
        else switch (val.ToLower())
            {
                case "no":
                    _value = false;
                    return;
                case "yes":
                    _value = true;
                    return;
                default:
                    throw new ArgumentOutOfRangeException(nameof(val), "参数值只能是true false 0 1或yes no");
            }
    }

    public static BoolInMessage Parse(string s, IFormatProvider? provider) => new(s);
    public static BoolInMessage Parse(string s) => new(s);

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out BoolInMessage result)
    {
        if (s == null)
        {
            result = default;
            return false;
        }
        else if (bool.TryParse(s, out var resb))
        {
            result = new(resb);
            return true;
        }
        else if (int.TryParse(s, out var resi))
        {
            switch (resi)
            {
                case 0:
                    result = new(false);
                    return true;
                case 1:
                    result = new(true);
                    return true;
                default:
                    result = default;
                    return false;
            }
        }
        else switch (s.ToLower())
            {
                case "yes":
                    result = new(true);
                    return true;
                case "no":
                    result = new(false);
                    return true;
                default:
                    result = default;
                    return false;
            }
    }
    public static bool TryParse([NotNullWhen(true)] string? s, [MaybeNullWhen(false)] out BoolInMessage result)
    {
        if (s == null)
        {
            result = default;
            return false;
        }
        else if (bool.TryParse(s, out var resb))
        {
            result = new(resb);
            return true;
        }
        else if (int.TryParse(s, out var resi))
        {
            switch (resi)
            {
                case 0:
                    result = new(false);
                    return true;
                case 1:
                    result = new(true);
                    return true;
                default:
                    result = default;
                    return false;
            }
        }
        else switch (s.ToLower())
            {
                case "yes":
                    result = new(true);
                    return true;
                case "no":
                    result = new(false);
                    return true;
                default:
                    result = default;
                    return false;
            }
    }

    public readonly int CompareTo(object? obj) => (obj is BoolInMessage val) ? CompareTo(val) : -100;
    public readonly int CompareTo(BoolInMessage other) => _value.CompareTo(other._value);
    public readonly int CompareTo(bool other) => _value.CompareTo(other);

    public bool Equals(bool other) => _value.Equals(other);
    public bool Equals(BoolInMessage other) => _value.Equals(other._value);

    public readonly TypeCode GetTypeCode() => TypeCode.Object;
    public readonly bool ToBoolean(IFormatProvider? provider) => ((IConvertible)_value).ToBoolean(provider);
    public readonly byte ToByte(IFormatProvider? provider) => ((IConvertible)_value).ToByte(provider);
    public readonly char ToChar(IFormatProvider? provider) => ((IConvertible)_value).ToChar(provider);
    public readonly DateTime ToDateTime(IFormatProvider? provider) => ((IConvertible)_value).ToDateTime(provider);
    public readonly decimal ToDecimal(IFormatProvider? provider) => ((IConvertible)_value).ToDecimal(provider);
    public readonly double ToDouble(IFormatProvider? provider) => ((IConvertible)_value).ToDouble(provider);
    public readonly short ToInt16(IFormatProvider? provider) => ((IConvertible)_value).ToInt16(provider);
    public readonly int ToInt32(IFormatProvider? provider) => ((IConvertible)_value).ToInt32(provider);
    public readonly long ToInt64(IFormatProvider? provider) => ((IConvertible)_value).ToInt64(provider);
    public readonly sbyte ToSByte(IFormatProvider? provider) => ((IConvertible)_value).ToSByte(provider);
    public readonly float ToSingle(IFormatProvider? provider) => ((IConvertible)_value).ToSingle(provider);
    public readonly string ToString(IFormatProvider? provider) => _value.ToString(provider);
    public readonly object ToType(Type conversionType, IFormatProvider? provider) => ((IConvertible)_value).ToType(conversionType, provider);
    public readonly ushort ToUInt16(IFormatProvider? provider) => ((IConvertible)_value).ToUInt16(provider);
    public readonly uint ToUInt32(IFormatProvider? provider) => ((IConvertible)_value).ToUInt32(provider);
    public readonly ulong ToUInt64(IFormatProvider? provider) => ((IConvertible)_value).ToUInt64(provider);

    public override bool Equals(object? obj) => obj is BoolInMessage message && Equals(message);
    public static bool operator ==(BoolInMessage left, BoolInMessage right) => left.Equals(right);
    public static bool operator !=(BoolInMessage left, BoolInMessage right) => !(left == right);
    public override int GetHashCode() => _value ? 1 : 0;
    public override string ToString() => _value.ToString();
}


public class BoolInMessageConverter : JsonConverter<BoolInMessage>
{
    public override BoolInMessage Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) =>
                BoolInMessage.Parse(reader.GetString()!);

        public override void Write(
            Utf8JsonWriter writer,
            BoolInMessage temperature,
            JsonSerializerOptions options) =>
                writer.WriteStringValue(temperature.ToString());
}