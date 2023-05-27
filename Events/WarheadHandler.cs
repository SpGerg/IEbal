using Exiled.API.Features;
using Exiled.Events.EventArgs.Warhead;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEbal.Events
{
    public static class WarheadHandler
    {
        public static void OnWarheadStopping(StoppingEventArgs args)
        { 
            Timing.RunCoroutine(Utils.BlackoutBroadcast(Program.Instance.Config.WarheadStopping));
        }

        public static void OnWarheadStarting(StartingEventArgs args)
        {
            Timing.RunCoroutine(Utils.BlackoutBroadcast(Program.Instance.Config.WarheadStarting));
        }

        public static void OnWarheadDetonated()
        {
            Timing.RunCoroutine(Utils.BlackoutBroadcast(Program.Instance.Config.WarheadDetonated));
        }

        public static void OnWarheadChangingLeverStatus(ChangingLeverStatusEventArgs args)
        {
            if (args.CurrentState == true)
            {
                Timing.RunCoroutine(Utils.BlackoutBroadcast(Program.Instance.Config.LeverEnabled));
            }
            else
            {
                Timing.RunCoroutine(Utils.BlackoutBroadcast(Program.Instance.Config.LeverDisabled));
            }
        }
    }
}
