using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Smart.Core
{
    public interface Iplugin
    {

        PluginInfoAttribute PluginInfo
        { get; set; }
        bool IsLoad
        {
            get;
            set;
        }

        Image ModulePicture
        {
            get;
        }

        Image ModulePictureEnter
        {
            get;
        }

        Image ModulePictureClick
        {
            get;
        }

        string ModuleName
        {
            get;
        }


        Dictionary<string, EventHandler> ChildNodes
        {
            get;
        }

        ILoadForm FormLoader
        {
            get;
            set;
        }

       
    }
}
