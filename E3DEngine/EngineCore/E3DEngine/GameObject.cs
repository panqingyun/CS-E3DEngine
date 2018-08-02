using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace E3DEngine
{

    public class GameObject : E3DEngineCommon.Object
    {
        private Renderer mRenderer;

        public Renderer GetRenderer()
        {
            return mRenderer;
        }
        public bool Active
        {
            get;
            set;
        }

        public uint LayerMask
        {
            get;
            set;
        }

        public Vector3 Position
        {
            get; set;
        }

        private Dictionary<string, List<Component>> component_dic = new Dictionary<string, List<Component>>();

        public Transform Transform;

        public GameObject()
        {
            
        }

        public void RemoveComponent(Component com)
        {
            if(component_dic.ContainsKey(com.GetType().FullName))
            {
                component_dic.Remove(com.GetType().FullName);
            }
        }
        
        
        public List<Component> GetComponents(Type t)
        {
            return GetComponents(t.FullName);
        }

        public List<Component> GetComponents(string typeFullName)
        {
            if (component_dic.ContainsKey(typeFullName))
            {
                return component_dic[typeFullName];
            }
            return null;
        }
        
        
        public static void Destory(GameObject go)
        {
            go = null;
        }
    }
}
