using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Context Menu Request", UltimaPacketDirection.FromClient, 0xBF, 0x13 )]
	public class ContextMenuRequestPacket : UltimaPacket, IUltimaEntity
	{
		private uint _Serial;
		[UltimaPacketProperty( "Serial", "0{0:X}" )]
		public uint Serial { get { return _Serial; } }

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			reader.ReadInt16(); // Size
            reader.ReadInt16(); // Command

			_Serial = reader.ReadUInt32();
		}
	}
}