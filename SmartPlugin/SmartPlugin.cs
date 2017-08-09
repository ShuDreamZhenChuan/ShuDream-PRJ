using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smart.Core;
using System.Drawing;

namespace SmartPlugin
{
    [PluginInfo("SmartPlugin", "1.0", "ZhenChuan", "www.shudream.com", true, 1)]
    class SmartPlugin:Smart.Core.Iplugin
    {
         private Dictionary<string, EventHandler> _ChildNodes = new Dictionary<string, EventHandler>();
         public static ILoadForm Formloader;
         public SmartMainForm _mainform = new SmartMainForm();

         public SmartPlugin()
         {
             _ChildNodes.Add("门禁管理", (sender, e) =>
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
                 return "门禁管理";
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
