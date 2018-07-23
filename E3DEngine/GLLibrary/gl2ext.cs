using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* GL_OES_EGL_image */
#if !GL_OES_EGL_image
using GLeglImageOES = System.IntPtr;
#endif
using GLenum = System.UInt32;
using GLboolean = System.Byte;

public delegate void GL_PROC_IMAGE_FUNCTION(GLenum target, GLeglImageOES image);
public delegate GLboolean GL_PROC_ENUM_FUNCTION(GLenum target);
public delegate GLboolean GL_PROC_2ENUM_FUNCTION(GLenum target, GLenum pname);
public delegate GLboolean GL_PROC_2ENUM_PARM_FUNCTION(GLenum target, GLenum pname, ref IntPtr param);

namespace GLLibrary
{
    class gl2ext
    {

        /*------------------------------------------------------------------------*
         * OES extension tokens
         *------------------------------------------------------------------------*/

        /* GL_OES_compressed_ETC1_RGB8_texture */
        public const int GL_ETC1_RGB8_OES = 0x8D64;

        /* GL_OES_compressed_paletted_texture */
#if !GL_OES_compressed_paletted_texture
        public const int GL_PALETTE4_RGB8_OES = 0x8B90;
        public const int GL_PALETTE4_RGBA8_OES = 0x8B91;
        public const int GL_PALETTE4_R5_G6_B5_OES = 0x8B92;
        public const int GL_PALETTE4_RGBA4_OES = 0x8B93;
        public const int GL_PALETTE4_RGB5_A1_OES = 0x8B94;
        public const int GL_PALETTE8_RGB8_OES = 0x8B95;
        public const int GL_PALETTE8_RGBA8_OES = 0x8B96;
        public const int GL_PALETTE8_R5_G6_B5_OES = 0x8B97;
        public const int GL_PALETTE8_RGBA4_OES = 0x8B98;
        public const int GL_PALETTE8_RGB5_A1_OES = 0x8B99;
#endif

        /* GL_OES_depth24 */
#if !GL_OES_depth24
        public const int GL_DEPTH_COMPONENT24_OES = 0x81A6;
#endif

        /* GL_OES_depth32 */
#if !GL_OES_depth32
        public const int GL_DEPTH_COMPONENT32_OES = 0x81A7;
#endif

        /* GL_OES_mapbuffer */
#if !GL_OES_mapbuffer
        /* GL_READ_ONLY and GL_READ_WRITE not supported */
        public const int GL_WRITE_ONLY_OES = 0x88B9;
        public const int GL_BUFFER_ACCESS_OES = 0x88BB;
        public const int GL_BUFFER_MAPPED_OES = 0x88BC;
        public const int GL_BUFFER_MAP_POINTER_OES = 0x88BD;
#endif

        /* GL_OES_rgb8_rgba8 */
# if !GL_OES_rgb8_rgba8
        public const int GL_RGB8_OES = 0x8051;
        public const int GL_RGBA8_OES = 0x8058;
#endif

        /* GL_OES_stencil1 */
# if !GL_OES_stencil1
        public const int GL_STENCIL_INDEX1_OES = 0x8D46;
#endif

        /* GL_OES_stencil4 */
#if !GL_OES_stencil4
        public const int GL_STENCIL_INDEX4_OES = 0x8D47;
#endif

        /* GL_OES_texture3D */
#if !GL_OES_texture3D
        public const int GL_TEXTURE_WRAP_R_OES = 0x8072;
        public const int GL_TEXTURE_3D_OES = 0x806F;
        public const int GL_TEXTURE_BINDING_3D_OES = 0x806A;
        public const int GL_MAX_3D_TEXTURE_SIZE_OES = 0x8073;
        public const int GL_SAMPLER_3D_OES = 0x8B5F;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4;
#endif

        /* GL_OES_texture_half_float */
# if !GL_OES_texture_half_float
        public const int GL_HALF_FLOAT_OES = 0x8D61;
#endif

        /* GL_OES_vertex_half_float */
        /* GL_HALF_FLOAT_OES defined in GL_OES_texture_half_float already. */

        /* GL_AMD_compressed_3DC_texture */
#if !GL_AMD_compressed_3DC_texture
        public const int GL_3DC_X_AMD = 0x87F9;
        public const int GL_3DC_XY_AMD = 0x87FA;
#endif

        /* GL_AMD_compressed_ATC_texture */
#if !GL_AMD_compressed_ATC_texture
        public const int GL_ATC_RGB_AMD = 0x8C92;
        public const int GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93;
        public const int GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE;
#endif

        /* GL_EXT_texture_filter_anisotropic */
#if !GL_EXT_texture_filter_anisotropic
        public const int GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
        public const int GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
#endif

        /*------------------------------------------------------------------------*
         * OES extension functions
         *------------------------------------------------------------------------*/

        /* GL_OES_compressed_ETC1_RGB8_texture */
#if !GL_OES_compressed_ETC1_RGB8_texture
        public const int GL_OES_compressed_ETC1_RGB8_texture = 1;
#endif

        /* GL_OES_compressed_paletted_texture */
#if !GL_OES_compressed_paletted_texture
        public const int GL_OES_compressed_paletted_texture = 1;
#endif

        /* GL_OES_EGL_image */
#if !GL_OES_EGL_image
        public const int GL_OES_EGL_image = 1;
#if GL_GLEXT_PROTOTYPES
        public static GL_APIENTRY glEGLImageTargetTexture2DOES;
        public static GL_APIENTRY glEGLImageTargetRenderbufferStorageOES;
#endif
        public static GL_PROC_IMAGE_FUNCTION PFNGLEGLIMAGETARGETTEXTURE2DOESPROC;
        public static GL_PROC_IMAGE_FUNCTION PFNGLEGLIMAGETARGETRENDERBUFFERSTORAGEOESPROC;
#endif

        /* GL_OES_depth24 */
#if !GL_OES_depth24
        public const int GL_OES_depth24 = 1;
#endif

        /* GL_OES_depth32 */
# if !GL_OES_depth32
        public const int GL_OES_depth32 = 1;
#endif

        /* GL_OES_element_index_uint */
#if !GL_OES_element_index_uint
        public const int GL_OES_element_index_uint = 1;
#endif

        /* GL_OES_fbo_render_mipmap */
#if !GL_OES_fbo_render_mipmap
        public const int GL_OES_fbo_render_mipmap = 1;
#endif

        /* GL_OES_fragment_precision_high */
#if !GL_OES_fragment_precision_high
        public const int GL_OES_fragment_precision_high = 1;
#endif

        /* GL_OES_mapbuffer */
#if !GL_OES_mapbuffer
        public const int GL_OES_mapbuffer = 1;
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
        public const int GL_OES_rgb8_rgba8 = 1;
#endif

        /* GL_OES_stencil1 */
#if !GL_OES_stencil1
        public const int GL_OES_stencil1 = 1;
#endif

        /* GL_OES_stencil4 */
#if !GL_OES_stencil4
        public const int GL_OES_stencil4 = 1;
#endif

        /* GL_OES_texture_3D */
#if !GL_OES_texture_3D
        public const int GL_OES_texture_3D = 1;
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
        public const int GL_OES_texture_float_linear = 1;
#endif

        /* GL_OES_texture_half_float_linear */
#if !GL_OES_texture_half_float_linear
        public const int GL_OES_texture_half_float_linear = 1;
#endif

        /* GL_OES_texture_float */
#if !GL_OES_texture_float
        public const int GL_OES_texture_float = 1;
#endif

        /* GL_OES_texture_half_float */
#if !GL_OES_texture_half_float
        public const int GL_OES_texture_half_float = 1;
#endif

        /* GL_OES_texture_npot */
#if !GL_OES_texture_npot
        public const int GL_OES_texture_npot = 1;
#endif

        /* GL_OES_vertex_half_float */
#if !GL_OES_vertex_half_float
        public const int GL_OES_vertex_half_float = 1;
#endif

        /* GL_AMD_compressed_3DC_texture */
#if !GL_AMD_compressed_3DC_texture
        public const int GL_AMD_compressed_3DC_texture = 1;
#endif

        /* GL_AMD_compressed_ATC_texture */
#if !GL_AMD_compressed_ATC_texture
        public const int GL_AMD_compressed_ATC_texture = 1;
#endif

        /* GL_EXT_texture_filter_anisotropic */
#if !GL_EXT_texture_filter_anisotropic
        public const int GL_EXT_texture_filter_anisotropic = 1;
#endif
    }
}
