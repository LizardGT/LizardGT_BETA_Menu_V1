using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class SpeedBoostMods
    {

        public static void UN_SpeedBoost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
        }

        public static void W_D_SpeedBoost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 10f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 15f;
        }

        public static void D_SpeedBoost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 22f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 22f;
        }
    }
}
