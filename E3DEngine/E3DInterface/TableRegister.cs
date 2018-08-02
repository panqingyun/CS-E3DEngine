using E3DEngineCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

/// <summary>
/// 配置注册
/// </summary>
public class TableRegister
{
    //表数量
    public static int TableCount = 0;

    //本地资源列表里的游戏数据表资源ID
    public static int GameTableDataResId = 90000;

    private static string tableNameFormat = "TableName = ";
    private static string LineLengthFormat = "LineLength = ";

    public static void RegistAllTable(Action<bool> onComplete)
    {
        //table
        string dirPath = "Config/Table/";// GameHelper.GetStreamingAssetsPrefixPath() + "Config/Data/Table/";
         
        //string dirPath = "Config/Data/Table/";
        Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
        List<string> fileList = readNameFromXml();
        int fileCount = fileList.Count;
        TableCount = fileCount;
        for (int i = 0; i < fileCount; ++i)
        {
            string className = fileList[i];//.Replace(".tbl32","");
            try
            {
                TableManager.Instance.RegisterTable((TableBase)assembly.CreateInstance(className), dirPath + fileList[i], className);
            }
            catch (Exception ex)
            {
                Console.WriteLine("加载配表报错 ： " + dirPath + fileList[i] + "  |  " + ex.ToString());
            }
        }
        onComplete(true);
        
    }
    private static List<string> readNameFromXml()
    {
        List<string> name = new List<string>();
        string sCfgName = "Config/TableConfig";
        string cfg_text = File.ReadAllText(sCfgName);
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(cfg_text);

        XmlElement rootElem = doc.DocumentElement;
        XmlNodeList serverNodes = rootElem.GetElementsByTagName("Resource");
        foreach (XmlNode node in serverNodes)
        {
            string table_name = ((XmlElement)node).GetAttribute("Name");
            name.Add(table_name);
        }
        return name;
    }

    public static int GetNumberInt(string str)
    {
        int result = 0;
        if (str != null && str != string.Empty)
        {
            // 正则表达式剔除非数字字符（不包含小数点.）
            str = Regex.Replace(str, @"<?[^\d.\d]", "");
            // 如果是数字，则转换为decimal类型
            if (Regex.IsMatch(str, @"^[+-]?\d*[.]?\d*$"))
            {
                result = int.Parse(str);
            }
        }
        return result;
    }

    public static string GetTableNameFromString(string str)
    {

        str = str.Replace(tableNameFormat, "");
        str = str.Substring(0, str.IndexOf(LineLengthFormat));

        return str;
    } 

    public static void AnalyzeTableStr(Assembly assembly, string tableName, string tableData)
    {
        if (tableName == ("TableConfig"))//这个表好像没什么用了
        {
            try
            {
                //  TableManager.Instance.RegisterTable(tableName, tableData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("加载配表报错 ： " + tableName + "  |  " + ex.ToString());
            }
        }
        else if (tableName.Contains("Scene_"))//这个表好像没什么用了
        {
            try
            {
              //  TableManager.Instance.RegisterTable(tableName, tableData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("加载配表报错 ： " + tableName + "  |  " + ex.ToString());
            }
        }
        else
        {
            try
            {

                TableManager.Instance.RegisterTable((TableBase)assembly.CreateInstance(tableName), tableData, tableName);   
            }
            catch (Exception ex)
            {
                Console.WriteLine("加载配表报错 ： " + tableName + "  |  " + ex.ToString());
            }
        }    
    }
}
