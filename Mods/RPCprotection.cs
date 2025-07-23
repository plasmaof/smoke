using smokemenu.Classes;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace smokemenu.Mods
{
    //credit to Crimson/Goldentrophy
    internal class RPCprotection
    {
        public static bool NoOverlapRPCs = true;
        public static bool hasRemovedThisFrame;

        public static object LogManager { get; private set; }

        public static void RPCProt()
        {
            try
            {

                if (hasRemovedThisFrame == false)
                {
                    if (NoOverlapRPCs)
                        hasRemovedThisFrame = true;

                    GorillaNot.instance.rpcErrorMax = int.MaxValue;
                    GorillaNot.instance.rpcCallLimit = int.MaxValue;
                    GorillaNot.instance.logErrorMax = int.MaxValue;

                    PhotonNetwork.MaxResendsBeforeDisconnect = int.MaxValue;
                    PhotonNetwork.QuickResends = int.MaxValue;

                    PhotonNetwork.SendAllOutgoingCommands();
                }
            }
            catch { LogManager.Log("RPC protection failed, are you in a lobby?"); }
        }

    }
}
