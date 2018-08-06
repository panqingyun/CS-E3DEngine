using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngineRuntime
{
    public class Material : Object
    {
        protected bool enableDepthTest;
        protected bool enableWriteDepth;
        protected bool enableStencilTest;
        protected bool enableDoubleSide;
        protected bool turnOnBlend;

        protected uint srcBlendFactor;
        protected uint dstBlendFactor;

        Dictionary<uint, Texture> Textures = new Dictionary<uint, Texture>();

        public Shader mShader;
        public TableManager mTableManager;
        public MaterialConfig mMaterialConfig;
        public string mFilePath;

        // -----------------------------------------------
        // 渲染调用开始之前，使用材质
        //-----------------------------------------------
        public virtual void UseMaterial()
        {

        }

        // -----------------------------------------------
        // 材质失效
        //-----------------------------------------------
        public virtual void InvalidMaterial()
        {

        }

        // -----------------------------------------------
        // 清理
        //-----------------------------------------------
        public virtual void Destory()
        {

        }

        // -----------------------------------------------
        // 创建材质
        // @param 材质配置
        // @param Shader配置
        //-----------------------------------------------
        public virtual void CreateMaterial(MaterialConfig config, ShaderConfig sCfg)
        {

        }

        // -----------------------------------------------
        // 给材质设置纹理
        // @param 纹理
        // @param 纹理索引
        //-----------------------------------------------
        public virtual void SetTexture(Texture texture, int index = 0)
        {

        }

        // -----------------------------------------------
        // 绑定纹理
        //-----------------------------------------------
        public virtual void BindTexture()
        {

        }

        // -----------------------------------------------
        // 启用Shader
        //-----------------------------------------------
        public virtual void UseProgram() { }

        // -----------------------------------------------
        // 使用ID是0的shader 即不使用任何shader
        //-----------------------------------------------
        public virtual void UseNullProgram() { }

        // -----------------------------------------------
        // 创建Shader 
        // @param shader配置
        //-----------------------------------------------
        public virtual void CreateShader(ShaderConfig cfg) { }

        // -----------------------------------------------
        // 创建环境贴图
        // @param 上下左右前后的贴图文件名
        //-----------------------------------------------
        public virtual void CreateCubeTexture(string dirPath, string xPName,
                                       string xNName,
                                       string yPName, string yNName, string zPName, string ZNName)
        {

        }

        public virtual void UpdateShader(uint vertexType) { }

        public virtual void SetEnableDepthWrite(bool bEnable) { enableWriteDepth = bEnable; }
        public virtual void SetBlendType(uint src, uint dst) { srcBlendFactor = src; dstBlendFactor = dst; }
        public virtual void SetEnableDepthTest(bool enable) { enableDepthTest = enable; }
        public virtual void SetEnableCullFace(bool enable) { enableDoubleSide = enable; }
    }
}
