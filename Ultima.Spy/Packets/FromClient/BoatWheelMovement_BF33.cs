using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System;

namespace Ultima.Spy.Packets
{

    [UltimaPacket("Boat Wheel Movement", UltimaPacketDirection.FromBoth, 0xBF, 0x33)]
    public class BoatWheelMovementPacket : UltimaPacket, IUltimaEntity
    {
        [UltimaPacketProperty("BF.33")]
        public string Subcommand { get { return "BF.33 Subcommand"; } }

        private uint _Serial;
        [UltimaPacketProperty("Serial", "0{0:X}")]
        public uint Serial { get { return _Serial; } }

        private Direction _FacingDirection;
        [UltimaPacketProperty("Facing Direction", "{0:D} - {0}")]
        public Direction FacingDirection { get { return _FacingDirection; } }

        private Direction _MovingDirection;
        [UltimaPacketProperty("Moving Direction", "{0:D} - {0}")]
        public Direction MovingDirection { get { return _MovingDirection; } }

        private BoatCommand _BoatCommand;
        [UltimaPacketProperty("Command", "{0:D} - {0}")]
        public BoatCommand BoatCommand { get { return _BoatCommand; } }

        protected override void Parse(BigEndianReader reader)
        {
            reader.ReadByte(); // ID
            reader.ReadInt16(); // Size
            reader.ReadInt16(); // Command

            _Serial = reader.ReadUInt32();
            _FacingDirection = (Direction)reader.ReadByte();
            _MovingDirection = (Direction)reader.ReadByte();
            _BoatCommand = (BoatCommand)reader.ReadByte();
        }
    }
}

//byte	ID (BF)
//word	Packet Size
//word	0x33
//dword	Player Serial
//byte	Facing Direction
//byte	Moving Direction
//byte	Boat Speed (0 = Stop Movement, 1 = One Tile Movement, 2 = Normal Movement)