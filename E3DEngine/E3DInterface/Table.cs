
using E3DEngineCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

#region LanguageStringTable lines:29

public class BallEmitterConfig : TableBase
{
	/// <summary> ID </summary>
	public int ID	{ get; set; } 
	/// <summary> 内容 </summary>
	public string Content	{ get; set; } 

	public override string GetKey1()
	{
		return "ID";
	}
	public override string GetKey2()
	{
		return "ID";
	}
	public BallEmitterConfig() { }
	public BallEmitterConfig(BallEmitterConfig other) 
		 : base(other)
	{
	}
	public BallEmitterConfig New()
	{
		return  new BallEmitterConfig(this);
	}
}
#endregion

public class MaterialConfig : TableBase
{
    public int ID { get; set; }
    public string Texture { get; set; }
    public int ShaderID { get; set; }
    public string Color { get; set; }
    public string Textures { get; set; }
    public string SrcBlendFactor { get; set; }
    public string DstBlendFactor { get; set; }
    public int CullFace { get; set; }
    public int EnableDepthTest { get; set; }
    public int EnableWriteDepth { get; set; }
    public int TextureClampType { get; set; }
    public int TextureFilterType { get; set; }

    public MaterialConfig() { }
    public MaterialConfig(MaterialConfig other)
        :base(other)
    {

    }
    public MaterialConfig New()
    {
        return new MaterialConfig(this);
    }
}

public class ShaderConfig : TableBase
{

}