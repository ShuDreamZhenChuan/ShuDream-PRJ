using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartParkingPlugin
{
    public class Payment
    {

        public int BaseNum;

        public float ExtraPrice;

        public Payment()
        { 
            
        
        
        }


        public float GetPaymentMoney(string vehiclenum,int Parktime)
        { 

            //先查询车辆表和收费配置表得到车辆所属车辆类型的收费参数
            BaseNum=2;

            ExtraPrice=1.5f;

            float finalnum=2+Parktime*ExtraPrice;

            return finalnum;
        }



    }
}
