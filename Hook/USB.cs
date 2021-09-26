using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_s_Apex_Power.Hook
{
    partial class USB
    {
        //打开盒子
        public static IntPtr M_Handle;//不管是单头的013W模块，还是双头的012WU模块，都是从1开始打开，依次为2,3,4...
        private static Thread th;//线程
        private static bool downBool = false;//右键按下
        private static double sensitivity = double.Parse(Config.getValue("sensitivity"));//鼠标灵敏度
        private static int modifier = (int)(2.50 / sensitivity);

        //检测飞易来
        public static int Start()
        {
            try
            {
                M_Handle = Msdk.M_Open(1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            if ((long)M_Handle == -1)
            {
                return -1;
                
            }
            else
            {
                //测试移动
                int CommRes = Msdk.M_MoveR(M_Handle, 100, -100);
                if (CommRes == 0)
                {
                    Trace.WriteLine("灵敏度"+sensitivity);
                    return 0;
                }
                else
                {
                    return -2;
                }
            }
        }

        //关闭飞易来
        public static int Close()
        {
            if (Msdk.M_Close(M_Handle) == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        
        //下压
        public static void OnFire()
        {
            if (!downBool)
            {
                downBool = true;
                th = new Thread(new ThreadStart(R99Loop));
                th.Start();
            }
        }

        //需要变量
        
        private static void R99Loop()
        {
            
            while (downBool)
            {
                if (MainForm.LeftTag)
                {

                    //Apex通用压枪逻辑【屏幕还是抖的....】
                    Msdk.M_MoveR(M_Handle, -10 * modifier, 12 * modifier);
                    Msdk.M_Delay(10);
                    Msdk.M_MoveR(M_Handle, 10 * modifier, -10 * modifier);
                    Msdk.M_Delay(10);
                }
                
            }
        }
        //抬起
        public static void DisFire()
        {
            downBool = false;
        }

    }

    public class Msdk
    {
        //打开设备
        [DllImport("msdk.dll", EntryPoint = "M_Open", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr M_Open(int port);

        //从当前位置移动鼠标    x: x方向（横轴）的距离（正:向右; 负值:向左）; y: y方向（纵轴）的距离（正:向下; 负值:向上）
        [DllImport("msdk.dll", EntryPoint = "M_MoveR", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int M_MoveR(IntPtr M_hdl, int x, int y);

        //关闭设备
        [DllImport("msdk.dll", EntryPoint = "M_Close", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int M_Close(IntPtr m_hdl);

        //延迟指定时间ms
        [DllImport("msdk.dll", EntryPoint = "M_Delay", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int M_Delay(int time);
    }
}
