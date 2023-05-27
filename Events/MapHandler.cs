using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Warhead;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEbal.Events
{
    public static class MapHandler
    {
        public static void OnGeneratorActivated(GeneratorActivatedEventArgs args)
        {
            Timing.RunCoroutine(Utils.BlackoutBroadcast(Program.Instance.Config.GeneratorActivated));
        }

        public static void OnLightZoneDecontaminating(DecontaminatingEventArgs args)
        {
            Timing.RunCoroutine(Utils.BlackoutBroadcast(Program.Instance.Config.LightZoneDecontaminating));
        }
    }
}
