using System;
using System.Collections.Generic;
using System.Text;

namespace smokemenu.Mods
{
    internal class SnowballSpam
    {
        public static void snowballspammer()
        {
            bool rightprim = ControllerInputPoller.instance.rightControllerPrimaryButton;
            if (rightprim)
            {
                GorillaTagger.Instance.rightHandTransform.position = new UnityEngine.Vector3(-14.1794f, 17.4025f, -108.8734f);
                bool rightGrab = ControllerInputPoller.instance.rightGrab;
                if (rightGrab)
                {
                    rightGrab = true;
                    rightGrab = false;
                    rightGrab = true;
                    rightGrab = false;
                    rightGrab = true;
                    rightGrab = false;
                    rightGrab = true;
                    rightGrab = false;
                }

            }
        }
    }
}
