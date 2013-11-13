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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Services updater = new Services();
        PlayerInfo playerinfo = new PlayerInfo();
        bool autoBattle = false;
        bool autoExplore = false;
        GameFunction Action = new GameFunction();
        AreaList area = new AreaList();
        FloorList floor = new FloorList();
        string aid;
        public string floorid = null;
        public string debugstring = null;
        bool Outtermode = false;
        bool useAP = false;
        bool useBC = false;
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
                updatePlayerInfo();
                textBoxoutput.Text = Action.getdebugstring();
                updateArea();
                //updateList();
                buttonAutoBattle.Enabled = true;
                timer1.Start();
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
            updateList();
            //updateArea();
            updatePlayerInfo();
            //updateFloor();
            //updateList()
            updater.settingRecovery(useAP, useBC);
        }
       private void updateList()
       {
           listViewFairyInfo.Items.Clear();
           FairyList list = updater.updateFairyInfo();
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
           area = updater.updateArea();
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
           playerinfo = updater.updateInfo();
           labelPlayerName.Text = "玩家名称: " + playerinfo.PlayerName;
           labelAP.Text = "AP:  " + playerinfo.NowAP + "/" + playerinfo.MaxAP.ToString();
           labelBC.Text = "BC:  " + playerinfo.NowBC + "/" + playerinfo.MaxBC.ToString();
           labelGold.Text = "金钱： " + playerinfo.gold;
           buttonAPRecovery.Text = "绿茶剩余：" + playerinfo.itemAP.ToString();
           buttonBCRecovery.Text = "红茶剩余：" + playerinfo.itemBC.ToString();
           labelPlayerName.Refresh();
           labelAP.Refresh();
           labelBC.Refresh();
           labelGold.Refresh();
           buttonAPRecovery.Refresh();
           buttonBCRecovery.Refresh();
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
           this.updatePlayerInfo();
       }

       private void buttonBCRecovery_Click(object sender, EventArgs e)
       {
           updater.useBCitem();
           this.updatePlayerInfo();
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

       }



    }
}
