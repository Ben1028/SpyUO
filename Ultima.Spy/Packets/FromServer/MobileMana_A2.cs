using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
    [UltimaPacket("Mobile Mana", UltimaPacketDirection.FromServer, 0xA2)]
    public class MobileManaPacket : UltimaPacket, IUltimaEntity
    {
        private uint _Serial;
        [UltimaPacketProperty("Serial", "0{0:X}")]
        public uint Serial { get { return _Serial; } }

        private int _Mana;
        [UltimaPacketProperty]
        public int Mana { get { return _Mana; } }

        private int _MaxMana;
        [UltimaPacketProperty]
        public int MaxMan { get { return _MaxMana; } }

        protected override void Parse(BigEndianReader reader)
        {
            reader.ReadByte(); // ID

            _Serial = reader.ReadUInt32();
            _MaxMana = reader.ReadInt16();
            _Mana = reader.ReadInt16();
        }
    }
}