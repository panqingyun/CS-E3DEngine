
using System.Runtime.CompilerServices;

namespace E3DEngine
{

    public class PLightSceneConfig
    {
        public const string _TypeName = "PointLight";
        public const string _Color = "Color";
    }

    public enum LightType : uint
    {
        DIRECTION_LIGHT = 1,
        POINT_LIGHT,
        SPOT_LIGHT,
    };

    public class Light : GameObject
    {
        public static T Create<T>() where T : Light
        {
            Light l = null;
            
            return l as T;
        }

        public Vector4 Color
        {
            set;get;

        }// 颜色
        public float Intensity
        {
            get;
            set;
        }// 强度
    }

    public class PointLight : Light
	{
	    public float Range
        {
            get;
            set;
        }
    }

    public class DirectionLight : Light
	{
	
	}

    public class SpotLight : Light
	{
	    public float Range
        {
            get;
            set;
        }
        public int SpotAngle
        {
            get;
            set;
        }
	}
}