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
        GameFunction Action = new GameFunction();
        AreaList area = new AreaList();
        FloorList floor = new FloorList();
        string floorid = null;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            PlayerInfo playerinfo = new PlayerInfo();

            Action.login("15099797743", "qwertyuiop");
            Action.getPlayerInfo(ref playerinfo);
            labelPlayerName.Text = "玩家名称: " + playerinfo.PlayerName;
            labelAP.Text = "AP:  "+ playerinfo.NowAP +"/" + playerinfo.MaxAP.ToString();
            labelBC.Text = "BC:  "+ playerinfo.NowBC +"/"  + playerinfo.MaxBC.ToString();
            labelGold.Text = "金钱： " + playerinfo.gold;
            
            area = Action.getarealist();
            int count = area.arealist.Count;
            for (int j = 0; j < count; j++) 
            {
                ComboxItem item = new ComboxItem
                {
                    Value = area.arealist[j].Areaid,
                    Text = area.arealist[j].AreaName
                };
                
                comboBoxAreaList.Items.Add(item);
                //comboBoxAreaList.Controls.Add(area.arealist[j].Areaid);
            }
                textBoxoutput.Text = Action.getdebugstring();
        }

        private void comboBoxAreaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AreaList list = new AreaList();
            if ((comboBoxAreaList.Items != null) && (comboBoxAreaList.Items.Count > 0) && (comboBoxAreaList.SelectedItem != null))
            {
                    string id = ((ComboxItem) comboBoxAreaList.SelectedItem).Value.ToString();
                    floor = Action.getfloorlist(id);
                    
             }
                int count1 = floor.floorlist.Count;
                for (int i = 0; i < count1; i++) 
                {
                    ComboxItem flooritem = new ComboxItem
                    {
                        Text = "区域"+floor.floorlist[i].id + "|进度：" + floor.floorlist[i].prog,
                        Value = floor.floorlist[i].id
                    };
                    comboBoxfloor.Items.Add(flooritem);
                }
           }

        private void comboBoxfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBoxAreaList.Items != null) && (comboBoxAreaList.Items.Count > 0) && (comboBoxAreaList.SelectedItem != null))
            {
                floorid = ((ComboxItem)comboBoxAreaList.SelectedItem).Value.ToString();
            }
        }
        

    }
}
