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
            this.buttonAutoExplore = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            this.timerExplore = new System.Windows.Forms.Timer(this.components);
            this.checkBoxOutterMode = new System.Windows.Forms.CheckBox();
            this.checkBoxBCrecovery = new System.Windows.Forms.CheckBox();
            this.checkBoxAPrecovery = new System.Windows.Forms.CheckBox();
            this.buttonAPRecovery = new System.Windows.Forms.Button();
            this.buttonBCRecovery = new System.Windows.Forms.Button();
            this.tabControlController = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewFairyInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripbattle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.攻击ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlInfomation = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonCurrentFriend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFriendName = new System.Windows.Forms.TextBox();
            this.buttonSearchFriend = new System.Windows.Forms.Button();
            this.buttonFriendAdd = new System.Windows.Forms.Button();
            this.listViewFriend = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripFriend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除好友ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.buttonApproveList = new System.Windows.Forms.Button();
            this.buttonApproveFriend = new System.Windows.Forms.Button();
            this.tabControlController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStripbattle.SuspendLayout();
            this.tabControlInfomation.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.contextMenuStripFriend.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(57, 6);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(116, 21);
            this.textLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(57, 33);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(116, 21);
            this.textPassword.TabIndex = 3;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(250, 6);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(57, 54);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxoutput
            // 
            this.textBoxoutput.Location = new System.Drawing.Point(-50, 411);
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
            this.labelPlayerName.Location = new System.Drawing.Point(2, 66);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(65, 12);
            this.labelPlayerName.TabIndex = 6;
            this.labelPlayerName.Text = "玩家名称：";
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.Location = new System.Drawing.Point(5, 90);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(29, 12);
            this.labelAP.TabIndex = 7;
            this.labelAP.Text = "AP：";
            // 
            // labelBC
            // 
            this.labelBC.AutoSize = true;
            this.labelBC.Location = new System.Drawing.Point(4, 112);
            this.labelBC.Name = "labelBC";
            this.labelBC.Size = new System.Drawing.Size(29, 12);
            this.labelBC.TabIndex = 8;
            this.labelBC.Text = "BC：";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(4, 134);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(29, 12);
            this.labelGold.TabIndex = 9;
            this.labelGold.Text = "金钱";
            // 
            // comboBoxAreaList
            // 
            this.comboBoxAreaList.FormattingEnabled = true;
            this.comboBoxAreaList.Location = new System.Drawing.Point(57, 156);
            this.comboBoxAreaList.Name = "comboBoxAreaList";
            this.comboBoxAreaList.Size = new System.Drawing.Size(206, 20);
            this.comboBoxAreaList.TabIndex = 10;
            this.comboBoxAreaList.SelectedIndexChanged += new System.EventHandler(this.comboBoxAreaList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "地图：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "区域：";
            // 
            // comboBoxfloor
            // 
            this.comboBoxfloor.FormattingEnabled = true;
            this.comboBoxfloor.Location = new System.Drawing.Point(57, 185);
            this.comboBoxfloor.Name = "comboBoxfloor";
            this.comboBoxfloor.Size = new System.Drawing.Size(206, 20);
            this.comboBoxfloor.TabIndex = 13;
            this.comboBoxfloor.SelectedIndexChanged += new System.EventHandler(this.comboBoxfloor_SelectedIndexChanged);
            // 
            // buttonAutoBattle
            // 
            this.buttonAutoBattle.Enabled = false;
            this.buttonAutoBattle.Location = new System.Drawing.Point(6, 344);
            this.buttonAutoBattle.Name = "buttonAutoBattle";
            this.buttonAutoBattle.Size = new System.Drawing.Size(75, 27);
            this.buttonAutoBattle.TabIndex = 14;
            this.buttonAutoBattle.Text = "自动攻击";
            this.buttonAutoBattle.UseVisualStyleBackColor = true;
            this.buttonAutoBattle.Click += new System.EventHandler(this.buttonAutoBattle_Click);
            // 
            // buttonAutoExplore
            // 
            this.buttonAutoExplore.Enabled = false;
            this.buttonAutoExplore.Location = new System.Drawing.Point(236, 343);
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
            this.checkBoxOutterMode.Location = new System.Drawing.Point(6, 20);
            this.checkBoxOutterMode.Name = "checkBoxOutterMode";
            this.checkBoxOutterMode.Size = new System.Drawing.Size(72, 16);
            this.checkBoxOutterMode.TabIndex = 17;
            this.checkBoxOutterMode.Text = "放妖模式";
            this.checkBoxOutterMode.UseVisualStyleBackColor = true;
            this.checkBoxOutterMode.CheckedChanged += new System.EventHandler(this.checkBoxOutterMode_CheckedChanged);
            // 
            // checkBoxBCrecovery
            // 
            this.checkBoxBCrecovery.AutoSize = true;
            this.checkBoxBCrecovery.Location = new System.Drawing.Point(16, 51);
            this.checkBoxBCrecovery.Name = "checkBoxBCrecovery";
            this.checkBoxBCrecovery.Size = new System.Drawing.Size(72, 16);
            this.checkBoxBCrecovery.TabIndex = 18;
            this.checkBoxBCrecovery.Text = "自动吃红";
            this.checkBoxBCrecovery.UseVisualStyleBackColor = true;
            this.checkBoxBCrecovery.CheckedChanged += new System.EventHandler(this.checkBoxBCrecovery_CheckedChanged);
            // 
            // checkBoxAPrecovery
            // 
            this.checkBoxAPrecovery.AutoSize = true;
            this.checkBoxAPrecovery.Location = new System.Drawing.Point(16, 20);
            this.checkBoxAPrecovery.Name = "checkBoxAPrecovery";
            this.checkBoxAPrecovery.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAPrecovery.TabIndex = 19;
            this.checkBoxAPrecovery.Text = "自动吃绿";
            this.checkBoxAPrecovery.UseVisualStyleBackColor = true;
            this.checkBoxAPrecovery.CheckedChanged += new System.EventHandler(this.checkBoxAPrecovery_CheckedChanged);
            // 
            // buttonAPRecovery
            // 
            this.buttonAPRecovery.Location = new System.Drawing.Point(213, 82);
            this.buttonAPRecovery.Name = "buttonAPRecovery";
            this.buttonAPRecovery.Size = new System.Drawing.Size(97, 29);
            this.buttonAPRecovery.TabIndex = 20;
            this.buttonAPRecovery.Text = "绿茶";
            this.buttonAPRecovery.UseVisualStyleBackColor = true;
            this.buttonAPRecovery.Click += new System.EventHandler(this.buttonAPRecovery_Click);
            // 
            // buttonBCRecovery
            // 
            this.buttonBCRecovery.Location = new System.Drawing.Point(213, 117);
            this.buttonBCRecovery.Name = "buttonBCRecovery";
            this.buttonBCRecovery.Size = new System.Drawing.Size(98, 30);
            this.buttonBCRecovery.TabIndex = 21;
            this.buttonBCRecovery.Text = "红茶";
            this.buttonBCRecovery.UseVisualStyleBackColor = true;
            this.buttonBCRecovery.Click += new System.EventHandler(this.buttonBCRecovery_Click);
            // 
            // tabControlController
            // 
            this.tabControlController.Controls.Add(this.tabPage1);
            this.tabControlController.Location = new System.Drawing.Point(1, 3);
            this.tabControlController.Name = "tabControlController";
            this.tabControlController.SelectedIndex = 0;
            this.tabControlController.Size = new System.Drawing.Size(321, 402);
            this.tabControlController.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textLogin);
            this.tabPage1.Controls.Add(this.buttonBCRecovery);
            this.tabPage1.Controls.Add(this.buttonAPRecovery);
            this.tabPage1.Controls.Add(this.textPassword);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Controls.Add(this.buttonAutoExplore);
            this.tabPage1.Controls.Add(this.labelPlayerName);
            this.tabPage1.Controls.Add(this.labelAP);
            this.tabPage1.Controls.Add(this.buttonAutoBattle);
            this.tabPage1.Controls.Add(this.labelBC);
            this.tabPage1.Controls.Add(this.comboBoxfloor);
            this.tabPage1.Controls.Add(this.labelGold);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxAreaList);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxOutterMode);
            this.groupBox3.Location = new System.Drawing.Point(8, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(86, 75);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "战斗模式";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 42);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "跑图模式";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAPrecovery);
            this.groupBox1.Controls.Add(this.checkBoxBCrecovery);
            this.groupBox1.Location = new System.Drawing.Point(206, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 74);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "吃药模式";
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
            this.listViewFairyInfo.Location = new System.Drawing.Point(0, 0);
            this.listViewFairyInfo.MultiSelect = false;
            this.listViewFairyInfo.Name = "listViewFairyInfo";
            this.listViewFairyInfo.Size = new System.Drawing.Size(458, 374);
            this.listViewFairyInfo.TabIndex = 15;
            this.listViewFairyInfo.UseCompatibleStateImageBehavior = false;
            this.listViewFairyInfo.View = System.Windows.Forms.View.Details;
            this.listViewFairyInfo.SelectedIndexChanged += new System.EventHandler(this.listViewFairyInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "妖精名称";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "妖精等级";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "所有人";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "被攻击";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "存活";
            this.columnHeader5.Width = 66;
            // 
            // contextMenuStripbattle
            // 
            this.contextMenuStripbattle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.攻击ToolStripMenuItem});
            this.contextMenuStripbattle.Name = "contextMenuStripbattle";
            this.contextMenuStripbattle.Size = new System.Drawing.Size(99, 26);
            // 
            // 攻击ToolStripMenuItem
            // 
            this.攻击ToolStripMenuItem.Name = "攻击ToolStripMenuItem";
            this.攻击ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.攻击ToolStripMenuItem.Text = "攻击";
            // 
            // tabControlInfomation
            // 
            this.tabControlInfomation.Controls.Add(this.tabPage3);
            this.tabControlInfomation.Controls.Add(this.tabPage4);
            this.tabControlInfomation.Location = new System.Drawing.Point(328, 3);
            this.tabControlInfomation.Name = "tabControlInfomation";
            this.tabControlInfomation.SelectedIndex = 0;
            this.tabControlInfomation.Size = new System.Drawing.Size(472, 402);
            this.tabControlInfomation.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listViewFairyInfo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(464, 376);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "妖精信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonApproveFriend);
            this.tabPage4.Controls.Add(this.buttonApproveList);
            this.tabPage4.Controls.Add(this.buttonCurrentFriend);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.textBoxFriendName);
            this.tabPage4.Controls.Add(this.buttonSearchFriend);
            this.tabPage4.Controls.Add(this.buttonFriendAdd);
            this.tabPage4.Controls.Add(this.listViewFriend);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(464, 376);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "好友信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonCurrentFriend
            // 
            this.buttonCurrentFriend.Location = new System.Drawing.Point(395, 9);
            this.buttonCurrentFriend.Name = "buttonCurrentFriend";
            this.buttonCurrentFriend.Size = new System.Drawing.Size(63, 23);
            this.buttonCurrentFriend.TabIndex = 5;
            this.buttonCurrentFriend.Text = "当前好友";
            this.buttonCurrentFriend.UseVisualStyleBackColor = true;
            this.buttonCurrentFriend.Click += new System.EventHandler(this.buttonCurrentFriend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "好友名称：";
            // 
            // textBoxFriendName
            // 
            this.textBoxFriendName.Location = new System.Drawing.Point(71, 8);
            this.textBoxFriendName.Name = "textBoxFriendName";
            this.textBoxFriendName.Size = new System.Drawing.Size(137, 21);
            this.textBoxFriendName.TabIndex = 3;
            // 
            // buttonSearchFriend
            // 
            this.buttonSearchFriend.Location = new System.Drawing.Point(214, 9);
            this.buttonSearchFriend.Name = "buttonSearchFriend";
            this.buttonSearchFriend.Size = new System.Drawing.Size(78, 23);
            this.buttonSearchFriend.TabIndex = 2;
            this.buttonSearchFriend.Text = "搜索好友";
            this.buttonSearchFriend.UseVisualStyleBackColor = true;
            this.buttonSearchFriend.Click += new System.EventHandler(this.buttonSearchFriend_Click);
            // 
            // buttonFriendAdd
            // 
            this.buttonFriendAdd.Location = new System.Drawing.Point(380, 336);
            this.buttonFriendAdd.Name = "buttonFriendAdd";
            this.buttonFriendAdd.Size = new System.Drawing.Size(78, 23);
            this.buttonFriendAdd.TabIndex = 1;
            this.buttonFriendAdd.Text = "发送申请";
            this.buttonFriendAdd.UseVisualStyleBackColor = true;
            // 
            // listViewFriend
            // 
            this.listViewFriend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewFriend.ContextMenuStrip = this.contextMenuStripFriend;
            this.listViewFriend.FullRowSelect = true;
            this.listViewFriend.GridLines = true;
            this.listViewFriend.Location = new System.Drawing.Point(6, 35);
            this.listViewFriend.Name = "listViewFriend";
            this.listViewFriend.Size = new System.Drawing.Size(452, 295);
            this.listViewFriend.TabIndex = 0;
            this.listViewFriend.UseCompatibleStateImageBehavior = false;
            this.listViewFriend.View = System.Windows.Forms.View.Details;
            this.listViewFriend.SelectedIndexChanged += new System.EventHandler(this.listViewFriend_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "好友名称";
            this.columnHeader6.Width = 209;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "等级";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "好友数量";
            this.columnHeader8.Width = 98;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "用户id";
            this.columnHeader9.Width = 80;
            // 
            // contextMenuStripFriend
            // 
            this.contextMenuStripFriend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除好友ToolStripMenuItem});
            this.contextMenuStripFriend.Name = "contextMenuStripFriend";
            this.contextMenuStripFriend.Size = new System.Drawing.Size(123, 26);
            // 
            // 删除好友ToolStripMenuItem
            // 
            this.删除好友ToolStripMenuItem.Name = "删除好友ToolStripMenuItem";
            this.删除好友ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.删除好友ToolStripMenuItem.Text = "删除好友";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "国服";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(3, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.Text = "台服";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(179, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 54);
            this.panel1.TabIndex = 27;
            // 
            // timerUI
            // 
            this.timerUI.Interval = 5000;
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // buttonApproveList
            // 
            this.buttonApproveList.Location = new System.Drawing.Point(298, 9);
            this.buttonApproveList.Name = "buttonApproveList";
            this.buttonApproveList.Size = new System.Drawing.Size(91, 23);
            this.buttonApproveList.TabIndex = 6;
            this.buttonApproveList.Text = "接受申请列表";
            this.buttonApproveList.UseVisualStyleBackColor = true;
            this.buttonApproveList.Click += new System.EventHandler(this.buttonApproveList_Click);
            // 
            // buttonApproveFriend
            // 
            this.buttonApproveFriend.Location = new System.Drawing.Point(8, 336);
            this.buttonApproveFriend.Name = "buttonApproveFriend";
            this.buttonApproveFriend.Size = new System.Drawing.Size(78, 23);
            this.buttonApproveFriend.TabIndex = 7;
            this.buttonApproveFriend.Text = "允许好友";
            this.buttonApproveFriend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 407);
            this.Controls.Add(this.tabControlInfomation);
            this.Controls.Add(this.tabControlController);
            this.Controls.Add(this.textBoxoutput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "无名亚瑟 v0.2";
            this.tabControlController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStripbattle.ResumeLayout(false);
            this.tabControlInfomation.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.contextMenuStripFriend.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button buttonAutoExplore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerBattle;
        private System.Windows.Forms.Timer timerExplore;
        private System.Windows.Forms.CheckBox checkBoxOutterMode;
        private System.Windows.Forms.CheckBox checkBoxBCrecovery;
        private System.Windows.Forms.CheckBox checkBoxAPrecovery;
        private System.Windows.Forms.Button buttonAPRecovery;
        private System.Windows.Forms.Button buttonBCRecovery;
        private System.Windows.Forms.TabControl tabControlController;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewFairyInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripbattle;
        private System.Windows.Forms.ToolStripMenuItem 攻击ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlInfomation;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listViewFriend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFriendName;
        private System.Windows.Forms.Button buttonSearchFriend;
        private System.Windows.Forms.Button buttonFriendAdd;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button buttonCurrentFriend;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFriend;
        private System.Windows.Forms.ToolStripMenuItem 删除好友ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.Button buttonApproveList;
        private System.Windows.Forms.Button buttonApproveFriend;
    }
}

