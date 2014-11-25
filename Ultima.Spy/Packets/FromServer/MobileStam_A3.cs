using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
    [UltimaPacket("Mobile Stamina", UltimaPacketDirection.FromServer, 0xA3)]
    public class MobileStaminaPacket : UltimaPacket, IUltimaEntity
    {
        private uint _Serial;

        [UltimaPacketProperty("Serial", "0x{0:X}")]
        public uint Serial
        {
            get { return _Serial; }
        }

        private int _Stamina;

        [UltimaPacketProperty]
        public int Stamina
        {
            get { return _Stamina; }
        }

        private int _MaxStamina;

        [UltimaPacketProperty]
        public int MaxStamina
        {
            get { return _MaxStamina; }
        }

        protected override void Parse(BigEndianReader reader)
        {
            reader.ReadByte(); // ID
            _Serial = reader.ReadUInt32();
            _MaxStamina = reader.ReadInt16();
            _Stamina = reader.ReadInt16();
        }
    }
}