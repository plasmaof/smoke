using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;

namespace smokemenu.Mods
{
    internal class TagAll
    {
        public static void TagAllMod()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f || Mouse.current.rightButton.isPressed)
            {
                foreach (Photon.Realtime.Player plr in PhotonNetwork.PlayerList)
                {
                    VRRig rig = GorillaGameManager.instance.FindPlayerVRRig(plr);
                    if (!rig.mainSkin.material.name.ToLower().Contains("fected") && !rig.mainSkin.material.name.ToLower().Contains("infected") && plr != PhotonNetwork.LocalPlayer)
                    {
                        VRRig.LocalRig.enabled = false;

                        VRRig.LocalRig.transform.position = rig.transform.position - new UnityEngine.Vector3(0f, 1f, 0f);
                        VRRig.LocalRig.leftHand.rigTarget.transform.position = rig.transform.position;
                        VRRig.LocalRig.rightHand.rigTarget.transform.position = rig.transform.position;
                        GorillaLocomotion.GTPlayer.Instance.rightControllerTransform.position = rig.transform.position;
                    }
                    else
                    {
                        VRRig.LocalRig.enabled = true;
                    }
                }
            }
            else
            {
                VRRig.LocalRig.enabled = true;
            }
        }
    }
}
