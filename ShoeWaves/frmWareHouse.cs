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
    public partial class frmWareHouse : Form
    {
        dbContext context = new dbContext();
        public frmWareHouse()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private GIAY GetGiay()
        {
            GIAY g = new GIAY();
            g.MAGIAY = txtCode.Text;
            g.HANG = txtBrand.Text;
            g.SIZE = txtSize.Text.ToString();
            g.GIA = double.Parse(txtPrice.Text.ToString());
            g.GHICHU = txtNote.Text;
            g.NGAYNHAP = DateTime.Now.ToShortDateString();
            return g;
        }

        private void ImbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext context = new dbContext();
                GIAY db = context.GIAYs.FirstOrDefault(p => p.MAGIAY.ToString() == txtCode.Text);
                if (db == null)
                {
                    GIAY g = GetGiay();
                    context.GIAYs.Add(g);
                    context.SaveChanges();
                    txtCode.Text = null;
                    txtBrand.Text = null;
                    txtSize.Text = null;
                    txtPrice.Text = null;
                    txtNote.Text = null;
                    MessageBox.Show("THÊM MỚI DỮ LIỆU THÀNH CÔNG!");
                }
                else
                {
                    MessageBox.Show("MÃ GIÀY ĐÃ TỒN TẠI!!!");
                }
                BindGrid(context.GIAYs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<GIAY> listGiay)
        {
            dgvWareHouse.Rows.Clear();
            foreach (var item in listGiay)
            {
                int index = dgvWareHouse.Rows.Add();
                dgvWareHouse.Rows[index].Cells[0].Value = item.MAGIAY;
                dgvWareHouse.Rows[index].Cells[1].Value = item.HANG;
                dgvWareHouse.Rows[index].Cells[2].Value = item.SIZE;
                dgvWareHouse.Rows[index].Cells[3].Value = item.GIA;
                dgvWareHouse.Rows[index].Cells[4].Value = item.NGAYNHAP;
                dgvWareHouse.Rows[index].Cells[5].Value = item.GHICHU;
            }
        }

        private void FrmWareHouse_Load(object sender, EventArgs e)
        {
            try
            {
                dbContext context = new dbContext();
                List<GIAY> listGiay = context.GIAYs.ToList();
                BindGrid(listGiay);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvWareHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            DataGridViewRow row = dgvWareHouse.Rows[i];
            txtCode.Text = dgvWareHouse.Rows[i].Cells[0].Value.ToString();
            txtBrand.Text = dgvWareHouse.Rows[i].Cells[1].Value.ToString();
            txtSize.Text = dgvWareHouse.Rows[i].Cells[2].Value.ToString();
            txtPrice.Text = dgvWareHouse.Rows[i].Cells[3].Value.ToString();
            txtNote.Text = dgvWareHouse.Rows[i].Cells[5].Value.ToString();
        }

        private void ImbDel_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext context = new dbContext();
                GIAY db = context.GIAYs.FirstOrDefault(p => p.MAGIAY.ToString() == txtCode.Text);
                if (db == null)
                    throw new Exception("KHÔNG TÌM THẤY MÃ GIÀY!");
                else
                {
                    DialogResult dlg = MessageBox.Show("BẠN CÓ MUỐN XÓA KHÔNG?", "CẢNH BÁO", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        context.GIAYs.Remove(db);
                        context.SaveChanges();
                        MessageBox.Show("XÓA DỮ LIỆU THÀNH CÔNG!");
                        txtCode.Text = null;
                        txtBrand.Text = null;
                        txtSize.Text = null;
                        txtPrice.Text = null;
                        txtNote.Text = null;
                    }
                }
                BindGrid(context.GIAYs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
