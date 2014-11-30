using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Movement Accepted", UltimaPacketDirection.FromBoth, 0x22 )]
	public class MovementAcceptedPacket : UltimaPacket
	{
		private int _Sequence;
		[UltimaPacketProperty]
		public int Sequence { get { return _Sequence; } }

		private int _Status;
		[UltimaPacketProperty]
        public int Status { get { return _Status; } }

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID

            _Sequence = reader.ReadByte();
            _Status = reader.ReadByte();
		}
	}
}