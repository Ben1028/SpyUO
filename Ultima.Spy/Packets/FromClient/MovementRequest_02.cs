using System.IO;
using System;

namespace Ultima.Spy.Packets
{
    [UltimaPacket("Movement Request", UltimaPacketDirection.FromClient, 0x02)]
    public class MovementRequestPacket : UltimaPacket
    {
        private uint _FastwalkPreventionKey;

        [UltimaPacketProperty]
        public uint FastwalkPreventionKey
        {
            get { return _FastwalkPreventionKey; }
        }

        private Direction _Direction;

        [UltimaPacketProperty("Direction", "{0:D} - {0}")]
        public Direction Direction
        {
            get { return _Direction; }
        }

        private int _SequenceNumber;

        [UltimaPacketProperty]
        public int SequenceNumber
        {
            get { return _SequenceNumber; }
        }

        protected override void Parse(BigEndianReader reader)
        {
            reader.ReadByte(); // ID
            _Direction = (Direction)reader.ReadByte();
            _SequenceNumber = reader.ReadByte();
            _FastwalkPreventionKey = reader.ReadUInt32();
        }
    }
}