using System;
using System.Collections.Generic;
using System.Linq;
using Smart.Core;
using System.Text;
using System.Drawing;

namespace SmartAccessPlugin
{
    [PluginInfo("SmartAccessPlugin", "1.0", "ZhenChuan", "www.shudream.com", true, 3)]
    class SmartAccessPlugin:Smart.Core.Iplugin
    {

           private Dictionary<string, EventHandler> _ChildNodes = new Dictionary<string, EventHandler>();
           public static ILoadForm Formloader;
           public SmartAccessForm _mainform = new SmartAccessForm();

         public SmartAccessPlugin()
         {
             _ChildNodes.Add("门禁验证", (sender, e) =>
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
                 return "门禁验证";
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
