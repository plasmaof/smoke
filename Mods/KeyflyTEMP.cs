using BepInEx;
using GorillaLocomotion;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;

namespace smokemenu.Mods
{
    //Credits to II This code is temporary 
    internal class KeyflyTEMP
    {
        private static float startX;
        private static float subThingy;
        private static int startY;
        private static float subThingyZ;

        public static void WASDFly()
        {
            GorillaTagger.Instance.rigidbody.velocity = new Vector3(0f, 0.067f, 0f);

            bool W = UnityInput.Current.GetKey(KeyCode.W);
            bool A = UnityInput.Current.GetKey(KeyCode.A);
            bool S = UnityInput.Current.GetKey(KeyCode.S);
            bool D = UnityInput.Current.GetKey(KeyCode.D);
            bool Space = UnityInput.Current.GetKey(KeyCode.Space);
            bool Ctrl = UnityInput.Current.GetKey(KeyCode.LeftControl);

            if (Mouse.current.rightButton.isPressed)
            {
                Transform parentTransform = GTPlayer.Instance.rightControllerTransform.parent;
                Quaternion currentRotation = parentTransform.rotation;
                Vector3 euler = currentRotation.eulerAngles;

                if (startX < 0)
                {
                    startX = euler.y;
                    subThingy = Mouse.current.position.value.x / Screen.width;
                }
                if (startY < 0)
                {
                    startY = (int)euler.x;
                    subThingyZ = Mouse.current.position.value.y / Screen.height;
                }

                float newX = startY - ((((Mouse.current.position.value.y / Screen.height) - subThingyZ) * 360) * 1.33f);
                float newY = startX + ((((Mouse.current.position.value.x / Screen.width) - subThingy) * 360) * 1.33f);

                newX = (newX > 180f) ? newX - 360f : newX;
                newX = Mathf.Clamp(newX, -90f, 90f);

                parentTransform.rotation = Quaternion.Euler(newX, newY, euler.z);
            }
            else
            {
                startX = -1;
                startY = -1;
            }

            float speed = 10f;
            if (UnityInput.Current.GetKey(KeyCode.LeftShift))
                speed *= 2f;

            if (W)
                GorillaTagger.Instance.rigidbody.transform.position += GTPlayer.Instance.rightControllerTransform.parent.forward * Time.deltaTime * speed;

            if (S)
                GorillaTagger.Instance.rigidbody.transform.position += GTPlayer.Instance.rightControllerTransform.parent.forward * Time.deltaTime * -speed;

            if (A)
                GorillaTagger.Instance.rigidbody.transform.position += GTPlayer.Instance.rightControllerTransform.parent.right * Time.deltaTime * -speed;

            if (D)
                GorillaTagger.Instance.rigidbody.transform.position += GTPlayer.Instance.rightControllerTransform.parent.right * Time.deltaTime * speed;

            if (Space)
                GorillaTagger.Instance.rigidbody.transform.position += new Vector3(0f, Time.deltaTime * speed, 0f);

            if (Ctrl)
                GorillaTagger.Instance.rigidbody.transform.position += new Vector3(0f, Time.deltaTime * -speed, 0f);

            VRRig.LocalRig.head.rigTarget.transform.rotation = GorillaTagger.Instance.headCollider.transform.rotation;
        }
    }
}
