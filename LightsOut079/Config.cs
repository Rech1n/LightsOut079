using Exiled.API.Interfaces;

namespace LightsOut079
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false; 
        public float DisableChance { get; set; } = 0.5f;
        public float DisableDuration { get; set; } = 5f;
        public float Cooldown { get; set; } = 10f;
    }
}
