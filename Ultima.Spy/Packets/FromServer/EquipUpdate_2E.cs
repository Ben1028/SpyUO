using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Diagnostics;
using System;

namespace Ultima.Spy.Packets
{

    [UltimaPacket("Equip Update", UltimaPacketDirection.FromServer, 0x2E)]
    public class EquipUpdatePacket : UltimaPacket, IUltimaEntity
    {
        private uint _Serial;
        [UltimaPacketProperty("Serial", "0{0:X}")]
        public uint Serial { get { return _Serial; } }

        private int _ObjectID;
        [UltimaPacketProperty("Object ID", UltimaPacketPropertyType.Texture)]
        public int ObjectID { get { return _ObjectID; } }

        private ItemLayer _Layer;
        [UltimaPacketProperty("Layer", "{0:D} - {0}")]
        public ItemLayer Layer { get { return _Layer; } }

        private uint _ParentSerial;
        [UltimaPacketProperty("Parent Serial", "0{0:X}")]
        public uint ParentSerial { get { return _ParentSerial; } }

        private int _Hue;
        [UltimaPacketProperty]
        public int Hue { get { return _Hue; } }

        protected override void Parse(BigEndianReader reader)
        {
            reader.ReadByte(); // ID

            _Serial = reader.ReadUInt32();
            _ObjectID = reader.ReadInt16();
            reader.ReadByte(); //0x00
            _Layer = (ItemLayer)reader.ReadByte();
            _ParentSerial = reader.ReadUInt32();
            _Hue = reader.ReadInt16();
        }
    }
}