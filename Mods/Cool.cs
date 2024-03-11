using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Cool
    {
        public static void CarMonke()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat >= 0.3f)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                if (ControllerInputPoller.instance.rightGrab)
                {
                    GorillaLocomotion.Player.Instance.transform.position -= GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 20f;
                }
            }
        }

        public static void InvisMonke()
        {
            if (ControllerInputPoller.instance.leftControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = -180f;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 0f;
            }
        }
    }
}
