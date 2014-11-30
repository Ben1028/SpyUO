using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Mobile Animation", UltimaPacketDirection.FromServer, 0xE2 )]
	public class MobileAnimation : UltimaPacket, IUltimaEntity
	{
        private uint _Serial;
        [UltimaPacketProperty("Serial", "0{0:X}")]
        public uint Serial { get { return _Serial; } }

		private AnimationType _AnimationType;
		[UltimaPacketProperty( "Animation Type", "{0:D} - {0}" )]
		public AnimationType AnimationType { get { return _AnimationType; } }

		private int _Action;
		[UltimaPacketProperty]
		public int Action { get { return _Action; } }

		private int _Delay;
		[UltimaPacketProperty]
		public int Delay { get { return _Delay; } }

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID

			_Serial = reader.ReadUInt32();
			_AnimationType = (AnimationType) reader.ReadInt16();
			_Action = reader.ReadInt16();
			_Delay = reader.ReadByte();
		}
	}
}