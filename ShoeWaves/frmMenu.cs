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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.Load += FrmMenu_Load;
            SetControl(false);
        }

        private void SetControl(bool isUse)
        {
            imbStaff.Enabled = isUse;
            imbNotes.Enabled = isUse;
            imbWareHouse.Enabled = isUse;
            imbBillManageMent.Enabled = isUse;
            imbBill.Enabled = isUse;
            imbLogOut.Enabled = isUse;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            frmLogIn login = new frmLogIn();
            login.MdiParent = this;
            login.loginSystemClick += Login_loginSystemClick;
            login.TopMost = true;
            login.Show();
        }

        private void Login_loginSystemClick(object sender, Utils.EventSetControlEnable e)
        {
            if (e.isUse)
            {
                SetControl(e.isUse);
                imbLogin.Enabled = false;
            }
        }

        private void ImbLogin_Click(object sender, EventArgs e)
        {
            frmLogIn login = new frmLogIn();
            if (ShowActiveChildForm(login) == false)
            {
                login.MdiParent = this;
                login.loginSystemClick += Login_loginSystemClick;
                login.Show();
            }
        }

        private bool ShowActiveChildForm(Form frm)
        {
            foreach (Form formChild in this.MdiChildren)
            {
                if (formChild.Name == frm.Name)
                {
                    formChild.Activate();
                    return true;
                }
            }
            return false;
        }

        private void ImbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ImbBill_Click(object sender, EventArgs e)
        {
            frmBill bill = new frmBill();
            bill.ShowDialog();
        }
        private void ImbStaff_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();
            staff.ShowDialog();
        }

        private void ImbWareHouse_Click(object sender, EventArgs e)
        {
            frmWareHouse wareHouse = new frmWareHouse();
            wareHouse.ShowDialog();
        }

        private void ImbBillManageMent_Click(object sender, EventArgs e)
        {
            frmBillManageMent billManageMent = new frmBillManageMent();
            billManageMent.ShowDialog();
        }

        private void ImbNotes_Click(object sender, EventArgs e)
        {
            frmNotes note = new frmNotes();
            note.ShowDialog();
        }

        private void ImbLogOut_Click(object sender, EventArgs e)
        {
            this.Load += FrmMenu_Load;
            SetControl(false);
            imbLogin.Enabled = true;
            MessageBox.Show("ĐĂNG XUẤT THÀNH CÔNG!");
        }
    }
}
