﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Player
{
    [PacketHeader("tit_eq", Scope.InGame | Scope.InExchange)]
    public class TitEqPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Mode { get; set; }

        [PacketIndex(1)]
        public short TitleId { get; set; }
    }
}