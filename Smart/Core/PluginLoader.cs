using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace Smart.Core
{
    public static class PluginLoader
    {

        public static List<Iplugin> plugins = new List<Iplugin>();
        private static ArrayList piProperties = new ArrayList();
        
        private static bool IsValidPlugin(Type t)
        {
			bool ret = false;
			//Type[] interfaces = t.GetInterfaces();
			//foreach( Type theInterface in interfaces ) {
            //    if (theInterface.FullName.Contains("Plugin"))
            //    {
            //        ret = true;
            //        break;
            //    }
            //}
            if (t.FullName.EndsWith("Plugin"))
            {
                ret = true;
            }

			return ret;
		}


       

        public static void LoadAllPlugins()
        {
            PluginLoader.plugins.Clear();
            string[] files = Directory.GetFiles(Application.StartupPath + "\\plugin\\");
            int i = 0;
            PluginInfoAttribute typeAttribute = new PluginInfoAttribute();
            foreach (string file in files)
            {
                string ext = file.Substring(file.LastIndexOf("."));
                if (ext != ".dll") continue;
                try
                {
                    Assembly tmp = Assembly.LoadFile(file);
                    Type[] types = tmp.GetTypes();
                    bool ok = false;
                    foreach (Type t in types)
                        if (IsValidPlugin(t))
                        {
                            Iplugin plugin = (Iplugin)tmp.CreateInstance(t.FullName);
                            plugins.Add(plugin);
                            object[] attbs = t.GetCustomAttributes(typeAttribute.GetType(), false);
                            PluginInfoAttribute attribute = null;
                            foreach (object attb in attbs)
                            {
                                if (attb is PluginInfoAttribute)
                                {
                                    attribute = (PluginInfoAttribute)attb;
                                    attribute.Index = i;
                                    i++;
                                    ok = true;
                                    break;
                                }
                            }

                            if (attribute != null)
                            {
                                piProperties.Add(attribute);
                                plugin.PluginInfo = attribute;
                            }
                            else throw new Exception("为定义插件属性");
                            if (ok) break;
                        }
                }
                catch (Exception err)
                {
                    throw err;
                }
            }
            plugins.Sort((p1, p2) => {
                return p2.PluginInfo.Index - p1.PluginInfo.Index;
            });
        }
    }
}
