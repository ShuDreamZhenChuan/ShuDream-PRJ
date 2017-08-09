using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartPlugin.SmartUserControl
{
    public partial class DeviceOptionControl : UserControl
    {
        public DeviceOptionControl()
        {
            InitializeComponent();
        }

        private void cmb_CardReader_CH2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddDevice_Click(object sender, EventArgs e)
        {
            DoorInfo_panel.Visible = false;
            DeviceTab.Visible = true;
        }

        private void Device_Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var tree = (TreeView)sender;

            if (tree.SelectedNode.Text == "门")
            {
                btn_AddDoor.Visible = true;
                btn_AddDevice.Visible = false;
                DoorInfo_panel.Visible = false;
                DeviceTab.Visible = false;
            }
            else
            {
                btn_AddDevice.Visible = true;
                btn_AddDoor.Visible =false;
                DoorInfo_panel.Visible = false;
                DeviceTab.Visible = false;
            }
        }

        private void btn_AddDoor_Click(object sender, EventArgs e)
        {
            DoorInfo_panel.Visible = true;
            DeviceTab.Visible = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txb_DoorName.Text != "")
            {
                this.Device_Tree.Nodes[2].Nodes.Add(txb_DoorName.Text);
            }
            else
            {
                MessageBox.Show("门名称不能为空白");
            }
        }

        private void btn_SaveDevice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("添加设备成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Width.ToString()+" "+this.Height.ToString());
        }
    }
}
