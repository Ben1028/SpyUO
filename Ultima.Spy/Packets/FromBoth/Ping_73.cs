using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Ping", UltimaPacketDirection.FromBoth, 0x73 )]
    public class PingPacket : UltimaPacket
	{
        private int _Value;
        [UltimaPacketProperty]
        public int Value { get { return _Value; } }

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID

            _Value = reader.ReadByte();
		}
	}
}