using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace smokemenu.Mods
{
    internal class JoinRoom
    {
        public static void JoinCodeMODS()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("MODS", JoinType.Solo);
        }

        public static void JoinCodeMOD()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("MOD", JoinType.Solo);
        }

        public static void JoinRandom()
        {
            if (PhotonNetwork.InRoom)
            {
                NetworkSystem.Instance.ReturnToSinglePlayer();  
            }
            string gamemode = PhotonNetworkController.Instance.currentJoinTrigger == null ? "forest" : PhotonNetworkController.Instance.currentJoinTrigger.networkZone;
            PhotonNetworkController.Instance.AttemptToJoinPublicRoom(GorillaComputer.instance.GetJoinTriggerForZone(gamemode), JoinType.Solo);
        }
    }
}