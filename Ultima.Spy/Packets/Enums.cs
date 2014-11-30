using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ultima.Spy.Packets
{
    public enum MessageType
    {
        Regular = 0x0,
        System = 0x1,
        Emote = 0x2,
        Label = 0x6,
        Focus = 0x7,
        Whisper = 0x8,
        Yell = 0x9,
        Spell = 0xA,
        Guild = 0xD,
        Alliance = 0xE,
        GMRequest = 0xF,
        GMResponse = 0x10,
        Special = 0x20,
        Encoded = 0xC0
    }

    public enum Direction
    {
        North = 0x00,
        Right = 0x01,
        East = 0x02,
        Down = 0x03,
        South = 0x04,
        Left = 0x05,
        West = 0x06,
        Up = 0x07,
        RunningNorth = 0x80,
        RunningRight = 0x81,
        RunningEast = 0x82,
        RunningDown = 0x83,
        RunningSouth = 0x84,
        RunningLeft = 0x85,
        RunningWest = 0x86,
        RunningUp = 0x87,
    }

    public enum Notoriety
    {
        Innocent = 0x1,
        Ally = 0x2,
        CanBeAttacked = 0x3,
        Criminal = 0x4,
        Enemy = 0x5,
        Murderer = 0x6,
        Invulenrable = 0x7
    }

    public enum ItemLayer
    {
        Invalid = 0x0,
        OneHanded = 0x1,
        TwoHanded = 0x2,
        Shoes = 0x3,
        Pants = 0x4,
        Short = 0x5,
        Helm = 0x6,
        Gloves = 0x7,
        Ring = 0x8,
        Talisman = 0x9,
        Neck = 0xA,
        Hair = 0xB,
        Waist = 0xC,
        InnerTorso = 0xD,
        Bracelet = 0xE,
        Face = 0xF,
        FacialHair = 0x10,
        MiddleTorso = 0x11,
        Earrings = 0x12,
        Arms = 0x13,
        Cloak = 0x14,
        Backpack = 0x15,
        OuterTorso = 0x16,
        OuterLegs = 0x17,
        InnerLegs = 0x18,
        Mount = 0x19,
        ShopBuy = 0x1A,
        ShopResell = 0x1B,
        ShopSell = 0x1C,
        Bank = 0x1D,
        ShopMax = 0x1E,
    }
}
