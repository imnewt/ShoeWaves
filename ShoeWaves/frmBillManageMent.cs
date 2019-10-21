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
    public partial class frmBillManageMent : Form
    {
        dbContext context = new dbContext();
        public frmBillManageMent()
        {
            InitializeComponent();
        }

        private void FrmBillManageMent_Load(object sender, EventArgs e)
        {
            try
            {
                List<HOADON> listHoaDon = context.HOADONs.ToList();
                BindGrid(listHoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<HOADON> listHoaDon)
        {
            dgvBillManageMent.Rows.Clear();
            foreach (var item in listHoaDon)
            {
                int index = dgvBillManageMent.Rows.Add();
                dgvBillManageMent.Rows[index].Cells[0].Value = item.MAHD;
                dgvBillManageMent.Rows[index].Cells[1].Value = item.TENKH;
                dgvBillManageMent.Rows[index].Cells[2].Value = item.SDT;
                dgvBillManageMent.Rows[index].Cells[3].Value = item.MAGIAY;
                dgvBillManageMent.Rows[index].Cells[4].Value = item.GIA;
                dgvBillManageMent.Rows[index].Cells[5].Value = item.NGAYXUAT;
                dgvBillManageMent.Rows[index].Cells[6].Value = item.GHICHU;
            }
        }

        private void ImbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            List<HOADON> list = context.HOADONs.Where(p => p.MAHD.ToLower().Contains(txtMaHoaDon.Text.Trim().ToLower())).ToList();
            BindGrid(list);
        }

        private void ImbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext context = new dbContext();
                HOADON db = context.HOADONs.FirstOrDefault(p => p.MAHD.ToString() == txtMaHoaDon.Text);
                if (db == null)
                    throw new Exception("HÃY CHỌN 1 DỮ LIỆU ĐỂ XÓA!");
                else
                {
                    DialogResult dlg = MessageBox.Show("BẠN CÓ MUỐN XÓA KHÔNG?", "CẢNH BÁO", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        context.HOADONs.Remove(db);
                        context.SaveChanges();
                        txtMaHoaDon.Text = null;
                        MessageBox.Show("XÓA DỮ LIỆU THÀNH CÔNG!");
                    }
                }
                BindGrid(context.HOADONs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImbFind_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaHoaDon.Text = null;
                List<HOADON> listHoaDon = context.HOADONs.ToList();
                BindGrid(listHoaDon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvBillManageMent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = dgvBillManageMent.Rows[i];
            txtMaHoaDon.Text = dgvBillManageMent.Rows[i].Cells[0].Value.ToString();
        }
    }
}
