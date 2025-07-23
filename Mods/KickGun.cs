using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace smokemenu.Mods
    {
        internal class kickgunwork
        {
            private static GameObject beam;
            private static LineRenderer line;
            private static bool setupDone = false;

            public static void KickGun()
            {
                if (!setupDone)
                {
                    beam = new GameObject("KickBeam");
                    line = beam.AddComponent<LineRenderer>();
                    line.startWidth = 0.01f;
                    line.endWidth = 0.01f;
                    line.material = new Material(Shader.Find("Unlit/Color"));
                    line.material.color = Color.clear;
                    line.positionCount = 2;
                    setupDone = true;
                }

                if (GorillaLocomotion.GTPlayer.Instance == null) return;

                Transform hand = GorillaLocomotion.GTPlayer.Instance.rightControllerTransform;
                Vector3 origin = hand.position;
                Vector3 dir = hand.forward;

                line.SetPosition(0, origin);
                line.SetPosition(1, origin + dir * 50f);

                if (Physics.Raycast(origin, dir, out RaycastHit hit, 50f))
                {
                    Photon.Pun.PhotonView view = hit.collider.GetComponentInParent<Photon.Pun.PhotonView>();

                    if (view != null && view.Owner != null && view.Owner != PhotonNetwork.LocalPlayer);
                    {
                        // Trigger press from right controller
                        if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
                        {
                            Kick(view.Owner);
                        }
                    }
                }
            }

            private static void Kick(Photon.Realtime.Player target)
            {
                if (PhotonNetwork.IsMasterClient)
                {
                    PhotonNetwork.CloseConnection(target);
                    Debug.Log("[kickgun] kicked " + target.NickName);
                }
                else
                {
                    Debug.Log("[kickgun] youre not the host");
                }
            }
        }
    }

