using System;
using System.Text;

using GLenum = System.UInt32;
using GLbitfield = System.UInt32;
using GLint = System.Int32;
using GLsizei = System.Int32;
using GLuint = System.UInt32;
using GLfloat = System.Single;
using GLbyte = System.Byte;
using GLclampf = System.Single;

/* GL types for handling large vertex buffer objects */
using GLintptr = System.Int32;
using GLsizeiptr = System.Int32;
using System.Runtime.InteropServices;

namespace E3DEngineRuntime
{
    public class GLCommon
    {
        public const GLbyte GL_TRUE = 1;
        public const GLbyte GL_FALSE = 0;
    }
    
    public interface IOpenGLImporter
    {
        void ActiveTexture(GLenum texture);

        void AttachShader(GLuint program, GLuint shader);
        
        void BindAttribLocation(GLuint program, GLuint index, string name);
        
        void BindBuffer(GLenum target, GLuint buffer);
        
        void BindFramebuffer(GLenum target, GLuint framebuffer);
        
        void BindRenderbuffer(GLenum target, GLuint renderbuffer);
        
        void BindTexture(GLenum target, GLuint texture);
        
        void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        
        void BlendEquation(GLenum mode);
        
        void BlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);
        
        void BlendFunc(GLenum sfactor, GLenum dfactor);
        
        void BlendFuncSeparate(GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
        
        void BufferData(GLenum target, GLsizeiptr size, GLbyte[] data, GLenum usage);
        
        void BufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, GLbyte[] data);
        
        GLenum CheckFramebufferStatus(GLenum target);
        
        void Clear(GLbitfield mask);
        
        void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        
        void ClearDepthf(GLclampf depth);
        
        void ClearStencil(GLint s);
        
        void ColorMask(bool red, bool green, bool blue, bool alpha);
        
        void CompileShader(GLuint shader);
        
        void CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat,
            GLsizei width, GLsizei height, GLint border, GLsizei imageSize, GLbyte[] data);
        
        void CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset,
            GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, GLbyte[] data);
        
        void CopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y,
            GLsizei width, GLsizei height, GLint border);
        
        void CopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x,
            GLint y, GLsizei width, GLsizei height);
        
        GLuint CreateProgram();
        
        GLuint CreateShader(GLenum type);
        
        void CullFace(GLenum mode);
        
        void DeleteBuffers(GLsizei n, GLuint[] buffers);
        
        void DeleteFramebuffers(GLsizei n, GLuint[] framebuffers);

        void DeleteFramebuffers(int n, ref GLuint framebuffer);


        void DeleteTextures(GLsizei n, GLuint[] textures);
        
        void DeleteProgram(GLuint program);
        
        void DeleteRenderbuffers(GLsizei n, GLuint[] renderbuffers);

        void DeleteRenderbuffers(int n, ref uint renderbuffer);

        void DeleteShader(GLuint shader);
        
        void DetachShader(GLuint program, GLuint shader);
        
        void DepthFunc(GLenum func);
        
        void DepthMask(bool flag);
        
        void DepthRange(GLclampf zNear, GLclampf zFar);
        
        void Disable(GLenum cap);
        
        void DisableVertexAttribArray(GLuint index);
        
        void DrawArrays(GLenum mode, GLint first, GLsizei count);
        
        void DrawElements(GLenum mode, GLsizei count, GLenum type, IntPtr indices);
        
        void Enable(GLenum cap);
        
        void EnableVertexAttribArray(GLuint index);
        
        void Finish();
        
        void Flush();
        
        void FramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        
        void FramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        
        void FrontFace(GLenum mode);
        
        void GenBuffers(GLsizei n, ref GLuint buffers);
        
        void GenBuffers(GLsizei n, GLuint[] buffers);
        
        void GenBuffers(GLsizei n, GLint[] buffers);
        
        void GenBuffers(GLsizei n, ref GLint buffers);
        
        void GenerateMipmap(GLenum target);
        
        void GenFramebuffers(GLsizei n, ref GLuint framebuffers);
        
        void GenFramebuffers(GLsizei n, GLuint[] framebuffers);
        
        void GenFramebuffers(GLsizei n, GLint[] framebuffers);
        
        void GenFramebuffers(GLsizei n, ref GLint framebuffers);
        
        void GenRenderbuffers(GLsizei n, ref GLuint renderbuffers);
        
        void GenRenderbuffers(GLsizei n, ref GLint renderbuffers);
        
        void GenRenderbuffers(GLsizei n, GLuint[] renderbuffers);
        
        void GenRenderbuffers(GLsizei n, GLint[] renderbuffers);
        
        void GenTextures(GLsizei n, ref GLuint textures);
        
        void GenTextures(GLsizei n, ref GLint textures);
        
        void GenTextures(GLsizei n, GLuint[] textures);
        
        void GenTextures(GLsizei n, GLint[] textures);
        
        void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufsize, ref GLsizei length,
            ref GLint size, ref GLenum type, StringBuilder name);
        
        void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufsize, GLsizei[] length,
            GLint[] size, GLenum[] type, StringBuilder name);
        
        void GetActiveUniform(GLuint program, GLuint index, GLsizei bufsize, ref GLsizei length,
            ref GLint size, ref GLenum type, StringBuilder name);
        
        void GetActiveUniform(GLuint program, GLuint index, GLsizei bufsize, GLsizei[] length,
            GLint[] size, GLenum[] type, StringBuilder name);
        
        void GetAttachedShaders(GLuint program, GLsizei maxcount, ref GLsizei count, ref GLuint shaders);
        
        void GetAttachedShaders(GLuint program, GLsizei maxcount, GLsizei[] count, GLuint[] shaders);
        
        int GetAttribLocation(GLuint program, string name);
        
        void GetBoolean(GLenum pname, bool[] param);
        
        void GetBufferParameter(GLenum target, GLenum pname, GLint[] param);
        
        GLenum GetError();
        
        void GetFloat(GLenum pname, GLfloat[] param);
        
        void GetFramebufferAttachmentParameter(GLenum target, GLenum attachment, GLenum pname, GLint[] param);
        
        void GetFramebufferAttachmentParameter(GLenum target, GLenum attachment, GLenum pname, ref GLint param);
        
        void GetInteger(GLenum pname, ref GLint param);
        
        void GetInteger(GLenum pname, GLint[] param);
        
        void GetProgram(GLuint program, GLenum pname, GLint[] param);
        
        void GetProgramInfoLog(GLuint program, GLsizei bufsize, ref GLsizei length, StringBuilder infolog);
        
        void GetProgramInfoLog(GLuint program, GLsizei bufsize, GLsizei[] length, StringBuilder infolog);
        
        void GetRenderbufferParameter(GLenum target, GLenum pname, GLint[] param);
        
        void GetRenderbufferParameter(GLenum target, GLenum pname, ref GLint param);
        
        void GetShader(GLuint shader, GLenum pname, GLint[] param);
        
        void GetShader(GLuint shader, GLenum pname, ref GLint param);
        
        void GetShaderInfoLog(GLuint shader, GLsizei bufsize, GLsizei[] length, StringBuilder infolog);
        
        void GetShaderInfoLog(GLuint shader, GLsizei bufsize, ref GLsizei length, StringBuilder infolog);
        
        void GetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint[] range, GLint[] precision);
        //*//
        void GetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, ref GLint range, ref GLint precision);
        
        void GetShaderSource(GLuint shader, GLsizei bufsize, ref GLsizei length, StringBuilder source);
        
        void GetShaderSource(GLuint shader, GLsizei bufsize, GLsizei[] length, StringBuilder source);
        
        string GetString(GLenum name);
        
        void GetTexParameter(GLenum target, GLenum pname, GLfloat[] param);
        
        void GetTexParameter(GLenum target, GLenum pname, ref GLfloat param);
        
        void GetTexParameter(GLenum target, GLenum pname, GLint[] param);
        
        void GetTexParameter(GLenum target, GLenum pname, ref GLint param);
        
        void GetUniform(GLuint program, GLint location, GLfloat[] param);
        
        void GetUniform(GLuint program, GLint location, ref GLfloat param);
        
        void GetUniform(GLuint program, GLint location, GLint[] param);
        
        void GetUniform(GLuint program, GLint location, ref GLint param);
        
        int GetUniformLocation(GLuint program, string name);
        
        void GetVertexAttrib(GLuint index, GLenum pname, GLfloat[] param);
        
        void GetVertexAttrib(GLuint index, GLenum pname, ref GLfloat param);
        
        void GetVertexAttrib(GLuint index, GLenum pname, GLint[] param);
        
        void GetVertexAttrib(GLuint index, GLenum pname, ref GLint param);
        
        void GetVertexAttribPointer(GLuint index, GLenum pname, IntPtr pointer);
        
        void Hint(GLenum target, GLenum mode);
        
        bool IsBuffer(GLuint buffer);
        
        bool IsEnabled(GLenum cap);
        
        bool IsFramebuffer(GLuint framebuffer);
        
        bool IsProgram(GLuint program);
        
        bool IsRenderbuffer(GLuint renderbuffer);
        
        bool IsShader(GLuint shader);
        
        bool IsTexture(GLuint texture);
        
        void LineWidth(GLfloat width);
        
        void LinkProgram(GLuint program);
        
        void PixelStore(GLenum pname, GLint param);
        
        void PolygonOffset(GLfloat factor, GLfloat units);
        
        void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLbyte[] pixels);
        
        void ReleaseShaderCompiler();
        
        void RenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
        
        void SampleCoverage(GLclampf value, bool invert);
        
        void Scissor(GLint x, GLint y, GLsizei width, GLsizei height);
        
        void ShaderBinary(GLint n, ref GLuint shaders, GLenum binaryformat, IntPtr binary, GLint length);
        
        void ShaderBinary(GLint n, GLuint[] shaders, GLenum binaryformat, IntPtr binary, GLint length);
        
        void ShaderSource(GLuint shader, GLsizei count, string[] str, ref GLint length);
        
        void ShaderSource(GLuint shader, GLsizei count, string[] str, GLint[] length);
        
        void StencilFunc(GLenum func, GLint _ref, GLuint mask);
        
        void StencilFuncSeparate(GLenum face, GLenum func, GLint _ref, GLuint mask);
        
        void StencilMask(GLuint mask);
        
        void StencilMaskSeparate(GLenum face, GLuint mask);
        
        void StencilOp(GLenum fail, GLenum zfail, GLenum zpass);
        
        void StencilOpSeparate(GLenum face, GLenum fail, GLenum zfail, GLenum zpass);
        
        void TexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height,
            GLint border, GLenum format, GLenum type, GLbyte[] pixels);
        
        void TexParameter(GLenum target, GLenum pname, GLfloat param);
        
        void TexParameter(GLenum target, GLenum pname, GLfloat[] param);
        
        void TexParameter(GLenum target, GLenum pname, GLint param);
        
        void TexParameter(GLenum target, GLenum pname, GLint[] param);
        
        void TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width,
            GLsizei height, GLenum format, GLenum type, GLbyte[] pixels);
        
        void Uniform1(GLint location, GLfloat x);
        
        void Uniform1(GLint location, GLsizei count, GLfloat[] v);
        
        void Uniform1(GLint location, GLint x);
        
        void Uniform1(GLint location, GLsizei count, GLint[] v);
        
        void Uniform2(GLint location, GLfloat x, GLfloat y);
        
        void Uniform2(GLint location, GLsizei count, GLfloat[] v);
        
        void Uniform2(GLint location, GLint x, GLint y);
        
        void Uniform2(GLint location, GLsizei count, GLint[] v);
        
        void Uniform3(GLint location, GLfloat x, GLfloat y, GLfloat z);
        
        void Uniform3(GLint location, GLsizei count, GLfloat[] v);
        
        void Uniform3(GLint location, GLint x, GLint y, GLint z);
        
        void Uniform3(GLint location, GLsizei count, GLint[] v);
        
        void Uniform4(GLint location, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        
        void Uniform4(GLint location, GLsizei count, GLfloat[] v);
        
        void Uniform4(GLint location, GLint x, GLint y, GLint z, GLint w);
        
        void Uniform4(GLint location, GLsizei count, GLint[] v);
        
        void UniformMatrix2(GLint location, GLsizei count, bool transpose, GLfloat[] value);
        
        void UniformMatrix3(GLint location, GLsizei count, bool transpose, GLfloat[] value);
        
        void UniformMatrix4(GLint location, GLsizei count, bool transpose, GLfloat[] value);
        
        void UseProgram(GLuint program);
        
        void ValidateProgram(GLuint program);
        
        void VertexAttrib1(GLuint indx, GLfloat x);
        
        void VertexAttrib1(GLuint indx, GLfloat[] values);
        
        void VertexAttrib2(GLuint indx, GLfloat x, GLfloat y);
        
        void VertexAttrib2(GLuint indx, GLfloat[] values);
        
        void VertexAttrib3(GLuint indx, GLfloat x, GLfloat y, GLfloat z);
        
        void VertexAttrib3(GLuint indx, GLfloat[] values);
        
        void VertexAttrib4(GLuint indx, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        
        void VertexAttrib4(GLuint indx, GLfloat[] values);
        
        void VertexAttribPointer(GLuint indx, GLint size, GLenum type, bool normalized, GLsizei stride, IntPtr ptr);
        
        void Viewport(GLint x, GLint y, GLsizei width, GLsizei height);
    }
}
