using GLImporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngineRenderSystem
{
    public enum RenderTargetType
    {
        RENDER_BUFFER,
        RENDER_TO_TEXTURE,
    }

    public class RenderTarget : IDisposable
    {
        public uint mDepthBuffer;
        public RenderTargetType mRenderType;

        ~RenderTarget()
        {
            
        }

        public virtual void Dispose()
        {
            gl2.DeleteRenderbuffers(1, ref mDepthBuffer);
        }
    }

    public class RenderTexture : RenderTarget
    {
        public uint mTextureBuffer;

        public RenderTexture()
        {
            mRenderType = RenderTargetType.RENDER_TO_TEXTURE;
            mDepthBuffer = 0;
            mTextureBuffer = 0;
        }

        public override void Dispose()
        {
            base.Dispose();
            gl2.DeleteRenderbuffers(1, ref mTextureBuffer);
        }
    }

    public class RenderBuffer : RenderTarget
    {
        public uint mRenderBuffer;

        public RenderBuffer()
        {
            mRenderType = RenderTargetType.RENDER_BUFFER;
            mDepthBuffer = 0;
            mRenderBuffer = 0;
        }

        public override void Dispose()
        {
            base.Dispose();
            gl2.DeleteRenderbuffers(1, ref mRenderBuffer);
        }
    }

    public class FrameBufferObject : IDisposable
    {
        private uint mFrameBuffer;
        private RenderTarget mRenderTarget;
        private int mFrameWidth;
        private int mFrameHeight;
        private Color4 mClearColor;
        private int mBufferFormat;
        private int mBufferType;
        private byte[] mBufferPixels;

        public FrameBufferObject()
        {
            mFrameBuffer = 0;
            mRenderTarget = null;
            mClearColor = new Color4(0, 0, 0, 0);
            mBufferPixels = null;
        }

        public void Dispose()
        {
            gl2.DeleteFramebuffers(1, ref mFrameBuffer);
        }

        public void Create(int width, int height, RenderTargetType targetType)
        {
            mFrameWidth = width;
            mFrameHeight = height;
            createTarget(targetType);

            gl2.GenFramebuffers(1, ref mFrameBuffer);
            gl2.BindFramebuffer(gl2.GL_FRAMEBUFFER, mFrameBuffer);
            gl2.GenRenderbuffers(1, ref mRenderTarget.mDepthBuffer);
            gl2.BindRenderbuffer(gl2.GL_RENDERBUFFER, mRenderTarget.mDepthBuffer);
            gl2.RenderbufferStorage(gl2.GL_RENDERBUFFER, gl2.GL_DEPTH_COMPONENT16, width, height);
            gl2.FramebufferRenderbuffer(gl2.GL_FRAMEBUFFER, gl2.GL_DEPTH_ATTACHMENT, gl2.GL_RENDERBUFFER, mRenderTarget.mDepthBuffer);

            if (targetType == RenderTargetType.RENDER_BUFFER)
            {
                RenderBuffer dt = mRenderTarget as RenderBuffer;
                gl2.GenRenderbuffers(1, ref dt.mRenderBuffer);
                gl2.BindRenderbuffer(gl2.GL_TEXTURE_2D, dt.mRenderBuffer);
                gl2.RenderbufferStorage(gl2.GL_RENDERBUFFER, gl2ext.GL_RGBA8_OES, width, height);
                gl2.FramebufferRenderbuffer(gl2.GL_FRAMEBUFFER, gl2.GL_COLOR_ATTACHMENT0, gl2.GL_RENDERBUFFER, dt.mRenderBuffer);
            }
            else
            {
                RenderTexture dt = mRenderTarget as RenderTexture;
                gl2.GenTextures(1, ref dt.mTextureBuffer);
                gl2.BindTexture(gl2.GL_TEXTURE_2D, dt.mTextureBuffer);
                gl2.TexParameter(gl2.GL_TEXTURE_2D, gl2.GL_TEXTURE_MIN_FILTER, gl2.GL_LINEAR);
                gl2.TexParameter(gl2.GL_TEXTURE_2D, gl2.GL_TEXTURE_MAG_FILTER, gl2.GL_LINEAR);
                gl2.TexParameter(gl2.GL_TEXTURE_2D, gl2.GL_TEXTURE_WRAP_S, gl2.GL_CLAMP_TO_EDGE);
                gl2.TexParameter(gl2.GL_TEXTURE_2D, gl2.GL_TEXTURE_WRAP_T, gl2.GL_CLAMP_TO_EDGE);
                gl2.TexImage2D(gl2.GL_TEXTURE_2D, 0, gl2.GL_RGBA, width, height, 0, gl2.GL_RGBA, gl2.GL_UNSIGNED_BYTE, null);
                gl2.FramebufferTexture2D(gl2.GL_FRAMEBUFFER, gl2.GL_COLOR_ATTACHMENT0, gl2.GL_TEXTURE_2D, dt.mTextureBuffer, 0);
            }

            mBufferPixels = new byte[width * height * 4];
            gl2.GetInteger(gl2.GL_IMPLEMENTATION_COLOR_READ_TYPE, ref mBufferType);
            gl2.GetInteger(gl2.GL_IMPLEMENTATION_COLOR_READ_FORMAT, ref mBufferFormat);
            gl2.BindFramebuffer(gl2.GL_FRAMEBUFFER, 0);
        }

        public void Clear()
        {
            gl2.ClearColor(mClearColor.r, mClearColor.g, mClearColor.b, mClearColor.a);
            gl2.ClearStencil(0);
            gl2.Clear(gl2.GL_COLOR_BUFFER_BIT | gl2.GL_DEPTH_BUFFER_BIT | gl2.GL_STENCIL_BUFFER_BIT);
        }

        public void Bind()
        {
            gl2.BindFramebuffer(gl2.GL_FRAMEBUFFER, mFrameBuffer);
            gl2.Viewport(0, 0, mFrameWidth, mFrameHeight);
        }

        public void BindRenderBuffer()
        {
            if (mRenderTarget.mRenderType == RenderTargetType.RENDER_BUFFER)
            {
                gl2.BindRenderbuffer(gl2.GL_RENDERBUFFER, ((RenderBuffer)mRenderTarget).mRenderBuffer);
            }
        }

        public void SetClearColor(Color4 clearColor)
        {
            mClearColor = clearColor;
        }

        public uint GetTextureBufferID()
        {
            if (mRenderTarget.mRenderType == RenderTargetType.RENDER_TO_TEXTURE)
            {
                return ((RenderTexture)mRenderTarget).mTextureBuffer;
            }
            return 0;
        }

        public uint GetRenderBufferID()
        {
            if (mRenderTarget.mRenderType == RenderTargetType.RENDER_BUFFER)
            {
                return ((RenderBuffer)mRenderTarget).mRenderBuffer;
            }
            return 0;
        }

        public uint GetDepthBufferID()
        {
            return mRenderTarget.mDepthBuffer;
        }

        public byte[] GetPixels()
        {
            gl2.BindFramebuffer(gl2.GL_FRAMEBUFFER, mFrameBuffer);
            gl2.ReadPixels(0, 0, mFrameWidth, mFrameHeight, (uint)mBufferFormat, (uint)mBufferType, mBufferPixels);
            return mBufferPixels;
        }

        public int GetReadBufferFormat()
        {
            return mBufferFormat;
        }

        private void createTarget(RenderTargetType targetType)
        {
            if (targetType == RenderTargetType.RENDER_BUFFER)
            {
                mRenderTarget = new RenderBuffer();
            }
            else if (targetType == RenderTargetType.RENDER_TO_TEXTURE)
            {
                mRenderTarget = new RenderTexture();
            }
        }
    }
}
