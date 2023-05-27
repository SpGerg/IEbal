using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IEbal.Handlers
{
    public static class PlayerHandler
    {
        public static void OnDied(DiedEventArgs args)
        {
            Timing.RunCoroutine(Utils.BlackoutBroadcast(Utils.BuildKillFeed(args.DamageHandler.Type, args.Attacker, args.Player)));
        }
    }
}
