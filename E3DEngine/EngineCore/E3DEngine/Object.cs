using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using E3DEngineCommon;

namespace E3DEngine
{
    public enum ObjectType
    {
        eT_GameObject,
        eT_Scene,
        eT_Object,
        eT_Camera,
        eT_RenderObject
    }
    
    public class Object : IObject
    {
        ~Object()
        {
           
        }

        protected IntPtr nullptr = IntPtr.Zero;

        public uint ID { get; set; }

        public string Name { get; set; }

        public ObjectType mType { get; set; }
    }
}