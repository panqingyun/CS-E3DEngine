using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngineCommon
{
    public interface IObject
    {

    }

    public interface IActor
    {

    }

    public interface IComponent
    {
        void Init(string monoName);
        void Awake();
        void Update(float deltaTime);
        void Start();
        void Destory();
    }


}
