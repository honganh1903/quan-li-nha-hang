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
using GUI;
using GUI.UserControls;
using System.IO;

namespace GUI
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        //ColorProgressBar.ColorProgressBar ProgressBar;
        Label lblPhanTram;
        string ucName;
        Task taskLoadProgressBar;
        Task taskLoadUserControl;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            if (TaiKhoanBL.Instance.GetTenQuyen(frmDangNhap.Quyen) != "Admin")
            {
                lbQuyen.Text = TaiKhoanBL.Instance.GetTenQuyen(frmDangNhap.Quyen);
                lbTenNV.Text = NhanVienBL.Instance.GetTenNhanVien(frmDangNhap.TenDangNhap);
                btnSanPham.Enabled = false;
                btnTrangChu.Enabled = false;
                btnNhapSanPham.Enabled = false;
                btnBanSanPham.PerformClick();
            }
            else
            {
                lbQuyen.Text = TaiKhoanBL.Instance.GetTenQuyen(frmDangNhap.Quyen);
                lbTenNV.Text = NhanVienBL.Instance.GetTenNhanVien(frmDangNhap.TenDangNhap);
                btnTrangChu.PerformClick();
            }
        }

        private void btnNhapSanPham_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            moveSidePanel(btnNhapSanPham);
            if (btnNhapSanPham.ForeColor == Color.White)
            {
                btnNhapSanPham.ForeColor = Color.FromArgb(255, 255, 254);
                btnNhapSanPham.BackColor = Color.FromArgb(8, 133, 204);

                check_reset(btnNhapSanPham);
                AddControl("ucNhapSanPham");
            }
            if (btnNhapSanPham.ForeColor == Color.White)
            {
                btnNhapSanPham.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 133, 204);
            }
            else
            {
                btnNhapSanPham.FlatAppearance.MouseDownBackColor = Color.White;
            }
            Cursor = Cursors.Default;
        }

        public void AddControl(string ucname)
        {
            ucName = ucname;
            //Xóa các uc trước khi thêm uc mới vào
            foreach (UserControl uc in pnControls.Controls.OfType<UserControl>())
            {
                pnControls.Controls.Remove(uc);
            }
            //Add vào ProgressBar từ ucProgressBar
            ucProgressbar ucprogress = new ucProgressbar();
            ucprogress.Dock = DockStyle.Fill;
            pnControls.Controls.Add(ucprogress);
            pnControls.Controls["ucProgressBar"].BringToFront();
            //Ánh xạ lên biến toàn cục
            //ProgressBar = ucprogress.progressLoading;
            //lblPhanTram = ucprogress.lblPhanTram;

            //taskLoadProgressBar = new Task(LoadProgressBar);
            taskLoadUserControl = new Task(LoadUserControl);
            //taskLoadProgressBar.Start();
            taskLoadUserControl.Start();
        }

        private void LoadUserControl()
        {
            pnControls.Invoke(new MethodInvoker(delegate ()
            {
                switch (ucName)
                {
                    case "ucTrangChu":
                        {
                            ucTrangChu ucTC = new ucTrangChu();
                            ucTC.Dock = DockStyle.Fill;
                            AddControlsIntoPanel(ucTC);
                        }
                        break;
                    case "ucSanPham":
                        {
                            ucQuanLySanPham ucSP = new ucQuanLySanPham();
                            ucSP.Dock = DockStyle.Fill;
                            AddControlsIntoPanel(ucSP);
                        }
                        break;
                    case "ucNhapSanPham":
                        {
                            ucNhapSanPham ucNSP = new ucNhapSanPham();
                            ucNSP.Dock = DockStyle.Fill;
                            AddControlsIntoPanel(ucNSP);
                        }
                        break;
                    case "ucBanSanPham":
                        {
                            ucBanSanPham ucBH = new ucBanSanPham();
                            ucBH.Dock = DockStyle.Fill;
                            AddControlsIntoPanel(ucBH);
                        }
                        break;
                    case "ucNhanVien":
                        {
                            ucNhanVien ucNV = new ucNhanVien();
                            ucNV.Dock = DockStyle.Fill;
                            AddControlsIntoPanel(ucNV);
                        }
                        break;
                    case "ucKhachHang":
                        {
                            ucKhachHang ucKH = new ucKhachHang();
                            ucKH.Dock = DockStyle.Fill;
                            AddControlsIntoPanel(ucKH);
                        }
                        break;
                    case "ucThongKe":
                        {
                            ucThongKe ucTL = new ucThongKe();
                            ucTL.Dock = DockStyle.Fill;
                            AddControlsIntoPanel(ucTL);
                        }
                        break;
                }
            }));
        }

        private void AddControlsIntoPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnControls.Controls.Clear();
            pnControls.Controls.Add(c);
        }

        private void check_reset(Button button)
        {
            foreach (Control control in pnLeft.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    if (btn.Text != button.Text)
                    {
                        if (btn.BackColor != Color.White)
                        {
                            btn.BackColor = Color.FromArgb(17, 145, 249);
                            btn.ForeColor = Color.White;
                            //btn.Image = (Image)Properties.Resources.ResourceManager.GetObject(btn.AccessibleName + "_blue");
                        }
                        btn.FlatAppearance.MouseDownBackColor = Color.White;
                    }
                }
            }
        }

        private void moveSidePanel(Control btn)
        {
            pnSide.Top = btn.Top;
            pnSide.Height = btn.Height;
        }
    }
}
