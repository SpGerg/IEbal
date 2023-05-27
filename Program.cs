using Exiled.API.Features;
using IEbal.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Player = Exiled.Events.Handlers.Player;
using Map = Exiled.Events.Handlers.Map;
using Warhead = Exiled.Events.Handlers.Warhead;
using IEbal.Events;

namespace IEbal
{
    public class Program : Plugin<Config>
    {
        public static Program Instance => Singleton;

        private static readonly Program Singleton = new Program();

        public override void OnEnabled()
        {
            Player.Died += PlayerHandler.OnDied;

            Map.GeneratorActivated += MapHandler.OnGeneratorActivated;
            Map.Decontaminating += MapHandler.OnLightZoneDecontaminating;

            Warhead.Stopping += WarheadHandler.OnWarheadStopping;
            Warhead.Starting += WarheadHandler.OnWarheadStarting;
            Warhead.ChangingLeverStatus += WarheadHandler.OnWarheadChangingLeverStatus;
            Warhead.Detonated += WarheadHandler.OnWarheadDetonated;

            base.OnEnabled();
        }
    }
}
