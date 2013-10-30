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
            AreaList area =  new AreaList();
            area = Action.getarealist();
            int count = area.arealist.Count;
            for (int j = 0; j < count; j++) 
            {
                
                comboBoxAreaList.Items.Add(area.arealist[j].AreaName);
                //comboBoxAreaList.Controls.Add(area.arealist[j].Areaid);
            }
                textBoxoutput.Text = Action.getdebugstring();
        }

        private void comboBoxAreaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
