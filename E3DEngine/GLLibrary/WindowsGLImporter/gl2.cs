using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
//using GLvoid = void;
using GLenum = System.UInt32;
using GLboolean = System.Byte;
using GLbitfield = System.UInt32;
using GLbyte = System.Byte;
using GLshort = System.UInt16;
using GLint = System.Int32;
using GLsizei = System.Int32;
using GLubyte = System.Byte;
using GLushort = System.Byte;
using GLuint = System.UInt32;
using GLfloat = System.Single;
using GLclampf = System.Single;
using GLfixed = System.Int32;
using GLclampx = System.Int32;

/* GL types for handling large vertex buffer objects */
using GLintptr = System.Int32;
using GLsizeiptr = System.Int32;

namespace OpenGL.ES20
{
    public class GL
    {
        private const string glDllName = "libGLESv2.dll";

        /*-------------------------------------------------------------------------
         * GL core functions.
         *-----------------------------------------------------------------------*/
        [DllImport(glDllName, EntryPoint = "glActiveTexture")]
        public static extern  void ActiveTexture(GLenum texture);

        [DllImport(glDllName, EntryPoint = "glAttachShader")]
        public static extern  void AttachShader(GLuint program, GLuint shader);

        [DllImport(glDllName, EntryPoint = "glBindAttribLocation")]
        public static extern  void BindAttribLocation(GLuint program, GLuint index, string name);

        [DllImport(glDllName, EntryPoint = "glBindBuffer")]
        public static extern  void BindBuffer(GLenum target, GLuint buffer);

        [DllImport(glDllName, EntryPoint = "glBindFramebuffer")]
        public static extern  void BindFramebuffer(GLenum target, GLuint framebuffer);

        [DllImport(glDllName, EntryPoint = "glBindRenderbuffer")]
        public static extern  void BindRenderbuffer(GLenum target, GLuint renderbuffer);

        [DllImport(glDllName, EntryPoint = "glBindTexture")]
        public static extern  void BindTexture(GLenum target, GLuint texture);

        [DllImport(glDllName, EntryPoint = "glBlendColor")]
        public static extern  void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);

        [DllImport(glDllName, EntryPoint = "glBlendEquation")]
        public static extern  void BlendEquation(GLenum mode);

        [DllImport(glDllName, EntryPoint = "glBlendEquationSeparate")]
        public static extern  void BlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);

        [DllImport(glDllName, EntryPoint = "glBlendFunc")]
        public static extern  void BlendFunc(GLenum sfactor, GLenum dfactor);

        [DllImport(glDllName, EntryPoint = "glBlendFuncSeparate")]
        public static extern  void BlendFuncSeparate(GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);

        [DllImport(glDllName, EntryPoint = "glBufferData")]
        public static extern  void BufferData(GLenum target, GLsizeiptr size, GLbyte[] data, GLenum usage);

        [DllImport(glDllName, EntryPoint = "glBufferSubData")]
        public static extern  void BufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, GLbyte[] data);

        [DllImport(glDllName, EntryPoint = "glCheckFramebufferStatus")]
        public static extern  GLenum  CheckFramebufferStatus(GLenum target);

        [DllImport(glDllName, EntryPoint = "glClear")]
        public static extern  void Clear(GLbitfield mask);

        [DllImport(glDllName, EntryPoint = "glClearColor")]
        public static extern  void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);

        [DllImport(glDllName, EntryPoint = "glClearDepthf")]
        public static extern  void ClearDepthf(GLclampf depth);

        [DllImport(glDllName, EntryPoint = "glClearStencil")]
        public static extern  void ClearStencil(GLint s);

        [DllImport(glDllName, EntryPoint = "glColorMask")]
        public static extern  void ColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);

        [DllImport(glDllName, EntryPoint = "glCompileShader")]
        public static extern  void CompileShader(GLuint shader);

        [DllImport(glDllName, EntryPoint = "glCompressedTexImage2D")]
        public static extern  void CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, 
            GLsizei width, GLsizei height, GLint border, GLsizei imageSize, GLbyte[] data);

        [DllImport(glDllName, EntryPoint = "glCompressedTexSubImage2D")]
        public static extern  void CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, 
            GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, GLbyte[] data);

        [DllImport(glDllName, EntryPoint = "glCopyTexImage2D")]
        public static extern  void CopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, 
            GLsizei width, GLsizei height, GLint border);

        [DllImport(glDllName, EntryPoint = "glCopyTexSubImage2D")]
        public static extern  void CopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x,
            GLint y, GLsizei width, GLsizei height);

        [DllImport(glDllName, EntryPoint = "glCreateProgram")]
        public static extern  GLuint CreateProgram();

        [DllImport(glDllName, EntryPoint = "glCreateShader")]
        public static extern  GLuint CreateShader(GLenum type);

        [DllImport(glDllName, EntryPoint = "glCullFace")]
        public static extern  void CullFace(GLenum mode);

        [DllImport(glDllName, EntryPoint = "glDeleteBuffers")]
        public static extern  void DeleteBuffers(GLsizei n, GLuint[] buffers);

        [DllImport(glDllName, EntryPoint = "glDeleteFramebuffers")]
        public static extern  void DeleteFramebuffers(GLsizei n, GLuint[] framebuffers);

        [DllImport(glDllName, EntryPoint = "glDeleteFramebuffers")]
        public static extern void DeleteFramebuffers(GLsizei n, ref GLuint framebuffer);

        [DllImport(glDllName, EntryPoint = "glDeleteTextures")]
        public static extern  void DeleteTextures(GLsizei n, GLuint[] textures);

        [DllImport(glDllName, EntryPoint = "glDeleteProgram")]
        public static extern  void DeleteProgram(GLuint program);

        [DllImport(glDllName, EntryPoint = "glDeleteRenderbuffers")]
        public static extern  void DeleteRenderbuffers(GLsizei n, GLuint[] renderbuffers);

        [DllImport(glDllName, EntryPoint = "glDeleteRenderbuffers")]
        public static extern void DeleteRenderbuffers(GLsizei n, ref uint renderbuffer);

        [DllImport(glDllName, EntryPoint = "glDeleteShader")]
        public static extern  void DeleteShader(GLuint shader);

        [DllImport(glDllName, EntryPoint = "glDetachShader")]
        public static extern  void DetachShader(GLuint program, GLuint shader);

        [DllImport(glDllName, EntryPoint = "glDepthFunc")]
        public static extern  void DepthFunc(GLenum func);

        [DllImport(glDllName, EntryPoint = "glDepthMask")]
        public static extern  void DepthMask(GLboolean flag);

        [DllImport(glDllName, EntryPoint = "glDepthRangef")]
        public static extern  void DepthRange(GLclampf zNear, GLclampf zFar);

        [DllImport(glDllName, EntryPoint = "glDisable")]
        public static extern  void Disable(GLenum cap);

        [DllImport(glDllName, EntryPoint = "glDisableVertexAttribArray")]
        public static extern  void DisableVertexAttribArray(GLuint index);

        [DllImport(glDllName, EntryPoint = "glDrawArrays")]
        public static extern  void DrawArrays(GLenum mode, GLint first, GLsizei count);

        [DllImport(glDllName, EntryPoint = "glDrawElements")]
        public static extern  void DrawElements(GLenum mode, GLsizei count, GLenum type, IntPtr indices);

        [DllImport(glDllName, EntryPoint = "glEnable")]
        public static extern  void Enable(GLenum cap);

        [DllImport(glDllName, EntryPoint = "glEnableVertexAttribArray")]
        public static extern  void EnableVertexAttribArray(GLuint index);

        [DllImport(glDllName, EntryPoint = "glFinish")]
        public static extern  void Finish();

        [DllImport(glDllName, EntryPoint = "glFlush")]
        public static extern  void Flush();

        [DllImport(glDllName, EntryPoint = "glFramebufferRenderbuffer")]
        public static extern  void FramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);

        [DllImport(glDllName, EntryPoint = "glFramebufferTexture2D")]
        public static extern  void FramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);

        [DllImport(glDllName, EntryPoint = "glFrontFace")]
        public static extern  void FrontFace(GLenum mode);

        [DllImport(glDllName, EntryPoint = "glGenBuffers")]
        public static extern  void GenBuffers(GLsizei n, ref GLuint buffers);

        [DllImport(glDllName, EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(GLsizei n, GLuint[] buffers);

        [DllImport(glDllName, EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(GLsizei n, GLint[] buffers);

        [DllImport(glDllName, EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(GLsizei n, ref GLint buffers);

        [DllImport(glDllName, EntryPoint = "glGenerateMipmap")]
        public static extern  void GenerateMipmap(GLenum target);

        [DllImport(glDllName, EntryPoint = "glGenFramebuffers")]
        public static extern  void GenFramebuffers(GLsizei n, ref GLuint framebuffers);

        [DllImport(glDllName, EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(GLsizei n, GLuint[] framebuffers);

        [DllImport(glDllName, EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(GLsizei n, GLint[] framebuffers);

        [DllImport(glDllName, EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(GLsizei n, ref GLint framebuffers);

        [DllImport(glDllName, EntryPoint = "glGenRenderbuffers")]
        public static extern  void GenRenderbuffers(GLsizei n, ref GLuint renderbuffers);

        [DllImport(glDllName, EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(GLsizei n, ref GLint renderbuffers);

        [DllImport(glDllName, EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(GLsizei n, GLuint[] renderbuffers);

        [DllImport(glDllName, EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(GLsizei n, GLint[] renderbuffers);

        [DllImport(glDllName, EntryPoint = "glGenTextures")]
        public static extern  void GenTextures(GLsizei n, ref GLuint textures);

        [DllImport(glDllName, EntryPoint = "glGenTextures")]
        public static extern void GenTextures(GLsizei n, ref GLint textures);

        [DllImport(glDllName, EntryPoint = "glGenTextures")]
        public static extern void GenTextures(GLsizei n, GLuint[] textures);

        [DllImport(glDllName, EntryPoint = "glGenTextures")]
        public static extern void GenTextures(GLsizei n, GLint[] textures);

        [DllImport(glDllName, EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufsize, ref GLsizei length, 
            ref GLint size, ref GLenum type, StringBuilder name);

        [DllImport(glDllName, EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufsize, GLsizei[] length, 
            GLint[] size, GLenum[] type, StringBuilder name);

        [DllImport(glDllName, EntryPoint = "glGetActiveUniform")]
        public static extern  void GetActiveUniform(GLuint program, GLuint index, GLsizei bufsize, ref GLsizei length,
            ref GLint size, ref GLenum type, StringBuilder name);

        [DllImport(glDllName, EntryPoint = "glGetActiveUniform")]
        public static extern void GetActiveUniform(GLuint program, GLuint index, GLsizei bufsize, GLsizei[] length,
            GLint[] size, GLenum[] type, StringBuilder name);

        [DllImport(glDllName, EntryPoint = "glGetAttachedShaders")]
        public static extern  void GetAttachedShaders(GLuint program, GLsizei maxcount, ref GLsizei count, ref GLuint shaders);

        [DllImport(glDllName, EntryPoint = "glGetAttachedShaders")]
        public static extern void GetAttachedShaders(GLuint program, GLsizei maxcount, GLsizei[] count, GLuint[] shaders);

        [DllImport(glDllName, EntryPoint = "glGetAttribLocation")]
        public static extern  int GetAttribLocation(GLuint program, string name);

        [DllImport(glDllName, EntryPoint = "glGetBooleanv")]
        public static extern  void GetBoolean(GLenum pname, GLboolean[] param);

        [DllImport(glDllName, EntryPoint = "glGetBufferParameteriv")]
        public static extern  void GetBufferParameter(GLenum target, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetError")]
        public static extern  GLenum GetError();

        [DllImport(glDllName, EntryPoint = "glGetFloatv")]
        public static extern  void GetFloat(GLenum pname, GLfloat[] param);

        [DllImport(glDllName, EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern  void GetFramebufferAttachmentParameter(GLenum target, GLenum attachment, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public static extern  void GetFramebufferAttachmentParameter(GLenum target, GLenum attachment, GLenum pname, ref GLint param);

        [DllImport(glDllName, EntryPoint = "glGetIntegerv")]
        public static extern  void GetInteger(GLenum pname, ref GLint param);

        [DllImport(glDllName, EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetProgramiv")]
        public static extern  void GetProgram(GLuint program, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetProgramInfoLog")]
        public static extern  void GetProgramInfoLog(GLuint program, GLsizei bufsize, ref GLsizei length, StringBuilder infolog);

        [DllImport(glDllName, EntryPoint = "glGetProgramInfoLog")]
        public static extern void GetProgramInfoLog(GLuint program, GLsizei bufsize, GLsizei[] length, StringBuilder infolog);

        [DllImport(glDllName, EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern  void GetRenderbufferParameter(GLenum target, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void GetRenderbufferParameter(GLenum target, GLenum pname, ref GLint param);

        [DllImport(glDllName, EntryPoint = "glGetShaderiv")]
        public static extern  void GetShader(GLuint shader, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(GLuint shader, GLenum pname, ref GLint param);

        [DllImport(glDllName, EntryPoint = "glGetShaderInfoLog")]
        public static extern  void GetShaderInfoLog(GLuint shader, GLsizei bufsize, GLsizei[] length, StringBuilder infolog);
        
        [DllImport(glDllName, EntryPoint = "glGetShaderInfoLog")]
        public static extern void GetShaderInfoLog(GLuint shader, GLsizei bufsize, ref GLsizei length, StringBuilder infolog);

        [DllImport(glDllName, EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern  void GetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint[] range, GLint[] precision);
        //*//
        [DllImport(glDllName, EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern void GetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, ref GLint range, ref GLint precision);

        [DllImport(glDllName, EntryPoint = "glGetShaderSource")]
        public static extern  void GetShaderSource(GLuint shader, GLsizei bufsize, ref GLsizei length, StringBuilder source);

        [DllImport(glDllName, EntryPoint = "glGetShaderSource")]
        public static extern void GetShaderSource(GLuint shader, GLsizei bufsize, GLsizei[] length, StringBuilder source);

        [DllImport(glDllName, EntryPoint = "glGetString")]
        public static extern  string GetString(GLenum name);

        [DllImport(glDllName, EntryPoint = "glGetTexParameterfv")]
        public static extern  void GetTexParameter(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport(glDllName, EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameter(GLenum target, GLenum pname, ref GLfloat param);

        [DllImport(glDllName, EntryPoint = "glGetTexParameteriv")]
        public static extern  void GetTexParameter(GLenum target, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameter(GLenum target, GLenum pname, ref GLint param);

        [DllImport(glDllName, EntryPoint = "glGetUniformfv")]
        public static extern  void GetUniform(GLuint program, GLint location, GLfloat[] param);

        [DllImport(glDllName, EntryPoint = "glGetUniformfv")]
        public static extern void GetUniform(GLuint program, GLint location, ref GLfloat param);

        [DllImport(glDllName, EntryPoint = "glGetUniformiv")]
        public static extern  void GetUniform(GLuint program, GLint location, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetUniformiv")]
        public static extern void GetUniform(GLuint program, GLint location,ref GLint param);

        [DllImport(glDllName, EntryPoint = "glGetUniformLocation")]
        public static extern  int GetUniformLocation(GLuint program, string name);

        [DllImport(glDllName, EntryPoint = "glGetVertexAttribfv")]
        public static extern  void GetVertexAttrib(GLuint index, GLenum pname, GLfloat[] param);

        [DllImport(glDllName, EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(GLuint index, GLenum pname, ref GLfloat param);

        [DllImport(glDllName, EntryPoint = "glGetVertexAttribiv")]
        public static extern  void GetVertexAttrib(GLuint index, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(GLuint index, GLenum pname,ref GLint param);

        [DllImport(glDllName, EntryPoint = "glGetVertexAttribPointerv")]
        public static extern  void GetVertexAttribPointer(GLuint index, GLenum pname, IntPtr pointer);

        [DllImport(glDllName, EntryPoint = "glHint")]
        public static extern  void Hint(GLenum target, GLenum mode);

        [DllImport(glDllName, EntryPoint = "glIsBuffer")]
        public static extern  GLboolean    IsBuffer(GLuint buffer);

        [DllImport(glDllName, EntryPoint = "glIsEnabled")]
        public static extern  GLboolean    IsEnabled(GLenum cap);

        [DllImport(glDllName, EntryPoint = "glIsFramebuffer")]
        public static extern  GLboolean    IsFramebuffer(GLuint framebuffer);

        [DllImport(glDllName, EntryPoint = "glIsProgram")]
        public static extern  GLboolean    IsProgram(GLuint program);

        [DllImport(glDllName, EntryPoint = "glIsRenderbuffer")]
        public static extern  GLboolean    IsRenderbuffer(GLuint renderbuffer);

        [DllImport(glDllName, EntryPoint = "glIsShader")]
        public static extern  GLboolean    IsShader(GLuint shader);

        [DllImport(glDllName, EntryPoint = "glIsTexture")]
        public static extern  GLboolean    IsTexture(GLuint texture);

        [DllImport(glDllName, EntryPoint = "glLineWidth")]
        public static extern  void LineWidth(GLfloat width);

        [DllImport(glDllName, EntryPoint = "glLinkProgram")]
        public static extern  void LinkProgram(GLuint program);

        [DllImport(glDllName, EntryPoint = "glPixelStorei")]
        public static extern  void PixelStore(GLenum pname, GLint param);

        [DllImport(glDllName, EntryPoint = "glPolygonOffset")]
        public static extern  void PolygonOffset(GLfloat factor, GLfloat units);

        [DllImport(glDllName, EntryPoint = "glReadPixels")]
        public static extern  void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLbyte[] pixels);

        [DllImport(glDllName, EntryPoint = "glReleaseShaderCompiler")]
        public static extern  void ReleaseShaderCompiler();

        [DllImport(glDllName, EntryPoint = "glRenderbufferStorage")]
        public static extern  void RenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);

        [DllImport(glDllName, EntryPoint = "glSampleCoverage")]
        public static extern  void SampleCoverage(GLclampf value, GLboolean invert);

        [DllImport(glDllName, EntryPoint = "glScissor")]
        public static extern  void Scissor(GLint x, GLint y, GLsizei width, GLsizei height);

        [DllImport(glDllName, EntryPoint = "glShaderBinary")]
        public static extern  void ShaderBinary(GLint n, ref GLuint shaders, GLenum binaryformat, IntPtr binary, GLint length);

        [DllImport(glDllName, EntryPoint = "glShaderBinary")]
        public static extern void ShaderBinary(GLint n, GLuint[] shaders, GLenum binaryformat, IntPtr binary, GLint length);

        [DllImport(glDllName, EntryPoint = "glShaderSource")]
        public static extern  void ShaderSource(GLuint shader, GLsizei count, string[] str, ref GLint length);

        [DllImport(glDllName, EntryPoint = "glShaderSource")]
        public static extern void ShaderSource(GLuint shader, GLsizei count, string[] str, GLint[] length);

        [DllImport(glDllName, EntryPoint = "glStencilFunc")]
        public static extern  void StencilFunc(GLenum func, GLint _ref, GLuint mask);

        [DllImport(glDllName, EntryPoint = "glStencilFuncSeparate")]
        public static extern  void StencilFuncSeparate(GLenum face, GLenum func, GLint _ref, GLuint mask);

        [DllImport(glDllName, EntryPoint = "glStencilMask")]
        public static extern  void StencilMask(GLuint mask);

        [DllImport(glDllName, EntryPoint = "glStencilMaskSeparate")]
        public static extern  void StencilMaskSeparate(GLenum face, GLuint mask);

        [DllImport(glDllName, EntryPoint = "glStencilOp")]
        public static extern  void StencilOp(GLenum fail, GLenum zfail, GLenum zpass);

        [DllImport(glDllName, EntryPoint = "glStencilOpSeparate")]
        public static extern  void StencilOpSeparate(GLenum face, GLenum fail, GLenum zfail, GLenum zpass);

        [DllImport(glDllName, EntryPoint = "glTexImage2D")]
        public static extern  void TexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height,
            GLint border, GLenum format, GLenum type, GLbyte[] pixels);

        [DllImport(glDllName, EntryPoint = "glTexParameterf")]
        public static extern  void TexParameter(GLenum target, GLenum pname, GLfloat param);

        [DllImport(glDllName, EntryPoint = "glTexParameterfv")]
        public static extern  void TexParameter(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport(glDllName, EntryPoint = "glTexParameteri")]
        public static extern  void TexParameter(GLenum target, GLenum pname, GLint param);        

        [DllImport(glDllName, EntryPoint = "glTexParameteriv")]
        public static extern  void TexParameter(GLenum target, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glTexSubImage2D")]
        public static extern  void TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, 
            GLsizei height, GLenum format, GLenum type, GLbyte[] pixels);

        [DllImport(glDllName, EntryPoint = "glUniform1f")]
        public static extern  void Uniform1(GLint location, GLfloat x);

        [DllImport(glDllName, EntryPoint = "glUniform1fv")]
        public static extern  void Uniform1(GLint location, GLsizei count, GLfloat[] v);

        [DllImport(glDllName, EntryPoint = "glUniform1i")]
        public static extern  void Uniform1(GLint location, GLint x);

        [DllImport(glDllName, EntryPoint = "glUniform1iv")]
        public static extern  void Uniform1(GLint location, GLsizei count, GLint[] v);

        [DllImport(glDllName, EntryPoint = "glUniform2f")]
        public static extern  void Uniform2(GLint location, GLfloat x, GLfloat y);

        [DllImport(glDllName, EntryPoint = "glUniform2fv")]
        public static extern  void Uniform2(GLint location, GLsizei count, GLfloat[] v);

        [DllImport(glDllName, EntryPoint = "glUniform2i")]
        public static extern  void Uniform2(GLint location, GLint x, GLint y);

        [DllImport(glDllName, EntryPoint = "glUniform2iv")]
        public static extern  void Uniform2(GLint location, GLsizei count, GLint[] v);

        [DllImport(glDllName, EntryPoint = "glUniform3f")]
        public static extern  void Uniform3(GLint location, GLfloat x, GLfloat y, GLfloat z);

        [DllImport(glDllName, EntryPoint = "glUniform3fv")]
        public static extern  void Uniform3(GLint location, GLsizei count, GLfloat[] v);

        [DllImport(glDllName, EntryPoint = "glUniform3i")]
        public static extern  void Uniform3(GLint location, GLint x, GLint y, GLint z);

        [DllImport(glDllName, EntryPoint = "glUniform3iv")]
        public static extern  void Uniform3(GLint location, GLsizei count, GLint[] v);

        [DllImport(glDllName, EntryPoint = "glUniform4f")]
        public static extern  void Uniform4(GLint location, GLfloat x, GLfloat y, GLfloat z, GLfloat w);

        [DllImport(glDllName, EntryPoint = "glUniform4fv")]
        public static extern  void Uniform4(GLint location, GLsizei count,GLfloat[] v);

        [DllImport(glDllName, EntryPoint = "glUniform4i")]
        public static extern  void Uniform4(GLint location, GLint x, GLint y, GLint z, GLint w);

        [DllImport(glDllName, EntryPoint = "glUniform4iv")]
        public static extern  void Uniform4(GLint location, GLsizei count, GLint[] v);

        [DllImport(glDllName, EntryPoint = "glUniformMatrix2fv")]
        public static extern  void UniformMatrix2(GLint location, GLsizei count, GLboolean transpose,GLfloat[] value);

        [DllImport(glDllName, EntryPoint = "glUniformMatrix3fv")]
        public static extern  void UniformMatrix3(GLint location, GLsizei count, GLboolean transpose,GLfloat[] value);

        [DllImport(glDllName, EntryPoint = "glUniformMatrix4fv")]
        public static extern  void UniformMatrix4(GLint location, GLsizei count, GLboolean transpose,GLfloat[] value);

        [DllImport(glDllName, EntryPoint = "glUseProgram")]
        public static extern  void UseProgram(GLuint program);

        [DllImport(glDllName, EntryPoint = "glValidateProgram")]
        public static extern  void ValidateProgram(GLuint program);

        [DllImport(glDllName, EntryPoint = "glVertexAttrib1f")]
        public static extern  void VertexAttrib1(GLuint indx, GLfloat x);

        [DllImport(glDllName, EntryPoint = "glVertexAttrib1fv")]
        public static extern  void VertexAttrib1(GLuint indx, GLfloat[] values);

        [DllImport(glDllName, EntryPoint = "glVertexAttrib2f")]
        public static extern  void VertexAttrib2(GLuint indx, GLfloat x, GLfloat y);

        [DllImport(glDllName, EntryPoint = "glVertexAttrib2fv")]
        public static extern  void VertexAttrib2(GLuint indx, GLfloat[] values);

        [DllImport(glDllName, EntryPoint = "glVertexAttrib3f")]
        public static extern  void VertexAttrib3(GLuint indx, GLfloat x, GLfloat y, GLfloat z);

        [DllImport(glDllName, EntryPoint = "glVertexAttrib3fv")]
        public static extern  void VertexAttrib3(GLuint indx, GLfloat[] values);

        [DllImport(glDllName, EntryPoint = "glVertexAttrib4f")]
        public static extern  void VertexAttrib4(GLuint indx, GLfloat x, GLfloat y, GLfloat z, GLfloat w);

        [DllImport(glDllName, EntryPoint = "glVertexAttrib4fv")]
        public static extern  void VertexAttrib4(GLuint indx, GLfloat[] values);

        [DllImport(glDllName, EntryPoint = "glVertexAttribPointer")]
        public static extern  void VertexAttribPointer(GLuint indx, GLint size, GLenum type, GLboolean normalized, GLsizei stride, IntPtr ptr);

        [DllImport(glDllName, EntryPoint = "glViewport")]
        public static extern  void Viewport(GLint x, GLint y, GLsizei width, GLsizei height);
    }
}
