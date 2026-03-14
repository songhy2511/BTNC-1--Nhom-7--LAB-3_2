using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6___Bai_tap_nang_cao___BT_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuXoaHocVien_Click(object sender, EventArgs e)
        {
            for(int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
            }

            for(int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItems[i]);
            }
        }

        private void mnuChuyenSangB_Click(object sender, EventArgs e)
        {
            if(lstLopA.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn học viên nào để chuyển sang lớp B", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                for(int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstLopB.Items.Add(lstLopA.SelectedItems[i]);
                    lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
                }
            }
        }

        private void mnuChuyenSangA_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn học viên nào để chuyển sang lớp A", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                for (int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstLopA.Items.Add(lstLopB.SelectedItems[i]);
                    lstLopB.Items.Remove(lstLopB.SelectedItems[i]);
                }
            }
        }

        private void mnuNhapHocVien_Click(object sender, EventArgs e)
        {
            frmNhapHocVienMoi frmNhap = new frmNhapHocVienMoi(lstLopA, lstLopB);
            frmNhap.Owner = this;
            frmNhap.ShowDialog();
        }
    }
}
