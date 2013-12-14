using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MillionTools.tool1;
using MillionTools.tool1.StructInfo;
using MillionTools.tool1.util;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        databaseconnect db = new databaseconnect();
        cardreader cr = new cardreader();

        Services updater = new Services();
        PlayerInfo playerinfo = new PlayerInfo();
        bool autoBattle = false;
        bool autoExplore = false;
        AreaList area = new AreaList();
        FloorList floor = new FloorList();
        FairyList list = new FairyList();
        string aid;
        public string floorid = null;
        public string debugstring = null;
        string selectfriend = null;
        string selectfairy = null;
        bool Outtermode = false;
        bool useAP = false;
        bool useBC = false;
        bool TWorCN = false;
        bool swPVP = false;
        int pvplimit = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textLogin.Text != "" && textPassword.Text != "")
            {
                updater.settingLogin(textLogin.Text, textPassword.Text);
                //updater.settingLogin("15099757550", "qwertyuiop");
                //updatePlayerInfo();
                //textBoxoutput.Text = Action.getdebugstring();
                //updateArea();
                //updateList();
                buttonAutoBattle.Enabled = true;
                buttonpvpbattle.Enabled = true;
                timer1.Start();
                timerUI.Start();
            }
            else 
            {
                MessageBox.Show("请输入用户名和密码");
            }
        }

        private void comboBoxAreaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            AreaList list = new AreaList();
            if ((comboBoxAreaList.Items != null) && (comboBoxAreaList.Items.Count > 0) && (comboBoxAreaList.SelectedItem != null))
            {
                    this.aid = ((ComboxItem) comboBoxAreaList.SelectedItem).Value.ToString();
                    
             }
            updateFloor();
           }

        private void comboBoxfloor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((comboBoxfloor.Items != null) && (comboBoxfloor.Items.Count > 0) && (comboBoxfloor.SelectedItem != null))
            {
                this.floorid = ((ComboxItem)comboBoxfloor.SelectedItem).Value.ToString();
                textBoxoutput.Text = this.floorid;
                buttonAutoExplore.Enabled = true;
            }
        }

        private void buttonAutoBattle_Click(object sender, EventArgs e)
        {

            if (autoBattle == false)
            {
                timerBattle.Start();
                buttonAutoBattle.Text = "停止";
                autoBattle = true;
                buttonAutoBattle.Refresh();
            }
            else
            {
                timerBattle.Stop();
                buttonAutoBattle.Text = "自动战斗";
                autoBattle = false;
                buttonAutoBattle.Refresh();
            }
            
            updateList();
            textBoxoutput.Text = updater.FairyBattle();
        }

        private void buttonAutoExplore_Click(object sender, EventArgs e)
        {
            if (autoExplore == false)
            {
                timerExplore.Start();
                buttonAutoExplore.Text = "停止";
                autoExplore = true;
                buttonAutoExplore.Refresh();
            }
            else 
            {
                timerExplore.Stop();
                buttonAutoExplore.Text = "自动探索";
                autoExplore = false;
                buttonAutoExplore.Refresh();
            }
            //updater.explore(aid, floorid);
            //textBoxoutput.Text = updater.debugstring;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            list = updater.updateFairyInfo();
            playerinfo = updater.updateInfo();
            area = updater.updateArea();
            updater.settingRecovery(useAP, useBC);
            if (aid != null)
            {
                floor = updater.updatefloor(aid);
            }
        }
        private void timerUI_Tick(object sender, EventArgs e)
        {
            updateList();
            updatePlayerInfo();
            updateArea();
            //updateFloor();
            //updateList()
        }
       private void updateList()
       {
           listViewFairyInfo.Items.Clear();
           int count = list.List.Count;
           for (int i = 0; i < count; i++)
           {
               if (list.List[i].IsAlive == true)
               {
                   ListViewItem item = new ListViewItem();
                   item.SubItems.Clear();
                   item.SubItems[0].Text = list.List[i].FairyName;
                   item.SubItems.Add(list.List[i].LV);
                   item.SubItems.Add(list.List[i].OwnerName);
                   if (list.List[i].IsAttack == true)
                   {
                       item.SubItems.Add("是");
                   }
                   else
                   {
                       item.SubItems.Add("否");
                   }
                   if (list.List[i].IsAlive == true)
                   {
                       item.SubItems.Add("是");
                   }
                   else
                   {
                       item.SubItems.Add("否");
                   }
                   //item.SubItems.Add(list.List[i].OwnerID);
                   listViewFairyInfo.Items.Add(item);
               }
           }
           listViewFairyInfo.EndUpdate();
       }
       private void updateArea() 
       {
           comboBoxAreaList.Items.Clear();
           
           int count = area.arealist.Count;
           for (int j = 0; j < count; j++)
           {
               ComboxItem item = new ComboxItem
               {
                   Value = area.arealist[j].Areaid,
                   Text = area.arealist[j].AreaName
               };

               comboBoxAreaList.Items.Add(item);
           }
       }

       private void updatePlayerInfo() 
       {
           
           labelPlayerName.Text = "玩家名称: " + playerinfo.PlayerName;
           labelAP.Text = "AP:  " + playerinfo.NowAP + "/" + playerinfo.MaxAP.ToString();
           labelBC.Text = "BC:  " + playerinfo.NowBC + "/" + playerinfo.MaxBC.ToString();
           labelGold.Text = "金钱： " + playerinfo.gold;
           buttonAPRecovery.Text = "绿茶剩余：" + playerinfo.itemAP.ToString();
           buttonBCRecovery.Text = "红茶剩余：" + playerinfo.itemBC.ToString();
           labelPlayerName.Update();
           labelAP.Update();
           labelBC.Update();
           labelGold.Update();
           buttonAPRecovery.Update();
           buttonBCRecovery.Update();
       }
       private void updateFloor() 
       {
           if (aid != null)
           {
               comboBoxfloor.Items.Clear();
               floor = updater.updatefloor(aid);
               int count1 = floor.floorlist.Count;
               for (int i = 0; i < count1; i++)
               {
                   ComboxItem flooritem = new ComboxItem
                   {
                       Text = "区域" + floor.floorlist[i].id + "|进度：" + floor.floorlist[i].prog,
                       Value = floor.floorlist[i].id
                   };
                   comboBoxfloor.Items.Add(flooritem);
               }
           }
       }
       private void updateFriend(FriendList friend1) 
       {
           listViewFriend.Items.Clear();
           int count = friend1.friendlist.Count();
           for (int i = 0; i < count; i++)
           {
               ListViewItem item = new ListViewItem();
               item.SubItems.Clear();
               item.SubItems[0].Text = friend1.friendlist[i].Name;
               item.SubItems.Add(friend1.friendlist[i].LV);
               item.SubItems.Add(friend1.friendlist[i].CurrentFriend + "/" + friend1.friendlist[i].MaxFriend);
               item.SubItems.Add(friend1.friendlist[i].ID);
               listViewFriend.Items.Add(item);

           }
           listViewFriend.EndUpdate();
       }

       private void timerBattle_Tick(object sender, EventArgs e)
       {
           updater.FairyBattle();
       }

       private void timerExplore_Tick(object sender, EventArgs e)
       {
           updater.explore(aid,floorid);
       }

       private void checkBoxOutterMode_CheckedChanged(object sender, EventArgs e)
       {
           updater.settingpolicy(checkBoxOutterMode.Checked);
       }

       private void buttonAPRecovery_Click(object sender, EventArgs e)
       {
           updater.useAPitem();
       }

       private void buttonBCRecovery_Click(object sender, EventArgs e)
       {
           updater.useBCitem();
       }

       private void checkBoxAPrecovery_CheckedChanged(object sender, EventArgs e)
       {
           useAP = checkBoxAPrecovery.Checked;
          
       }

       private void checkBoxBCrecovery_CheckedChanged(object sender, EventArgs e)
       {
           useBC = checkBoxBCrecovery.Checked;
       }

       private void buttonSearchFriend_Click(object sender, EventArgs e)
       {
           if (textBoxFriendName.Text == "")
           {
               MessageBox.Show("请输入好友名称");
           }
           else 
           {
               FriendList friend = new FriendList();
               string input = textBoxFriendName.Text;
               byte[] encodeBytes = System.Text.Encoding.UTF8.GetBytes(input); 
               string inputString= System.Text.Encoding.UTF8.GetString(encodeBytes);
               friend = updater.searchfriend(inputString);
               updateFriend(friend);
           }

       }

       private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
       {

       }

       private void radioButton1_CheckedChanged(object sender, EventArgs e)
       {
           TWorCN = false;
           updater.settingServer(TWorCN);
       }

       private void radioButton2_CheckedChanged(object sender, EventArgs e)
       {
           TWorCN = true;
           updater.settingServer(TWorCN);
       }


       private void buttonCurrentFriend_Click(object sender, EventArgs e)
       {

           FriendList friend = new FriendList();
           friend = updater.updatefriendlist();
           updateFriend(friend);

       }

       private void listViewFriend_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (listViewFriend.SelectedItems.Count > 0) 
           {
               selectfriend = listViewFriend.SelectedItems[0].SubItems[2].Text;
           }
       }

       private void listViewFairyInfo_SelectedIndexChanged(object sender, EventArgs e)
       {
       }

       private void buttonApproveList_Click(object sender, EventArgs e)
       {
           FriendList friend = new FriendList();
           friend = updater.updateApprovefriendlist();
           updateFriend(friend);
       }

       private void buttonpvpbattle_Click(object sender, EventArgs e)
       {
           if (swPVP == false)
           {
               buttonpvpbattle.Text = "停止";
               swPVP = true;
               timerpvp.Start();
           }
           else
           {
               buttonpvpbattle.Text = "开始PVP";
               swPVP = false;
               timerpvp.Stop();
           }

       }

       private void timerpvp_Tick(object sender, EventArgs e)
       {
           int limit = 0;
           if (textBoxlimitBC.Text == "")
           {
               limit = 1;
           }
           else 
           {
               limit =  int.Parse(textBoxlimitBC.Text);
           }
           updater.PVP(limit);
       }

       private void button1_Click(object sender, EventArgs e)
       {
           bool test;
           //cr.reader();
           //db.init();
           MessageBox.Show("OK");
       }





    }
}
