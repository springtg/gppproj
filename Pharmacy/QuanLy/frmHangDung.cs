using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Pharmacy.QuanLy
{
    public partial class frmHangDung : Pharmacy.BASIC.frmChild
    {
        #region Bien   

        
        Pharmacy.QuanLy.BLL.THanDung tHH = new Pharmacy.QuanLy.BLL.THanDung();


        DataTable HH = new DataTable();

        #endregion

        public frmHangDung()
        {
            InitializeComponent();
        }

        private void frmNSX_Load(object sender, EventArgs e)
        {
            SetTitle("HỆ THỐNG CẢNH BÁO");
            Init();
        }
        private void Init()
        {
            LoadHanDung();
            LoadSL();
        }

        public void LoadHanDung()
        {
            try
            {
                HH = tHH.GetHanDung();
                if (HH != null)
                {
                    lvhanghoa.Items.Clear();
                    for (int i = 0; i < HH.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        lvhanghoa.Items.Add(item);
                        item.SubItems.Add(HH.Rows[i]["CODE"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["TENHANGHOA"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["MALO"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["NGAYNHAP"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["NGAYSX"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["NGAYHH"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["SLTON_LO"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["TEN"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNSX_loadnsx", ex.Message + "|" + ex.StackTrace);
            }
        }
        public void LoadSL()
        {
            try
            {
                DataTable HH = tHH.GetSL();
                if (HH != null)
                {
                    listSL.Items.Clear();
                    for (int i = 0; i < HH.Rows.Count; i++)
                    {
                        int stt = i + 1;
                        ListViewItem item = new ListViewItem(stt.ToString());
                        listSL.Items.Add(item);
                        item.SubItems.Add(HH.Rows[i]["CODE"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["TENHANGHOA"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["SLTON_LO"].ToString().Trim());
                        item.SubItems.Add(HH.Rows[i]["TEN"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                TLog.WriteErr("frmNSX_loadnsx", ex.Message + "|" + ex.StackTrace);
            }
        }
      
        private void cmdDn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntPrintHD_Click(object sender, EventArgs e)
        {
            ListViewPrinter pr = new ListViewPrinter("THỐNG KÊ HẠN DÙNG HÀNG HÓA");
            pr.ListView = lvhanghoa;
            pr.PrintPreview();
        }

        private void bntPrintSL_Click(object sender, EventArgs e)
        {
            ListViewPrinter pr = new ListViewPrinter("THỐNG KÊ SỐ LƯỢNG HÀNG HÓA");
            pr.ListView = listSL;
            pr.PrintPreview();
        }
     }
}
