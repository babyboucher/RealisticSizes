﻿using Exiled.API.Enums;
using Exiled.API.Features;
using System;

using Player = Exiled.Events.Handlers.Player;

namespace RealisticSizes
{
    public class RealisticSizes : Plugin<Config>
    {
        private Handlers.Player player;

        public override string Name { get; } = "RealisticSizes";
        public override string Author { get; } = "JesusQC";
        public override string Prefix { get; } = "RealisticSizes";

        public override void OnEnabled()
        {
            base.OnEnabled();

            RegisterEvents();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            player = new Handlers.Player();

            Player.ChangingRole += player.OnChangingRole;
        }

        public void UnregisterEvents()
        {
            Player.ChangingRole -= player.OnChangingRole;

            player = null;
        }
    }
}
