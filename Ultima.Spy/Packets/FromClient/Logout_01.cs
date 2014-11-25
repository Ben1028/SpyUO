using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
    [UltimaPacket("Logout", UltimaPacketDirection.FromClient, 0x01)]
    public class LogoutPacket : UltimaPacket
    {
        protected override void Parse(BigEndianReader reader)
        {
            reader.ReadByte(); // ID
            reader.ReadUInt32();
        }
    }
}