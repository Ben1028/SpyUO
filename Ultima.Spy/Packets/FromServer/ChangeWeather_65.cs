using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{
	[UltimaPacket( "Change Weather", UltimaPacketDirection.FromServer, 0x65 )]
	public class ChangeWeatherPacket : UltimaPacket
    {
        private WeatherTypes _WeatherType;
        [UltimaPacketProperty("Weather Type", "{0:D} - {0}")]
        public WeatherTypes WeatherType { get { return _WeatherType; } }

        private int _Density;
        [UltimaPacketProperty]
        public int Density { get { return _Density; } }

        private int _Temperature;
        [UltimaPacketProperty]
        public int Temperature { get { return _Temperature; } }

		protected override void Parse( BigEndianReader reader )
		{
			reader.ReadByte(); // ID

            _WeatherType = (WeatherTypes)reader.ReadByte();
            _Density = reader.ReadByte();
            _Temperature = reader.ReadByte();
		}
	}
}