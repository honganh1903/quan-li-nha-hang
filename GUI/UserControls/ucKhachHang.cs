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
using DTO;
using GUI;

namespace GUI.UserControls
{
    public partial class ucKhachHang : UserControl
    {
        public int check = 0;
        public int makh = 0;
        public int maDS =-1;
        public ucKhachHang()
        {
            InitializeComponent();
        }
        private void load()
        {
            maDS = -1;
            txtSearch.Visible = false;
            groupBox1.Visible= false;
            dateTimePicker2.Visible = false;
            dgvKhachHang.DataSource = KhachHangBL.Instance.GetDanhSachKhachHang();
            dgvKhachHang.Columns["Mã khách hàng"].Visible = false;
            dgvKhachHang.Columns["Đã xóa"].Visible = false;
            Lock();
        }
        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            load();
        }
        private void Lock()
        {
            txtTenKH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            rdNam1.Enabled = false;
            rdNu1.Enabled = false;
            txtsdt.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtDoanhSo.ReadOnly = true;
            CheckXoa.Enabled = false;
            btnOK.Enabled = false;
        }
        private void UnLock()
        {
            txtTenKH.ReadOnly = false;
            txtTenKH.Text = "";
            txtDiaChi.ReadOnly = false;
            txtDiaChi.Text = "";
            rdNam1.Enabled = true;
            rdNu1.Enabled = true;
            rdNu1.Checked = false;
            rdNam1.Checked = false;
            txtsdt.ReadOnly = false;
            txtsdt.Text = "";
            txtEmail.ReadOnly = false;
            txtEmail.Text = "";
            txtDoanhSo.ReadOnly = false;
            txtDoanhSo.Text = "0";
            btnOK.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLock();
            lbDaXoa.Visible = false;
            CheckXoa.Visible = false;
            CheckXoa.Checked = false;
            check = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count != 1)
                MessageBox.Show("Vui lòng chọn dòng cần sửa");
            if(dgvKhachHang.SelectedRows.Count==1)
            {
                UnLock();
                rdNu1.Checked = true;
                lbDaXoa.Visible = true;
                CheckXoa.Visible = true;
                CheckXoa.Enabled = true;
                makh = Convert.ToInt16(dgvKhachHang.SelectedRows[0].Cells["Mã khách hàng"].Value.ToString());
                txtTenKH.Text = dgvKhachHang.SelectedRows[0].Cells["Họ tên"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.SelectedRows[0].Cells["Địa chỉ"].Value.ToString();
                txtsdt.Text = dgvKhachHang.SelectedRows[0].Cells["SĐT"].Value.ToString();
                rdNam1.Checked = (Boolean)dgvKhachHang.SelectedRows[0].Cells["Giới tính(Nam)"].Value;
                dateTimePicker1.Value =(DateTime) dgvKhachHang.SelectedRows[0].Cells["Ngày đăng ký"].Value;
                txtEmail.Text = dgvKhachHang.SelectedRows[0].Cells["Email"].Value.ToString();
                txtDoanhSo.Text = dgvKhachHang.SelectedRows[0].Cells["Doanh số"].Value.ToString();
                CheckXoa.Checked = (Boolean)dgvKhachHang.SelectedRows[0].Cells["Đã xóa"].Value;
                check = 2;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdNu1.Checked == false && rdNam1.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
            }
            else
            {
                KhachHangDTO khDTO = new KhachHangDTO();
                if (check == 2) khDTO.MaKH = makh;
                khDTO.TenKH = txtTenKH.Text;
                khDTO.DiaChi = txtDiaChi.Text;
                khDTO.SDT = txtsdt.Text;
                if (rdNam1.Checked == true) khDTO.GioiTinh = true;
                else if (rdNu1.Checked) khDTO.GioiTinh = false;
                khDTO.NgayDangKy = dateTimePicker1.Value.Date;
                khDTO.Email = txtEmail.Text;
                khDTO.DoanhSo = Convert.ToInt16(txtDoanhSo.Text);
                if (check == 1)
                {
                    KhachHangBL.Instance.ThemKhachHang(khDTO);
                    MessageBox.Show("Thêm thành công khách hàng!");
                }
                else if (check == 2)
                {
                    khDTO.DaXoa = CheckXoa.Checked;
                    KhachHangBL.Instance.SuaKhachHang(khDTO);
                    MessageBox.Show("Sửa thành công khách hàng!");
                }
                UnLock();
                Lock();
                load();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kiemtra = 0;
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa ");
            }
            else
            {
                int[] del = new int[dgvKhachHang.SelectedRows.Count];
                bool[] listCheck = new bool[dgvKhachHang.SelectedRows.Count];
                for (int i = 0; i < dgvKhachHang.SelectedRows.Count; i++)
                {
                    del[i]=(Convert.ToInt16(dgvKhachHang.SelectedRows[i].Cells["Mã khách hàng"].Value.ToString()));
                    listCheck[i]=((Boolean)dgvKhachHang.SelectedRows[i].Cells["Đã xóa"].Value);
                }
                foreach (bool tmp in listCheck)
                {
                    if (tmp == true)
                    {
                        MessageBox.Show("Thông tin được chọn đã được xóa từ trước!");
                        kiemtra = 1;
                        break;
                    }
                }
                if (kiemtra == 0)
                {
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dlr == DialogResult.Yes)
                    {
                        KhachHangDTO khDTO = new KhachHangDTO();
                        for (int i  = 0;i < dgvKhachHang.SelectedRows.Count; i++)
                        {
                            khDTO.MaKH = del[i];
                            khDTO.DaXoa = true;
                            KhachHangBL.Instance.XoaKhachHang(khDTO);
                        }
                        MessageBox.Show("Xóa khách hàng thành công!");
                        load();
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            switch (cbbList.SelectedIndex)
            {
                case 0:
                    {
                        load();
                        break;
                    }
                case 1:
                    {
                        dgvKhachHang.DataSource = KhachHangBL.Instance.GetDanhSachByName(txtSearch.Text,maDS);
                        break;
                    }
                case 2:
                    {
                        dgvKhachHang.DataSource = KhachHangBL.Instance.GetDanhSachByDC(txtSearch.Text,maDS);
                        break;
                    }
                case 3:
                    {
                        if (rdNam.Checked == false && rdNu.Checked == false)
                        {
                            MessageBox.Show("Vui lòng chọn giới tính");
                        }
                        else
                        {
                            bool tmp = new bool();
                            if (rdNam.Checked == true) tmp = true;
                            else tmp = false;
                            dgvKhachHang.DataSource = KhachHangBL.Instance.GetDanhSachByGT(tmp,maDS);
                        }
                        break;
                    }
                case 4:
                    {
                        dgvKhachHang.DataSource = KhachHangBL.Instance.GetDanhSachBySDT(txtSearch.Text,maDS);
                        break;
                    }
                case 5:
                    {
                        DateTime tmp = dateTimePicker2.Value.Date;
                        dgvKhachHang.DataSource = KhachHangBL.Instance.GetDanhSachByNDK(tmp,maDS);
                        break;
                    }
                case 6:
                    {
                        dgvKhachHang.DataSource = KhachHangBL.Instance.GetDanhSachByMail(txtSearch.Text,maDS);
                        break;
                    }
            }
        }

        private void cbbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbList.SelectedIndex)
            {
                case 0:
                    {
                        txtSearch.Visible = false;
                        groupBox1.Visible = false;
                        dateTimePicker2.Visible = false;
                        break;
                    }
                case 1:
                case 2:
                case 4:
                case 6:
                    {
                        txtSearch.Visible = true;
                        txtSearch.Text = "";
                        groupBox1.Visible = false;
                        dateTimePicker2.Visible = false;
                        break;
                    }
                case 3:
                    {
                        groupBox1.Visible = true;
                        txtSearch.Visible = false;
                        dateTimePicker2.Visible = false;
                        break;
                    }
                case 5:
                    {
                        groupBox1.Visible = false;
                        txtSearch.Visible = false;
                        dateTimePicker2.Visible = true;
                        break;
                    }
            }
        }

        private void btnHienTai_Click(object sender, EventArgs e)
        {
            maDS = 0;
            dgvKhachHang.DataSource = KhachHangBL.Instance.GetDanhSachKhachHangHT();
            //dgvKhachHang.Columns["Mã khách hàng"].Visible = false;
            //dgvKhachHang.Columns["Đã xóa"].Visible = false;
        }

        private void btnDaXoa_Click(object sender, EventArgs e)
        {
            maDS = 1;
            dgvKhachHang.DataSource = KhachHangBL.Instance.GetDanhSachKhachHangDX();
            //dgvKhachHang.Columns["Mã khách hàng"].Visible = false;
            //dgvKhachHang.Columns["Đã xóa"].Visible = false;
        }
    }
}
