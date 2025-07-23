using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Text;
using Unity.Mathematics;
using UnityEngine;

namespace smokemenu.Mods
{
    internal class Safety
    {
        public static void Disconnect()
        {
            NetworkSystem.Instance.ReturnToSinglePlayer();
        }

        public static float threshold = 0.2f;

        public static float Thing1 { get; private set; }
        public static float Thing2 { get; private set; }

        public static void AntiReport()
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    if (line.linePlayer == NetworkSystem.Instance.LocalPlayer)
                    {
                        Transform report = line.reportButton.gameObject.transform;

                        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                        {
                            if (vrrig != VRRig.LocalRig)
                            {
                                Thing1 = Vector3.Distance(vrrig.rightHandTransform.position, report.position);
                                Thing2 = Vector3.Distance(vrrig.leftHandTransform.position, report.position);
                            }
                            if (Thing1 < threshold || Thing2 < threshold)
                            {
                                NetworkSystem.Instance.ReturnToSinglePlayer();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"An error occurred in AntiReport: {ex.Message}");
            }
        }


        public static void QuestMenu()
        {
            if (ControllerInputPoller.instance.leftControllerPrimaryButton)
            {
                GTPlayer.Instance.inOverlay = true;
                GTPlayer.Instance.leftControllerTransform.localPosition = new Vector3(238f, -90f, 0f);
                GTPlayer.Instance.rightControllerTransform.localPosition = new Vector3(-190f, 90f, 0f);
                GTPlayer.Instance.leftControllerTransform.rotation = Camera.main.transform.rotation * quaternion.Euler(-55f, 90f, 0f);
                GTPlayer.Instance.rightControllerTransform.rotation = Camera.main.transform.rotation * quaternion.Euler(-55f, -49f, 0f);
                {
                    ControllerInputPoller.instance.leftControllerGripFloat = 0f;
                    ControllerInputPoller.instance.rightControllerGripFloat = 0f;
                    ControllerInputPoller.instance.leftControllerIndexFloat = 0f;
                    ControllerInputPoller.instance.rightControllerIndexFloat = 0f;
                    ControllerInputPoller.instance.leftControllerPrimaryButton = false;
                    ControllerInputPoller.instance.leftControllerSecondaryButton = false;
                    ControllerInputPoller.instance.rightControllerPrimaryButton = false;
                    ControllerInputPoller.instance.rightControllerSecondaryButton = false;
                    ControllerInputPoller.instance.leftControllerPrimaryButtonTouch = false;
                    ControllerInputPoller.instance.leftControllerSecondaryButtonTouch = false;
                    ControllerInputPoller.instance.rightControllerPrimaryButtonTouch = false;
                    ControllerInputPoller.instance.rightControllerSecondaryButtonTouch = false;
                }
            }
        }
        public static void ReturnTostump()
        {
            
            Vector3 targetPosition = new Vector3(-66.9039f, 11.8661f, -82.1227f);
            Quaternion targetRotation = Quaternion.identity;
            GTPlayer.Instance.TeleportTo(targetPosition, targetRotation);
        }
        
    }
}
