using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace smokemenu.Mods
{
    internal class SteamLongArms
    {
        public static void EnableSteamLongArms()
        {
            GorillaLocomotion.GTPlayer.Instance.transform.localScale = new Vector3(armlength, armlength, armlength);
        }
        public static void DisableSteamLongArms()
        {
            GorillaLocomotion.GTPlayer.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        public static float armlength = 1.25f;
    }
}
