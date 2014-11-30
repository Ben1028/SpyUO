using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
    [UltimaPacket("Mobile Hits", UltimaPacketDirection.FromServer, 0xA1)]
    public class MobileHitsPacket : UltimaPacket, IUltimaEntity
    {
        private uint _Serial;
        [UltimaPacketProperty("Serial", "0{0:X}")]
        public uint Serial { get { return _Serial; } }

        private int _Hitpoints;
        [UltimaPacketProperty]
        public int Hitpoints { get { return _Hitpoints; }  }

        private int _MaxHitpoints;
        [UltimaPacketProperty]
        public int MaxHitpoints { get { return _MaxHitpoints; } }

        protected override void Parse(BigEndianReader reader)
        {
            reader.ReadByte(); // ID

            _Serial = reader.ReadUInt32();
            _MaxHitpoints = reader.ReadInt16();
            _Hitpoints = reader.ReadInt16();
        }
    }
}