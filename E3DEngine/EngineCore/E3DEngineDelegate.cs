using E3DEngineInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngine
{
    public enum RenderAPI
    {
        OpenGL,
        OpenGLES,
        DirectX
    }

    public class EngineDelegate : Singleton<EngineDelegate>
    {
        public RenderSystem RenderSystem
        {
            get;set;
        }
    }
}
