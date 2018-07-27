using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngine
{
    public class RigidBody : Component
    {
        public float Mass
        {
            set;
            get;
        }

        public float Friction
        {
            set;
            get;
        }

        public float Restitution
        {
            set;
            get;
        }
    }
}
