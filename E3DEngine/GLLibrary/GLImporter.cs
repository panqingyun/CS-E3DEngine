using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3DEngineInterface;

namespace GLImporter
{
    public class GLImporter
    {

#if __IOS__
        private static IOSGL.IOSGLImporter importer = new IOSGL.IOSGLImporter();
#elif __ANDROID__
        private static AndroidGL.AndroidGLImporter importer = new AndroidGL.AndroidGLImporter();
#elif __WIN32__
        private static WindowsGL.WindowsGLImporter importer = new WindowsGL.WindowsGLImporter();
#endif

        public static IOpenGLImporter Ins
        {
            get
            {
                return (IOpenGLImporter)importer;
            }
        }
    }

}
