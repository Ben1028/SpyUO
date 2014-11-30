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

    public enum BuffType
    {
        Strength = 0x1,
        Dexterity = 0x2,
        Intelligence = 0x3,
        HitPoints = 0x7,
        Stamina = 0x8,
        Mana = 0x9,
        HitPointRegeneration = 0xA,
        StaminaRegeneration = 0xB,
        ManaRegeneration = 0xC,
        NightSignt = 0xD,
        Luck = 0xE,
        ReflectPhysical = 0x10,
        EnhancePotions = 0x11,
        AttackChance = 0x12,
        DefendChance = 0x13,
        SpellDamage = 0x14,
        CastRecovery = 0x15,
        CastSpeed = 0x16,
        ManaCost = 0x17,
        ReagentCost = 0x18,
        WeaponSpeed = 0x19,
        WeaponDamage = 0x1A,
        PhysicalResistance = 0x1B,
        FireResistance = 0x1C,
        ColdResistance = 0x1D,
        PoisonResistance = 0x1E,
        EnergyResistance = 0x1F,
        MaxPhysicalResistance = 0x20,
        MaxFireResistance = 0x21,
        MaxColdResistance = 0x22,
        MaxPoisonResistance = 0x23,
        MaxEnergyResistance = 0x24,
        AmmoCost = 0x26,
        KarmaLoss = 0x28,
        BuffIcons = 0x3EA,
    }

    public enum BuffSourceType
    {
        Character = 0,
        TwoHandedWeapon = 50,
        OneHandedWeaponOrSpellbook = 53,
        ShieldOrRangedWeapon = 54,
        Shoes = 55,
        PantsOrLegs = 56,
        HelmOrHat = 58,
        Gloves = 59,
        Ring = 60,
        Talisman = 61,
        NecklaceOrGorget = 62,
        Waist = 64,
        InnnerTorso = 65,
        Bracelet = 66,
        MiddleTorso = 69,
        Earring = 70,
        Arms = 71,
        CloakOrQuiver = 72,
        OuterTorso = 74,
        Spells = 1000,
    }

    public enum WeatherTypes
    {
        Rain = 0x00,
        FierceStorm = 0x01,
        Snow = 0x02,
        Storm = 0x03,
        SetTemperature = 0xFE,
        StopAllWeather = 0xFF
    }

    public enum LightLevels
    {
        Bright = 0x00,
        Night = 0x09,
        Black = 0x1F
    }

    public enum GraphicalEffectType
    {
        SourceToDestination = 0x0,
        LightningStrike = 0x1,
        StayWithDestination = 0x2,
        StayWithSource = 0x3,
        SpecialEffect = 0x4,
    }

    public enum MapNames
    {
        Felluca = 0x0,
        Trammel = 0x1,
        Ilshenar = 0x2,
        Malas = 0x3,
        Tokuno = 0x4,
        TerMur = 0x5
    }

    public enum AnimationType
    {
        Attack = 0,
        Parry = 1,
        Block = 2,
        Die = 3,
        Impact = 4,
        Fidget = 5,
        Eat = 6,
        Emote = 7,
        Alert = 8,
        TakeOff = 9,
        Land = 10,
        Spell = 11,
        StartCombat = 12,
        EndCombat = 13,
        Pillage = 14,
        Spawn = 15
    }

    public enum MobileRace
    {
        Human = 1,
        Elf = 2,
        Gargoyle = 3,
    }

    public enum WorldObjectType
    {
        Tile = 0,
        Body = 1,
        Multi = 2
    }

    public enum WorldObjectAccess
    {
        Player = 0,
        World = 1,
    }

    public enum BoatCommand
    {
        Stop = 0,
        OneTile = 1,
        Normal = 2,
    }
}
