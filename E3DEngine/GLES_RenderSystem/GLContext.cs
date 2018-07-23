#if __WIN32__
using System;
using GLLibrary;

using EGLNativeWindowType = System.IntPtr;
using EGLint = System.Int32;
using EGLBoolean = System.UInt32;
using EGLConfig = System.IntPtr;
using EGLContext = System.IntPtr;
using EGLDisplay = System.IntPtr;
using EGLSurface = System.IntPtr;
using System.Diagnostics;

namespace E3DEngine
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

            if (createEGLEnv() == egl.EGL_FALSE)
            {
                Debug.Assert(false, "初始化EGL失败");
            }
        }

        public void SwapBuffer()
        {
            egl.eglSwapBuffers(eglDisplay, eglSurface);
        }

        public EGLBoolean UseContext()
        {
            return egl.eglMakeCurrent(eglDisplay, eglSurface, eglSurface, eglContext);
        }

        protected EGLBoolean createEGLEnv()
        {
            EGLint numConfigs = 0;
            EGLint[] contextAttribs = { egl.EGL_CONTEXT_CLIENT_VERSION, 2, egl.EGL_NONE, egl.EGL_NONE };

            eglDisplay = egl.eglGetDisplay(egl.EGL_DEFAULT_DISPLAY);

            if (eglDisplay == egl.EGL_NO_DISPLAY)
            {
                return egl.EGL_FALSE;
            }

            if (egl.eglInitialize(eglDisplay,ref majorVersion,ref minorVersion) == egl.EGL_FALSE)
            {
                return egl.EGL_FALSE;
            }
            

            if (egl.eglGetConfigs(eglDisplay, nullptr, 0, ref numConfigs) == egl.EGL_FALSE)
            {
                return egl.EGL_FALSE;
            }

            if (chooseConfig(ref config, ref numConfigs) == 0) 
            {
                return egl.EGL_FALSE;
            }

            if (createSurface(config) == egl.EGL_FALSE)
            {
                return egl.EGL_FALSE;
            }

            eglContext = egl.eglCreateContext(eglDisplay, config, egl.EGL_NO_CONTEXT, contextAttribs);
            if (eglContext == egl.EGL_NO_CONTEXT)
            {
                return egl.EGL_FALSE;
            };
            return UseContext();
        }

        protected EGLBoolean createSurface(EGLConfig config)
        {
            eglSurface = egl.eglCreateWindowSurface(eglDisplay, config, windType, nullptr);
            
            if (eglSurface == egl.EGL_NO_SURFACE)
            {
                return egl.EGL_FALSE;
            }
            
            return egl.EGL_TRUE;
        }

        protected EGLBoolean chooseConfig(ref EGLConfig config, ref EGLint numConfigs)
        {
            EGLint[] attribList =
            {
                egl.EGL_RED_SIZE,           8,
                egl.EGL_GREEN_SIZE,         8,
                egl.EGL_BLUE_SIZE,          8,
                egl.EGL_ALPHA_SIZE,         8,
                egl.EGL_DEPTH_SIZE,         8,
                egl.EGL_STENCIL_SIZE,       8,
                egl.EGL_SAMPLE_BUFFERS,     1,
                egl.EGL_SAMPLES,            4,
                egl.EGL_NONE
            };
            if (egl.eglChooseConfig(eglDisplay, attribList, ref config, 1, ref numConfigs) == egl.EGL_FALSE)
            {
                int err = egl.eglGetError();
                return egl.EGL_FALSE;
            }

            return egl.EGL_TRUE;
        }

    }
}
#endif
