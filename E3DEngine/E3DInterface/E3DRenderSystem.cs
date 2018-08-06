using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngineRuntime
{
    public enum ClearType
    {
        eCT_Color = 1,
        eCT_Depth = 1 << 1,
        eCT_Stencil = 1 << 2,
    };

    public enum DrawModule
    {
        eDM_TRIANGLE_STRIP,
        eDM_TRIANGLES,
        eDM_LINE_STRIP,
        eDM_LINES,
        eDM_POINTS,
    };

    public class RenderSystem : ISystem
    {
        public int ViewportWidth = 800;
        public int ViewportHeight = 600;

        public RendererManager mRenderManager
        {
            get;
            protected set;
        }

        public MaterialManager mMaterialManager
        {
            get;
            protected set;
        }

        public TextureDataManager mTextureManager
        {
            get;
            protected set;
        }

        public virtual void Initilize()
        {

        }

        public virtual void Cleanup()
        {

        }

        public virtual void ClearColor(float r, float g, float b, float a, ClearType clearType)
        {

        }

        public virtual void BindDefaultBackbuffer()
        {

        }

        public virtual void BeginFrame()
        {

        }

        public virtual void EndFrame()
        {

        }

        public virtual void Update(float deltaTime)
        {

        }

        public virtual void Destory()
        {
            
        }

        public string GetName()
        {
            return "RenderSystem";
        }
    }
}
