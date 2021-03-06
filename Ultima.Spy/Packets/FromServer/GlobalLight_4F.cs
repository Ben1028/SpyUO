﻿using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Global Light", UltimaPacketDirection.FromServer, 0x4F )]
	public class GlobalLightPacket : UltimaPacket
	{
        private LightLevels _LightLevel;
        [UltimaPacketProperty("Light Level", "{0:D} - {0}")]
        public LightLevels LightLevel { get { return _LightLevel; } }

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID

            _LightLevel = (LightLevels) reader.ReadByte();
		}
	}
}