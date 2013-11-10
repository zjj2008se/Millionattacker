namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxoutput = new System.Windows.Forms.TextBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelAP = new System.Windows.Forms.Label();
            this.labelBC = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.comboBoxAreaList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxfloor = new System.Windows.Forms.ComboBox();
            this.buttonAutoBattle = new System.Windows.Forms.Button();
            this.listViewFairyInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAutoExplore = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            this.timerExplore = new System.Windows.Forms.Timer(this.components);
            this.checkBoxOutterMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(56, 12);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(112, 21);
            this.textLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(56, 45);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(112, 21);
            this.textPassword.TabIndex = 3;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(184, 15);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(57, 45);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxoutput
            // 
            this.textBoxoutput.Location = new System.Drawing.Point(573, 16);
            this.textBoxoutput.Multiline = true;
            this.textBoxoutput.Name = "textBoxoutput";
            this.textBoxoutput.ReadOnly = true;
            this.textBoxoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxoutput.Size = new System.Drawing.Size(299, 296);
            this.textBoxoutput.TabIndex = 5;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(9, 87);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(65, 12);
            this.labelPlayerName.TabIndex = 6;
            this.labelPlayerName.Text = "玩家名称：";
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.Location = new System.Drawing.Point(10, 111);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(29, 12);
            this.labelAP.TabIndex = 7;
            this.labelAP.Text = "AP：";
            // 
            // labelBC
            // 
            this.labelBC.AutoSize = true;
            this.labelBC.Location = new System.Drawing.Point(9, 133);
            this.labelBC.Name = "labelBC";
            this.labelBC.Size = new System.Drawing.Size(29, 12);
            this.labelBC.TabIndex = 8;
            this.labelBC.Text = "BC：";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(9, 155);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(29, 12);
            this.labelGold.TabIndex = 9;
            this.labelGold.Text = "金钱";
            // 
            // comboBoxAreaList
            // 
            this.comboBoxAreaList.FormattingEnabled = true;
            this.comboBoxAreaList.Location = new System.Drawing.Point(78, 177);
            this.comboBoxAreaList.Name = "comboBoxAreaList";
            this.comboBoxAreaList.Size = new System.Drawing.Size(163, 20);
            this.comboBoxAreaList.TabIndex = 10;
            this.comboBoxAreaList.SelectedIndexChanged += new System.EventHandler(this.comboBoxAreaList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "地图：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "区域：";
            // 
            // comboBoxfloor
            // 
            this.comboBoxfloor.FormattingEnabled = true;
            this.comboBoxfloor.Location = new System.Drawing.Point(78, 206);
            this.comboBoxfloor.Name = "comboBoxfloor";
            this.comboBoxfloor.Size = new System.Drawing.Size(163, 20);
            this.comboBoxfloor.TabIndex = 13;
            this.comboBoxfloor.SelectedIndexChanged += new System.EventHandler(this.comboBoxfloor_SelectedIndexChanged);
            // 
            // buttonAutoBattle
            // 
            this.buttonAutoBattle.Enabled = false;
            this.buttonAutoBattle.Location = new System.Drawing.Point(12, 281);
            this.buttonAutoBattle.Name = "buttonAutoBattle";
            this.buttonAutoBattle.Size = new System.Drawing.Size(75, 27);
            this.buttonAutoBattle.TabIndex = 14;
            this.buttonAutoBattle.Text = "自动攻击";
            this.buttonAutoBattle.UseVisualStyleBackColor = true;
            this.buttonAutoBattle.Click += new System.EventHandler(this.buttonAutoBattle_Click);
            // 
            // listViewFairyInfo
            // 
            this.listViewFairyInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewFairyInfo.FullRowSelect = true;
            this.listViewFairyInfo.GridLines = true;
            this.listViewFairyInfo.Location = new System.Drawing.Point(247, 16);
            this.listViewFairyInfo.MultiSelect = false;
            this.listViewFairyInfo.Name = "listViewFairyInfo";
            this.listViewFairyInfo.Size = new System.Drawing.Size(310, 292);
            this.listViewFairyInfo.TabIndex = 15;
            this.listViewFairyInfo.UseCompatibleStateImageBehavior = false;
            this.listViewFairyInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "妖精名称";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "妖精等级";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "所有人";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "被攻击";
            this.columnHeader4.Width = 64;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "存活";
            // 
            // buttonAutoExplore
            // 
            this.buttonAutoExplore.Enabled = false;
            this.buttonAutoExplore.Location = new System.Drawing.Point(170, 281);
            this.buttonAutoExplore.Name = "buttonAutoExplore";
            this.buttonAutoExplore.Size = new System.Drawing.Size(71, 27);
            this.buttonAutoExplore.TabIndex = 16;
            this.buttonAutoExplore.Text = "自动跑图";
            this.buttonAutoExplore.UseVisualStyleBackColor = true;
            this.buttonAutoExplore.Click += new System.EventHandler(this.buttonAutoExplore_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerBattle
            // 
            this.timerBattle.Interval = 5000;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // timerExplore
            // 
            this.timerExplore.Interval = 3000;
            this.timerExplore.Tick += new System.EventHandler(this.timerExplore_Tick);
            // 
            // checkBoxOutterMode
            // 
            this.checkBoxOutterMode.AutoSize = true;
            this.checkBoxOutterMode.Location = new System.Drawing.Point(15, 241);
            this.checkBoxOutterMode.Name = "checkBoxOutterMode";
            this.checkBoxOutterMode.Size = new System.Drawing.Size(72, 16);
            this.checkBoxOutterMode.TabIndex = 17;
            this.checkBoxOutterMode.Text = "小号模式";
            this.checkBoxOutterMode.UseVisualStyleBackColor = true;
            this.checkBoxOutterMode.CheckedChanged += new System.EventHandler(this.checkBoxOutterMode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 320);
            this.Controls.Add(this.checkBoxOutterMode);
            this.Controls.Add(this.buttonAutoExplore);
            this.Controls.Add(this.listViewFairyInfo);
            this.Controls.Add(this.buttonAutoBattle);
            this.Controls.Add(this.comboBoxfloor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAreaList);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.labelBC);
            this.Controls.Add(this.labelAP);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.textBoxoutput);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "无名亚瑟 v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxoutput;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelAP;
        private System.Windows.Forms.Label labelBC;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.ComboBox comboBoxAreaList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxfloor;
        private System.Windows.Forms.Button buttonAutoBattle;
        private System.Windows.Forms.ListView listViewFairyInfo;
        private System.Windows.Forms.Button buttonAutoExplore;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerBattle;
        private System.Windows.Forms.Timer timerExplore;
        private System.Windows.Forms.CheckBox checkBoxOutterMode;
    }
}

