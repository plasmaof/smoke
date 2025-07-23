using smokemenu.Menu;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


namespace smokemenu.Mods
{
    internal class GravityMods
    {
        public static void LowgravityV2()
        {
            GorillaTagger.Instance.rigidbody.AddForce(new Vector3(0, 1.7f, 0), ForceMode.Impulse);
        }
        public static void midgrav()
        {
            GorillaTagger.Instance.rigidbody.AddForce(new Vector3(0, -0.05f, 0), ForceMode.Impulse);
        }
        public static void highgravV2()
        {
            GorillaTagger.Instance.rigidbody.AddForce(new Vector3(0, -0.1f, 0), ForceMode.Impulse);
        }
    }
}





