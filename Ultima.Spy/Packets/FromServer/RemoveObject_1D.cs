using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
    [UltimaPacket("Remove Object", UltimaPacketDirection.FromServer, 0x1D)]
    public class RemoveObjectPacket : UltimaPacket, IUltimaEntity
    {
        private uint _Serial;

        [UltimaPacketProperty("Serial", "0x{0:X}")]
        public uint Serial
        {
            get { return _Serial; }
        }

        protected override void Parse(BigEndianReader reader)
        {
            reader.ReadByte(); // ID
            _Serial = reader.ReadUInt32();
        }
    }
}