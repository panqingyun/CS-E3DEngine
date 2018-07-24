using System;
using OpenGL.EGL;

using EGLNativeWindowType = System.IntPtr;
using EGLint = System.Int32;
using EGLBoolean = System.UInt32;
using EGLConfig = System.IntPtr;
using EGLContext = System.IntPtr;
using EGLDisplay = System.IntPtr;
using EGLSurface = System.IntPtr;
using System.Diagnostics;

namespace WindowsGL
{
    public class GLContext
    {
        private EGLConfig config;
        private EGLint majorVersion;
        private EGLint minorVersion;
        private EGLNativeWindowType windType;
        private EGLDisplay eglDisplay;
        private EGLContext eglContext;
        private EGLSurface eglSurface;
        private IntPtr nullptr = IntPtr.Zero;

        public void InitGLES( EGLNativeWindowType _windType)
        {
            windType = _windType;

            if (createEGLEnv() == EGL.EGL_FALSE)
            {
                Debug.Assert(false, "初始化EGL失败");
            }
        }

        public void SwapBuffer()
        {
            EGL.eglSwapBuffers(eglDisplay, eglSurface);
        }

        public EGLBoolean UseContext()
        {
            return EGL.eglMakeCurrent(eglDisplay, eglSurface, eglSurface, eglContext);
        }

        protected EGLBoolean createEGLEnv()
        {
            EGLint numConfigs = 0;
            EGLint[] contextAttribs = { EGL.EGL_CONTEXT_CLIENT_VERSION, 2, EGL.EGL_NONE, EGL.EGL_NONE };

            eglDisplay = EGL.eglGetDisplay(EGL.EGL_DEFAULT_DISPLAY);

            if (eglDisplay == EGL.EGL_NO_DISPLAY)
            {
                return EGL.EGL_FALSE;
            }

            if (EGL.eglInitialize(eglDisplay,ref majorVersion,ref minorVersion) == EGL.EGL_FALSE)
            {
                return EGL.EGL_FALSE;
            }
            

            if (EGL.eglGetConfigs(eglDisplay, nullptr, 0, ref numConfigs) == EGL.EGL_FALSE)
            {
                return EGL.EGL_FALSE;
            }

            if (chooseConfig(ref config, ref numConfigs) == 0) 
            {
                return EGL.EGL_FALSE;
            }

            if (createSurface(config) == EGL.EGL_FALSE)
            {
                return EGL.EGL_FALSE;
            }

            eglContext = EGL.eglCreateContext(eglDisplay, config, EGL.EGL_NO_CONTEXT, contextAttribs);
            if (eglContext == EGL.EGL_NO_CONTEXT)
            {
                return EGL.EGL_FALSE;
            };
            return UseContext();
        }

        protected EGLBoolean createSurface(EGLConfig config)
        {
            eglSurface = EGL.eglCreateWindowSurface(eglDisplay, config, windType, nullptr);
            
            if (eglSurface == EGL.EGL_NO_SURFACE)
            {
                return EGL.EGL_FALSE;
            }
            
            return EGL.EGL_TRUE;
        }

        protected EGLBoolean chooseConfig(ref EGLConfig config, ref EGLint numConfigs)
        {
            EGLint[] attribList =
            {
                EGL.EGL_RED_SIZE,           8,
                EGL.EGL_GREEN_SIZE,         8,
                EGL.EGL_BLUE_SIZE,          8,
                EGL.EGL_ALPHA_SIZE,         8,
                EGL.EGL_DEPTH_SIZE,         8,
                EGL.EGL_STENCIL_SIZE,       8,
                EGL.EGL_SAMPLE_BUFFERS,     1,
                EGL.EGL_SAMPLES,            4,
                EGL.EGL_NONE
            };
            if (EGL.eglChooseConfig(eglDisplay, attribList, ref config, 1, ref numConfigs) == EGL.EGL_FALSE)
            {
                int err = EGL.eglGetError();
                return EGL.EGL_FALSE;
            }

            return EGL.EGL_TRUE;
        }

    }
}
