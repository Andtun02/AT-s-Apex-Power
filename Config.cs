using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace AT_s_Apex_Power
{
    /*配置文件类
     *功能：读 写文件
     */
    class Config
    {
        private static string conPath = "./Config.ini";
        private static Hashtable conTab = new Hashtable();

        public static void ConRunning()
        {
            conTab.Add("initialization","yes");
            conTab.Add("sensitivity", "5.00");
            conTab.Add("colorBlindnessMode", "默认");
            conTab.Add("hotKey", "VK_RBUTTON");
            conTab.Add("shotPing","2");
        }

        public static string getValue(string id)
        {
            return conTab[id].ToString();
        }

        public static void setValue(string id, string text)
        {
            conTab[id] = text;
        }

        public static void Refresh()//重新读取值
        {
            if (File.Exists(conPath))
            {
                conTab.Clear();//反正没几个参数，直接大换血
                StreamReader sr = new StreamReader(new FileStream(conPath, FileMode.Open));
                string str = null;
                string[] tmp = new string[2];
                while ((str = sr.ReadLine()) != null)
                {
                    str = str.Replace(" ", "");
                    //MessageBox.Show("[replace]"+str);
                    tmp = str.Split("=");
                    conTab.Add(tmp[0], tmp[1]);
                }
                sr.Close();
                Save();
                
            }
            else
            {
                Save();
            }
        }

        public static void Save()//保存
        {

            StreamWriter sw = null;
            if (!File.Exists(conPath))
            {
                sw = new StreamWriter(new FileStream(conPath, FileMode.CreateNew));
            }
            else
            {
                sw = new StreamWriter(new FileStream(conPath, FileMode.Create));
            }

            foreach (string item in conTab.Keys)//遍历并到文件
            {
                sw.WriteLine(item + " = " + conTab[item]);
            }
            /* 直接保存对象到文件 方法过时了...查了下，安全漏洞
             * BinaryFormatter bf = new BinaryFormatter();
             * bf.Serialize(fs, conTab);
             */
            sw.Flush();
            sw.Close();

            /*foreach (string item in conTab.Keys)//遍历debug
            {
                MessageBox.Show(item + " = " + conTab[item]);
            }
            */
        }
    }
}
