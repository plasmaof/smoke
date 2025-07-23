using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace smokemenu.Mods
{
    internal class SuperMonke
    {
        public static bool PrimaryR { get; private set; }
        public static bool TriggerR { get; private set; }

        public static void Flymonke()
        {
            PrimaryR = ControllerInputPoller.instance.rightControllerPrimaryButton;


            if (PrimaryR)
            {
                GTPlayer.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * 10f;
                GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
            }
        }

            
                public static void FlymonkeT()
            
                {
            TriggerR = ControllerInputPoller.instance.rightControllerIndexFloat > 0.5;

            if (TriggerR)
            {
                GTPlayer.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * 10f;
                GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;

            }

        }
    }
}






