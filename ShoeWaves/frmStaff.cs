using System;
using System.Collections.Generic;
using Doann.Entities;
using Doann.Utils;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doann
{
    public partial class frmStaff : Form
    {
        
        public frmStaff()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindGrid(List<CHECKIN> listCheckin)
        {
            dgvStaff.Rows.Clear();
            foreach (var item in listCheckin)
            {
                int index = dgvStaff.Rows.Add();
                dgvStaff.Rows[index].Cells[0].Value = item.ID;
                dgvStaff.Rows[index].Cells[1].Value = item.NAME;
                dgvStaff.Rows[index].Cells[2].Value = item.GIOCHECKIN;
                dgvStaff.Rows[index].Cells[3].Value = item.NGAYCHECKIN;
            }
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            try
            {
                dbContext context = new dbContext();
                List<CHECKIN> listCheckin = context.CHECKINs.ToList();
                BindGrid(listCheckin);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
