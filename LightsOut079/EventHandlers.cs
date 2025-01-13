using System.Linq;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using MEC;
using Random = UnityEngine.Random;
using PlayerRoles;

namespace LightsOut079
{
    public class EventHandlers
    {
        public void OnShooting(ShootingEventArgs ev)
        {
            
            var scp079 = Player.List.FirstOrDefault(p => p.Role == RoleTypeId.Scp079);

            if (scp079 == null)
            {
                ev.Player.ShowHint("There is no SCP-079 in this match.", 5);
                return;
            }

            
            if (Random.value <= Plugin.Instance.Config.DisableChance)
            {
                
                if (!scp079.SessionVariables.ContainsKey("CameraDisableCooldown"))
                {
                    
                    scp079.IsIntercomMuted = true; 
                    scp079.ShowHint("You have been disabled temporarily!", 5);
                    ev.Player.ShowHint($"You have disabled SCP-079 for {Plugin.Instance.Config.DisableDuration} seconds!", 5);

                    
                    scp079.SessionVariables["CameraDisableCooldown"] = true;
                    Timing.CallDelayed(Plugin.Instance.Config.DisableDuration, () =>
                    {
                        scp079.IsIntercomMuted = false; // Restaurar las interacciones.
                        scp079.SessionVariables.Remove("CameraDisableCooldown");
                        scp079.ShowHint("You can interact again.", 5);
                    });
                }
                else
                {
                    ev.Player.ShowHint("SCP-079 is already disabled or on cooldown.", 5);
                }
            }
            else
            {
                ev.Player.ShowHint("Your shot failed to disable SCP-079.", 5);
            }
        }
    }
}
