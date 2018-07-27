using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace E3DEngine
{
    public delegate Object CreateDelegate(string str, int id = 0);
	public class Resource
	{
        private static Dictionary<Type, CreateDelegate> createFunDic = new Dictionary<Type, CreateDelegate>();

        static Resource()
		{
            // TODO

        }

        public static Object Load(string filePath, Type tp, int id = 1)
        {            
            if(createFunDic.ContainsKey(tp))
            {
                return createFunDic[tp](filePath, id);
            }
            return null;
        }
	}
}
