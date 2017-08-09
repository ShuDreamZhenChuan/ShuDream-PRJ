using System;
using System.Collections.Generic;
using System.Linq;
using Smart.Core;
using System.Text;
using System.Drawing;

namespace SmartParkingPlugin
{
    [PluginInfo("SmartParkingPlugin", "1.0", "ZhenChuan", "www.shudream.com", true, 2)]
    class SmartParkingPlugin : Smart.Core.Iplugin
    {
        private Dictionary<string, EventHandler> _ChildNodes = new Dictionary<string, EventHandler>();
        public static ILoadForm Formloader;
        public SmartParking _mainform = new SmartParking();

        public SmartParkingPlugin()
        {
            _ChildNodes.Add("停车场监控", (sender, e) =>
            {
                FormLoader.LoadContentFrm(_mainform);
            });
        }

        public Image ModulePicture
        {
            //get
            //{
            //    return ((System.Drawing.Image)(ImageResource.Index));
            //}
            get
            {
                return null;
            }
        }

        public Image ModulePictureEnter
        {
            //get
            //{
            //    return ((System.Drawing.Image)(.IndexEnter));
            //}
            get
            {
                return null;
            }
        }

        public Image ModulePictureClick
        {
            //get
            //{
            //    return ((System.Drawing.Image)(ImageResource.IndexClick));
            //}
            get
            {
                return null;
            }
        }

        public string ModuleName
        {
            get
            {
                return "停车场监控";
            }
        }

        public Dictionary<string, EventHandler> ChildNodes
        {
            get
            {
                return _ChildNodes;
            }
        }
        public bool IsLoad
        {
            get;
            set;
        }

        public ILoadForm FormLoader
        {
            get
            {
                return Formloader;
            }
            set
            {
                Formloader = value;
            }
        }

        public PluginInfoAttribute PluginInfo
        {
            get;
            set;
        }


    }
}
