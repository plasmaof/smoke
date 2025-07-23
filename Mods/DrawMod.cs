using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace smokemenu.Mods
{
    internal class draw_mod
    {
        public static void draw()
        {
            if (ControllerInputPoller.instance.rightControllerGripFloat > 0.1f)
            {
                GunSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                GunSphere.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                GunSphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                GunSphere.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                GunSphere.GetComponent<Renderer>().material.color = Color.white;
                GameObject.Destroy(GunSphere.GetComponent<BoxCollider>());
                GameObject.Destroy(GunSphere.GetComponent<Rigidbody>());
                GameObject.Destroy(GunSphere.GetComponent<Collider>());
            }

            else
            {
                GunSphere.Destroy();
            }
        }
        private static GameObject GunSphere;
    }
}