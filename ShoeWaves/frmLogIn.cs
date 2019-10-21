using Doann.Utils;
using Doann.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doann
{
    public partial class frmLogIn : Form
    {
        public event LoginSystemClick loginSystemClick;
        dbContext dbContext;
        public frmLogIn()
        {
            InitializeComponent();
            dbContext = new dbContext();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImbConfirm_Click(object sender, EventArgs e)
        {
            NHANVIEN nhanvien = dbContext.NHANVIENs.Where(x => x.NAME == txtUserName.Text.Trim()).FirstOrDefault<NHANVIEN>();
            if (nhanvien != null)
            {
                if (nhanvien.PASS == txtPass.Text)
                {
                    EventSetControlEnable thongBao = new EventSetControlEnable();

                    CHECKIN ch = new CHECKIN
                    {
                        ID = nhanvien.ID,
                        NAME = nhanvien.NAME,
                        NGAYCHECKIN = DateTime.Now.ToShortDateString(),
                        GIOCHECKIN = DateTime.Now.ToLongTimeString()
                    };

                    dbContext.CHECKINs.Add(ch);
                    dbContext.SaveChanges();
                    thongBao.isUse = true;
                    loginSystemClick(this, thongBao);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("MẬT KHẨU KHÔNG CHÍNH XÁC!");
                }
            }
            else
            {
                MessageBox.Show("KHÔNG TỒN TẠI TÀI KHOẢN NÀY!");
            }
        }
    }

    internal class DangNhap
    {
        public static List<DangNhap> dangnhap = new List<DangNhap>();
        public string id;
        public string name;
        public string pass;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Pass { get => pass; set => pass = value; }

        public DangNhap(string id, string name, string pass)
        {
            this.id = id;
            this.name = name;
            this.pass = pass;
        }
    }
}
