using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngine
{
    public class Singleton<T> where T : class, new()
    {
        private static T _Instance;

        static Singleton()
        {
            Singleton<T>._Instance = new T();
        }

        public static void CreateInstance()
        {
            if (Singleton<T>._Instance == null)
            {
                Singleton<T>._Instance = Activator.CreateInstance<T>();
            }
        }

        public static void DestroyInstance()
        {
            if (Singleton<T>._Instance != null)
            {
                Singleton<T>._Instance = null;
            }
        }

        public static T getInstance()
        {
            return GetInstance();
        }

        public static T GetInstance()
        {
            if (Singleton<T>._Instance == null)
            {
                Singleton<T>._Instance = Activator.CreateInstance<T>();
            }

            return Singleton<T>._Instance;
        }

        public static T Instance
        {
            get
            {
                if (Singleton<T>._Instance == null)
                {
                    Singleton<T>._Instance = Activator.CreateInstance<T>();
                }
                return Singleton<T>._Instance;
            }
        }
    }
}
