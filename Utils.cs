using Exiled.API.Enums;
using Exiled.API.Features;
using MEC;
using PlayerRoles;
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
        private static List<string> broadcasts = new List<string>();

        public static IEnumerator<float> BlackoutBroadcast(string message)
        {
            broadcasts.Add(message);

            if (broadcasts.Count > 3)
            {
                broadcasts.RemoveAt(0);
            }

            StringBuilder builder = new StringBuilder();
            foreach (string entity in broadcasts)
            {
                builder.Append(entity + Environment.NewLine);
            }

            int length = broadcasts.Count;

            for (int i = 100; i > 0; i -= 25)
            {
                if (broadcasts.Count != length)
                {
                    yield break;
                }

                string transparency = i.ToString();

                if (transparency == "100") transparency = "99";

                Map.Broadcast(1, "<color=#aabbcc" + transparency +">" + builder.ToString() + "</color>");

                yield return Timing.WaitForSeconds(1f);
            }

            broadcasts.Clear();
        }

        /*
        public static void BlackoutBroadcast(Player player, string message)
        {
            player.ShowHint(message, 30f);
        }
        */

        public static string BuildKillFeed(DamageType type, Player killer, Player target, RoleTypeId oldRole)
        {
            if (killer == null)
            {
                if (Program.Instance.Config.TranslateReasons.ContainsKey(type))
                {
                    return Program.Instance.Config.TranslateRoles[oldRole] + " Убит " + Program.Instance.Config.TranslateReasons[type];
                }

                return Program.Instance.Config.TranslateRoles[oldRole] + " Убит " + Program.Instance.Config.TranslateReasons[DamageType.Unknown];
            }

            return Program.Instance.Config.TranslateRoles[oldRole] + " Убит " + Program.Instance.Config.TranslateRoles[killer.Role.Type];
        }
    }
}
