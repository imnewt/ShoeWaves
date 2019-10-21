using Doann.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doann
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void ImbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private HOADON GetHoaDon()
        {
            HOADON b = new HOADON();
            b.MAHD = txtBillCode.Text;
            b.TENKH = txtNameCustomer.Text;
            b.SDT = txtPhoneNumber.Text;
            b.MAGIAY = txtCodeShoe.Text;
            b.GIA = double.Parse(txtPrice.Text);
            b.NGAYXUAT = DateTime.Now.ToShortDateString();
            b.GHICHU = txtNote.Text;
            return b;
        }
        private void ImbConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext context = new dbContext();
                HOADON db = context.HOADONs.FirstOrDefault(p => p.MAHD.ToString() == txtBillCode.Text);
                if (db == null)
                {
                    HOADON b = GetHoaDon();
                    context.HOADONs.Add(b);
                    context.SaveChanges();
                    txtBillCode.Text = null;
                    txtNameCustomer.Text = null;
                    txtPhoneNumber.Text = null;
                    txtCodeShoe.Text = null;
                    txtPrice.Text = null;
                    txtNote.Text = null;
                    MessageBox.Show("THÊM MỚI DỮ LIỆU THÀNH CÔNG!");
                }
                else
                {
                    MessageBox.Show("MÃ HÓA ĐƠN ĐÃ TỒN TẠI!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
