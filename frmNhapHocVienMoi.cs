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
    public partial class frmNhapHocVienMoi : Form
    {
        private ListBox _LstA;
        private ListBox _LstB;
        public frmNhapHocVienMoi(ListBox lstA, ListBox lstB)
        {
            InitializeComponent();
            _LstA = lstA;
            _LstB = lstB;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(cboLop.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cho học viên mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboLop.SelectedIndex == 0)
            {
                _LstA.Items.Add(txtHoTen.Text);             
            }
            else if(cboLop.SelectedIndex == 1)
            {
                _LstB.Items.Add(txtHoTen.Text);
            }
        }
    }
}
