
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public interface IValueChange : IOpcodeData
    {
        float NewValue { get; set; }
    }
}
