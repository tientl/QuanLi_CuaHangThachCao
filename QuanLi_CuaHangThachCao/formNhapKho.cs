﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi_CuaHangThachCao
{
    public partial class formNhapKho : Form
    {
        public formNhapKho()
        {
            InitializeComponent();
        }

        private void formNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCuaHang_ThachCaoDataSet.NhapKho' table. You can move, or remove it, as needed.
            this.nhapKhoTableAdapter.Fill(this.dbCuaHang_ThachCaoDataSet.NhapKho);

        }
    }
}
