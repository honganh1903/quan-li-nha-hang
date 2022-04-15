using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI;

namespace GUI.UserControls
{
    public partial class ucQuanLySanPham : UserControl
    {
        public ucQuanLySanPham()
        {
            InitializeComponent();
        }

        private void dateNgaySX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlNCC_Click(object sender, EventArgs e)
        {
            frmNCC frm = new frmNCC();
            frm.ShowDialog();
            if (frm.b)
            {
                LoadCboNCC();
                LoadCboLocNCC();
            }
        }
        private void LoadCboLocNCC()
        {
            DataTable dt = NCCBL.Instance.GetDanhSachNCC();
            DataRow dr = dt.NewRow();
            dr["Mã NCC"] = "-1";
            dr["Tên NCC"] = "Tất cả";
            dt.Rows.Add(dr);
            cboLocNCC.DataSource = dt;
            cboLocNCC.DisplayMember = "Tên NCC";
            cboLocNCC.ValueMember = "Mã NCC";
            cboLocNCC.SelectedIndex = cboLocNCC.Items.Count - 1;
        }

        private void LoadCboNCC()
        {
            cboNCC.DataSource = NCCBL.Instance.GetDanhSachNCC();
            cboNCC.DisplayMember = "Tên NCC";
            cboNCC.ValueMember = "Mã NCC";
        }

        private void ucQuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            DataTable dt = SanPhamBL.Instance.GetDanhSachSanPham();
            dgvSanPham.DataSource = dt;
        }
    }
}
