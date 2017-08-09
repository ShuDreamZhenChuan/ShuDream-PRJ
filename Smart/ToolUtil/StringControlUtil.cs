using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Smart.ToolUtil
{
    public class StringControlUtil
    {

        public void IDCardTextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
        }

        public void NumTextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
        }

        public void PhoneTextChanged(object sender, EventArgs e)
        {

        }

        public void NameTextChanged(object sender, EventArgs e)
        {

        }

        public void NumTextChanged(object sender, EventArgs e)
        {

        }

        public static bool CheckIDCardNum(string idcard)
        {
            Regex _regex=new Regex(@"(^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$)|(^[1-9]\d{5}\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{2}[0-9Xx]$)");

            if (_regex.IsMatch(idcard))
                return true;
            else
                return false;
        }

         public static bool CheckPhoneNum(string idcard)
        {
            Regex _regex = new Regex(@"^(13|15|18)[0-9]{9}$");
         
            if (_regex.IsMatch(idcard))
                return true;
            else
                return false;
        }





    }
}
