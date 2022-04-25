﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;
using GUI;
using GUI.UserControls;

namespace GUI
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            DataSet ds = HoaDonBL.Instance.InHoaDon(ucBanSanPham.SOHD_Report);
            ReportDataSource dataSource = new ReportDataSource("DataSet_Report", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
<<<<<<< HEAD
=======
            this.reportViewer1.RefreshReport();
>>>>>>> 1d2968237a66b7aa77cabd4a5387fc72f73bebea
        }
    }
}
