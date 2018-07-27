using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngine
{
    public class Quaternion
    {
        public Vector3 v;
        public float w = 0;

        public Quaternion()
        {
            v.SetValue(0, 0, 0);
            w = 0;
        }

        public Quaternion(Quaternion other)
        {
            v = other.v;
            w = other.w;
        }

        public Quaternion(Vector3 _v, float _w)
        {
            v = _v;
            w = _w;
        }

        public Quaternion(float x, float y, float z, float _w)
        {
            v.SetValue(x, y, z);
            w = _w;
        }

        public static bool operator ==(Quaternion lhs, Quaternion rhs)
        {
            return (lhs.v == rhs.v && lhs.w == rhs.w);
        }

        public static bool operator !=(Quaternion lhs, Quaternion rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            return this == (Quaternion)obj;
        }

        public static Quaternion operator +(Quaternion lhs, Quaternion rhs)
        {
            Quaternion quat = new Quaternion();
            quat.w = lhs.w + rhs.w;
            quat.v = lhs.v + rhs.v;
            return quat;
        }

        public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
        {
            return new Quaternion(lhs.w * rhs.w - lhs.v.x * rhs.v.x - lhs.v.y * rhs.v.y - lhs.v.z * rhs.v.z,
                    lhs.w * rhs.v.x + lhs.v.x * rhs.w + lhs.v.y * rhs.v.z - lhs.v.z * rhs.v.y,
                    lhs.w * rhs.v.y - lhs.v.x * rhs.v.z + lhs.v.y * rhs.w + lhs.v.z * rhs.v.x,
                    lhs.w * rhs.v.z + lhs.v.x * rhs.v.y - lhs.v.y * rhs.v.x + lhs.v.z * rhs.w);
        }

        public static Quaternion operator *(Quaternion lhs, float rhs)
        {
            return new Quaternion(lhs.v * rhs, lhs.w * rhs);
        }

        public static Quaternion operator -(Quaternion lhs, Quaternion rhs)
        {
            return new Quaternion(lhs.v - rhs.v, lhs.w - rhs.w);
        }

        public static Quaternion operator ~(Quaternion lhs)
        {
            lhs.v = lhs.v * -1;
            return lhs;
        }

        public float Length()
        {
            return (float)Math.Sqrt(w * w + v.LengthSq());
        }

        public static Vector3 operator *(Quaternion quat, Vector3 vec3)
        {
            Quaternion q = new Quaternion();
            Vector3 vn = new Vector3(vec3);
            vn.Normalize();

            Quaternion vecQuat = new Quaternion(), resQuat = new Quaternion();
            vecQuat.v.x = vn.x;
            vecQuat.v.y = vn.y;
            vecQuat.v.z = vn.z;
            vecQuat.w = 0.0f;
            Quaternion qq = ~quat;
            resQuat = vecQuat * qq;
            resQuat = quat * resQuat;

            return new Vector3(resQuat.v.x, resQuat.v.y, resQuat.v.z);
        }

        public float LengthSq()
        {
            return w * w + v.LengthSq();
        }

        public void Normalize()
        {
            float len = Length();

            if (len == 0.0)
                return;

            float inv = 1 / len;
            w *= inv;
            v *= inv;
        }

        public void FromatAxisRot(Vector3 axis, float angleDeg)
        {
            double angleRad = EMath.Deg2Rad(angleDeg);
            double sa2 = Math.Sin(angleRad / 2);
            double ca2 = Math.Cos(angleRad / 2);
            v = axis * (float)sa2;
            w = (float)ca2;
        }

        public static Quaternion FromEulerAngles(float x, float y, float z)
        {
            Quaternion ret = FromAxisRot(new Vector3(0, 0, 1), z) * FromAxisRot(new Vector3(0, 1, 0), y)
                    * FromAxisRot(new Vector3(1, 0, 0), x);
            return ret;
        }

        public static Quaternion FromAxisRot(Vector3 axis, float angleDeg)
        {
            double angleRad = EMath.Deg2Rad(angleDeg);
            double sa2 = Math.Sin(angleRad / 2);
            double ca2 = Math.Cos(angleRad / 2);
            return new Quaternion( axis * (float)sa2, (float)ca2);
        }

        public Matrix3x3 RotateMatatrix()
        {
            Matrix3x3 ret = new Matrix3x3();

            float xx = v.x * v.x;
            float xy = v.x * v.y;
            float xz = v.x * v.z;
            float xw = v.x * w;

            float yy = v.y * v.y;
            float yz = v.y * v.z;
            float yw = v.y * w;

            float zz = v.z * v.z;
            float zw = v.z * w;

            ret[0, 0] = 1 - 2 * (yy + zz);
            ret[1, 0] = 2 * (xy - zw);
            ret[2, 0] = 2 * (xz + yw);

            ret[0, 1] = 2 * (xy + zw);
            ret[1, 1] = 1 - 2 * (xx + zz);
            ret[2, 1] = 2 * (yz - xw);

            ret[0, 2] = 2 * (xz - yw);
            ret[1, 2] = 2 * (yz + xw);
            ret[2, 2] = 1 - 2 * (xx + yy);

            return ret;
        }

        public Matrix4x4 Transform()
        {

            Matrix4x4 ret = new Matrix4x4();

            float xx = v.x * v.x;
            float xy = v.x * v.y;
            float xz = v.x * v.z;
            float xw = v.x * w;

            float yy = v.y * v.y;
            float yz = v.y * v.z;
            float yw = v.y * w;

            float zz = v.z * v.z;
            float zw = v.z * w;

            ret[0, 0] = 1 - 2 * (yy + zz);
            ret[1, 0] = 2 * (xy - zw);
            ret[2, 0] = 2 * (xz + yw);
            ret[3, 0] = 0;

            ret[0, 1] = 2 * (xy + zw);
            ret[1, 1] = 1 - 2 * (xx + zz);
            ret[2, 1] = 2 * (yz - xw);
            ret[3, 1] = 0;

            ret[0, 2] = 2 * (xz - yw);
            ret[1, 2] = 2 * (yz + xw);
            ret[2, 2] = 1 - 2 * (xx + yy);
            ret[3, 2] = 0;

            ret[0, 3] = 0;
            ret[1, 3] = 0;
            ret[2, 3] = 0;
            ret[3, 3] = 1;

            return ret;

        }

        public void GetAxisAngle(ref Vector3 axis, ref float angle)
        {
            float scale = (float)Math.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
            axis.x = v.x / scale;
            axis.y = v.y / scale;
            axis.z = v.z / scale;
            angle = (float)Math.Acos(w) * 2.0f;
        }

        public Vector3 ToEulerAngles()
        {
            float roll = (float)(Math.Atan2(2 * ((v.x * v.y) + (w * v.z)), ((w * w) + (v.x * v.x) - (v.y * v.y) - (v.z * v.z))));
            float yaw = (float)(Math.Asin(-2 * ((v.x * v.z) - (w * v.y))));
            float pitch = (float)(Math.Atan2(2 * ((w * v.x) + (v.y * v.z)), ((w * w) - (v.x * v.x) - (v.y * v.y) + (v.z * v.z))));
            return new Vector3(pitch * 180.0f / (float)EMath.M_PI, yaw * 180.0f / (float)EMath.M_PI, roll * 180.0f / (float)EMath.M_PI);
        }

        public Quaternion Lerp(float fact, Quaternion rhs)
        {
            return new Quaternion( v.Lerp(fact, rhs.v),(1 - fact) * w + fact * rhs.w);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Quaternion Fromat(Matrix4x4 m)
        {
            Quaternion q = new Quaternion();
            float tr = 0, s = 0;
            tr = m[1, 1] + m[2, 2] + m[3, 3];
            if (tr >= EMath.Epsilon)
            {
                s = 0.5f / (float)Math.Sqrt(tr + 1.0f);
                q.w = 0.25f / s;
                q.v.x = (m[3, 2] - m[2, 3]) * s;
                q.v.y = (m[1, 3] - m[3, 1]) * s;
                q.v.z = (m[2, 1] - m[1, 2]) * s;
            }
            else
            {
                float d0 = m[1, 1];
                float d1 = m[2, 2];
                float d2 = m[3, 3];

                int bigIdx = (d0 > d1) ? ((d0 > d2) ? 0 : 2) : ((d1 > d2) ? 1 : 2);

                if (bigIdx == 0)
                {
                    s = 2.0f * (float)Math.Sqrt(1.0 + m[1, 1] - m[2, 2] - m[3, 3]);
                    q.w = (m[3, 2] - m[2, 3]) / s;
                    q.v.x = 0.25f * s;
                    q.v.y = (m[1, 2] + m[2, 1]) / s;
                    q.v.z = (m[1, 3] + m[3, 1]) / s;
                }
                else if (bigIdx == 1)
                {
                    s = 2.0f * (float)Math.Sqrt(1.0 + m[2, 2] - m[1, 1] - m[3, 3]);
                    q.w = (m[1, 3] - m[3, 1]) / s;
                    q.v.x = (m[1, 2] + m[2, 1]) / s;
                    q.v.y = 0.25f * s;
                    q.v.z = (m[2, 3] + m[3, 2]) / s;
                }
                else
                {
                    s = 2.0f * (float)Math.Sqrt(1.0 + m[3, 3] - m[1, 1] - m[2, 2]);
                    q.w = (m[2, 1] - m[1, 2]) / s;
                    q.v.x = (m[1, 3] + m[3, 1]) / s;
                    q.v.y = (m[2, 3] + m[3, 2]) / s;
                    q.v.z = 0.25f * s;
                }
            }

            return q;
        }
    }
}
