using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using UnityEngine;

namespace smokemenu.Mods
{
    internal class Othershit
    {
        public static void Noclip()
        {
            bool NoCollide = ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;
            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>();

            foreach (MeshCollider collider in colliders)
            {
                collider.enabled = !NoCollide;
            }
        }

        public static void Tptobeachload()
        {
            Vector3 targetPosition = new Vector3(-14.0499f, 1.5595f, -68.6916f);
            Quaternion targetRotation = Quaternion.identity;
            GTPlayer.Instance.TeleportTo(targetPosition, targetRotation);
        }

        public static void Tptocityload()
        {
            Vector3 targetPosition = new Vector3(-63.6591f, 13.5011f, -93.3268f);
            Quaternion targetRotation = Quaternion.identity;
            GTPlayer.Instance.TeleportTo(targetPosition, targetRotation);
        }

        public static void Joindiscord()
        {
            Process.Start(serverlink);
        }
        public static string serverlink = "https://discord.gg/R5Jty6vKsH";

        public static float Prevtime;
        public static void Fpscapper(int fps)
        {
            float targetDelta = 1f / fps;
            float elapsed = Time.realtimeSinceStartup - Prevtime;

            if (elapsed < targetDelta)
            {
                int sleepMs = Mathf.FloorToInt((targetDelta - elapsed) * 1000);
                if (sleepMs > 0) 
                 Thread.Sleep(sleepMs);
            }
           Prevtime = Time.realtimeSinceStartup;
        }

    }
}
