using smokemenu.Classes;
using smokemenu.Menu;
using smokemenu.Mods;
using smokemenu.Mods;
using static smokemenu.Settings;

namespace smokemenu.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "leave", method =() => Safety.Disconnect(), toolTip = "left", isTogglable = false},
                new ButtonInfo { buttonText = "movement mods", isTogglable = false},
                new ButtonInfo { buttonText = "steam long arms", method =() => SteamLongArms.EnableSteamLongArms(), disableMethod =() => SteamLongArms.DisableSteamLongArms(), toolTip = "gives you steam long arms", isTogglable = true},
                new ButtonInfo { buttonText = "unsticky plats", method =() => Platforms.PlatformsMod(), toolTip = "use left and right grips to spawn platforms", isTogglable = true},
                new ButtonInfo { buttonText = "speedboost", method =() => SpeedBoost.speedboost(), toolTip = "gives the player a slight speedboost", isTogglable = true},
                new ButtonInfo { buttonText = "wasd fly", method =() => KeyflyTEMP.WASDFly(), toolTip = "fly with the wasd keys", isTogglable = true},
                new ButtonInfo { buttonText = "low grav", method =() => GravityMods.LowgravityV2(),toolTip = "low grav", isTogglable=true},
                new ButtonInfo { buttonText = "medium grav", method =() => GravityMods.midgrav(),toolTip = "med grav", isTogglable=true},
                new ButtonInfo { buttonText = "high grav", method =() => GravityMods.highgravV2(),toolTip = "high grav", isTogglable=true},
                new ButtonInfo { buttonText = "fly [a]", method =() => SuperMonke.Flymonke(), toolTip = "fly with a", isTogglable = true},
                new ButtonInfo { buttonText = "fly [t]", method =() => SuperMonke.FlymonkeT(), toolTip = "fly with your trigger", isTogglable = true},
                new ButtonInfo { buttonText = "rig mods", isTogglable = false},
                new ButtonInfo { buttonText = "ghost monke [t]", method =() => Rig.ghost(), toolTip = "enables ghost monke", isTogglable = true},
                new ButtonInfo { buttonText = "hold rig", method =() => Rig.Grabrig(), toolTip = "allows you to hold your rig", isTogglable = true},
                new ButtonInfo { buttonText = "op mods", isTogglable = false},
                new ButtonInfo { buttonText = "kick gun [w? m]", method =() => kickgunwork.KickGun(), toolTip = "kick EVERYONE", isTogglable = true},
                new ButtonInfo { buttonText = "advantage mods", isTogglable = false},
                new ButtonInfo { buttonText = "tag all [w?]", method =() => TagAll.TagAllMod(), toolTip = "tagged everyone", isTogglable = false},
                new ButtonInfo { buttonText = "join code mods", isTogglable = false},
                new ButtonInfo { buttonText = "Join room [mods]", method =() => JoinRoom.JoinCodeMODS(), toolTip = "joins room on click!", isTogglable = false},
                new ButtonInfo { buttonText = "join room [mod]", method =() => JoinRoom.JoinCodeMOD(), toolTip = "joins room on click!", isTogglable = false},
                new ButtonInfo { buttonText = "join Random public", method =() => JoinRoom.JoinRandom(), toolTip  = "joins room on click!", isTogglable =false},
                new ButtonInfo { buttonText = "safety mods", isTogglable = false},
                new ButtonInfo { buttonText = "tp to stump", method =() => Safety.ReturnTostump(), toolTip = "teleports you to stump when clicked", isTogglable = false},
                new ButtonInfo { buttonText = "antireport [nw]", method =() => Safety.AntiReport(), toolTip = "disconnects you when someone attempts to report you", isTogglable = true},
                new ButtonInfo { buttonText = "fake quest menu [x]", method =() => Safety.QuestMenu(), toolTip = "press a to activate fake quest menu", isTogglable = true},
                new ButtonInfo { buttonText = "advantage mods", isTogglable = false},
                new ButtonInfo { buttonText = "slide control", method =() => Advantage.Questslidecontroll(), toolTip = "gives you slide control", isTogglable = true},
                new ButtonInfo { buttonText = "better slide control", method =() => Advantage.Betterslidecontroll(), toolTip = "gives you lax's slide control", isTogglable = true},
                new ButtonInfo { buttonText = "fun mods", isTogglable = false},
                new ButtonInfo { buttonText = "no finger movement", method =() => NoFingerMovement.NoFingers(), toolTip = "lmao", isTogglable = true},
                new ButtonInfo { buttonText = "draw mod", method =() => draw_mod.draw(), toolTip = "inf quest score enabled", isTogglable = true},
                new ButtonInfo { buttonText = "snowball spam", method =() => SnowballSpam.snowballspammer(), toolTip = "spammer", isTogglable = true},
                new ButtonInfo { buttonText = "other mods", isTogglable = false},
                new ButtonInfo { buttonText = "rpc prot", method =() => RPCprotection.RPCProt(), toolTip = "self explanitory", isTogglable = true},
                new ButtonInfo { buttonText = "inf quest score", method =() => SetBadge99999.QuestBadgeScoreInf(), toolTip = "inf quest score enabled", isTogglable = false},
                new ButtonInfo { buttonText = "discord", method =() => Othershit.Joindiscord(), toolTip = "joins the smoke menu discord", isTogglable = false},
                new ButtonInfo { buttonText = "noclip [t]", method =() => Othershit.Noclip(), toolTip = "disables all collides", isTogglable = true},
                new ButtonInfo { buttonText = "tp to city", method =() => Othershit.Tptocityload(), toolTip = "tps you to city on click", isTogglable = false},
                new ButtonInfo { buttonText = "tp to beach", method =() => Othershit.Tptobeachload(), toolTip = "tps you to beach on click", isTogglable = false},
                new ButtonInfo { buttonText = "quest fps cap", method =() => Othershit.Fpscapper(72), toolTip = "caps your fps at 60 - 70", isTogglable = true},
                new ButtonInfo { buttonText = "credits", isTogglable = false},
                new ButtonInfo { buttonText = "lax", isTogglable = false},
                new ButtonInfo { buttonText = "moko_soko", isTogglable = false},

            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
