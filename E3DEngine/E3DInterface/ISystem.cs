using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngineRuntime
{
    public interface ISystem
    {
        void Update(float deltaTime);
        void Initilize();
        void Destory();
        string GetName();
    }
}
