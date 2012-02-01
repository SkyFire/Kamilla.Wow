
namespace Kamilla.Network.Protocols.Wow.OpcodeDatas
{
    public interface IChange : IOpcodeData
    {
        uint ChangeCounter { get; set; }
    }
}
