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
            this.textBoxoutput.Location = new System.Drawing.Point(267, 12);
            this.textBoxoutput.Multiline = true;
            this.textBoxoutput.Name = "textBoxoutput";
            this.textBoxoutput.ReadOnly = true;
            this.textBoxoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxoutput.Size = new System.Drawing.Size(328, 276);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 320);
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
            this.Name = "Form1";
            this.Text = "无名亚瑟";
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
    }
}

