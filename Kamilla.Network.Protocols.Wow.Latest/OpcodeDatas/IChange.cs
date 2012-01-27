
namespace Kamilla.Network.Protocols.Wow.Latest.OpcodeDatas
{
    public interface IChange : IOpcodeData
    {
        uint ChangeCounter { get; set; }
    }
}
