using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEbal
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }

        public string GeneratorActivated { get; set; } = "Генератор активирован!";

        public string LightZoneDecontaminating { get; set; } = "Мне лень писать это очень долгое название";

        public string WarheadStopping { get; set; } = "Боеголовка остановлена";

        public string WarheadStarting { get; set; } = "Боеголовка запущена";

        public string WarheadDetonated { get; set; } = "Зачем это сообщать если и так все знают";

        public string LeverEnabled { get; set; } = "Рычаг боеголовки включён";

        public string LeverDisabled { get; set; } = "Рычаг боеголовки выключён";

        public Dictionary<DamageType, string> Translate { get; set; } = new Dictionary<DamageType, string>
        {
            { DamageType.Unknown, "Неизвестно" },
            { DamageType.Warhead, "Боеголовка" }
        };
    }
}
