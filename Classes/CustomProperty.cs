using ExitGames.Client.Photon;
using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace smokemenu.Classes
{
    internal class CustomProperty
    {
        public static void smokemenucusp()
        {
            smokemenu["smoke menu v4"] = "";
            PhotonNetwork.SetPlayerCustomProperties(smokemenu);
        }
        private static ExitGames.Client.Photon.Hashtable smokemenu = PhotonNetwork.LocalPlayer.CustomProperties;
    }
}
