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
using GLbyte = System.SByte;
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
using GLintptr = System.IntPtr;
using GLsizeiptr = System.IntPtr;

namespace GLLibrary
{
    public class gl2
    {
#if WIN32
        private const string glDllName = "libGLESv2.dll";
#endif

        /* OpenGL ES core versions */
        public const int GL_ES_VERSION_2_0 = 1;

        /* ClearBufferMask */
        public const int GL_DEPTH_BUFFER_BIT = 0x00000100;
        public const int GL_STENCIL_BUFFER_BIT = 0x00000400;
        public const int GL_COLOR_BUFFER_BIT = 0x00004000;

        /* Boolean */
        public const int GL_FALSE = 0;
        public const int GL_TRUE = 1;

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
        public const int GL_FUNC_ADD                       = 0x8006;
        public const int GL_BLEND_EQUATION                 = 0x8009;
        public const int GL_BLEND_EQUATION_RGB             = 0x8009;    /* same as BLEND_EQUATION */
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
        public static extern  void BufferData(GLenum target, GLsizeiptr size, IntPtr data, GLenum usage);

        [DllImport(glDllName, EntryPoint = "glBufferSubData")]
        public static extern  void BufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data);

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
            GLsizei width, GLsizei height, GLint border, GLsizei imageSize, IntPtr data);

        [DllImport(glDllName, EntryPoint = "glCompressedTexSubImage2D")]
        public static extern  void CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, 
            GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, IntPtr data);

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

        [DllImport(glDllName, EntryPoint = "glDeleteTextures")]
        public static extern  void DeleteTextures(GLsizei n, GLuint[] textures);

        [DllImport(glDllName, EntryPoint = "glDeleteProgram")]
        public static extern  void DeleteProgram(GLuint program);

        [DllImport(glDllName, EntryPoint = "glDeleteRenderbuffers")]
        public static extern  void DeleteRenderbuffers(GLsizei n, GLuint[] renderbuffers);

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
        public static extern  void GenBuffers(GLsizei n, out GLuint buffers);

        [DllImport(glDllName, EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(GLsizei n, GLuint[] buffers);

        [DllImport(glDllName, EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(GLsizei n, GLint[] buffers);

        [DllImport(glDllName, EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(GLsizei n, out GLint buffers);

        [DllImport(glDllName, EntryPoint = "glGenerateMipmap")]
        public static extern  void GenerateMipmap(GLenum target);

        [DllImport(glDllName, EntryPoint = "glGenFramebuffers")]
        public static extern  void GenFramebuffers(GLsizei n, out GLuint framebuffers);

        [DllImport(glDllName, EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(GLsizei n, GLuint[] framebuffers);

        [DllImport(glDllName, EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(GLsizei n, GLint[] framebuffers);

        [DllImport(glDllName, EntryPoint = "glGenFramebuffers")]
        public static extern void GenFramebuffers(GLsizei n, out GLint framebuffers);

        [DllImport(glDllName, EntryPoint = "glGenRenderbuffers")]
        public static extern  void GenRenderbuffers(GLsizei n, out GLuint renderbuffers);

        [DllImport(glDllName, EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(GLsizei n, out GLint renderbuffers);

        [DllImport(glDllName, EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(GLsizei n, GLuint[] renderbuffers);

        [DllImport(glDllName, EntryPoint = "glGenRenderbuffers")]
        public static extern void GenRenderbuffers(GLsizei n, GLint[] renderbuffers);

        [DllImport(glDllName, EntryPoint = "glGenTextures")]
        public static extern  void GenTextures(GLsizei n, out GLuint textures);

        [DllImport(glDllName, EntryPoint = "glGenTextures")]
        public static extern void GenTextures(GLsizei n, out GLint textures);

        [DllImport(glDllName, EntryPoint = "glGenTextures")]
        public static extern void GenTextures(GLsizei n, GLuint[] textures);

        [DllImport(glDllName, EntryPoint = "glGenTextures")]
        public static extern void GenTextures(GLsizei n, GLint[] textures);

        [DllImport(glDllName, EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufsize, out GLsizei length, 
            out GLint size, out GLenum type, StringBuilder name);

        [DllImport(glDllName, EntryPoint = "glGetActiveAttrib")]
        public static extern void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufsize, GLsizei[] length, 
            GLint[] size, GLenum[] type, StringBuilder name);

        [DllImport(glDllName, EntryPoint = "glGetActiveUniform")]
        public static extern  void GetActiveUniform(GLuint program, GLuint index, GLsizei bufsize, out GLsizei length,
            out GLint size, out GLenum type, StringBuilder name);

        [DllImport(glDllName, EntryPoint = "glGetActiveUniform")]
        public static extern void GetActiveUniform(GLuint program, GLuint index, GLsizei bufsize, GLsizei[] length,
            GLint[] size, GLenum[] type, StringBuilder name);

        [DllImport(glDllName, EntryPoint = "glGetAttachedShaders")]
        public static extern  void GetAttachedShaders(GLuint program, GLsizei maxcount, out GLsizei count, out GLuint shaders);

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
        public static extern  void GetInteger(GLenum pname, out GLint param);

        [DllImport(glDllName, EntryPoint = "glGetIntegerv")]
        public static extern void GetInteger(GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetProgramiv")]
        public static extern  void GetProgram(GLuint program, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetProgramInfoLog")]
        public static extern  void GetProgramInfoLog(GLuint program, GLsizei bufsize, out GLsizei length, StringBuilder infolog);

        [DllImport(glDllName, EntryPoint = "glGetProgramInfoLog")]
        public static extern void GetProgramInfoLog(GLuint program, GLsizei bufsize, GLsizei[] length, StringBuilder infolog);

        [DllImport(glDllName, EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern  void GetRenderbufferParameter(GLenum target, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetRenderbufferParameteriv")]
        public static extern void GetRenderbufferParameter(GLenum target, GLenum pname, out GLint param);

        [DllImport(glDllName, EntryPoint = "glGetShaderiv")]
        public static extern  void GetShader(GLuint shader, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(GLuint shader, GLenum pname, out GLint param);

        [DllImport(glDllName, EntryPoint = "glGetShaderInfoLog")]
        public static extern  void GetShaderInfoLog(GLuint shader, GLsizei bufsize, GLsizei[] length, StringBuilder infolog);
        
        [DllImport(glDllName, EntryPoint = "glGetShaderInfoLog")]
        public static extern void GetShaderInfoLog(GLuint shader, GLsizei bufsize, out GLsizei length, StringBuilder infolog);

        [DllImport(glDllName, EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern  void GetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint[] range, GLint[] precision);
        //*//
        [DllImport(glDllName, EntryPoint = "glGetShaderPrecisionFormat")]
        public static extern void GetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, out GLint range, out GLint precision);

        [DllImport(glDllName, EntryPoint = "glGetShaderSource")]
        public static extern  void GetShaderSource(GLuint shader, GLsizei bufsize, out GLsizei length, StringBuilder source);

        [DllImport(glDllName, EntryPoint = "glGetShaderSource")]
        public static extern void GetShaderSource(GLuint shader, GLsizei bufsize, GLsizei[] length, StringBuilder source);

        [DllImport(glDllName, EntryPoint = "glGetString")]
        public static extern  string GetString(GLenum name);

        [DllImport(glDllName, EntryPoint = "glGetTexParameterfv")]
        public static extern  void GetTexParameter(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport(glDllName, EntryPoint = "glGetTexParameterfv")]
        public static extern void GetTexParameter(GLenum target, GLenum pname, out GLfloat param);

        [DllImport(glDllName, EntryPoint = "glGetTexParameteriv")]
        public static extern  void GetTexParameter(GLenum target, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetTexParameteriv")]
        public static extern void GetTexParameter(GLenum target, GLenum pname, out GLint param);

        [DllImport(glDllName, EntryPoint = "glGetUniformfv")]
        public static extern  void GetUniform(GLuint program, GLint location, GLfloat[] param);

        [DllImport(glDllName, EntryPoint = "glGetUniformfv")]
        public static extern void GetUniform(GLuint program, GLint location, out GLfloat param);

        [DllImport(glDllName, EntryPoint = "glGetUniformiv")]
        public static extern  void GetUniform(GLuint program, GLint location, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetUniformiv")]
        public static extern void GetUniform(GLuint program, GLint location,out GLint param);

        [DllImport(glDllName, EntryPoint = "glGetUniformLocation")]
        public static extern  int GetUniformLocation(GLuint program, string name);

        [DllImport(glDllName, EntryPoint = "glGetVertexAttribfv")]
        public static extern  void GetVertexAttrib(GLuint index, GLenum pname, GLfloat[] param);

        [DllImport(glDllName, EntryPoint = "glGetVertexAttribfv")]
        public static extern void GetVertexAttrib(GLuint index, GLenum pname, out GLfloat param);

        [DllImport(glDllName, EntryPoint = "glGetVertexAttribiv")]
        public static extern  void GetVertexAttrib(GLuint index, GLenum pname, GLint[] param);

        [DllImport(glDllName, EntryPoint = "glGetVertexAttribiv")]
        public static extern void GetVertexAttrib(GLuint index, GLenum pname,out GLint param);

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
        public static extern  void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr pixels);

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
            GLint border, GLenum format, GLenum type, IntPtr pixels);

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
            GLsizei height, GLenum format, GLenum type, IntPtr pixels);

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
