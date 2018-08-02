using System;
using System.Text;

using GLenum = System.UInt32;
using GLboolean = System.Boolean;
using GLbitfield = System.UInt32;
using GLint = System.Int32;
using GLsizei = System.Int32;
using GLuint = System.UInt32;
using GLfloat = System.Single;
using GLbyte = System.Byte;
using GLclampf = System.Single;
using GLstring = System.String;

/* GL_OES_EGL_image */
#if !GL_OES_EGL_image
using GLeglImageOES = System.IntPtr;
#endif

public delegate void GL_PROC_IMAGE_FUNCTION(GLenum target, GLeglImageOES image);
public delegate GLboolean GL_PROC_ENUM_FUNCTION(GLenum target);
public delegate GLboolean GL_PROC_2ENUM_FUNCTION(GLenum target, GLenum pname);
public delegate GLboolean GL_PROC_2ENUM_PARM_FUNCTION(GLenum target, GLenum pname, ref IntPtr param);

namespace GLImporter
{
    public class gl2ext
    {

        /*------------------------------------------------------------------------*
         * OES extension tokens
         *------------------------------------------------------------------------*/

        /* GL_OES_compressed_ETC1_RGB8_texture */
        public const GLint GL_ETC1_RGB8_OES = 0x8D64;

        /* GL_OES_compressed_paletted_texture */
#if !GL_OES_compressed_paletted_texture
        public const GLint GL_PALETTE4_RGB8_OES = 0x8B90;
        public const GLint GL_PALETTE4_RGBA8_OES = 0x8B91;
        public const GLint GL_PALETTE4_R5_G6_B5_OES = 0x8B92;
        public const GLint GL_PALETTE4_RGBA4_OES = 0x8B93;
        public const GLint GL_PALETTE4_RGB5_A1_OES = 0x8B94;
        public const GLint GL_PALETTE8_RGB8_OES = 0x8B95;
        public const GLint GL_PALETTE8_RGBA8_OES = 0x8B96;
        public const GLint GL_PALETTE8_R5_G6_B5_OES = 0x8B97;
        public const GLint GL_PALETTE8_RGBA4_OES = 0x8B98;
        public const GLint GL_PALETTE8_RGB5_A1_OES = 0x8B99;
#endif

        /* GL_OES_depth24 */
#if !GL_OES_depth24
        public const GLint GL_DEPTH_COMPONENT24_OES = 0x81A6;
#endif

        /* GL_OES_depth32 */
#if !GL_OES_depth32
        public const GLint GL_DEPTH_COMPONENT32_OES = 0x81A7;
#endif

        /* GL_OES_mapbuffer */
#if !GL_OES_mapbuffer
        /* GL_READ_ONLY and GL_READ_WRITE not supported */
        public const GLint GL_WRITE_ONLY_OES = 0x88B9;
        public const GLint GL_BUFFER_ACCESS_OES = 0x88BB;
        public const GLint GL_BUFFER_MAPPED_OES = 0x88BC;
        public const GLint GL_BUFFER_MAP_POINTER_OES = 0x88BD;
#endif

        /* GL_OES_rgb8_rgba8 */
# if !GL_OES_rgb8_rgba8
        public const GLint GL_RGB8_OES = 0x8051;
        public const GLint GL_RGBA8_OES = 0x8058;
#endif

        /* GL_OES_stencil1 */
# if !GL_OES_stencil1
        public const GLint GL_STENCIL_INDEX1_OES = 0x8D46;
#endif

        /* GL_OES_stencil4 */
#if !GL_OES_stencil4
        public const GLint GL_STENCIL_INDEX4_OES = 0x8D47;
#endif

        /* GL_OES_texture3D */
#if !GL_OES_texture3D
        public const GLint GL_TEXTURE_WRAP_R_OES = 0x8072;
        public const GLint GL_TEXTURE_3D_OES = 0x806F;
        public const GLint GL_TEXTURE_BINDING_3D_OES = 0x806A;
        public const GLint GL_MAX_3D_TEXTURE_SIZE_OES = 0x8073;
        public const GLint GL_SAMPLER_3D_OES = 0x8B5F;
        public const GLint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4;
#endif

        /* GL_OES_texture_half_float */
# if !GL_OES_texture_half_float
        public const GLint GL_HALF_FLOAT_OES = 0x8D61;
#endif

        /* GL_OES_vertex_half_float */
        /* GL_HALF_FLOAT_OES defined in GL_OES_texture_half_float already. */

        /* GL_AMD_compressed_3DC_texture */
#if !GL_AMD_compressed_3DC_texture
        public const GLint GL_3DC_X_AMD = 0x87F9;
        public const GLint GL_3DC_XY_AMD = 0x87FA;
#endif

        /* GL_AMD_compressed_ATC_texture */
#if !GL_AMD_compressed_ATC_texture
        public const GLint GL_ATC_RGB_AMD = 0x8C92;
        public const GLint GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93;
        public const GLint GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE;
#endif

        /* GL_EXT_texture_filter_anisotropic */
#if !GL_EXT_texture_filter_anisotropic
        public const GLint GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
        public const GLint GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
#endif

        /*------------------------------------------------------------------------*
         * OES extension functions
         *------------------------------------------------------------------------*/

        /* GL_OES_compressed_ETC1_RGB8_texture */
#if !GL_OES_compressed_ETC1_RGB8_texture
        public const GLint GL_OES_compressed_ETC1_RGB8_texture = 1;
#endif

        /* GL_OES_compressed_paletted_texture */
#if !GL_OES_compressed_paletted_texture
        public const GLint GL_OES_compressed_paletted_texture = 1;
#endif

        /* GL_OES_EGL_image */
#if !GL_OES_EGL_image
        public const GLint GL_OES_EGL_image = 1;
#if GL_GLEXT_PROTOTYPES
        public static GL_APIENTRY glEGLImageTargetTexture2DOES;
        public static GL_APIENTRY glEGLImageTargetRenderbufferStorageOES;
#endif
        public static GL_PROC_IMAGE_FUNCTION PFNGLEGLIMAGETARGETTEXTURE2DOESPROC;
        public static GL_PROC_IMAGE_FUNCTION PFNGLEGLIMAGETARGETRENDERBUFFERSTORAGEOESPROC;
#endif

        /* GL_OES_depth24 */
#if !GL_OES_depth24
        public const GLint GL_OES_depth24 = 1;
#endif

        /* GL_OES_depth32 */
# if !GL_OES_depth32
        public const GLint GL_OES_depth32 = 1;
#endif

        /* GL_OES_element_index_uint */
#if !GL_OES_element_index_uint
        public const GLint GL_OES_element_index_uint = 1;
#endif

        /* GL_OES_fbo_render_mipmap */
#if !GL_OES_fbo_render_mipmap
        public const GLint GL_OES_fbo_render_mipmap = 1;
#endif

        /* GL_OES_fragment_precision_high */
#if !GL_OES_fragment_precision_high
        public const GLint GL_OES_fragment_precision_high = 1;
#endif

        /* GL_OES_mapbuffer */
#if !GL_OES_mapbuffer
        public const GLint GL_OES_mapbuffer = 1;
# if GL_GLEXT_PROTOTYPES
        //public static GL_PROC_FUNCTION glMapBufferOES;
        //GL_APICALL GLboolean GL_APIENTRY glUnmapBufferOES(GLenum target);
        //GL_APICALL void GL_APIENTRY glGetBufferPointervOES(GLenum target, GLenum pname, void** params);
#endif
        public static GL_PROC_2ENUM_FUNCTION PFNGLMAPBUFFEROESPROC;
        public static GL_PROC_ENUM_FUNCTION PFNGLUNMAPBUFFEROESPROC;
        public static GL_PROC_2ENUM_PARM_FUNCTION PFNGLGETBUFFERPOINTERVOESPROC;
#endif

        /* GL_OES_rgb8_rgba8 */
#if !GL_OES_rgb8_rgba8
        public const GLint GL_OES_rgb8_rgba8 = 1;
#endif

        /* GL_OES_stencil1 */
#if !GL_OES_stencil1
        public const GLint GL_OES_stencil1 = 1;
#endif

        /* GL_OES_stencil4 */
#if !GL_OES_stencil4
        public const GLint GL_OES_stencil4 = 1;
#endif

        /* GL_OES_texture_3D */
#if !GL_OES_texture_3D
        public const GLint GL_OES_texture_3D = 1;
#endif
        // TODO
#if GL_GLEXT_PROTOTYPES
        //GL_APICALL void GL_APIENTRY glTexImage3DOES(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const void* pixels);
        //GL_APICALL void GL_APIENTRY glTexSubImage3DOES(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const void* pixels);
        //GL_APICALL void GL_APIENTRY glCopyTexSubImage3DOES(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        //GL_APICALL void GL_APIENTRY glCompressedTexImage3DOES(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const void* data);
        //GL_APICALL void GL_APIENTRY glCompressedTexSubImage3DOES(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const void* data);
        //GL_APICALL void GL_APIENTRY glFramebufferTexture3DOES(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
#else
        //typedef void (GL_PROC_IMAGE_FUNCTION PFNGLTEXIMAGE3DOESPROC) (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const GLvoid* pixels);
        //typedef void (GL_PROC_IMAGE_FUNCTION PFNGLTEXSUBIMAGE3DOESPROC) (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const void* pixels);
        //typedef void (GL_PROC_IMAGE_FUNCTION PFNGLCOPYTEXSUBIMAGE3DOESPROC) (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        //typedef void (GL_PROC_IMAGE_FUNCTION PFNGLCOMPRESSEDTEXIMAGE3DOESPROC) (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const void* data);
        //typedef void (GL_PROC_IMAGE_FUNCTION PFNGLCOMPRESSEDTEXSUBIMAGE3DOESPROC) (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const void* data);
        //typedef void (GL_PROC_IMAGE_FUNCTION PFNGLFRAMEBUFFERTEXTURE3DOES) (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
#endif

        /* GL_OES_texture_float_linear */
# if !GL_OES_texture_float_linear
        public const GLint GL_OES_texture_float_linear = 1;
#endif

        /* GL_OES_texture_half_float_linear */
#if !GL_OES_texture_half_float_linear
        public const GLint GL_OES_texture_half_float_linear = 1;
#endif

        /* GL_OES_texture_float */
#if !GL_OES_texture_float
        public const GLint GL_OES_texture_float = 1;
#endif

        /* GL_OES_texture_half_float */
#if !GL_OES_texture_half_float
        public const GLint GL_OES_texture_half_float = 1;
#endif

        /* GL_OES_texture_npot */
#if !GL_OES_texture_npot
        public const GLint GL_OES_texture_npot = 1;
#endif

        /* GL_OES_vertex_half_float */
#if !GL_OES_vertex_half_float
        public const GLint GL_OES_vertex_half_float = 1;
#endif

        /* GL_AMD_compressed_3DC_texture */
#if !GL_AMD_compressed_3DC_texture
        public const GLint GL_AMD_compressed_3DC_texture = 1;
#endif

        /* GL_AMD_compressed_ATC_texture */
#if !GL_AMD_compressed_ATC_texture
        public const GLint GL_AMD_compressed_ATC_texture = 1;
#endif

        /* GL_EXT_texture_filter_anisotropic */
#if !GL_EXT_texture_filter_anisotropic
        public const GLint GL_EXT_texture_filter_anisotropic = 1;
#endif
    }

    public class gl2 
    {
        /* OpenGL ES core versions */
        public const GLint GL_ES_VERSION_2_0 = 1;

        /* ClearBufferMask */
        public const GLint GL_DEPTH_BUFFER_BIT = 0x00000100;
        public const GLint GL_STENCIL_BUFFER_BIT = 0x00000400;
        public const GLint GL_COLOR_BUFFER_BIT = 0x00004000;

        /* Boolean */
        public const GLbyte GL_FALSE = 0;
        public const GLbyte GL_TRUE = 1;

        /* \todo check that this should be in core. */
        public const GLint GL_NONE = 0;

        /* BeginMode */
        public const GLint GL_POINTS = 0x0000;
        public const GLint GL_LINES = 0x0001;
        public const GLint GL_LINE_LOOP = 0x0002;
        public const GLint GL_LINE_STRIP = 0x0003;
        public const GLint GL_TRIANGLES = 0x0004;
        public const GLint GL_TRIANGLE_STRIP = 0x0005;
        public const GLint GL_TRIANGLE_FAN = 0x0006;

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
        public const GLint GL_ZERO = 0;
        public const GLint GL_ONE = 1;
        public const GLint GL_SRC_COLOR = 0x0300;
        public const GLint GL_ONE_MINUS_SRC_COLOR = 0x0301;
        public const GLint GL_SRC_ALPHA = 0x0302;
        public const GLint GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        public const GLint GL_DST_ALPHA = 0x0304;
        public const GLint GL_ONE_MINUS_DST_ALPHA = 0x0305;

        /* BlendingFactorSrc */
        /*      GL_ZERO */
        /*      GL_ONE */
        public const GLint GL_DST_COLOR = 0x0306;
        public const GLint GL_ONE_MINUS_DST_COLOR = 0x0307;
        public const GLint GL_SRC_ALPHA_SATURATE = 0x0308;
        /*      GL_SRC_ALPHA */
        /*      GL_ONE_MINUS_SRC_ALPHA */
        /*      GL_DST_ALPHA */
        /*      GL_ONE_MINUS_DST_ALPHA */

        /* BlendEquationSeparate */
        public const GLint GL_FUNC_ADD = 0x8006;
        public const GLint GL_BLEND_EQUATION = 0x8009;
        public const GLint GL_BLEND_EQUATION_RGB = 0x8009;    /* same as BLEND_EQUATION */
        public const GLint GL_BLEND_EQUATION_ALPHA = 0x883D;

        /* BlendSubtract */
        public const GLint GL_FUNC_SUBTRACT = 0x800A;
        public const GLint GL_FUNC_REVERSE_SUBTRACT = 0x800B;

        /* Separate Blend Functions */
        public const GLint GL_BLEND_DST_RGB = 0x80C8;
        public const GLint GL_BLEND_SRC_RGB = 0x80C9;
        public const GLint GL_BLEND_DST_ALPHA = 0x80CA;
        public const GLint GL_BLEND_SRC_ALPHA = 0x80CB;
        public const GLint GL_CONSTANT_COLOR = 0x8001;
        public const GLint GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const GLint GL_CONSTANT_ALPHA = 0x8003;
        public const GLint GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const GLint GL_BLEND_COLOR = 0x8005;

        /* Buffer Objects */
        public const GLint GL_ARRAY_BUFFER = 0x8892;
        public const GLint GL_ELEMENT_ARRAY_BUFFER = 0x8893;
        public const GLint GL_ARRAY_BUFFER_BINDING = 0x8894;
        public const GLint GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

        public const GLint GL_STREAM_DRAW = 0x88E0;
        public const GLint GL_STATIC_DRAW = 0x88E4;
        public const GLint GL_DYNAMIC_DRAW = 0x88E8;

        public const GLint GL_BUFFER_SIZE = 0x8764;
        public const GLint GL_BUFFER_USAGE = 0x8765;
        public const GLint GL_CURRENT_VERTEX_ATTRIB = 0x8626;
        /* CullFaceMode */
        public const GLint GL_FRONT = 0x0404;
        public const GLint GL_BACK = 0x0405;
        public const GLint GL_FRONT_AND_BACK = 0x0408;

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
        public const GLint GL_TEXTURE_2D = 0x0DE1;
        public const GLint GL_CULL_FACE = 0x0B44;
        public const GLint GL_BLEND = 0x0BE2;
        public const GLint GL_DITHER = 0x0BD0;
        public const GLint GL_STENCIL_TEST = 0x0B90;
        public const GLint GL_DEPTH_TEST = 0x0B71;
        public const GLint GL_SCISSOR_TEST = 0x0C11;
        public const GLint GL_POLYGON_OFFSET_FILL = 0x8037;
        public const GLint GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const GLint GL_SAMPLE_COVERAGE = 0x80A0;

        /* ErrorCode */
        public const GLint GL_NO_ERROR = 0;
        public const GLint GL_INVALID_ENUM = 0x0500;
        public const GLint GL_INVALID_VALUE = 0x0501;
        public const GLint GL_INVALID_OPERATION = 0x0502;
        public const GLint GL_OUT_OF_MEMORY = 0x0505;

        /* FrontFaceDirection */
        public const GLint GL_CW = 0x0900;
        public const GLint GL_CCW = 0x0901;

        /* GetPName */
        public const GLint GL_LINE_WIDTH = 0x0B21;
        public const GLint GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const GLint GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const GLint GL_CULL_FACE_MODE = 0x0B45;
        public const GLint GL_FRONT_FACE = 0x0B46;
        public const GLint GL_DEPTH_RANGE = 0x0B70;
        public const GLint GL_DEPTH_WRITEMASK = 0x0B72;
        public const GLint GL_DEPTH_CLEAR_VALUE = 0x0B73;
        public const GLint GL_DEPTH_FUNC = 0x0B74;
        public const GLint GL_STENCIL_CLEAR_VALUE = 0x0B91;
        public const GLint GL_STENCIL_FUNC = 0x0B92;
        public const GLint GL_STENCIL_FAIL = 0x0B94;
        public const GLint GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const GLint GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const GLint GL_STENCIL_REF = 0x0B97;
        public const GLint GL_STENCIL_VALUE_MASK = 0x0B93;
        public const GLint GL_STENCIL_WRITEMASK = 0x0B98;
        public const GLint GL_STENCIL_BACK_FUNC = 0x8800;
        public const GLint GL_STENCIL_BACK_FAIL = 0x8801;
        public const GLint GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        public const GLint GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        public const GLint GL_STENCIL_BACK_REF = 0x8CA3;
        public const GLint GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
        public const GLint GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
        public const GLint GL_VIEWPORT = 0x0BA2;
        public const GLint GL_SCISSOR_BOX = 0x0C10;
        /*      GL_SCISSOR_TEST */
        public const GLint GL_COLOR_CLEAR_VALUE = 0x0C22;
        public const GLint GL_COLOR_WRITEMASK = 0x0C23;
        public const GLint GL_UNPACK_ALIGNMENT = 0x0CF5;
        public const GLint GL_PACK_ALIGNMENT = 0x0D05;
        public const GLint GL_MAX_TEXTURE_SIZE = 0x0D33;
        public const GLint GL_MAX_VIEWPORT_DIMS = 0x0D3A;
        public const GLint GL_SUBPIXEL_BITS = 0x0D50;
        public const GLint GL_RED_BITS = 0x0D52;
        public const GLint GL_GREEN_BITS = 0x0D53;
        public const GLint GL_BLUE_BITS = 0x0D54;
        public const GLint GL_ALPHA_BITS = 0x0D55;
        public const GLint GL_DEPTH_BITS = 0x0D56;
        public const GLint GL_STENCIL_BITS = 0x0D57;
        public const GLint GL_POLYGON_OFFSET_UNITS = 0x2A00;
        /*      GL_POLYGON_OFFSET_FILL */
        public const GLint GL_POLYGON_OFFSET_FACTOR = 0x8038;
        public const GLint GL_TEXTURE_BINDING_2D = 0x8069;
        public const GLint GL_SAMPLE_BUFFERS = 0x80A8;
        public const GLint GL_SAMPLES = 0x80A9;
        public const GLint GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const GLint GL_SAMPLE_COVERAGE_INVERT = 0x80AB;

        /* GetTextureParameter */
        /*      GL_TEXTURE_MAG_FILTER */
        /*      GL_TEXTURE_MIN_FILTER */
        /*      GL_TEXTURE_WRAP_S */
        /*      GL_TEXTURE_WRAP_T */

        public const GLint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const GLint GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;

        /* HintMode */
        public const GLint GL_DONT_CARE = 0x1100;
        public const GLint GL_FASTEST = 0x1101;
        public const GLint GL_NICEST = 0x1102;

        /* HintTarget */
        public const GLint GL_GENERATE_MIPMAP_HINT = 0x8192;
        public const GLint GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;

        /* DataType */
        public const GLint GL_BYTE = 0x1400;
        public const GLint GL_UNSIGNED_BYTE = 0x1401;
        public const GLint GL_SHORT = 0x1402;
        public const GLint GL_UNSIGNED_SHORT = 0x1403;
        public const GLint GL_INT = 0x1404;
        public const GLint GL_UNSIGNED_INT = 0x1405;
        public const GLint GL_FLOAT = 0x1406;
        public const GLint GL_FIXED = 0x140C;

        /* PixelFormat */
        public const GLint GL_DEPTH_COMPONENT = 0x1902;
        public const GLint GL_ALPHA = 0x1906;
        public const GLint GL_RGB = 0x1907;
        public const GLint GL_RGBA = 0x1908;
        public const GLint GL_LUMINANCE = 0x1909;
        public const GLint GL_LUMINANCE_ALPHA = 0x190A;

        /* PixelType */
        /*      GL_UNSIGNED_BYTE */
        public const GLint GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const GLint GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const GLint GL_UNSIGNED_SHORT_5_6_5 = 0x8363;

        /* Shaders */
        public const GLint GL_FRAGMENT_SHADER = 0x8B30;
        public const GLint GL_VERTEX_SHADER = 0x8B31;
        public const GLint GL_MAX_VERTEX_ATTRIBS = 0x8869;
        public const GLint GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const GLint GL_MAX_VARYING_VECTORS = 0x8DFC;
        public const GLint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public const GLint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        public const GLint GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        public const GLint GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public const GLint GL_SHADER_TYPE = 0x8B4F;
        public const GLint GL_DELETE_STATUS = 0x8B80;
        public const GLint GL_LINK_STATUS = 0x8B82;
        public const GLint GL_VALIDATE_STATUS = 0x8B83;
        public const GLint GL_ATTACHED_SHADERS = 0x8B85;
        public const GLint GL_ACTIVE_UNIFORMS = 0x8B86;
        public const GLint GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        public const GLint GL_ACTIVE_ATTRIBUTES = 0x8B89;
        public const GLint GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        public const GLint GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
        public const GLint GL_CURRENT_PROGRAM = 0x8B8D;

        /* StencilFunction */
        public const GLint GL_NEVER = 0x0200;
        public const GLint GL_LESS = 0x0201;
        public const GLint GL_EQUAL = 0x0202;
        public const GLint GL_LEQUAL = 0x0203;
        public const GLint GL_GREATER = 0x0204;
        public const GLint GL_NOTEQUAL = 0x0205;
        public const GLint GL_GEQUAL = 0x0206;
        public const GLint GL_ALWAYS = 0x0207;

        /* StencilOp */
        /*      GL_ZERO */
        public const GLint GL_KEEP = 0x1E00;
        public const GLint GL_REPLACE = 0x1E01;
        public const GLint GL_INCR = 0x1E02;
        public const GLint GL_DECR = 0x1E03;
        public const GLint GL_INVERT = 0x150A;
        public const GLint GL_INCR_WRAP = 0x8507;
        public const GLint GL_DECR_WRAP = 0x8508;

        /* StringName */
        public const GLint GL_VENDOR = 0x1F00;
        public const GLint GL_RENDERER = 0x1F01;
        public const GLint GL_VERSION = 0x1F02;
        public const GLint GL_EXTENSIONS = 0x1F03;

        /* TextureMagFilter */
        public const GLint GL_NEAREST = 0x2600;
        public const GLint GL_LINEAR = 0x2601;

        /* TextureMinFilter */
        /*      GL_NEAREST */
        /*      GL_LINEAR */
        public const GLint GL_NEAREST_MIPMAP_NEAREST = 0x2700;
        public const GLint GL_LINEAR_MIPMAP_NEAREST = 0x2701;
        public const GLint GL_NEAREST_MIPMAP_LINEAR = 0x2702;
        public const GLint GL_LINEAR_MIPMAP_LINEAR = 0x2703;

        /* TextureParameterName */
        public const GLint GL_TEXTURE_MAG_FILTER = 0x2800;
        public const GLint GL_TEXTURE_MIN_FILTER = 0x2801;
        public const GLint GL_TEXTURE_WRAP_S = 0x2802;
        public const GLint GL_TEXTURE_WRAP_T = 0x2803;

        /* TextureTarget */
        /*      GL_TEXTURE_2D */
        public const GLint GL_TEXTURE = 0x1702;
        public const GLint GL_TEXTURE_CUBE_MAP = 0x8513;
        public const GLint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const GLint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const GLint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const GLint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const GLint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const GLint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const GLint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const GLint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

        /* TextureUnit */
        public const GLint GL_TEXTURE0 = 0x84C0;
        public const GLint GL_TEXTURE1 = 0x84C1;
        public const GLint GL_TEXTURE2 = 0x84C2;
        public const GLint GL_TEXTURE3 = 0x84C3;
        public const GLint GL_TEXTURE4 = 0x84C4;
        public const GLint GL_TEXTURE5 = 0x84C5;
        public const GLint GL_TEXTURE6 = 0x84C6;
        public const GLint GL_TEXTURE7 = 0x84C7;
        public const GLint GL_TEXTURE8 = 0x84C8;
        public const GLint GL_TEXTURE9 = 0x84C9;
        public const GLint GL_TEXTURE10 = 0x84CA;
        public const GLint GL_TEXTURE11 = 0x84CB;
        public const GLint GL_TEXTURE12 = 0x84CC;
        public const GLint GL_TEXTURE13 = 0x84CD;
        public const GLint GL_TEXTURE14 = 0x84CE;
        public const GLint GL_TEXTURE15 = 0x84CF;
        public const GLint GL_TEXTURE16 = 0x84D0;
        public const GLint GL_TEXTURE17 = 0x84D1;
        public const GLint GL_TEXTURE18 = 0x84D2;
        public const GLint GL_TEXTURE19 = 0x84D3;
        public const GLint GL_TEXTURE20 = 0x84D4;
        public const GLint GL_TEXTURE21 = 0x84D5;
        public const GLint GL_TEXTURE22 = 0x84D6;
        public const GLint GL_TEXTURE23 = 0x84D7;
        public const GLint GL_TEXTURE24 = 0x84D8;
        public const GLint GL_TEXTURE25 = 0x84D9;
        public const GLint GL_TEXTURE26 = 0x84DA;
        public const GLint GL_TEXTURE27 = 0x84DB;
        public const GLint GL_TEXTURE28 = 0x84DC;
        public const GLint GL_TEXTURE29 = 0x84DD;
        public const GLint GL_TEXTURE30 = 0x84DE;
        public const GLint GL_TEXTURE31 = 0x84DF;
        public const GLint GL_ACTIVE_TEXTURE = 0x84E0;

        /* TextureWrapMode */
        public const GLint GL_REPEAT = 0x2901;
        public const GLint GL_CLAMP_TO_EDGE = 0x812F;
        public const GLint GL_MIRRORED_REPEAT = 0x8370;

        /* Uniform Types */
        public const GLint GL_FLOAT_VEC2 = 0x8B50;
        public const GLint GL_FLOAT_VEC3 = 0x8B51;
        public const GLint GL_FLOAT_VEC4 = 0x8B52;
        public const GLint GL_INT_VEC2 = 0x8B53;
        public const GLint GL_INT_VEC3 = 0x8B54;
        public const GLint GL_INT_VEC4 = 0x8B55;
        public const GLint GL_BOOL = 0x8B56;
        public const GLint GL_BOOL_VEC2 = 0x8B57;
        public const GLint GL_BOOL_VEC3 = 0x8B58;
        public const GLint GL_BOOL_VEC4 = 0x8B59;
        public const GLint GL_FLOAT_MAT2 = 0x8B5A;
        public const GLint GL_FLOAT_MAT3 = 0x8B5B;
        public const GLint GL_FLOAT_MAT4 = 0x8B5C;
        public const GLint GL_SAMPLER_2D = 0x8B5E;
        public const GLint GL_SAMPLER_CUBE = 0x8B60;

        /* Vertex Arrays */
        public const GLint GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        public const GLint GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        public const GLint GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        public const GLint GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        public const GLint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        public const GLint GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        public const GLint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

        /* Read Format */
        public const GLint GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const GLint GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;

        /* Shader Source */
        public const GLint GL_COMPILE_STATUS = 0x8B81;
        public const GLint GL_INFO_LOG_LENGTH = 0x8B84;
        public const GLint GL_SHADER_SOURCE_LENGTH = 0x8B88;
        public const GLint GL_SHADER_COMPILER = 0x8DFA;

        /* Shader Binary */
        public const GLint GL_PLATFORM_BINARY = 0x8D63;
        public const GLint GL_SHADER_BINARY_FORMATS = 0x8DF8;
        public const GLint GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;

        /* Shader Precision-Specified Types */
        public const GLint GL_LOW_FLOAT = 0x8DF0;
        public const GLint GL_MEDIUM_FLOAT = 0x8DF1;
        public const GLint GL_HIGH_FLOAT = 0x8DF2;
        public const GLint GL_LOW_INT = 0x8DF3;
        public const GLint GL_MEDIUM_INT = 0x8DF4;
        public const GLint GL_HIGH_INT = 0x8DF5;

        /* Framebuffer Object. */
        public const GLint GL_FRAMEBUFFER = 0x8D40;
        public const GLint GL_RENDERBUFFER = 0x8D41;

        public const GLint GL_RGBA4 = 0x8056;
        public const GLint GL_RGB5_A1 = 0x8057;
        public const GLint GL_RGB565 = 0x8D62;
        public const GLint GL_DEPTH_COMPONENT16 = 0x81A5;
        public const GLint GL_STENCIL_INDEX = 0x1901;
        public const GLint GL_STENCIL_INDEX8 = 0x8D48;

        public const GLint GL_RENDERBUFFER_WIDTH = 0x8D42;
        public const GLint GL_RENDERBUFFER_HEIGHT = 0x8D43;
        public const GLint GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        public const GLint GL_RENDERBUFFER_RED_SIZE = 0x8D50;
        public const GLint GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
        public const GLint GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
        public const GLint GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        public const GLint GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        public const GLint GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;

        public const GLint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const GLint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const GLint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const GLint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;

        public const GLint GL_COLOR_ATTACHMENT0 = 0x8CE0;
        public const GLint GL_DEPTH_ATTACHMENT = 0x8D00;
        public const GLint GL_STENCIL_ATTACHMENT = 0x8D20;

        public const GLint GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
        public const GLint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const GLint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const GLint GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
        public const GLint GL_FRAMEBUFFER_INCOMPLETE_FORMATS = 0x8CDA;
        public const GLint GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;

        public const GLint GL_FRAMEBUFFER_BINDING = 0x8CA6;
        public const GLint GL_RENDERBUFFER_BINDING = 0x8CA7;
        public const GLint GL_MAX_RENDERBUFFER_SIZE = 0x84E8;

        public const GLint GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;

#if __IOS__
        private static IOSGL.IOSGLImporter importer = new IOSGL.IOSGLImporter();
#elif __ANDROID__
        private static AndroidGL.AndroidGLImporter importer = new AndroidGL.AndroidGLImporter();
#elif __WIN32__
        private static WindowsGL.WindowsGLImporter importer = new WindowsGL.WindowsGLImporter();
#endif

        public static void ActiveTexture(GLuint texture)
        {
            importer.ActiveTexture(texture);
        }

        public static void AttachShader(GLuint program, GLuint shader)
        {
            importer.AttachShader(program, shader);
        }

        public static void BindAttribLocation(GLuint program, GLuint index, GLstring name)
        {
            importer.BindAttribLocation(program, index, name);
        }

        public static void BindBuffer(GLuint target, GLuint buffer)
        {
            importer.BindBuffer(target, buffer);
        }

        public static void BindFramebuffer(GLuint target, GLuint framebuffer)
        {
            importer.BindFramebuffer(target, framebuffer);
        }

        public static void BindRenderbuffer(GLuint target, GLuint renderbuffer)
        {
            importer.BindRenderbuffer(target, renderbuffer);
        }

        public static void BindTexture(GLuint target, GLuint texture)
        {
            importer.BindTexture(target, texture);
        }

        public static void BlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
        {
            importer.BlendColor(red, green, blue, alpha);
        }

        public static void BlendEquation(GLuint mode)
        {
            importer.BlendEquation(mode);
        }

        public static void BlendEquationSeparate(GLuint modeRGB, GLuint modeAlpha)
        {
            importer.BlendEquationSeparate(modeRGB, modeAlpha);
        }

        public static void BlendFunc(GLuint sfactor, GLuint dfactor)
        {
            importer.BlendFunc(sfactor, dfactor);
        }

        public static void BlendFuncSeparate(GLuint srcRGB, GLuint dstRGB, GLuint srcAlpha, GLuint dstAlpha)
        {
            importer.BlendFuncSeparate(srcRGB, dstRGB, srcAlpha, dstAlpha);
        }

        public static void BufferData(GLuint target, GLint size, GLbyte[] data, GLuint usage)
        {
            importer.BufferData(target, size, data, usage);
        }

        public static void BufferSubData(GLuint target, GLint offset, GLint size, GLbyte[] data)
        {
            importer.BufferSubData(target, offset, size, data);
        }

        public static GLuint CheckFramebufferStatus(GLuint target)
        {
            return importer.CheckFramebufferStatus(target);
        }

        public static void Clear(GLuint mask)
        {
            importer.Clear(mask);
        }

        public static void ClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
        {
            importer.ClearColor(red, green, blue, alpha);
        }

        public static void ClearDepth(GLfloat depth)
        {
            importer.ClearDepthf(depth);
        }

        public static void ClearStencil(GLint s)
        {
            importer.ClearStencil(s);
        }

        public static void ColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)
        {
            importer.ColorMask(red, green, blue , alpha);
        }

        public static void CompileShader(GLuint shader)
        {
            importer.CompileShader(shader);
        }

        public static void CompressedTexImage2D(GLuint target, GLint level, GLuint internalformat, GLint width, GLint height, GLint border, GLint imageSize, GLbyte[] data)
        {
            importer.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        }

        public static void CompressedTexSubImage2D(GLuint target, GLint level, GLint xoffset, GLint yoffset, GLint width, GLint height, GLuint format, GLint imageSize, GLbyte[] data)
        {
            importer.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public static void CopyTexImage2D(GLuint target, GLint level, GLuint internalformat, GLint x, GLint y, GLint width, GLint height, GLint border)
        {
            importer.CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
        }

        public static void CopyTexSubImage2D(GLuint target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLint width, GLint height)
        {
            importer.CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }

        public static GLuint CreateProgram()
        {
            return importer.CreateProgram();
        }

        public static GLuint CreateShader(GLuint type)
        {
            return CreateShader(type);
        }

        public static void CullFace(GLuint mode)
        {
            importer.CullFace(mode);
        }

        public static void DeleteBuffers(GLint n, GLuint[] buffers)
        {
            importer.DeleteBuffers(n, buffers);
        }

        public static void DeleteFramebuffers(GLint n, GLuint[] framebuffers)
        {
            importer.DeleteFramebuffers(n, framebuffers);
        }

        public static void DeleteFramebuffers(GLint n, ref GLuint framebuffer)
        {
            importer.DeleteFramebuffers(n, ref framebuffer);
        }

        public static void DeleteProgram(GLuint program)
        {
            importer.DeleteProgram(program);
        }

        public static void DeleteRenderbuffers(GLint n, GLuint[] renderbuffers)
        {
            importer.DeleteRenderbuffers(n, renderbuffers);
        }

        public static void DeleteRenderbuffers(GLint n, ref GLuint renderbuffer)
        {
            importer.DeleteRenderbuffers(n, ref renderbuffer);
        }

        public static void DeleteShader(GLuint shader)
        {
            importer.DeleteShader(shader);
        }

        public static void DeleteTextures(GLint n, GLuint[] textures)
        {
            importer.DeleteTextures(n, textures);
        }

        public static void DepthFunc(GLuint func)
        {
            importer.DepthFunc(func);
        }

        public static void DepthMask(GLboolean flag)
        {
            importer.DepthMask(flag);
        }

        public static void DepthRange(GLfloat zNear, GLfloat zFar)
        {
            importer.DepthRange(zNear, zFar);
        }

        public static void DetachShader(GLuint program, GLuint shader)
        {
            importer.DetachShader(program, shader);
        }

        public static void Disable(GLuint cap)
        {
            importer.Disable(cap);
        }

        public static void DisableVertexAttribArray(GLuint index)
        {
            importer.DisableVertexAttribArray(index);
        }

        public static void DrawArrays(GLuint mode, GLint first, GLint count)
        {
            importer.DrawArrays(mode, first, count);
        }

        public static void DrawElements(GLuint mode, GLint count, GLuint type, IntPtr indices)
        {
            importer.DrawElements(mode, count, type, indices);
        }

        public static void Enable(GLuint cap)
        {
            importer.Enable(cap);
        }

        public static void EnableVertexAttribArray(GLuint index)
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

        public static void FramebufferRenderbuffer(GLuint target, GLuint attachment, GLuint renderbuffertarget, GLuint renderbuffer)
        {
            importer.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
        }

        public static void FramebufferTexture2D(GLuint target, GLuint attachment, GLuint textarget, GLuint texture, GLint level)
        {
            importer.FramebufferTexture2D(target, attachment, textarget, texture, level);
        }

        public static void FrontFace(GLuint mode)
        {
            importer.FrontFace(mode);
        }

        public static void GenBuffers(GLint n, GLint[] buffers)
        {
            importer.GenBuffers(n, buffers);
        }

        public static void GenBuffers(GLint n, ref GLint buffers)
        {
            importer.GenBuffers(n, ref buffers);
        }

        public static void GenBuffers(GLint n, GLuint[] buffers)
        {
            importer.GenBuffers(n, buffers);
        }

        public static void GenBuffers(GLint n, ref GLuint buffers)
        {
            importer.GenBuffers(n, ref buffers);
        }

        public static void GenerateMipmap(GLuint target)
        {
            importer.GenerateMipmap(target);
        }

        public static void GenFramebuffers(GLint n, GLint[] framebuffers)
        {
            importer.GenFramebuffers(n, framebuffers);
        }

        public static void GenFramebuffers(GLint n, ref GLint framebuffers)
        {
            importer.GenFramebuffers(n, ref framebuffers);
        }

        public static void GenFramebuffers(GLint n, GLuint[] framebuffers)
        {
            importer.GenFramebuffers(n, framebuffers);
        }

        public static void GenFramebuffers(GLint n, ref GLuint framebuffers)
        {
            importer.GenFramebuffers(n, ref framebuffers);
        }

        public static void GenRenderbuffers(GLint n, GLuint[] renderbuffers)
        {
            importer.GenRenderbuffers(n, renderbuffers);
        }

        public static void GenRenderbuffers(GLint n, GLint[] renderbuffers)
        {
            importer.GenRenderbuffers(n, renderbuffers);
        }

        public static void GenRenderbuffers(GLint n, ref GLint renderbuffers)
        {
            importer.GenRenderbuffers(n, ref renderbuffers);
        }

        public static void GenRenderbuffers(GLint n, ref GLuint renderbuffers)
        {
            importer.GenRenderbuffers(n, ref renderbuffers);
        }

        public static void GenTextures(GLint n, GLint[] textures)
        {
            importer.GenTextures(n, textures);
        }

        public static void GenTextures(GLint n, GLuint[] textures)
        {
            importer.GenTextures(n, textures);
        }

        public static void GenTextures(GLint n, ref GLint textures)
        {
            importer.GenTextures(n, ref textures);
        }

        public static void GenTextures(GLint n, ref GLuint textures)
        {
            importer.GenTextures(n, ref textures);
        }

        public static void GetActiveAttrib(GLuint program, GLuint index, GLint bufsize, GLint[] length, GLint[] size, GLuint[] type, StringBuilder name)
        {
            importer.GetActiveAttrib(program, index, bufsize, length, size, type, name);
        }

        public static void GetActiveAttrib(GLuint program, GLuint index, GLint bufsize, ref GLint length, ref GLint size, ref GLuint type, StringBuilder name)
        {
            GLuint _type = 0;
            importer.GetActiveAttrib(program, index, bufsize, ref length, ref size, ref _type, name);
            type = _type;
        }

        public static void GetActiveUniform(GLuint program, GLuint index, GLint bufsize, GLint[] length, GLint[] size, GLuint[] type, StringBuilder name)
        {
            importer.GetActiveUniform(program, index, bufsize, length, size, type, name);
        }

        public static void GetActiveUniform(GLuint program, GLuint index, GLint bufsize, ref GLint length, ref GLint size, ref GLuint type, StringBuilder name)
        {
            GLuint _type = 0;
            importer.GetActiveUniform(program, index, bufsize, ref length, ref size, ref _type, name);
            type = _type;
        }

        public static void GetAttachedShaders(GLuint program, GLint maxcount, GLint[] count, GLuint[] shaders)
        {
            importer.GetAttachedShaders(program, maxcount, count, shaders);
        }

        public static void GetAttachedShaders(GLuint program, GLint maxcount, ref GLint count, ref GLuint shaders)
        {
            importer.GetAttachedShaders(program, maxcount, ref count, ref shaders);
        }

        public static GLint GetAttribLocation(GLuint program, GLstring name)
        {
            return importer.GetAttribLocation(program, name);
        }

        public static void GetBoolean(GLuint pname, GLboolean[] param)
        {
            importer.GetBoolean(pname, param);
        }

        public static void GetBufferParameter(GLuint target, GLuint pname, GLint[] param)
        {
            importer.GetBufferParameter(target, pname, param);
        }

        public static GLuint GetError()
        {
            return importer.GetError();
        }

        public static void GetFloat(GLuint pname, GLfloat[] param)
        {
            importer.GetFloat(pname, param);
        }

        public static void GetFramebufferAttachmentParameter(GLuint target, GLuint attachment, GLuint pname, ref GLint param)
        {
            importer.GetFramebufferAttachmentParameter(target, attachment, pname, ref param);
        }

        public static void GetFramebufferAttachmentParameter(GLuint target, GLuint attachment, GLuint pname, GLint[] param)
        {
            importer.GetFramebufferAttachmentParameter(target, attachment, pname, param);
        }

        public static void GetInteger(GLuint pname, GLint[] param)
        {
            importer.GetInteger(pname, param);
        }

        public static void GetInteger(GLuint pname, ref GLint param)
        {
            importer.GetInteger(pname, ref param);
        }

        public static void GetProgram(GLuint program, GLuint pname, GLint[] param)
        {
            importer.GetProgram(program, pname, param);
        }

        public static void GetProgramInfoLog(GLuint program, GLint bufsize, GLint[] length, StringBuilder infolog)
        {
            importer.GetProgramInfoLog(program, bufsize, length, infolog);
        }

        public static void GetProgramInfoLog(GLuint program, GLint bufsize, ref GLint length, StringBuilder infolog)
        {
            importer.GetProgramInfoLog(program, bufsize, ref length, infolog);
        }

        public static void GetRenderbufferParameter(GLuint target, GLuint pname, ref GLint param)
        {
            importer.GetRenderbufferParameter(target, pname, ref param);
        }

        public static void GetRenderbufferParameter(GLuint target, GLuint pname, GLint[] param)
        {
            importer.GetRenderbufferParameter(target, pname, param);
        }

        public static void GetShader(GLuint shader, GLuint pname, ref GLint param)
        {
            importer.GetShader(shader, pname, ref param);
        }

        public static void GetShader(GLuint shader, GLuint pname, GLint[] param)
        {
            importer.GetShader(shader, pname, param);
        }

        public static void GetShaderInfoLog(GLuint shader, GLint bufsize, ref GLint length, StringBuilder infolog)
        {
            importer.GetShaderInfoLog(shader, bufsize, ref length, infolog);
        }

        public static void GetShaderInfoLog(GLuint shader, GLint bufsize, GLint[] length, StringBuilder infolog)
        {
            importer.GetShaderInfoLog(shader, bufsize, length, infolog);
        }

        public static void GetShaderPrecisionFormat(GLuint shadertype, GLuint precisiontype, ref GLint range, ref GLint precision)
        {
            importer.GetShaderPrecisionFormat(shadertype, precisiontype, ref range, ref precision);
        }

        public static void GetShaderPrecisionFormat(GLuint shadertype, GLuint precisiontype, GLint[] range, GLint[] precision)
        {
            importer.GetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
        }

        public static void GetShaderSource(GLuint shader, GLint bufsize, GLint[] length, StringBuilder source)
        {
            importer.GetShaderSource(shader, bufsize, length, source);
        }

        public static void GetShaderSource(GLuint shader, GLint bufsize, ref GLint length, StringBuilder source)
        {
            importer.GetShaderSource(shader, bufsize, ref length, source);
        }

        public static GLstring GetString(GLuint name)
        {
            return importer.GetString(name);
        }

        public static void GetTexParameter(GLuint target, GLuint pname, GLint[] param)
        {
            importer.GetTexParameter(target, pname, param);
        }

        public static void GetTexParameter(GLuint target, GLuint pname, ref GLint param)
        {
            importer.GetTexParameter(target, pname, ref param);
        }

        public static void GetTexParameter(GLuint target, GLuint pname, ref GLfloat param)
        {
            importer.GetTexParameter(target, pname, ref param);
        }

        public static void GetTexParameter(GLuint target, GLuint pname, GLfloat[] param)
        {
            importer.GetTexParameter(target, pname, param);
        }

        public static void GetUniform(GLuint program, GLint location, GLint[] param)
        {
            importer.GetUniform(program, location, param);
        }

        public static void GetUniform(GLuint program, GLint location, ref GLint param)
        {
            importer.GetUniform(program, location, ref param);
        }

        public static void GetUniform(GLuint program, GLint location, ref GLfloat param)
        {
            importer.GetUniform(program, location, ref param);
        }

        public static void GetUniform(GLuint program, GLint location, GLfloat[] param)
        {
            importer.GetUniform(program, location, param);
        }

        public static GLint GetUniformLocation(GLuint program, GLstring name)
        {
            return importer.GetUniformLocation(program, name);
        }

        public static void GetVertexAttrib(GLuint index, GLuint pname, GLint[] param)
        {
            importer.GetVertexAttrib(index, pname, param);
        }

        public static void GetVertexAttrib(GLuint index, GLuint pname, ref GLint param)
        {
            importer.GetVertexAttrib(index, pname, ref param);
        }

        public static void GetVertexAttrib(GLuint index, GLuint pname, ref GLfloat param)
        {
            importer.GetVertexAttrib(index, pname, ref param);
        }

        public static void GetVertexAttrib(GLuint index, GLuint pname, GLfloat[] param)
        {
            importer.GetVertexAttrib(index, pname, param);
        }

        public static void GetVertexAttribPointer(GLuint index, GLuint pname, IntPtr pointer)
        {
            importer.GetVertexAttribPointer(index, pname, pointer);
        }

        public static void Hint(GLuint target, GLuint mode)
        {
            importer.Hint(target, mode);
        }

        public static GLboolean IsBuffer(GLuint buffer)
        {
            return importer.IsBuffer(buffer);
        }

        public static GLboolean IsEnabled(GLuint cap)
        {
            return importer.IsEnabled(cap);
        }

        public static GLboolean IsFramebuffer(GLuint framebuffer)
        {
            return importer.IsFramebuffer(framebuffer);
        }

        public static GLboolean IsProgram(GLuint program)
        {
            return importer.IsProgram(program);
        }

        public static GLboolean IsRenderbuffer(GLuint renderbuffer)
        {
            return importer.IsRenderbuffer(renderbuffer);
        }

        public static GLboolean IsShader(GLuint shader)
        {
            return importer.IsShader(shader);
        }

        public static GLboolean IsTexture(GLuint texture)
        {
            return importer.IsTexture(texture);
        }

        public static void LineWidth(GLfloat width)
        {
            importer.LineWidth(width);
        }

        public static void LinkProgram(GLuint program)
        {
            importer.LinkProgram(program);
        }

        public static void PixelStore(GLuint pname, GLint param)
        {
            importer.PixelStore(pname, param);
        }

        public static void PolygonOffset(GLfloat factor, GLfloat units)
        {
            importer.PolygonOffset(factor, units);
        }

        public static void ReadPixels(GLint x, GLint y, GLint width, GLint height, GLuint format, GLuint type, GLbyte[] pixels)
        {
            importer.ReadPixels(x, y, width, height, format, type, pixels);
        }

        public static void ReleaseShaderCompiler()
        {
            importer.ReleaseShaderCompiler();
        }

        public static void RenderbufferStorage(GLuint target, GLuint internalformat, GLint width, GLint height)
        {
            importer.RenderbufferStorage(target, internalformat, width, height);
        }

        public static void SampleCoverage(GLfloat value, GLboolean invert)
        {
            importer.SampleCoverage(value, invert);
        }

        public static void Scissor(GLint x, GLint y, GLint width, GLint height)
        {
            importer.Scissor(x, y, width, height);
        }

        public static void ShaderBinary(GLint n, GLuint[] shaders, GLuint binaryformat, IntPtr binary, GLint length)
        {
            importer.ShaderBinary(n, shaders, binaryformat, binary, length);
        }

        public static void ShaderBinary(GLint n, ref GLuint shaders, GLuint binaryformat, IntPtr binary, GLint length)
        {
            importer.ShaderBinary(n, ref shaders, binaryformat, binary, length);
        }

        public static void ShaderSource(GLuint shader, GLint count, GLstring[] str, GLint[] length)
        {
            importer.ShaderSource(shader, count, str, length);
        }

        public static void ShaderSource(GLuint shader, GLint count, GLstring[] str, ref GLint length)
        {
            importer.ShaderSource(shader, count, str, ref length);
        }

        public static void StencilFunc(GLuint func, GLint _ref, GLuint mask)
        {
            importer.StencilFunc(func, _ref, mask);
        }

        public static void StencilFuncSeparate(GLuint face, GLuint func, GLint _ref, GLuint mask)
        {
            importer.StencilFuncSeparate(face, func, _ref, mask);
        }

        public static void StencilMask(GLuint mask)
        {
            importer.StencilMask(mask);
        }

        public static void StencilMaskSeparate(GLuint face, GLuint mask)
        {
            importer.StencilMaskSeparate(face, mask);
        }

        public static void StencilOp(GLuint fail, GLuint zfail, GLuint zpass)
        {
            importer.StencilOp(fail, zfail, zpass);
        }

        public static void StencilOpSeparate(GLuint face, GLuint fail, GLuint zfail, GLuint zpass)
        {
            importer.StencilOpSeparate(face, fail, zfail, zpass);
        }

        public static void TexImage2D(GLuint target, GLint level, GLuint internalformat, GLint width, GLint height, GLint border, GLuint format, GLuint type, GLbyte[] pixels)
        {
            importer.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }

        public static void TexParameter(GLuint target, GLuint pname, GLint[] param)
        {
            importer.TexParameter(target, pname, param);
        }

        public static void TexParameter(GLuint target, GLuint pname, GLint param)
        {
            importer.TexParameter(target, pname, param);
        }

        public static void TexParameter(GLuint target, GLuint pname, GLfloat[] param)
        {
            importer.TexParameter(target, pname, param);
        }

        public static void TexParameter(GLuint target, GLuint pname, GLfloat param)
        {
            importer.TexParameter(target, pname, param);
        }

        public static void TexSubImage2D(GLuint target, GLint level, GLint xoffset, GLint yoffset, GLint width, GLint height, GLuint format, GLuint type, GLbyte[] pixels)
        {
            importer.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public static void Uniform1(GLint location, GLint x)
        {
            importer.Uniform1(location, x);
        }

        public static void Uniform1(GLint location, GLfloat x)
        {
            importer.Uniform1(location, x);
        }

        public static void Uniform1(GLint location, GLint count, GLint[] v)
        {
            importer.Uniform1(location, count, v);
        }

        public static void Uniform1(GLint location, GLint count, GLfloat[] v)
        {
            importer.Uniform1(location, count, v);
        }

        public static void Uniform2(GLint location, GLint count, GLint[] v)
        {
            importer.Uniform2(location, count, v);
        }

        public static void Uniform2(GLint location, GLint x, GLint y)
        {
            importer.Uniform2(location, x, y);
        }

        public static void Uniform2(GLint location, GLint count, GLfloat[] v)
        {
            importer.Uniform2(location, count, v);
        }

        public static void Uniform2(GLint location, GLfloat x, GLfloat y)
        {
            importer.Uniform2(location, x, y);
        }

        public static void Uniform3(GLint location, GLint count, GLint[] v)
        {
            importer.Uniform3(location, count, v);
        }

        public static void Uniform3(GLint location, GLint count, GLfloat[] v)
        {
            importer.Uniform3(location, count, v);
        }

        public static void Uniform3(GLint location, GLint x, GLint y, GLint z)
        {
            importer.Uniform3(location, x, y, z);
        }

        public static void Uniform3(GLint location, GLfloat x, GLfloat y, GLfloat z)
        {
            importer.Uniform3(location, x, y, z);
        }

        public static void Uniform4(GLint location, GLint count, GLint[] v)
        {
            importer.Uniform4(location, count, v);
        }

        public static void Uniform4(GLint location, GLint count, GLfloat[] v)
        {
            importer.Uniform4(location, count, v);
        }

        public static void Uniform4(GLint location, GLint x, GLint y, GLint z, GLint w)
        {
            importer.Uniform4(location, x, y, z, w);
        }

        public static void Uniform4(GLint location, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            importer.Uniform4(location, x, y, z, w);
        }

        public static void UniformMatrix2(GLint location, GLint count, GLboolean transpose, GLfloat[] value)
        {
            importer.UniformMatrix2(location, count, transpose, value);
        }

        public static void UniformMatrix3(GLint location, GLint count, GLboolean transpose, GLfloat[] value)
        {
            importer.UniformMatrix3(location, count, transpose , value);
        }

        public static void UniformMatrix4(GLint location, GLint count, GLboolean transpose, GLfloat[] value)
        {
            importer.UniformMatrix4(location, count, transpose, value);
        }

        public static void UseProgram(GLuint program)
        {
            importer.UseProgram(program);
        }

        public static void ValidateProgram(GLuint program)
        {
            importer.ValidateProgram(program);
        }

        public static void VertexAttrib1(GLuint indx, GLfloat[] values)
        {
            importer.VertexAttrib1(indx, values);
        }

        public static void VertexAttrib1(GLuint indx, GLfloat x)
        {
            importer.VertexAttrib1(indx, x);
        }

        public static void VertexAttrib2(GLuint indx, GLfloat[] values)
        {
            importer.VertexAttrib2(indx, values);
        }

        public static void VertexAttrib2(GLuint indx, GLfloat x, GLfloat y)
        {
            importer.VertexAttrib2(indx, x, y);
        }

        public static void VertexAttrib3(GLuint indx, GLfloat[] values)
        {
            importer.VertexAttrib3(indx, values);
        }

        public static void VertexAttrib3(GLuint indx, GLfloat x, GLfloat y, GLfloat z)
        {
            importer.VertexAttrib3(indx, x, y, z);
        }

        public static void VertexAttrib4(GLuint indx, GLfloat[] values)
        {
            importer.VertexAttrib4(indx, values);
        }

        public static void VertexAttrib4(GLuint indx, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            importer.VertexAttrib4(indx, x, y, z, w);
        }

        public static void VertexAttribPointer(GLuint indx, GLint size, GLuint type, GLboolean normalized, GLint stride, IntPtr ptr)
        {
            importer.VertexAttribPointer(indx, size, type, normalized , stride, ptr);
        }

        public static void Viewport(GLint x, GLint y, GLint width, GLint height)
        {
            importer.Viewport(x, y, width, height);
        }
    }

}
