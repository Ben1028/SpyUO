using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Packet WTF", UltimaPacketDirection.FromBoth, 0xBF, 0x24 )]
	public class PacketWTFPacket : UltimaPacket
	{
        private int _WTF;
        [UltimaPacketProperty]
        public int WTF { get { return _WTF; } }

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			reader.ReadInt16(); // Size
            reader.ReadInt16(); // Command

            _WTF = reader.ReadByte();
		}
	}
}