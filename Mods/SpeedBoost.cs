using Photon.Voice.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace smokemenu.Mods
{
    internal class SpeedBoost
    {
        public static void speedboost()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 7f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 1.45f;
        }
    }
}
