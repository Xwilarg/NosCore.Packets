﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using System.Collections.Generic;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Battle
{
    [PacketHeader("mtlist")]
    public class MultiTargetListPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public byte TargetsAmount { get; set; }

        [PacketListIndex(1)]
        public List<MultiTargetListSubPacket>? Targets { get; set; }

    }
}