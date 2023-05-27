using Exiled.API.Enums;
using Exiled.API.Features;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Map = Exiled.API.Features.Map;

namespace IEbal
{
    public static class Utils
    {
        public static IEnumerator<float> BlackoutBroadcast(string message)
        {
            Timing.KillCoroutines();

            for (int i = 100; i > 0; i -= 25)
            {
                string transparency = i.ToString();

                if (transparency == "100") transparency = "99";

                Map.Broadcast(1, "<color=#aabbcc" + transparency +">" + message + "</color>");

                yield return Timing.WaitForSeconds(1f);
            }
        }

        /*
        public static void BlackoutBroadcast(Player player, string message)
        {
            player.ShowHint(message, 30f);
        }
        */

        public static string BuildKillFeed(DamageType type, Player killer, Player target)
        {
            if (killer == null)
            {
                if (Program.Instance.Config.Translate.ContainsKey(type))
                {
                    return target + " Убит " + Program.Instance.Config.Translate[type];
                }

                return target + " Убит " + Program.Instance.Config.Translate[DamageType.Unknown];
            }

            return target + " Убит " + killer;
        }
    }
}
