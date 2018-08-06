using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLImporter;
using E3DEngineRuntime;

namespace E3DEngineRenderSystem
{
    public class GLESRenderSystem : RenderSystem
    {
        private FrameBufferObject defaultFrameBuffer;

        public override void Initilize()
        {
            base.Initilize();
            mRenderManager = new GLES_RendererManager();
            mTextureManager = new GLES_TextureDataManager();
            mMaterialManager = new GLES_MaterialManager();
        }

        public override void Cleanup()
        {
            base.Cleanup();
            mMaterialManager.Cleanup();
            mTextureManager.Cleanup();
            mRenderManager.Cleanup();
            defaultFrameBuffer.Dispose();
        }

        public override void BindDefaultBackbuffer()
        {
            base.BindDefaultBackbuffer();
#if __IOS__
            defaultFrameBuffer.Bind();
            defaultFrameBuffer.BindRenderBuffer();
#else
            gl2.BindFramebuffer(gl2.GL_FRAMEBUFFER, 0);
            gl2.Viewport(0, 0, ViewportWidth, ViewportHeight);       
#endif
        }

        public override void BeginFrame()
        {
            base.BeginFrame();
#if __IOS__
            BindDefaultBackbuffer();
            defaultFrameBuffer.Clear();
#else
            gl2.BindFramebuffer(gl2.GL_FRAMEBUFFER, 0);
            gl2.Viewport(0, 0, ViewportWidth, ViewportHeight);
#endif
            gl2.CullFace(gl2.GL_BACK);
        }
        
        public override void EndFrame()
        {
            base.EndFrame();
#if !__IOS__

#endif
        }

        public override void ClearColor(float r, float g, float b, float a, ClearType clearType)
        {
            uint _type = 0;
            uint _iclearType = (uint)clearType;
            if ((_iclearType & (uint)ClearType.eCT_Color) != 0)
            {
                gl2.ClearColor(r, g, b, a);
                _type |= gl2.GL_COLOR_BUFFER_BIT;
            }
            if ((_iclearType & (uint)ClearType.eCT_Depth) != 0)
            {
                gl2.ClearDepth(1);
                _type |= gl2.GL_DEPTH_BUFFER_BIT;
            }
            if ((_iclearType & (uint)ClearType.eCT_Stencil) != 0)
            {
                gl2.ClearStencil(0);
                _type |= gl2.GL_STENCIL_BUFFER_BIT;
            }
            gl2.Clear(_type);
        }

        public void SetupDefaultFrameBuffer()
        {
            defaultFrameBuffer = new FrameBufferObject();
            defaultFrameBuffer.Create(ViewportWidth, ViewportHeight, RenderTargetType.RENDER_BUFFER);
        }

        public override void Destory()
        {
            base.Destory();
            defaultFrameBuffer.Dispose();
        }
    }

}
