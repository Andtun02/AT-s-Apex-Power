using AT_s_Apex_Power.Hook;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AT_s_Apex_Power
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)//加载窗体
        {
            Config.ConRunning();//配置文件HashTab初始化
            MainRunning();//窗口预加载内容
            Config.Refresh();//读取配置文件
        }

        MouseHook mh;
        public static bool LeftTag = false;
        public static bool RightTag = false;
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 0);

        private void Main_Shown(object sender, EventArgs e)
        {
            SensitivityBox.Text = Config.getValue("sensitivity");
            ColorBox.SelectedItem = Config.getValue("colorBlindnessMode");
            HotKeyBox.Text = Config.getValue("hotKey");
            ShotPingBox.Text = Config.getValue("shotPing");

            mh = new MouseHook();
            mh.SetHook();
            mh.MouseDownEvent += mh_MouseDownEvent;
            mh.MouseUpEvent += mh_MouseUpEvent;

        }

        //按下鼠标键触发的事件
        private void mh_MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LeftTag = true;
                Trace.WriteLine("按下了左键\n");
            }
            if (e.Button == MouseButtons.Right)
            {
                RightTag = true;
                Trace.WriteLine("按下了右键\n");
                if (on)
                {
                    USB.OnFire();
                }
            }
            p1 = e.Location;
        }
        //松开鼠标键触发的事件
        private void mh_MouseUpEvent(object sender, MouseEventArgs e)
        {
            p2 = e.Location;
            //double value = Math.Sqrt(Math.Abs(p1.X - p2.X) * Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y) * Math.Abs(p1.Y - p2.Y));
            //if (LeftTag && RightTag && value > 100)
            //{
            //    MessageBox.Show("ok");
            //}
            if (e.Button == MouseButtons.Left)
            {
                Trace.WriteLine("松开了左键\n");
            }
            if (e.Button == MouseButtons.Right)
            {
                Trace.WriteLine("松开了右键\n");
                if (on)
                {
                    USB.DisFire();
                }
            }
            //Trace.WriteLine("移动了" + value + "距离\n");
            RightTag = false;
            LeftTag = false;
            p1 = new Point(0, 0);
            p2 = new Point(0, 0);
        }

        //程序关闭时关闭hook
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mh.UnHook();
        }

        private void MainRunning()
        {
            ColorBox.Items.Add("默认");
            ColorBox.Items.Add("蓝色盲");
            ColorBox.Items.Add("待添加...");
        }

        //灵敏度被修改
        private void SensitivityBox_TextChanged(object sender, EventArgs e)
        {
            string text = SensitivityBox.Text;
            if (text != null || !text.Equals(Config.getValue("sensitivity")))
            {
                Config.setValue("sensitivity",text);
                Config.Save();
            }
            Trace.WriteLine("灵敏度被修改：" + Config.getValue("sensitivity"));
        }

        //debug按钮
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Config.getValue("sensitivity"));
        }

        //色盲模式被修改
        private void ColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel = ColorBox.SelectedItem.ToString();
            if (sel != null || !sel.Equals(Config.getValue("colorBlindnessMode")))
            {
                Config.setValue("colorBlindnessMode", sel);
                Config.Save();
            }
            //Trace.WriteLine(sel);
            Trace.WriteLine("色盲模式被修改：" + Config.getValue("colorBlindnessMode"));
        }

        bool on = false;
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!on)
            {
                switch (USB.Start())
                {
                    case -1:
                        StateBox.AppendText(DateTime.Now + "盒子设备打开失败！！"+Environment.NewLine);
                        break;
                    case -2:
                        StateBox.AppendText(DateTime.Now + "鼠标移动测试失败！！" + Environment.NewLine);
                        break;
                    case 0:
                        StateBox.AppendText(DateTime.Now + "盒子设备打开 成功！" + Environment.NewLine);
                        StateBox.AppendText(DateTime.Now + "鼠标移动测试 成功！" + Environment.NewLine);
                        on = true;
                        break;
                    default:
                        StateBox.AppendText(DateTime.Now + "异常：你不应该看到此消息" + Environment.NewLine);
                        break;
                }
            }
            else
            {
                switch (USB.Close())
                {
                    case -1:
                        StateBox.AppendText(DateTime.Now + "盒子设备关闭失败！！" + Environment.NewLine);
                        break;
                    case 0:
                        StateBox.AppendText(DateTime.Now + "盒子设备关闭 成功！" + Environment.NewLine);
                        on = false;
                        break;
                }
            }
            
        }

        //热键被修改
        private void HotKeyBox_TextChanged(object sender, EventArgs e)
        {
            string text = HotKeyBox.Text;
            if (text != null || !text.Equals(Config.getValue("hotKey")))
            {
                Config.setValue("hotKey", text);
                Config.Save();
            }
            Trace.WriteLine("热键被修改：" + Config.getValue("hotKey"));
        }

        //下压延迟被修改
        private void ShotPingBox_TextChanged(object sender, EventArgs e)
        {
            string text = ShotPingBox.Text;
            if (text != null || !text.Equals(Config.getValue("shotPing")))
            {
                Config.setValue("shotPing", text);
                Config.Save();
            }
            Trace.WriteLine("下压延迟被修改：" + Config.getValue("shotPing"));
        }

        
    }
}
