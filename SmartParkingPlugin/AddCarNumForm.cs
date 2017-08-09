using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartParkingPlugin
{
    public partial class AddCarNumForm : Form
    {
        string ChannelName;

        public AddCarNumForm(string channel)
        {
            this.ChannelName = channel;
            InitializeComponent();
        }
    }
}
