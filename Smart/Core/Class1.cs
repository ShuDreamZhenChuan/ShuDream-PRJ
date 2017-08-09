using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart.Core
{
    public class StandardForm:Form
    {

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x112)
            {
                switch ((int)m.WParam)
                {
                    //禁止双击标题栏关闭窗体
                    case 0xF063:
                    case 0xF093:
                        m.WParam = IntPtr.Zero;
                        break;
                    //禁止拖拽标题栏还原窗体
                    case 0xF012:
                    case 0xF010:
                    //    m.WParam = IntPtr.Zero;
                        break;
                    //禁止双击标题栏
                    case 0xf122:
                        m.WParam = IntPtr.Zero;
                        break;
                    //禁止关闭按钮
                    case 0xF060:
                    //    m.WParam = IntPtr.Zero;
                        break;
                    //禁止最大化按钮
                    case 0xf020:
                        m.WParam = IntPtr.Zero;
                        break;
                    //禁止最小化按钮
                    case 0xf030:
                        m.WParam = IntPtr.Zero;
                        break;
                    //禁止还原按钮
                    case 0xf120:
                        m.WParam = IntPtr.Zero;
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // StandardForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StandardForm";
            this.ResumeLayout(false);

        }





    }
}
