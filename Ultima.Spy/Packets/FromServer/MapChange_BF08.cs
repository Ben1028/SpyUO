using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Map Change", UltimaPacketDirection.FromServer, 0xBF, 0x08 )]
	public class MapChangePacket : UltimaPacket
	{
		private uint _MapID;
		[UltimaPacketProperty]
        public uint MapID { get { return _MapID; } }

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			reader.ReadInt16(); // Size
            reader.ReadInt16(); // Command

            _MapID = reader.ReadByte();
		}
	}
}