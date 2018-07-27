using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngine
{

    public class Transform : Object
    {
        public GameObject gameObject
        {
            get;set;
        }
        
        public void SetRote(Quaternion quat)
        {
            Rotation = quat;
        }

        public Quaternion GetRoate()
        {
            return Rotation;
        }

        private Vector3 position;
        public Vector3 Position
        {
            get;
            set;
        }

        private Vector3 scale;
        public Vector3 Scale
        {
            get
            {               
                return scale;
            }
            set
            {
                scale = value;
            }
        }

        public Quaternion Rotation
        {
            get;set;
        }

        private Vector3 forward;
        public Vector3 Forward
        {
            get
            {
                return forward;
            }
        }
        private Vector3 up;
        public Vector3 Up
        {
            get
            {
                return up;
            }
        }

        private Vector3 right;
        public Vector3 Right
        {
            get
            {
                return right;
            }
        }
    }
}
