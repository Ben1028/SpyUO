using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Diagnostics;
using System;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Mobile Status Update", UltimaPacketDirection.FromServer, 0x17 )]
	public class MobileStatusUpdatePacket : UltimaPacket, IUltimaEntity
	{
		private uint _Serial;
		[UltimaPacketProperty( "Serial", "0{0:X}" )]
		public uint Serial { get { return _Serial; } }

        private int _Status;
        [UltimaPacketProperty]
        public int Status { get { return _Status; } }

        private int _Flag;
        [UltimaPacketProperty]
        public int Flag { get { return _Flag; } }

		protected override void Parse( BigEndianReader reader )
		{
            reader.ReadByte();
            reader.ReadInt16();

            _Serial = reader.ReadUInt32();
            reader.ReadInt16();
            _Status = reader.ReadInt16();
            _Flag = reader.ReadByte();
		}
	}
}