using GorillaLocomotion;
using Photon.Realtime;
using PlayFab.ClientModels;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;

namespace smokemenu.Mods
{
    internal class Advantage
    {
        public static void Questslidecontroll()
        {
            GTPlayer.Instance.slideControl = 0.008f;
        }
        public static void Betterslidecontroll()
        {
            GTPlayer.Instance.slideControl = 1f;
        }
        public static void FlickGun()
        {
            //placeholderdata
        }
    }
}
