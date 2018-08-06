using E3DEngineRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngine
{
    public class Camera : GameObject
    {

        private Matrix4x4 viewMatrix = new Matrix4x4();
        private Matrix4x4 projMatrix = new Matrix4x4();

        /// <summary>
        /// 前方向
        /// </summary>
        public Vector3 Forward
        {
            get
            {
                return Transform.Forward * -1;
            }
        }

        /// <summary>
        /// 上方向
        /// </summary>
        public Vector3 Up
        {
            get
            {
                return Transform.Up;
            }
        }

        /// <summary>
        /// 右方向
        /// </summary>
        public Vector3 Right
        {
            get
            {
                return Transform.Right;
            }
        }

        private Matrix4x4 mMatrixView;
        private Matrix4x4 mMatrixProjection;
        private Matrix4x4 mMatrixViewInverse;
        private Matrix4x4 mMatrixProjectInverse;

        private float mPitch;
        private float mYaw;
        private float mRoll;
        private float mFacearea;
        private float mFov;
        private float mAspect;
        private float mNear;
        private float mFar;

        private bool isPerspective;
        private List<float[]> mPlans;
        private float mTemp;
        private Vector4 mClearColor;
        private int mDepth;
        private ClearType mClearType;
        //private  List<Render2Texture*> RTTs;
        //private  RenderQueue* m_RenderQueue;

        public Camera(Vector3 position, Vector3 target, float fov, Vector3 up, float zNear, float zFar, float aspect)
        {
            for (int i = 0; i < mPlans.Count; i++)
            {
                mPlans[i] = new float[4];
            }
            isPerspective = true;
            mMatrixProjection = Matrix4x4.CreatePerspective(fov, aspect, zNear, zFar);
            mMatrixView = Matrix4x4.CreateLookAt(Transform.Position, target, up);
            Transform.Rotation = Quaternion.Fromat(mMatrixView);
            Transform.Position = position;
            mNear = zNear;
            mFar = zFar;
            mFov = fov;
            mMatrixViewInverse = mMatrixView.Inverse();
            mMatrixProjectInverse = mMatrixProjection.Inverse();
            mType = ObjectType.eT_Camera;
            mClearType = (ClearType.eCT_Color | ClearType.eCT_Depth | ClearType.eCT_Stencil);
            mDepth = 0;

        }

        public Camera(Vector3 position, Vector3 target, Vector3 up, float left, float right, float bottom, float top, float zNear, float zFar)
        {

        }

        public void Render()
        {

        }

        public void Clear()
        {
            EngineDelegate.RenderSystem.ClearColor(mClearColor.r, mClearColor.g, mClearColor.b, mClearColor.a, mClearType);
        }

        public void SetClearColor(float r, float g, float b, float a)
        {
            mClearColor.SetValue(r, g, b, a);
        }

        public void SetClearType(ClearType clearType)
        {
            mClearType = clearType;
        }
    }
}
