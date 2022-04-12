using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.UserControls
{
    public partial class ucNhapSanPham : UserControl
    {
        public ucNhapSanPham()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucNhapSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = SanPhamBL.Instance.GetDanhSachSanPham();
            dgvSanPham.ClearSelection();
            dgvPhieuNhap.DataSource = PhieuNhapBL.Instance.GetDanhSachPhieuNhap();
            dgvPhieuNhap.ClearSelection();
        }
    }
}
