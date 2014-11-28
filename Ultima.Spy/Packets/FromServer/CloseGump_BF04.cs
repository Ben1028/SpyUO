using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Close Gump", UltimaPacketDirection.FromServer, 0xBF, 0x04 )]
	public class CloseGumpPacket : UltimaPacket
	{
		private uint _GumpID;
		[UltimaPacketProperty]
        public uint GumpID { get { return _GumpID; } }

        private uint _ButtonID;
        [UltimaPacketProperty]
        public uint ButtonID { get { return _ButtonID; } }

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			reader.ReadInt16(); // Size
            reader.ReadInt16(); // Command

            _GumpID = reader.ReadUInt32();
            _ButtonID = reader.ReadUInt32();
		}
	}
}