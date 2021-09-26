
namespace AT_s_Apex_Power
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SensitivityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HotKeyBox = new System.Windows.Forms.TextBox();
            this.ShotPingBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "游戏灵敏度";
            // 
            // SensitivityBox
            // 
            this.SensitivityBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SensitivityBox.Location = new System.Drawing.Point(86, 6);
            this.SensitivityBox.MaxLength = 4;
            this.SensitivityBox.Name = "SensitivityBox";
            this.SensitivityBox.Size = new System.Drawing.Size(75, 23);
            this.SensitivityBox.TabIndex = 1;
            this.SensitivityBox.WordWrap = false;
            this.SensitivityBox.TextChanged += new System.EventHandler(this.SensitivityBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "色盲模式";
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ColorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Location = new System.Drawing.Point(86, 38);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(75, 25);
            this.ColorBox.TabIndex = 2;
            this.ColorBox.SelectedIndexChanged += new System.EventHandler(this.ColorBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "deBug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StateBox
            // 
            this.StateBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StateBox.Location = new System.Drawing.Point(-3, 162);
            this.StateBox.Multiline = true;
            this.StateBox.Name = "StateBox";
            this.StateBox.ReadOnly = true;
            this.StateBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StateBox.Size = new System.Drawing.Size(254, 149);
            this.StateBox.TabIndex = 4;
            this.StateBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(447, 249);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(88, 48);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "启动";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "压枪热键";
            // 
            // HotKeyBox
            // 
            this.HotKeyBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.HotKeyBox.Location = new System.Drawing.Point(86, 69);
            this.HotKeyBox.MaxLength = 20;
            this.HotKeyBox.Name = "HotKeyBox";
            this.HotKeyBox.Size = new System.Drawing.Size(75, 23);
            this.HotKeyBox.TabIndex = 1;
            this.HotKeyBox.WordWrap = false;
            this.HotKeyBox.TextChanged += new System.EventHandler(this.HotKeyBox_TextChanged);
            // 
            // ShotPingBox
            // 
            this.ShotPingBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ShotPingBox.Location = new System.Drawing.Point(86, 98);
            this.ShotPingBox.MaxLength = 3;
            this.ShotPingBox.Name = "ShotPingBox";
            this.ShotPingBox.Size = new System.Drawing.Size(75, 23);
            this.ShotPingBox.TabIndex = 6;
            this.ShotPingBox.WordWrap = false;
            this.ShotPingBox.TextChanged += new System.EventHandler(this.ShotPingBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(-1, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "下压延迟(ms)";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::AT_s_Apex_Power.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(547, 309);
            this.Controls.Add(this.ShotPingBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.HotKeyBox);
            this.Controls.Add(this.SensitivityBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AT\'s Apex Power";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SensitivityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StartButton;
        public System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HotKeyBox;
        private System.Windows.Forms.TextBox ShotPingBox;
        private System.Windows.Forms.Label label4;
    }
}

