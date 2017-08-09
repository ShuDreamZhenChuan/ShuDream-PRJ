using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartPlugin.SmartChildForm;
namespace SmartPlugin.SmartUserControl
{
    public partial class CarAuthorized : UserControl
    {

        DataTable carauthorizetable = new DataTable();
        public CarAuthorized()
        {
            InitializeComponent();

            carauthorizetable.Columns.Add("CardNum");
            carauthorizetable.Columns.Add("CardUser");
            carauthorizetable.Columns.Add("CarNum");
            carauthorizetable.Columns.Add("CardStatus");
            carauthorizetable.Columns.Add("UserType");
            carauthorizetable.Columns.Add("Balance");
            carauthorizetable.Columns.Add("AvailableDate");
            carauthorizetable.Columns.Add("DisableDate");
        }

        private void lab_Refresh_Click(object sender, EventArgs e)
        {
            carauthorizetable.Rows.Clear();

            DataRow _row = carauthorizetable.NewRow();

            _row["CardNum"] = "8531797980";
            _row["CardUser"] = "甄川";
            _row["CarNum"] = "川A678X";
            _row["CardStatus"] = "正常";
            _row["UserType"] = "物业经理";
            _row["Balance"] = "100.0";
            _row["AvailableDate"] = "2017-07-12";
            _row["DisableDate"] = "2019-07-12";

            carauthorizetable.Rows.Add(_row);

            dataGrid_CarInfo.DataSource = carauthorizetable;
        }

        private void lab_Add_Click(object sender, EventArgs e)
        {
            NewVehicleForm register = new NewVehicleForm();

            register.Show();

            DataRow _row = carauthorizetable.NewRow();

            _row["CardNum"] = "8531797980";
            _row["CardUser"] = "甄川";
            _row["CarNum"] = "川A678X";
            _row["CardStatus"] = "正常";
            _row["UserType"] = "物业经理";
            _row["Balance"] = "100.0";
            _row["AvailableDate"] = "2017-07-12";
            _row["DisableDate"] = "2019-07-12";

            carauthorizetable.Rows.Add(_row);

            dataGrid_CarInfo.DataSource = carauthorizetable;
        }

        private void lab_Delete_Click(object sender, EventArgs e)
        {
            if (dataGrid_CarInfo.SelectedRows[0].Index > 0)
                carauthorizetable.Rows.RemoveAt(dataGrid_CarInfo.SelectedRows[0].Index);
            dataGrid_CarInfo.DataSource = carauthorizetable;
        }

        private void lab_CleanKey_Click(object sender, EventArgs e)
        {
            this.txb_CardSearchKey.Text = "";
        }
    }
}
