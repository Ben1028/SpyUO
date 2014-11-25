using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
    [UltimaPacket("Mobile Query", UltimaPacketDirection.FromClient, 0x34)]
    public class MobileQueryPacket : UltimaPacket, IUltimaEntity
    {
        private uint _Serial;
        [UltimaPacketProperty("Serial", "0x{0:X}")]
        public uint Serial { get { return _Serial; } }

        private int _Type;
        [UltimaPacketProperty]
        public int Type { get { return _Type; } }

        protected override void Parse(BigEndianReader reader)
        {
            reader.ReadByte(); // ID
            reader.ReadUInt32();

            _Type = reader.ReadByte();
            _Serial = reader.ReadUInt32();
        }
    }
}