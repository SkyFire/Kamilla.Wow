
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public interface IValueChange : IOpcodeData
    {
        float NewValue { get; set; }
    }
}
