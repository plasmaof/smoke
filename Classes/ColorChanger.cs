﻿using UnityEngine;


namespace smokemenu.Classes
{
    public class ColorChanger : TimedBehaviour
    {
        public override void Start()
        {
            base.Start();
            renderer = base.GetComponent<Renderer>();
            Update();
        }

        public override void Update()
        {
            base.Update();
            if (colorInfo != null)
            {
                if (!colorInfo.copyRigColors)
                {
                    Color color = new Gradient { colorKeys = colorInfo.colors }.Evaluate((Time.time / 2f) % 1);
                    if (colorInfo.isRainbow)
                    {
                        float m = (Time.frameCount / 180f) % 1f;
                        color = new Color(61f / 255f, 22f / 255f, 67f / 255f);
                    }
                    renderer.material.color = color;
                }
                else
                {
                    renderer.material = GorillaTagger.Instance.offlineVRRig.mainSkin.material;
                }
            }
        }

        public Renderer renderer;
        public ExtGradient colorInfo;
    }
}
