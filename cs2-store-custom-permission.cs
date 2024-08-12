using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Admin;
using CounterStrikeSharp.API.Modules.Utils;
using StoreApi;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Store_CustomPermission
{
    public class Store_CustomPermissionConfig : BasePluginConfig
    {
       
    }

    public class Store_CustomPermission : BasePlugin, IPluginConfig<Store_CustomPermissionConfig>
    {
        public override string ModuleName => "Store Custom Permission";
        public override string ModuleVersion => "0.0.1";
        public override string ModuleAuthor => "Astral & Nathy";

        private IStoreApi? storeApi;
        private float intervalInSeconds;
        public Store_CustomPermissionConfig Config { get; set; } = null!;

       
    private bool HasPermission(CCSPlayerController? player, string id)
    {
        string permission = string.Empty;

        switch (id)
        {
            case "Permission":
                permission = "@css/custom-permission";
                break;
            case "Permission2":
                permission = "@css/reservation";
                break;
            case "Permission3":
                permission = "@css/generic";
                break;
            case "Permission4":
                permission = "@css/kick";
                break;
            case "Permission5":
                permission = "@css/ban";
                break;
            case "Permission6":
                permission = "@css/vip";
                break;
            case "Permission7":
                permission = "@css/slay";
                break;
            case "Permission8":
                permission = "@css/changemap";
                break;
            case "Permission9":
                permission = "@css/cvar";
                break;
            case "Permission10":
                permission = "@css/config";
                break;
            case "Permission11":
                permission = "@css/chat";
                break;
            case "Permission12":
                permission = "@css/vote";
                break;
            case "Permission13":
                permission = "@css/password";
                break;
             case "Permission14":
                permission = "@css/rcon";
                break;
             case "Permission15":
                permission = "@css/cheats";
                break;
            case "Permission16":
                permission = "@css/root";
                break;
            
        }
        return (string.IsNullOrEmpty(permission) || AdminManager.PlayerHasPermissions(player, permission));
    }

       

        public void OnConfigParsed(Store_CustomPermissionConfig config)
        {
            Config = config;
        }

        private void StartCreditTimer()
        {
            AddTimer(intervalInSeconds, () =>
            {
                GrantCreditsToEligiblePlayers();
                StartCreditTimer();
            });private void GrantCreditsToEligiblePlayers()
        {
            var players = Utilities.GetPlayers();
            

            foreach (var player in players)
            {
                if (player != null && !player.IsBot && player.IsValid)
                {
                    foreach (var adText in Config.AdTexts)
                    {
                        if (player.PlayerName.Contains(adText))
                        {
                            storeApi?.GivePlayerCredits(player, Config.BonusCredits);
                            player.PrintToChat(Localizer["Prefix"] + Localizer["You have been awarded", Config.BonusCredits, adText]);

                            var steamId = player?.AuthorizedSteamID?.SteamId64;
                            var callerName = player == null ? "Console" : player.PlayerName;//Custom Add
                            if (HasPermission(player, "Permission"))
                            { 
                                Server.ExecuteCommand($"css_addadmin {steamId} {callerName} @css/custom-permission 40 40000");
                                break; 
                                } 
                            break; 

                        }
                    }
                }
            }
        }

        

        private void GrantCreditsToEligiblePlayers()
        {
            var players = Utilities.GetPlayers();
            

            foreach (var player in players)
            {
                if (player != null && !player.IsBot && player.IsValid)
                {
                    foreach (var adText in Config.AdTexts)
                    {
                        if (player.PlayerName.Contains(adText))
                        {
                            storeApi?.GivePlayerCredits(player, Config.BonusCredits);
                            player.PrintToChat(Localizer["Prefix"] + Localizer["You have been awarded", Config.BonusCredits, adText]);

                            var steamId = player?.AuthorizedSteamID?.SteamId64;
                            var callerName = player == null ? "Console" : player.PlayerName;//Custom Add
                            if (HasPermission(player, "Permission"))
                            { 
                                Server.ExecuteCommand($"css_addadmin {steamId} {callerName} @css/custom-permission 40 40000");
                                break; 
                                } 
                            break; 

                        }
                    }
                }
            }
        }

        private void StartAdMessageTimer()
        {
            AddTimer(Config.AdMessageDelaySeconds, () =>
            {
                BroadcastAdMessage();
                StartAdMessageTimer();
            });
        }

       
    }
}
