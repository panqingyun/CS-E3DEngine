using System;
using System.Runtime.CompilerServices;

namespace E3DEngine
{
    public enum BLEND_TYPE
    {
        NONE = 0,
        SRCALPHA_ADD_DESONE = 1,
        SRCALPHA_DESONEMINUSSRCALPHA = 2,
    }

    public enum CLAMP_TYPE
    {
        CLAMP_TO_EDGE = 0,
        REPEAT = 1,
        MIRRORED_REPEAT = 2,
    }

    public enum FILTER_TYPE
    {
        LINEAR = 0,
        NEAREST = 1,
        NEAREST_MIPMAP_NEAREST = 2,
        LINEAR_MIPMAP_NEAREST = 3,
        NEAREST_MIPMAP_LINEAR = 4,
        LINEAR_MIPMAP_LINEAR = 5
    }

    public class Material : Object
    {
        private Material()
        {

        }

        public void UpdateFloatValue(string name, float value)
        {

        }
    }
}