using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenGL.ES20;

using GLboolean = System.Byte;
using E3DEngineCommon;

namespace WindowsGL
{
    public class WindowsGLImporter : IOpenGLImporter
    {
        public void ActiveTexture(uint texture)
        {
            GL.ActiveTexture(texture);
        }

        public void AttachShader(uint program, uint shader)
        {
            GL.AttachShader(program, shader);
        }

        public void BindAttribLocation(uint program, uint index, string name)
        {
            GL.BindAttribLocation(program, index, name);
        }

        public void BindBuffer(uint target, uint buffer)
        {
            GL.BindBuffer(target, buffer);
        }

        public void BindFramebuffer(uint target, uint framebuffer)
        {
            GL.BindFramebuffer(target, framebuffer);
        }

        public void BindRenderbuffer(uint target, uint renderbuffer)
        {
            GL.BindRenderbuffer(target, renderbuffer);
        }

        public void BindTexture(uint target, uint texture)
        {
            GL.BindTexture(target, texture);
        }

        public void BlendColor(float red, float green, float blue, float alpha)
        {
            GL.BlendColor(red, green, blue, alpha);
        }

        public void BlendEquation(uint mode)
        {
            GL.BlendEquation(mode);
        }

        public void BlendEquationSeparate(uint modeRGB, uint modeAlpha)
        {
            GL.BlendEquationSeparate(modeRGB, modeAlpha);
        }

        public void BlendFunc(uint sfactor, uint dfactor)
        {
            GL.BlendFunc(sfactor, dfactor);
        }

        public void BlendFuncSeparate(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
        {
            GL.BlendFuncSeparate(srcRGB, dstRGB, srcAlpha, dstAlpha);
        }

        public void BufferData(uint target, int size, byte[] data, uint usage)
        {
            GL.BufferData(target, size, data, usage);
        }

        public void BufferSubData(uint target, int offset, int size, byte[] data)
        {
            GL.BufferSubData(target, offset, size, data);
        }

        public uint CheckFramebufferStatus(uint target)
        {
            return GL.CheckFramebufferStatus(target);
        }

        public void Clear(uint mask)
        {
            GL.Clear(mask);
        }

        public void ClearColor(float red, float green, float blue, float alpha)
        {
            GL.ClearColor(red, green, blue, alpha);
        }

        public void ClearDepthf(float depth)
        {
            GL.ClearDepthf(depth);
        }

        public void ClearStencil(int s)
        {
            GL.ClearStencil(s);
        }

        public void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            GL.ColorMask(red ? (byte)1 : (byte)0, green ? (byte)1 : (byte)0, blue ? (byte)1 : (byte)0, alpha ? (byte)1 : (byte)0);
        }

        public void CompileShader(uint shader)
        {
            GL.CompileShader(shader);
        }

        public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, byte[] data)
        {
            GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        }

        public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, byte[] data)
        {
            GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
        {
            GL.CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
        }

        public void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            GL.CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }

        public uint CreateProgram()
        {
            return GL.CreateProgram();
        }

        public uint CreateShader(uint type)
        {
            return CreateShader(type);
        }

        public void CullFace(uint mode)
        {
            GL.CullFace(mode);
        }

        public void DeleteBuffers(int n, uint[] buffers)
        {
            GL.DeleteBuffers(n, buffers);
        }

        public void DeleteFramebuffers(int n, uint[] framebuffers)
        {
            GL.DeleteFramebuffers(n, framebuffers);
        }

        public void DeleteProgram(uint program)
        {
            GL.DeleteProgram(program);
        }

        public void DeleteRenderbuffers(int n, uint[] renderbuffers)
        {
            GL.DeleteRenderbuffers(n, renderbuffers);
        }

        public void DeleteShader(uint shader)
        {
            GL.DeleteShader(shader);
        }

        public void DeleteTextures(int n, uint[] textures)
        {
            GL.DeleteTextures(n, textures);
        }

        public void DepthFunc(uint func)
        {
            GL.DepthFunc(func);
        }

        public void DepthMask(byte flag)
        {
            GL.DepthMask(flag);
        }

        public void DepthRange(float zNear, float zFar)
        {
            GL.DepthRange(zNear, zFar);
        }

        public void DetachShader(uint program, uint shader)
        {
            GL.DetachShader(program, shader);
        }

        public void Disable(uint cap)
        {
            GL.Disable(cap);
        }

        public void DisableVertexAttribArray(uint index)
        {
            GL.DisableVertexAttribArray(index);
        }

        public void DrawArrays(uint mode, int first, int count)
        {
            GL.DrawArrays(mode, first, count);
        }

        public void DrawElements(uint mode, int count, uint type, IntPtr indices)
        {
            GL.DrawElements(mode, count, type, indices);
        }

        public void Enable(uint cap)
        {
            GL.Enable(cap);
        }

        public void EnableVertexAttribArray(uint index)
        {
            GL.EnableVertexAttribArray(index);
        }

        public void Finish()
        {
            GL.Finish();
        }

        public void Flush()
        {
            GL.Flush();
        }

        public void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
        {
            GL.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
        }

        public void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
        {
            GL.FramebufferTexture2D(target, attachment, textarget, texture, level);
        }

        public void FrontFace(uint mode)
        {
            GL.FrontFace(mode);
        }

        public void GenBuffers(int n, int[] buffers)
        {
            GL.GenBuffers(n, buffers);
        }

        public void GenBuffers(int n, ref int buffers)
        {
            GL.GenBuffers(n, ref  buffers);
        }

        public void GenBuffers(int n, uint[] buffers)
        {
            GL.GenBuffers(n, buffers);
        }

        public void GenBuffers(int n, ref uint buffers)
        {
            GL.GenBuffers(n, ref buffers);
        }

        public void GenerateMipmap(uint target)
        {
            GL.GenerateMipmap(target);
        }

        public void GenFramebuffers(int n, int[] framebuffers)
        {
            GL.GenFramebuffers(n, framebuffers);
        }

        public void GenFramebuffers(int n, ref int framebuffers)
        {
            GL.GenFramebuffers(n, ref framebuffers);
        }

        public void GenFramebuffers(int n, uint[] framebuffers)
        {
            GL.GenFramebuffers(n, framebuffers);
        }

        public void GenFramebuffers(int n, ref uint framebuffers)
        {
            GL.GenFramebuffers(n, ref framebuffers);
        }

        public void GenRenderbuffers(int n, uint[] renderbuffers)
        {
            GL.GenRenderbuffers(n, renderbuffers);
        }

        public void GenRenderbuffers(int n, int[] renderbuffers)
        {
            GL.GenRenderbuffers(n, renderbuffers);
        }

        public void GenRenderbuffers(int n, ref int renderbuffers)
        {
            GL.GenRenderbuffers(n, ref renderbuffers);
        }

        public void GenRenderbuffers(int n, ref uint renderbuffers)
        {
            GL.GenRenderbuffers(n, ref renderbuffers);
        }

        public void GenTextures(int n, int[] textures)
        {
            GL.GenTextures(n, textures);
        }

        public void GenTextures(int n, uint[] textures)
        {
            GL.GenTextures(n, textures);
        }

        public void GenTextures(int n, ref int textures)
        {
            GL.GenTextures(n, ref textures);
        }

        public void GenTextures(int n, ref uint textures)
        {
            GL.GenTextures(n, ref textures);
        }

        public void GetActiveAttrib(uint program, uint index, int bufsize, int[] length, int[] size, uint[] type, StringBuilder name)
        {
            GL.GetActiveAttrib(program, index, bufsize, length, size, type, name);
        }

        public void GetActiveAttrib(uint program, uint index, int bufsize, ref int length, ref int size, ref uint type, StringBuilder name)
        {
            uint _type = 0;
            GL.GetActiveAttrib(program, index, bufsize, ref length, ref size, ref _type, name);
            type = _type;
        }

        public void GetActiveUniform(uint program, uint index, int bufsize, int[] length, int[] size, uint[] type, StringBuilder name)
        {
            GL.GetActiveUniform(program, index, bufsize, length, size, type, name);
        }

        public void GetActiveUniform(uint program, uint index, int bufsize, ref int length, ref int size, ref uint type, StringBuilder name)
        {
            uint _type = 0;
            GL.GetActiveUniform(program, index, bufsize, ref length, ref size, ref _type, name);
            type = _type;
        }

        public void GetAttachedShaders(uint program, int maxcount, int[] count, uint[] shaders)
        {
            GL.GetAttachedShaders(program, maxcount, count, shaders);
        }

        public void GetAttachedShaders(uint program, int maxcount, ref int count, ref uint shaders)
        {
            GL.GetAttachedShaders(program, maxcount, ref count, ref shaders);
        }

        public int GetAttribLocation(uint program, string name)
        {
            return GL.GetAttribLocation(program, name);
        }

        public void GetBoolean(uint pname, byte[] param)
        {
            GL.GetBoolean(pname, param);
        }

        public void GetBufferParameter(uint target, uint pname, int[] param)
        {
            GL.GetBufferParameter(target, pname, param);
        }

        public uint GetError()
        {
            return GL.GetError();
        }

        public void GetFloat(uint pname, float[] param)
        {
            GL.GetFloat(pname, param);
        }

        public void GetFramebufferAttachmentParameter(uint target, uint attachment, uint pname, ref int param)
        {
            GL.GetFramebufferAttachmentParameter(target, attachment, pname, ref param);
        }

        public void GetFramebufferAttachmentParameter(uint target, uint attachment, uint pname, int[] param)
        {
            GL.GetFramebufferAttachmentParameter(target, attachment, pname, param);
        }

        public void GetInteger(uint pname, int[] param)
        {
            GL.GetInteger(pname, param);
        }

        public void GetInteger(uint pname, ref int param)
        {
            GL.GetInteger(pname, ref param);
        }

        public void GetProgram(uint program, uint pname, int[] param)
        {
            GL.GetProgram(program, pname, param);
        }

        public void GetProgramInfoLog(uint program, int bufsize, int[] length, StringBuilder infolog)
        {
            GL.GetProgramInfoLog(program, bufsize, length, infolog);
        }

        public void GetProgramInfoLog(uint program, int bufsize, ref int length, StringBuilder infolog)
        {
            GL.GetProgramInfoLog(program, bufsize, ref length, infolog);
        }

        public void GetRenderbufferParameter(uint target, uint pname, ref int param)
        {
            GL.GetRenderbufferParameter(target, pname, ref param);
        }

        public void GetRenderbufferParameter(uint target, uint pname, int[] param)
        {
            GL.GetRenderbufferParameter(target, pname, param);
        }

        public void GetShader(uint shader, uint pname, ref int param)
        {
            GL.GetShader(shader, pname, ref param);
        }

        public void GetShader(uint shader, uint pname, int[] param)
        {
            GL.GetShader(shader, pname, param);
        }

        public void GetShaderInfoLog(uint shader, int bufsize, ref int length, StringBuilder infolog)
        {
            GL.GetShaderInfoLog(shader, bufsize, ref length, infolog);
        }

        public void GetShaderInfoLog(uint shader, int bufsize, int[] length, StringBuilder infolog)
        {
            GL.GetShaderInfoLog(shader, bufsize, length, infolog);
        }

        public void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, ref int range, ref int precision)
        {
            GL.GetShaderPrecisionFormat(shadertype, precisiontype, ref range, ref precision);
        }

        public void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int[] range, int[] precision)
        {
            GL.GetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
        }

        public void GetShaderSource(uint shader, int bufsize, int[] length, StringBuilder source)
        {
            GL.GetShaderSource(shader, bufsize, length, source);
        }

        public void GetShaderSource(uint shader, int bufsize, ref int length, StringBuilder source)
        {
            GL.GetShaderSource(shader, bufsize, ref length, source);
        }

        public string GetString(uint name)
        {
            return GL.GetString(name);
        }

        public void GetTexParameter(uint target, uint pname, int[] param)
        {
            GL.GetTexParameter(target, pname, param);
        }

        public void GetTexParameter(uint target, uint pname, ref int param)
        {
            GL.GetTexParameter(target, pname, ref param);
        }

        public void GetTexParameter(uint target, uint pname, ref float param)
        {
            GL.GetTexParameter(target, pname, ref param);
        }

        public void GetTexParameter(uint target, uint pname, float[] param)
        {
            GL.GetTexParameter(target, pname, param);
        }

        public void GetUniform(uint program, int location, int[] param)
        {
            GL.GetUniform(program, location, param);
        }

        public void GetUniform(uint program, int location, ref int param)
        {
            GL.GetUniform(program, location, ref param);
        }

        public void GetUniform(uint program, int location, ref float param)
        {
            GL.GetUniform(program, location, ref param);
        }

        public void GetUniform(uint program, int location, float[] param)
        {
            GL.GetUniform(program, location, param);
        }

        public int GetUniformLocation(uint program, string name)
        {
            return GL.GetUniformLocation(program, name);
        }

        public void GetVertexAttrib(uint index, uint pname, int[] param)
        {
            GL.GetVertexAttrib(index, pname, param);
        }

        public void GetVertexAttrib(uint index, uint pname, ref int param)
        {
            GL.GetVertexAttrib(index, pname, ref param);
        }

        public void GetVertexAttrib(uint index, uint pname, ref float param)
        {
            GL.GetVertexAttrib(index, pname, ref param);
        }

        public void GetVertexAttrib(uint index, uint pname, float[] param)
        {
            GL.GetVertexAttrib(index, pname, param);
        }

        public void GetVertexAttribPointer(uint index, uint pname, IntPtr pointer)
        {
            GL.GetVertexAttribPointer(index, pname, pointer);
        }

        public void Hint(uint target, uint mode)
        {
            GL.Hint(target, mode);
        }

        public GLboolean IsBuffer(uint buffer)
        {
            return GL.IsBuffer(buffer);
        }

        public GLboolean IsEnabled(uint cap)
        {
            return GL.IsEnabled(cap);
        }

        public GLboolean IsFramebuffer(uint framebuffer)
        {
            return GL.IsFramebuffer(framebuffer);
        }

        public GLboolean IsProgram(uint program)
        {
            return GL.IsProgram(program);
        }

        public GLboolean IsRenderbuffer(uint renderbuffer)
        {
            return GL.IsRenderbuffer(renderbuffer);
        }

        public GLboolean IsShader(uint shader)
        {
            return GL.IsShader(shader);
        }

        public GLboolean IsTexture(uint texture)
        {
            return GL.IsTexture(texture);
        }

        public void LineWidth(float width)
        {
            GL.LineWidth(width);
        }

        public void LinkProgram(uint program)
        {
            GL.LinkProgram(program);
        }

        public void PixelStore(uint pname, int param)
        {
            GL.PixelStore(pname, param);
        }

        public void PolygonOffset(float factor, float units)
        {
            GL.PolygonOffset(factor, units);
        }

        public void ReadPixels(int x, int y, int width, int height, uint format, uint type, byte[] pixels)
        {
            GL.ReadPixels(x, y, width, height, format, type, pixels);
        }

        public void ReleaseShaderCompiler()
        {
            GL.ReleaseShaderCompiler();
        }

        public void RenderbufferStorage(uint target, uint internalformat, int width, int height)
        {
            GL.RenderbufferStorage(target, internalformat, width, height);
        }

        public void SampleCoverage(float value, byte invert)
        {
            throw new NotImplementedException();
        }

        public void Scissor(int x, int y, int width, int height)
        {
            GL.Scissor(x, y, width, height);
        }

        public void ShaderBinary(int n, uint[] shaders, uint binaryformat, IntPtr binary, int length)
        {
            GL.ShaderBinary(n, shaders, binaryformat, binary, length);
        }

        public void ShaderBinary(int n, ref uint shaders, uint binaryformat, IntPtr binary, int length)
        {
            GL.ShaderBinary(n, ref shaders, binaryformat, binary, length);
        }

        public void ShaderSource(uint shader, int count, string[] str, int[] length)
        {
            GL.ShaderSource(shader, count, str, length);
        }

        public void ShaderSource(uint shader, int count, string[] str, ref int length)
        {
            GL.ShaderSource(shader, count, str, ref length);
        }

        public void StencilFunc(uint func, int _ref, uint mask)
        {
            GL.StencilFunc(func, _ref, mask);
        }

        public void StencilFuncSeparate(uint face, uint func, int _ref, uint mask)
        {
            GL.StencilFuncSeparate(face, func, _ref, mask);
        }

        public void StencilMask(uint mask)
        {
            GL.StencilMask(mask);
        }

        public void StencilMaskSeparate(uint face, uint mask)
        {
            GL.StencilMaskSeparate(face, mask);
        }

        public void StencilOp(uint fail, uint zfail, uint zpass)
        {
            GL.StencilOp(fail, zfail, zpass);
        }

        public void StencilOpSeparate(uint face, uint fail, uint zfail, uint zpass)
        {
            GL.StencilOpSeparate(face, fail, zfail, zpass);
        }

        public void TexImage2D(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, byte[] pixels)
        {
            GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }

        public void TexParameter(uint target, uint pname, int[] param)
        {
            GL.TexParameter(target, pname, param);
        }

        public void TexParameter(uint target, uint pname, int param)
        {
            GL.TexParameter(target, pname, param);
        }

        public void TexParameter(uint target, uint pname, float[] param)
        {
            GL.TexParameter(target, pname, param);
        }

        public void TexParameter(uint target, uint pname, float param)
        {
            GL.TexParameter(target, pname, param);
        }

        public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, byte[] pixels)
        {
            GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void Uniform1(int location, int x)
        {
            GL.Uniform1(location, x);
        }

        public void Uniform1(int location, float x)
        {
            GL.Uniform1(location, x);
        }

        public void Uniform1(int location, int count, int[] v)
        {
            GL.Uniform1(location, count, v);
        }

        public void Uniform1(int location, int count, float[] v)
        {
            GL.Uniform1(location, count, v);
        }

        public void Uniform2(int location, int count, int[] v)
        {
            GL.Uniform2(location, count, v);
        }

        public void Uniform2(int location, int x, int y)
        {
            GL.Uniform2(location, x, y);
        }

        public void Uniform2(int location, int count, float[] v)
        {
            GL.Uniform2(location, count, v);
        }

        public void Uniform2(int location, float x, float y)
        {
            GL.Uniform2(location, x, y);
        }

        public void Uniform3(int location, int count, int[] v)
        {
            GL.Uniform3(location, count, v);
        }

        public void Uniform3(int location, int count, float[] v)
        {
            GL.Uniform3(location, count, v);
        }

        public void Uniform3(int location, int x, int y, int z)
        {
            GL.Uniform3(location, x, y, z);
        }

        public void Uniform3(int location, float x, float y, float z)
        {
            GL.Uniform3(location, x, y, z);
        }

        public void Uniform4(int location, int count, int[] v)
        {
            GL.Uniform4(location, count, v);
        }

        public void Uniform4(int location, int count, float[] v)
        {
            GL.Uniform4(location, count, v);
        }

        public void Uniform4(int location, int x, int y, int z, int w)
        {
            GL.Uniform4(location, x, y, z, w);
        }

        public void Uniform4(int location, float x, float y, float z, float w)
        {
            GL.Uniform4(location, x, y, z, w);
        }

        public void UniformMatrix2(int location, int count, bool transpose, float[] value)
        {
            GL.UniformMatrix2(location, count, transpose == true ? ((byte)1) : ((byte)0), value);
        }

        public void UniformMatrix3(int location, int count, bool transpose, float[] value)
        {
            GL.UniformMatrix3(location, count, transpose == true ? ((byte)1) : ((byte)0), value);
        }

        public void UniformMatrix4(int location, int count, bool transpose, float[] value)
        {
            GL.UniformMatrix4(location, count, transpose == true ? ((byte)1) : ((byte)0), value);
        }

        public void UseProgram(uint program)
        {
            GL.UseProgram(program);
        }

        public void ValidateProgram(uint program)
        {
            GL.ValidateProgram(program);
        }

        public void VertexAttrib1(uint indx, float[] values)
        {
            GL.VertexAttrib1(indx, values);
        }

        public void VertexAttrib1(uint indx, float x)
        {
            GL.VertexAttrib1(indx, x);
        }

        public void VertexAttrib2(uint indx, float[] values)
        {
            GL.VertexAttrib2(indx, values);
        }

        public void VertexAttrib2(uint indx, float x, float y)
        {
            GL.VertexAttrib2(indx, x, y);
        }

        public void VertexAttrib3(uint indx, float[] values)
        {
            GL.VertexAttrib3(indx, values);
        }

        public void VertexAttrib3(uint indx, float x, float y, float z)
        {
            GL.VertexAttrib3(indx, x, y, z);
        }

        public void VertexAttrib4(uint indx, float[] values)
        {
            GL.VertexAttrib4(indx, values);
        }

        public void VertexAttrib4(uint indx, float x, float y, float z, float w)
        {
            GL.VertexAttrib4(indx, x, y, z, w);
        }

        public void VertexAttribPointer(uint indx, int size, uint type, bool normalized, int stride, IntPtr ptr)
        {
            GL.VertexAttribPointer(indx, size, type, normalized == true ? ((byte)1) : ((byte)0) , stride, ptr);
        }

        public void Viewport(int x, int y, int width, int height)
        {
            GL.Viewport(x, y, width, height);
        }
    }
}
