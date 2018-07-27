using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3DEngineCommon;
using GLenum = System.UInt32;
using GLboolean = System.Byte;
using GLbitfield = System.UInt32;
using GLint = System.Int32;
using GLsizei = System.Int32;
using GLuint = System.UInt32;
using GLfloat = System.Single;
using GLbyte = System.Byte;
using GLclampf = System.Single;

/* importer types for handling large vertex buffer objects */
using GLintptr = System.Int32;
using GLsizeiptr = System.Int32;
using System.Runtime.InteropServices;
namespace GLImporter
{
    public class gl2 
    {
        /* OpenGL ES core versions */
        public const int GL_ES_VERSION_2_0 = 1;

        /* ClearBufferMask */
        public const int GL_DEPTH_BUFFER_BIT = 0x00000100;
        public const int GL_STENCIL_BUFFER_BIT = 0x00000400;
        public const int GL_COLOR_BUFFER_BIT = 0x00004000;

        /* Boolean */
        public const byte GL_FALSE = 0;
        public const byte GL_TRUE = 1;

        /* \todo check that this should be in core. */
        public const int GL_NONE = 0;

        /* BeginMode */
        public const int GL_POINTS = 0x0000;
        public const int GL_LINES = 0x0001;
        public const int GL_LINE_LOOP = 0x0002;
        public const int GL_LINE_STRIP = 0x0003;
        public const int GL_TRIANGLES = 0x0004;
        public const int GL_TRIANGLE_STRIP = 0x0005;
        public const int GL_TRIANGLE_FAN = 0x0006;

        /* AlphaFunction (not supported in ES20) */
        /*      GL_NEVER */
        /*      GL_LESS */
        /*      GL_EQUAL */
        /*      GL_LEQUAL */
        /*      GL_GREATER */
        /*      GL_NOTEQUAL */
        /*      GL_GEQUAL */
        /*      GL_ALWAYS */

        /* BlendingFactorDest */
        public const int GL_ZERO = 0;
        public const int GL_ONE = 1;
        public const int GL_SRC_COLOR = 0x0300;
        public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;
        public const int GL_SRC_ALPHA = 0x0302;
        public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        public const int GL_DST_ALPHA = 0x0304;
        public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;

        /* BlendingFactorSrc */
        /*      GL_ZERO */
        /*      GL_ONE */
        public const int GL_DST_COLOR = 0x0306;
        public const int GL_ONE_MINUS_DST_COLOR = 0x0307;
        public const int GL_SRC_ALPHA_SATURATE = 0x0308;
        /*      GL_SRC_ALPHA */
        /*      GL_ONE_MINUS_SRC_ALPHA */
        /*      GL_DST_ALPHA */
        /*      GL_ONE_MINUS_DST_ALPHA */

        /* BlendEquationSeparate */
        public const int GL_FUNC_ADD = 0x8006;
        public const int GL_BLEND_EQUATION = 0x8009;
        public const int GL_BLEND_EQUATION_RGB = 0x8009;    /* same as BLEND_EQUATION */
        public const int GL_BLEND_EQUATION_ALPHA = 0x883D;

        /* BlendSubtract */
        public const int GL_FUNC_SUBTRACT = 0x800A;
        public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;

        /* Separate Blend Functions */
        public const int GL_BLEND_DST_RGB = 0x80C8;
        public const int GL_BLEND_SRC_RGB = 0x80C9;
        public const int GL_BLEND_DST_ALPHA = 0x80CA;
        public const int GL_BLEND_SRC_ALPHA = 0x80CB;
        public const int GL_CONSTANT_COLOR = 0x8001;
        public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const int GL_CONSTANT_ALPHA = 0x8003;
        public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const int GL_BLEND_COLOR = 0x8005;

        /* Buffer Objects */
        public const int GL_ARRAY_BUFFER = 0x8892;
        public const int GL_ELEMENT_ARRAY_BUFFER = 0x8893;
        public const int GL_ARRAY_BUFFER_BINDING = 0x8894;
        public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

        public const int GL_STREAM_DRAW = 0x88E0;
        public const int GL_STATIC_DRAW = 0x88E4;
        public const int GL_DYNAMIC_DRAW = 0x88E8;

        public const int GL_BUFFER_SIZE = 0x8764;
        public const int GL_BUFFER_USAGE = 0x8765;
        public const int GL_CURRENT_VERTEX_ATTRIB = 0x8626;
        /* CullFaceMode */
        public const int GL_FRONT = 0x0404;
        public const int GL_BACK = 0x0405;
        public const int GL_FRONT_AND_BACK = 0x0408;

        /* DepthFunction */
        /*      GL_NEVER */
        /*      GL_LESS */
        /*      GL_EQUAL */
        /*      GL_LEQUAL */
        /*      GL_GREATER */
        /*      GL_NOTEQUAL */
        /*      GL_GEQUAL */
        /*      GL_ALWAYS */

        /* EnableCap */
        public const int GL_TEXTURE_2D = 0x0DE1;
        public const int GL_CULL_FACE = 0x0B44;
        public const int GL_BLEND = 0x0BE2;
        public const int GL_DITHER = 0x0BD0;
        public const int GL_STENCIL_TEST = 0x0B90;
        public const int GL_DEPTH_TEST = 0x0B71;
        public const int GL_SCISSOR_TEST = 0x0C11;
        public const int GL_POLYGON_OFFSET_FILL = 0x8037;
        public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const int GL_SAMPLE_COVERAGE = 0x80A0;

        /* ErrorCode */
        public const int GL_NO_ERROR = 0;
        public const int GL_INVALID_ENUM = 0x0500;
        public const int GL_INVALID_VALUE = 0x0501;
        public const int GL_INVALID_OPERATION = 0x0502;
        public const int GL_OUT_OF_MEMORY = 0x0505;

        /* FrontFaceDirection */
        public const int GL_CW = 0x0900;
        public const int GL_CCW = 0x0901;

        /* GetPName */
        public const int GL_LINE_WIDTH = 0x0B21;
        public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const int GL_CULL_FACE_MODE = 0x0B45;
        public const int GL_FRONT_FACE = 0x0B46;
        public const int GL_DEPTH_RANGE = 0x0B70;
        public const int GL_DEPTH_WRITEMASK = 0x0B72;
        public const int GL_DEPTH_CLEAR_VALUE = 0x0B73;
        public const int GL_DEPTH_FUNC = 0x0B74;
        public const int GL_STENCIL_CLEAR_VALUE = 0x0B91;
        public const int GL_STENCIL_FUNC = 0x0B92;
        public const int GL_STENCIL_FAIL = 0x0B94;
        public const int GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const int GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const int GL_STENCIL_REF = 0x0B97;
        public const int GL_STENCIL_VALUE_MASK = 0x0B93;
        public const int GL_STENCIL_WRITEMASK = 0x0B98;
        public const int GL_STENCIL_BACK_FUNC = 0x8800;
        public const int GL_STENCIL_BACK_FAIL = 0x8801;
        public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        public const int GL_STENCIL_BACK_REF = 0x8CA3;
        public const int GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
        public const int GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
        public const int GL_VIEWPORT = 0x0BA2;
        public const int GL_SCISSOR_BOX = 0x0C10;
        /*      GL_SCISSOR_TEST */
        public const int GL_COLOR_CLEAR_VALUE = 0x0C22;
        public const int GL_COLOR_WRITEMASK = 0x0C23;
        public const int GL_UNPACK_ALIGNMENT = 0x0CF5;
        public const int GL_PACK_ALIGNMENT = 0x0D05;
        public const int GL_MAX_TEXTURE_SIZE = 0x0D33;
        public const int GL_MAX_VIEWPORT_DIMS = 0x0D3A;
        public const int GL_SUBPIXEL_BITS = 0x0D50;
        public const int GL_RED_BITS = 0x0D52;
        public const int GL_GREEN_BITS = 0x0D53;
        public const int GL_BLUE_BITS = 0x0D54;
        public const int GL_ALPHA_BITS = 0x0D55;
        public const int GL_DEPTH_BITS = 0x0D56;
        public const int GL_STENCIL_BITS = 0x0D57;
        public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;
        /*      GL_POLYGON_OFFSET_FILL */
        public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;
        public const int GL_TEXTURE_BINDING_2D = 0x8069;
        public const int GL_SAMPLE_BUFFERS = 0x80A8;
        public const int GL_SAMPLES = 0x80A9;
        public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;

        /* GetTextureParameter */
        /*      GL_TEXTURE_MAG_FILTER */
        /*      GL_TEXTURE_MIN_FILTER */
        /*      GL_TEXTURE_WRAP_S */
        /*      GL_TEXTURE_WRAP_T */

        public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;

        /* HintMode */
        public const int GL_DONT_CARE = 0x1100;
        public const int GL_FASTEST = 0x1101;
        public const int GL_NICEST = 0x1102;

        /* HintTarget */
        public const int GL_GENERATE_MIPMAP_HINT = 0x8192;
        public const int GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

        /* DataType */
        public const int GL_BYTE = 0x1400;
        public const int GL_UNSIGNED_BYTE = 0x1401;
        public const int GL_SHORT = 0x1402;
        public const int GL_UNSIGNED_SHORT = 0x1403;
        public const int GL_INT = 0x1404;
        public const int GL_UNSIGNED_INT = 0x1405;
        public const int GL_FLOAT = 0x1406;
        public const int GL_FIXED = 0x140C;

        /* PixelFormat */
        public const int GL_DEPTH_COMPONENT = 0x1902;
        public const int GL_ALPHA = 0x1906;
        public const int GL_RGB = 0x1907;
        public const int GL_RGBA = 0x1908;
        public const int GL_LUMINANCE = 0x1909;
        public const int GL_LUMINANCE_ALPHA = 0x190A;

        /* PixelType */
        /*      GL_UNSIGNED_BYTE */
        public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;

        /* Shaders */
        public const int GL_FRAGMENT_SHADER = 0x8B30;
        public const int GL_VERTEX_SHADER = 0x8B31;
        public const int GL_MAX_VERTEX_ATTRIBS = 0x8869;
        public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const int GL_MAX_VARYING_VECTORS = 0x8DFC;
        public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        public const int GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public const int GL_SHADER_TYPE = 0x8B4F;
        public const int GL_DELETE_STATUS = 0x8B80;
        public const int GL_LINK_STATUS = 0x8B82;
        public const int GL_VALIDATE_STATUS = 0x8B83;
        public const int GL_ATTACHED_SHADERS = 0x8B85;
        public const int GL_ACTIVE_UNIFORMS = 0x8B86;
        public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        public const int GL_ACTIVE_ATTRIBUTES = 0x8B89;
        public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        public const int GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
        public const int GL_CURRENT_PROGRAM = 0x8B8D;

        /* StencilFunction */
        public const int GL_NEVER = 0x0200;
        public const int GL_LESS = 0x0201;
        public const int GL_EQUAL = 0x0202;
        public const int GL_LEQUAL = 0x0203;
        public const int GL_GREATER = 0x0204;
        public const int GL_NOTEQUAL = 0x0205;
        public const int GL_GEQUAL = 0x0206;
        public const int GL_ALWAYS = 0x0207;

        /* StencilOp */
        /*      GL_ZERO */
        public const int GL_KEEP = 0x1E00;
        public const int GL_REPLACE = 0x1E01;
        public const int GL_INCR = 0x1E02;
        public const int GL_DECR = 0x1E03;
        public const int GL_INVERT = 0x150A;
        public const int GL_INCR_WRAP = 0x8507;
        public const int GL_DECR_WRAP = 0x8508;

        /* StringName */
        public const int GL_VENDOR = 0x1F00;
        public const int GL_RENDERER = 0x1F01;
        public const int GL_VERSION = 0x1F02;
        public const int GL_EXTENSIONS = 0x1F03;

        /* TextureMagFilter */
        public const int GL_NEAREST = 0x2600;
        public const int GL_LINEAR = 0x2601;

        /* TextureMinFilter */
        /*      GL_NEAREST */
        /*      GL_LINEAR */
        public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;
        public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;
        public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;
        public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;

        /* TextureParameterName */
        public const int GL_TEXTURE_MAG_FILTER = 0x2800;
        public const int GL_TEXTURE_MIN_FILTER = 0x2801;
        public const int GL_TEXTURE_WRAP_S = 0x2802;
        public const int GL_TEXTURE_WRAP_T = 0x2803;

        /* TextureTarget */
        /*      GL_TEXTURE_2D */
        public const int GL_TEXTURE = 0x1702;
        public const int GL_TEXTURE_CUBE_MAP = 0x8513;
        public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

        /* TextureUnit */
        public const int GL_TEXTURE0 = 0x84C0;
        public const int GL_TEXTURE1 = 0x84C1;
        public const int GL_TEXTURE2 = 0x84C2;
        public const int GL_TEXTURE3 = 0x84C3;
        public const int GL_TEXTURE4 = 0x84C4;
        public const int GL_TEXTURE5 = 0x84C5;
        public const int GL_TEXTURE6 = 0x84C6;
        public const int GL_TEXTURE7 = 0x84C7;
        public const int GL_TEXTURE8 = 0x84C8;
        public const int GL_TEXTURE9 = 0x84C9;
        public const int GL_TEXTURE10 = 0x84CA;
        public const int GL_TEXTURE11 = 0x84CB;
        public const int GL_TEXTURE12 = 0x84CC;
        public const int GL_TEXTURE13 = 0x84CD;
        public const int GL_TEXTURE14 = 0x84CE;
        public const int GL_TEXTURE15 = 0x84CF;
        public const int GL_TEXTURE16 = 0x84D0;
        public const int GL_TEXTURE17 = 0x84D1;
        public const int GL_TEXTURE18 = 0x84D2;
        public const int GL_TEXTURE19 = 0x84D3;
        public const int GL_TEXTURE20 = 0x84D4;
        public const int GL_TEXTURE21 = 0x84D5;
        public const int GL_TEXTURE22 = 0x84D6;
        public const int GL_TEXTURE23 = 0x84D7;
        public const int GL_TEXTURE24 = 0x84D8;
        public const int GL_TEXTURE25 = 0x84D9;
        public const int GL_TEXTURE26 = 0x84DA;
        public const int GL_TEXTURE27 = 0x84DB;
        public const int GL_TEXTURE28 = 0x84DC;
        public const int GL_TEXTURE29 = 0x84DD;
        public const int GL_TEXTURE30 = 0x84DE;
        public const int GL_TEXTURE31 = 0x84DF;
        public const int GL_ACTIVE_TEXTURE = 0x84E0;

        /* TextureWrapMode */
        public const int GL_REPEAT = 0x2901;
        public const int GL_CLAMP_TO_EDGE = 0x812F;
        public const int GL_MIRRORED_REPEAT = 0x8370;

        /* Uniform Types */
        public const int GL_FLOAT_VEC2 = 0x8B50;
        public const int GL_FLOAT_VEC3 = 0x8B51;
        public const int GL_FLOAT_VEC4 = 0x8B52;
        public const int GL_INT_VEC2 = 0x8B53;
        public const int GL_INT_VEC3 = 0x8B54;
        public const int GL_INT_VEC4 = 0x8B55;
        public const int GL_BOOL = 0x8B56;
        public const int GL_BOOL_VEC2 = 0x8B57;
        public const int GL_BOOL_VEC3 = 0x8B58;
        public const int GL_BOOL_VEC4 = 0x8B59;
        public const int GL_FLOAT_MAT2 = 0x8B5A;
        public const int GL_FLOAT_MAT3 = 0x8B5B;
        public const int GL_FLOAT_MAT4 = 0x8B5C;
        public const int GL_SAMPLER_2D = 0x8B5E;
        public const int GL_SAMPLER_CUBE = 0x8B60;

        /* Vertex Arrays */
        public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

        /* Read Format */
        public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;

        /* Shader Source */
        public const int GL_COMPILE_STATUS = 0x8B81;
        public const int GL_INFO_LOG_LENGTH = 0x8B84;
        public const int GL_SHADER_SOURCE_LENGTH = 0x8B88;
        public const int GL_SHADER_COMPILER = 0x8DFA;

        /* Shader Binary */
        public const int GL_PLATFORM_BINARY = 0x8D63;
        public const int GL_SHADER_BINARY_FORMATS = 0x8DF8;
        public const int GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;

        /* Shader Precision-Specified Types */
        public const int GL_LOW_FLOAT = 0x8DF0;
        public const int GL_MEDIUM_FLOAT = 0x8DF1;
        public const int GL_HIGH_FLOAT = 0x8DF2;
        public const int GL_LOW_INT = 0x8DF3;
        public const int GL_MEDIUM_INT = 0x8DF4;
        public const int GL_HIGH_INT = 0x8DF5;

        /* Framebuffer Object. */
        public const int GL_FRAMEBUFFER = 0x8D40;
        public const int GL_RENDERBUFFER = 0x8D41;

        public const int GL_RGBA4 = 0x8056;
        public const int GL_RGB5_A1 = 0x8057;
        public const int GL_RGB565 = 0x8D62;
        public const int GL_DEPTH_COMPONENT16 = 0x81A5;
        public const int GL_STENCIL_INDEX = 0x1901;
        public const int GL_STENCIL_INDEX8 = 0x8D48;

        public const int GL_RENDERBUFFER_WIDTH = 0x8D42;
        public const int GL_RENDERBUFFER_HEIGHT = 0x8D43;
        public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        public const int GL_RENDERBUFFER_RED_SIZE = 0x8D50;
        public const int GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
        public const int GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
        public const int GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        public const int GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        public const int GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;

        public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;

        public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
        public const int GL_DEPTH_ATTACHMENT = 0x8D00;
        public const int GL_STENCIL_ATTACHMENT = 0x8D20;

        public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
        public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
        public const int GL_FRAMEBUFFER_INCOMPLETE_FORMATS = 0x8CDA;
        public const int GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;

        public const int GL_FRAMEBUFFER_BINDING = 0x8CA6;
        public const int GL_RENDERBUFFER_BINDING = 0x8CA7;
        public const int GL_MAX_RENDERBUFFER_SIZE = 0x84E8;

        public const int GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;

#if __IOS__
        private static IOSGL.IOSGLImporter importer = new IOSGL.IOSGLImporter();
#elif __ANDROID__
        private static AndroidGL.AndroidGLImporter importer = new AndroidGL.AndroidGLImporter();
#elif __WIN32__
        private static WindowsGL.WindowsGLImporter importer = new WindowsGL.WindowsGLImporter();
#endif

        public static void ActiveTexture(uint texture)
        {
            importer.ActiveTexture(texture);
        }

        public static void AttachShader(uint program, uint shader)
        {
            importer.AttachShader(program, shader);
        }

        public static void BindAttribLocation(uint program, uint index, string name)
        {
            importer.BindAttribLocation(program, index, name);
        }

        public static void BindBuffer(uint target, uint buffer)
        {
            importer.BindBuffer(target, buffer);
        }

        public static void BindFramebuffer(uint target, uint framebuffer)
        {
            importer.BindFramebuffer(target, framebuffer);
        }

        public static void BindRenderbuffer(uint target, uint renderbuffer)
        {
            importer.BindRenderbuffer(target, renderbuffer);
        }

        public static void BindTexture(uint target, uint texture)
        {
            importer.BindTexture(target, texture);
        }

        public static void BlendColor(float red, float green, float blue, float alpha)
        {
            importer.BlendColor(red, green, blue, alpha);
        }

        public static void BlendEquation(uint mode)
        {
            importer.BlendEquation(mode);
        }

        public static void BlendEquationSeparate(uint modeRGB, uint modeAlpha)
        {
            importer.BlendEquationSeparate(modeRGB, modeAlpha);
        }

        public static void BlendFunc(uint sfactor, uint dfactor)
        {
            importer.BlendFunc(sfactor, dfactor);
        }

        public static void BlendFuncSeparate(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
        {
            importer.BlendFuncSeparate(srcRGB, dstRGB, srcAlpha, dstAlpha);
        }

        public static void BufferData(uint target, int size, byte[] data, uint usage)
        {
            importer.BufferData(target, size, data, usage);
        }

        public static void BufferSubData(uint target, int offset, int size, byte[] data)
        {
            importer.BufferSubData(target, offset, size, data);
        }

        public static uint CheckFramebufferStatus(uint target)
        {
            return importer.CheckFramebufferStatus(target);
        }

        public static void Clear(uint mask)
        {
            importer.Clear(mask);
        }

        public static void ClearColor(float red, float green, float blue, float alpha)
        {
            importer.ClearColor(red, green, blue, alpha);
        }

        public static void ClearDepthf(float depth)
        {
            importer.ClearDepthf(depth);
        }

        public static void ClearStencil(int s)
        {
            importer.ClearStencil(s);
        }

        public static void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            importer.ColorMask(red, green, blue , alpha);
        }

        public static void CompileShader(uint shader)
        {
            importer.CompileShader(shader);
        }

        public static void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, byte[] data)
        {
            importer.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        }

        public static void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, byte[] data)
        {
            importer.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public static void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
        {
            importer.CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
        }

        public static void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            importer.CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }

        public static uint CreateProgram()
        {
            return importer.CreateProgram();
        }

        public static uint CreateShader(uint type)
        {
            return CreateShader(type);
        }

        public static void CullFace(uint mode)
        {
            importer.CullFace(mode);
        }

        public static void DeleteBuffers(int n, uint[] buffers)
        {
            importer.DeleteBuffers(n, buffers);
        }

        public static void DeleteFramebuffers(int n, uint[] framebuffers)
        {
            importer.DeleteFramebuffers(n, framebuffers);
        }

        public static void DeleteProgram(uint program)
        {
            importer.DeleteProgram(program);
        }

        public static void DeleteRenderbuffers(int n, uint[] renderbuffers)
        {
            importer.DeleteRenderbuffers(n, renderbuffers);
        }

        public static void DeleteShader(uint shader)
        {
            importer.DeleteShader(shader);
        }

        public static void DeleteTextures(int n, uint[] textures)
        {
            importer.DeleteTextures(n, textures);
        }

        public static void DepthFunc(uint func)
        {
            importer.DepthFunc(func);
        }

        public static void DepthMask(byte flag)
        {
            importer.DepthMask(flag);
        }

        public static void DepthRange(float zNear, float zFar)
        {
            importer.DepthRange(zNear, zFar);
        }

        public static void DetachShader(uint program, uint shader)
        {
            importer.DetachShader(program, shader);
        }

        public static void Disable(uint cap)
        {
            importer.Disable(cap);
        }

        public static void DisableVertexAttribArray(uint index)
        {
            importer.DisableVertexAttribArray(index);
        }

        public static void DrawArrays(uint mode, int first, int count)
        {
            importer.DrawArrays(mode, first, count);
        }

        public static void DrawElements(uint mode, int count, uint type, IntPtr indices)
        {
            importer.DrawElements(mode, count, type, indices);
        }

        public static void Enable(uint cap)
        {
            importer.Enable(cap);
        }

        public static void EnableVertexAttribArray(uint index)
        {
            importer.EnableVertexAttribArray(index);
        }

        public static void Finish()
        {
            importer.Finish();
        }

        public static void Flush()
        {
            importer.Flush();
        }

        public static void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer)
        {
            importer.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
        }

        public static void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level)
        {
            importer.FramebufferTexture2D(target, attachment, textarget, texture, level);
        }

        public static void FrontFace(uint mode)
        {
            importer.FrontFace(mode);
        }

        public static void GenBuffers(int n, int[] buffers)
        {
            importer.GenBuffers(n, buffers);
        }

        public static void GenBuffers(int n, ref int buffers)
        {
            importer.GenBuffers(n, ref buffers);
        }

        public static void GenBuffers(int n, uint[] buffers)
        {
            importer.GenBuffers(n, buffers);
        }

        public static void GenBuffers(int n, ref uint buffers)
        {
            importer.GenBuffers(n, ref buffers);
        }

        public static void GenerateMipmap(uint target)
        {
            importer.GenerateMipmap(target);
        }

        public static void GenFramebuffers(int n, int[] framebuffers)
        {
            importer.GenFramebuffers(n, framebuffers);
        }

        public static void GenFramebuffers(int n, ref int framebuffers)
        {
            importer.GenFramebuffers(n, ref framebuffers);
        }

        public static void GenFramebuffers(int n, uint[] framebuffers)
        {
            importer.GenFramebuffers(n, framebuffers);
        }

        public static void GenFramebuffers(int n, ref uint framebuffers)
        {
            importer.GenFramebuffers(n, ref framebuffers);
        }

        public static void GenRenderbuffers(int n, uint[] renderbuffers)
        {
            importer.GenRenderbuffers(n, renderbuffers);
        }

        public static void GenRenderbuffers(int n, int[] renderbuffers)
        {
            importer.GenRenderbuffers(n, renderbuffers);
        }

        public static void GenRenderbuffers(int n, ref int renderbuffers)
        {
            importer.GenRenderbuffers(n, ref renderbuffers);
        }

        public static void GenRenderbuffers(int n, ref uint renderbuffers)
        {
            importer.GenRenderbuffers(n, ref renderbuffers);
        }

        public static void GenTextures(int n, int[] textures)
        {
            importer.GenTextures(n, textures);
        }

        public static void GenTextures(int n, uint[] textures)
        {
            importer.GenTextures(n, textures);
        }

        public static void GenTextures(int n, ref int textures)
        {
            importer.GenTextures(n, ref textures);
        }

        public static void GenTextures(int n, ref uint textures)
        {
            importer.GenTextures(n, ref textures);
        }

        public static void GetActiveAttrib(uint program, uint index, int bufsize, int[] length, int[] size, uint[] type, StringBuilder name)
        {
            importer.GetActiveAttrib(program, index, bufsize, length, size, type, name);
        }

        public static void GetActiveAttrib(uint program, uint index, int bufsize, ref int length, ref int size, ref uint type, StringBuilder name)
        {
            uint _type = 0;
            importer.GetActiveAttrib(program, index, bufsize, ref length, ref size, ref _type, name);
            type = _type;
        }

        public static void GetActiveUniform(uint program, uint index, int bufsize, int[] length, int[] size, uint[] type, StringBuilder name)
        {
            importer.GetActiveUniform(program, index, bufsize, length, size, type, name);
        }

        public static void GetActiveUniform(uint program, uint index, int bufsize, ref int length, ref int size, ref uint type, StringBuilder name)
        {
            uint _type = 0;
            importer.GetActiveUniform(program, index, bufsize, ref length, ref size, ref _type, name);
            type = _type;
        }

        public static void GetAttachedShaders(uint program, int maxcount, int[] count, uint[] shaders)
        {
            importer.GetAttachedShaders(program, maxcount, count, shaders);
        }

        public static void GetAttachedShaders(uint program, int maxcount, ref int count, ref uint shaders)
        {
            importer.GetAttachedShaders(program, maxcount, ref count, ref shaders);
        }

        public static int GetAttribLocation(uint program, string name)
        {
            return importer.GetAttribLocation(program, name);
        }

        public static void GetBoolean(uint pname, byte[] param)
        {
            importer.GetBoolean(pname, param);
        }

        public static void GetBufferParameter(uint target, uint pname, int[] param)
        {
            importer.GetBufferParameter(target, pname, param);
        }

        public static uint GetError()
        {
            return importer.GetError();
        }

        public static void GetFloat(uint pname, float[] param)
        {
            importer.GetFloat(pname, param);
        }

        public static void GetFramebufferAttachmentParameter(uint target, uint attachment, uint pname, ref int param)
        {
            importer.GetFramebufferAttachmentParameter(target, attachment, pname, ref param);
        }

        public static void GetFramebufferAttachmentParameter(uint target, uint attachment, uint pname, int[] param)
        {
            importer.GetFramebufferAttachmentParameter(target, attachment, pname, param);
        }

        public static void GetInteger(uint pname, int[] param)
        {
            importer.GetInteger(pname, param);
        }

        public static void GetInteger(uint pname, ref int param)
        {
            importer.GetInteger(pname, ref param);
        }

        public static void GetProgram(uint program, uint pname, int[] param)
        {
            importer.GetProgram(program, pname, param);
        }

        public static void GetProgramInfoLog(uint program, int bufsize, int[] length, StringBuilder infolog)
        {
            importer.GetProgramInfoLog(program, bufsize, length, infolog);
        }

        public static void GetProgramInfoLog(uint program, int bufsize, ref int length, StringBuilder infolog)
        {
            importer.GetProgramInfoLog(program, bufsize, ref length, infolog);
        }

        public static void GetRenderbufferParameter(uint target, uint pname, ref int param)
        {
            importer.GetRenderbufferParameter(target, pname, ref param);
        }

        public static void GetRenderbufferParameter(uint target, uint pname, int[] param)
        {
            importer.GetRenderbufferParameter(target, pname, param);
        }

        public static void GetShader(uint shader, uint pname, ref int param)
        {
            importer.GetShader(shader, pname, ref param);
        }

        public static void GetShader(uint shader, uint pname, int[] param)
        {
            importer.GetShader(shader, pname, param);
        }

        public static void GetShaderInfoLog(uint shader, int bufsize, ref int length, StringBuilder infolog)
        {
            importer.GetShaderInfoLog(shader, bufsize, ref length, infolog);
        }

        public static void GetShaderInfoLog(uint shader, int bufsize, int[] length, StringBuilder infolog)
        {
            importer.GetShaderInfoLog(shader, bufsize, length, infolog);
        }

        public static void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, ref int range, ref int precision)
        {
            importer.GetShaderPrecisionFormat(shadertype, precisiontype, ref range, ref precision);
        }

        public static void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int[] range, int[] precision)
        {
            importer.GetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
        }

        public static void GetShaderSource(uint shader, int bufsize, int[] length, StringBuilder source)
        {
            importer.GetShaderSource(shader, bufsize, length, source);
        }

        public static void GetShaderSource(uint shader, int bufsize, ref int length, StringBuilder source)
        {
            importer.GetShaderSource(shader, bufsize, ref length, source);
        }

        public static string GetString(uint name)
        {
            return importer.GetString(name);
        }

        public static void GetTexParameter(uint target, uint pname, int[] param)
        {
            importer.GetTexParameter(target, pname, param);
        }

        public static void GetTexParameter(uint target, uint pname, ref int param)
        {
            importer.GetTexParameter(target, pname, ref param);
        }

        public static void GetTexParameter(uint target, uint pname, ref float param)
        {
            importer.GetTexParameter(target, pname, ref param);
        }

        public static void GetTexParameter(uint target, uint pname, float[] param)
        {
            importer.GetTexParameter(target, pname, param);
        }

        public static void GetUniform(uint program, int location, int[] param)
        {
            importer.GetUniform(program, location, param);
        }

        public static void GetUniform(uint program, int location, ref int param)
        {
            importer.GetUniform(program, location, ref param);
        }

        public static void GetUniform(uint program, int location, ref float param)
        {
            importer.GetUniform(program, location, ref param);
        }

        public static void GetUniform(uint program, int location, float[] param)
        {
            importer.GetUniform(program, location, param);
        }

        public static int GetUniformLocation(uint program, string name)
        {
            return importer.GetUniformLocation(program, name);
        }

        public static void GetVertexAttrib(uint index, uint pname, int[] param)
        {
            importer.GetVertexAttrib(index, pname, param);
        }

        public static void GetVertexAttrib(uint index, uint pname, ref int param)
        {
            importer.GetVertexAttrib(index, pname, ref param);
        }

        public static void GetVertexAttrib(uint index, uint pname, ref float param)
        {
            importer.GetVertexAttrib(index, pname, ref param);
        }

        public static void GetVertexAttrib(uint index, uint pname, float[] param)
        {
            importer.GetVertexAttrib(index, pname, param);
        }

        public static void GetVertexAttribPointer(uint index, uint pname, IntPtr pointer)
        {
            importer.GetVertexAttribPointer(index, pname, pointer);
        }

        public static void Hint(uint target, uint mode)
        {
            importer.Hint(target, mode);
        }

        public static GLboolean IsBuffer(uint buffer)
        {
            return importer.IsBuffer(buffer);
        }

        public static GLboolean IsEnabled(uint cap)
        {
            return importer.IsEnabled(cap);
        }

        public static GLboolean IsFramebuffer(uint framebuffer)
        {
            return importer.IsFramebuffer(framebuffer);
        }

        public static GLboolean IsProgram(uint program)
        {
            return importer.IsProgram(program);
        }

        public static GLboolean IsRenderbuffer(uint renderbuffer)
        {
            return importer.IsRenderbuffer(renderbuffer);
        }

        public static GLboolean IsShader(uint shader)
        {
            return importer.IsShader(shader);
        }

        public static GLboolean IsTexture(uint texture)
        {
            return importer.IsTexture(texture);
        }

        public static void LineWidth(float width)
        {
            importer.LineWidth(width);
        }

        public static void LinkProgram(uint program)
        {
            importer.LinkProgram(program);
        }

        public static void PixelStore(uint pname, int param)
        {
            importer.PixelStore(pname, param);
        }

        public static void PolygonOffset(float factor, float units)
        {
            importer.PolygonOffset(factor, units);
        }

        public static void ReadPixels(int x, int y, int width, int height, uint format, uint type, byte[] pixels)
        {
            importer.ReadPixels(x, y, width, height, format, type, pixels);
        }

        public static void ReleaseShaderCompiler()
        {
            importer.ReleaseShaderCompiler();
        }

        public static void RenderbufferStorage(uint target, uint internalformat, int width, int height)
        {
            importer.RenderbufferStorage(target, internalformat, width, height);
        }

        public static void SampleCoverage(float value, byte invert)
        {
            //throw new NotImplementedException();
        }

        public static void Scissor(int x, int y, int width, int height)
        {
            importer.Scissor(x, y, width, height);
        }

        public static void ShaderBinary(int n, uint[] shaders, uint binaryformat, IntPtr binary, int length)
        {
            importer.ShaderBinary(n, shaders, binaryformat, binary, length);
        }

        public static void ShaderBinary(int n, ref uint shaders, uint binaryformat, IntPtr binary, int length)
        {
            importer.ShaderBinary(n, ref shaders, binaryformat, binary, length);
        }

        public static void ShaderSource(uint shader, int count, string[] str, int[] length)
        {
            importer.ShaderSource(shader, count, str, length);
        }

        public static void ShaderSource(uint shader, int count, string[] str, ref int length)
        {
            importer.ShaderSource(shader, count, str, ref length);
        }

        public static void StencilFunc(uint func, int _ref, uint mask)
        {
            importer.StencilFunc(func, _ref, mask);
        }

        public static void StencilFuncSeparate(uint face, uint func, int _ref, uint mask)
        {
            importer.StencilFuncSeparate(face, func, _ref, mask);
        }

        public static void StencilMask(uint mask)
        {
            importer.StencilMask(mask);
        }

        public static void StencilMaskSeparate(uint face, uint mask)
        {
            importer.StencilMaskSeparate(face, mask);
        }

        public static void StencilOp(uint fail, uint zfail, uint zpass)
        {
            importer.StencilOp(fail, zfail, zpass);
        }

        public static void StencilOpSeparate(uint face, uint fail, uint zfail, uint zpass)
        {
            importer.StencilOpSeparate(face, fail, zfail, zpass);
        }

        public static void TexImage2D(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, byte[] pixels)
        {
            importer.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }

        public static void TexParameter(uint target, uint pname, int[] param)
        {
            importer.TexParameter(target, pname, param);
        }

        public static void TexParameter(uint target, uint pname, int param)
        {
            importer.TexParameter(target, pname, param);
        }

        public static void TexParameter(uint target, uint pname, float[] param)
        {
            importer.TexParameter(target, pname, param);
        }

        public static void TexParameter(uint target, uint pname, float param)
        {
            importer.TexParameter(target, pname, param);
        }

        public static void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, byte[] pixels)
        {
            importer.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public static void Uniform1(int location, int x)
        {
            importer.Uniform1(location, x);
        }

        public static void Uniform1(int location, float x)
        {
            importer.Uniform1(location, x);
        }

        public static void Uniform1(int location, int count, int[] v)
        {
            importer.Uniform1(location, count, v);
        }

        public static void Uniform1(int location, int count, float[] v)
        {
            importer.Uniform1(location, count, v);
        }

        public static void Uniform2(int location, int count, int[] v)
        {
            importer.Uniform2(location, count, v);
        }

        public static void Uniform2(int location, int x, int y)
        {
            importer.Uniform2(location, x, y);
        }

        public static void Uniform2(int location, int count, float[] v)
        {
            importer.Uniform2(location, count, v);
        }

        public static void Uniform2(int location, float x, float y)
        {
            importer.Uniform2(location, x, y);
        }

        public static void Uniform3(int location, int count, int[] v)
        {
            importer.Uniform3(location, count, v);
        }

        public static void Uniform3(int location, int count, float[] v)
        {
            importer.Uniform3(location, count, v);
        }

        public static void Uniform3(int location, int x, int y, int z)
        {
            importer.Uniform3(location, x, y, z);
        }

        public static void Uniform3(int location, float x, float y, float z)
        {
            importer.Uniform3(location, x, y, z);
        }

        public static void Uniform4(int location, int count, int[] v)
        {
            importer.Uniform4(location, count, v);
        }

        public static void Uniform4(int location, int count, float[] v)
        {
            importer.Uniform4(location, count, v);
        }

        public static void Uniform4(int location, int x, int y, int z, int w)
        {
            importer.Uniform4(location, x, y, z, w);
        }

        public static void Uniform4(int location, float x, float y, float z, float w)
        {
            importer.Uniform4(location, x, y, z, w);
        }

        public static void UniformMatrix2(int location, int count, bool transpose, float[] value)
        {
            importer.UniformMatrix2(location, count, transpose, value);
        }

        public static void UniformMatrix3(int location, int count, bool transpose, float[] value)
        {
            importer.UniformMatrix3(location, count, transpose , value);
        }

        public static void UniformMatrix4(int location, int count, bool transpose, float[] value)
        {
            importer.UniformMatrix4(location, count, transpose, value);
        }

        public static void UseProgram(uint program)
        {
            importer.UseProgram(program);
        }

        public static void ValidateProgram(uint program)
        {
            importer.ValidateProgram(program);
        }

        public static void VertexAttrib1(uint indx, float[] values)
        {
            importer.VertexAttrib1(indx, values);
        }

        public static void VertexAttrib1(uint indx, float x)
        {
            importer.VertexAttrib1(indx, x);
        }

        public static void VertexAttrib2(uint indx, float[] values)
        {
            importer.VertexAttrib2(indx, values);
        }

        public static void VertexAttrib2(uint indx, float x, float y)
        {
            importer.VertexAttrib2(indx, x, y);
        }

        public static void VertexAttrib3(uint indx, float[] values)
        {
            importer.VertexAttrib3(indx, values);
        }

        public static void VertexAttrib3(uint indx, float x, float y, float z)
        {
            importer.VertexAttrib3(indx, x, y, z);
        }

        public static void VertexAttrib4(uint indx, float[] values)
        {
            importer.VertexAttrib4(indx, values);
        }

        public static void VertexAttrib4(uint indx, float x, float y, float z, float w)
        {
            importer.VertexAttrib4(indx, x, y, z, w);
        }

        public static void VertexAttribPointer(uint indx, int size, uint type, bool normalized, int stride, IntPtr ptr)
        {
            importer.VertexAttribPointer(indx, size, type, normalized , stride, ptr);
        }

        public static void Viewport(int x, int y, int width, int height)
        {
            importer.Viewport(x, y, width, height);
        }
    }

}
