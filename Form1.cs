using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP10_studentProfile
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable("Student");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s0,s1, s2, s3, s4;
            int r = Convert.ToInt32(tbReg.Text);
            s0 = ddDept.selectedValue;
            s1 = tbFname.Text.ToString();
            s2 = tbLname.Text.ToString();
            s3 = tbPhone.Text.ToString();
            s4 = tbAddress.Text.ToString();
            dt.Rows.Add(r,s1,s2,s0,s3,s4);
            MessageBox.Show("Added");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            DataColumn stucol = dt.Columns.Add("RegNo", typeof(Int32));
            stucol.AllowDBNull = false;
            stucol.Unique = true;
            dt.Columns.Add("StuFName", typeof(String));
            dt.Columns.Add("StuLName", typeof(String));
            dt.Columns.Add("Department", typeof(String));
            dt.Columns.Add("Phone", typeof(String));
            dt.Columns.Add("Address", typeof(String));

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbReg.Text = "";
            tbFname.Text = "";
            ddDept.selectedIndex=-1;
            tbFname.Text = "";
            tbLname.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";

        }

        private void gbStored_Enter(object sender, EventArgs e)
        {
            dgvStudents.DataSource = dt;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            gbStored.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbStored.Visible = false;
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            gbStored.Visible = true;
        }
    }
}
