using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class DisconectMODS
    {
        public static void Diconnect()
        {
            PhotonNetwork.Disconnect();
        }

        public static void QUITGTAG()
        {
            Application.Quit();
        }
    }
}
