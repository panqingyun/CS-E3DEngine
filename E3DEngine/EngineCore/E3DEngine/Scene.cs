using E3DEngineRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace E3DEngine
{
    public class Scene : E3DEngineRuntime.Object
    {
        private uint mObjectID;
        private GameObject mRootObject;
        private DirectionLight mUsedDirectionLight;
        private List<Camera> mCameraList = new List<Camera>();
        private Dictionary<uint, Light> mLightsMap = new Dictionary<uint, Light>();
        private Dictionary<uint, RenderObject> mRendersMap = new Dictionary<uint, RenderObject>();
        private Dictionary<uint, E3DEngineRuntime.Object> mObjMap = new Dictionary<uint, E3DEngineRuntime.Object>();

        public Scene()
        {

        }

        ~Scene()
        {

        }

        public void Create(string filePath)
        {

        }

        public void Update(float deltaTime)
        {

        }

        public void Destory()
        {

        }

        public void DestoryAllObjectImmediately()
        {

        }

        public void RenderScene()
        {

        }

        public void ChangeRenderIndex(uint id, eRenderIndex index)
        {

        }
    }

}
