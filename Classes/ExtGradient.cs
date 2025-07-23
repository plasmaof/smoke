using System;
using UnityEngine;

namespace smokemenu.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.black, 0f),
            new GradientColorKey(Color.red, 0f),
            new GradientColorKey(Color.black, 1f)
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
