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
            DamageType type = args.DamageHandler.Type;

            Utils.BlackoutBroadcast(args.Player, "sdgsdgsdgsdgs");

            //крч args.Attacker ?? null не сработает т.к принимает в аргументе string, а args.Attacker.Nickname ?? null будет ошибка т.к args.Attacker нуликом может быть
        }
    }
}
