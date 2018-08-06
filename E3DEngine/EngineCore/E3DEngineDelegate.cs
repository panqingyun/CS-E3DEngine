using E3DEngineRuntime;
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
        private bool mbIsInited = false;
        private bool mbPause = false;

        public static RenderSystem RenderSystem
        {
            get;set;
        }
        
        public void Initilize()
        {
            if(mbIsInited)
            {
                return;
            }
            Application.Initialize();
            mbIsInited = true;
        }

        public void Update(float deltaTime)
        {
            if (mbPause)
            {
                return;
            }
            Application.UpdateApp(deltaTime);
        }
            
        public void Destory()
        {
            Application.Destory();
        }

        public void SetEnginePause(bool bPause)
        {
            mbPause = bPause;
        }
    }
}
