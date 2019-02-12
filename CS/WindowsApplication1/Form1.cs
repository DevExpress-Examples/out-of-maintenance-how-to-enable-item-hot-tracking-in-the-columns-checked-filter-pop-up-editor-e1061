using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitData();
        }
        public void InitData() {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("Trademark", typeof(string));
            for (int i = 0; i < 20; i++)
                dt.Rows.Add(new object[] { i, "Test" + i });
            myGridControl1.DataSource = dt;
        }
    }
}