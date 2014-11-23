using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Diagnostics;
using System;

namespace Ultima.Spy.Packets
{

	[UltimaPacket( "Animation (old)", UltimaPacketDirection.FromServer, 0x6E )]
	public class AnimationOldPacket : UltimaPacket, IUltimaEntity
	{
		private uint _Serial;

		[UltimaPacketProperty( "Serial", "0x{0:X}" )]
		public uint Serial
		{
			get { return _Serial; }
		}

		private int _Action;

		[UltimaPacketProperty]
		public int Action
		{
			get { return _Action; }
		}

		private int _FrameCount;

		[UltimaPacketProperty]
		public int FrameCount
		{
			get { return _FrameCount; }
		}

		private int _RepeatTimes;

		[UltimaPacketProperty]
		public int RepeatTimes
		{
			get { return _RepeatTimes; }
		}

		private int _Forward;

		[UltimaPacketProperty]
		public int Forward
		{
			get { return _Forward; }
		}

		private int _Repeat;

		[UltimaPacketProperty]
		public int Repeat
		{
			get { return _Repeat; }
		}

		private int _Delay;

		[UltimaPacketProperty]
		public int Delay
		{
			get { return _Delay; }
		}

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID
			_Serial = reader.ReadUInt32();
			_Action = reader.ReadInt16();
			_FrameCount = reader.ReadInt16();
			_RepeatTimes = reader.ReadInt16();
			_Forward = reader.ReadByte();
			_Repeat = reader.ReadByte();
			_Delay = reader.ReadByte();
		}
	}
}
