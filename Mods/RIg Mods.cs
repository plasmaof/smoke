using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Unity.Mathematics;
using UnityEngine;

namespace smokemenu.Mods
{
    internal class Rig
    {
        public static void ghost()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }

        public static void Grabrig()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                VRRig.LocalRig.enabled = false;

                VRRig.LocalRig.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                
            }
            else
            {
                VRRig.LocalRig.enabled = true;
            }
        }
    }
}
    


