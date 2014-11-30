using System.Collections.ObjectModel;
using System.IO;

namespace Ultima.Spy.Packets
{

    public enum WeatherTypes
	{
		Rain			= 0x00,
		FierceStorm		= 0x01,
		Snow			= 0x02,
		Storm			= 0x03,
		SetTemperature	= 0xFE,
		StopAllWeather	= 0xFF
	}

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