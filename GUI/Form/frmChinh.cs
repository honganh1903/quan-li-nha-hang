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
        //Label lblPhanTram;
        string ucName;
        //Task taskLoadProgressBar;
        Task taskLoadUserControl;

        
        // hàm này để di chuyển form ko có title bar
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel2.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            moveSidePanel(btnBanSanPham);
            if (btnBanSanPham.ForeColor == Color.White)
            {
                btnBanSanPham.ForeColor = Color.FromArgb(255, 255, 254);
                btnBanSanPham.BackColor = Color.FromArgb(8, 133, 204);

                check_reset(btnBanSanPham);
                AddControl("ucBanSanPham");
            }
            if (btnBanSanPham.ForeColor == Color.White)
            {
                btnBanSanPham.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 133, 204);
            }
            else
            {
                btnBanSanPham.FlatAppearance.MouseDownBackColor = Color.White;
            }
            Cursor = Cursors.Default;
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

            ucProgressbar ucprogress = new ucProgressbar();
            ucprogress.Dock = DockStyle.Fill;
            pnControls.Controls.Add(ucprogress);
            pnControls.Controls["ucProgressBar"].BringToFront();

            taskLoadUserControl = new Task(LoadUserControl);

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

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            timerPanel.Start();
            Cursor = Cursors.Default;
        }
        int PanelWidth=64;
        bool isCollapsed;
        private void timerpanel_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnLeft.Width = pnLeft.Width + 8;
                if (pnLeft.Width >= PanelWidth)
                {
                    timerPanel.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                pnLeft.Width = pnLeft.Width - 8;
                if (pnLeft.Width <= 64)
                {
                    timerPanel.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            moveSidePanel(btnSanPham);
            if (btnSanPham.ForeColor == Color.White)
            {
                btnSanPham.ForeColor = Color.FromArgb(255, 255, 254);
                btnSanPham.BackColor = Color.FromArgb(8, 133, 204);

                check_reset(btnSanPham);
                AddControl("ucSanPham");
            }
            if (btnSanPham.ForeColor == Color.White)
            {
                btnSanPham.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 133, 204);
            }
            else
            {
                btnSanPham.FlatAppearance.MouseDownBackColor = Color.White;
            }
            Cursor = Cursors.Default;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            moveSidePanel(btnKhachHang);
            if(btnKhachHang.ForeColor == Color.White)
            {
                btnKhachHang.ForeColor = Color.FromArgb(255, 255, 254);
                btnKhachHang.BackColor = Color.FromArgb(8, 133, 204);

                check_reset(btnKhachHang);
                AddControl("ucKhachHang");
            }
            if (btnKhachHang.ForeColor == Color.White)
            {
                btnKhachHang.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 133, 204);
            }
            else
            {
                btnKhachHang.FlatAppearance.MouseDownBackColor = Color.White;
            }
            Cursor = Cursors.Default;
        }
    }
}
